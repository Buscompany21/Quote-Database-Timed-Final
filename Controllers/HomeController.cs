using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Final.Models.ViewModels;
using Final.Models;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private IQuoteRepository _repo { get; set; }

        public HomeController(IQuoteRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {

            var x = new QuotesViewModel
            {
                Quotes = _repo.Quotes.OrderBy(q => q.Author)
            };
            return View(x);

        }

        //The following two routes are for the form to add a quote
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Quote q)
        {
            if (ModelState.IsValid)
            {
                _repo.CreateQuote(q);
                _repo.SaveQuote(q);

                //var blah = _repo.Quotes
                //.ToList();

                return View("AddConfirmation", q);
            }
            else
            {
                return View(q);
            }

        }

        [HttpGet]
        public IActionResult AddConfirmation(Quote q)
        {
            return View(q);
        }

        //The following is for editing a quote's information
        [HttpGet]
        public IActionResult Details(string Quote)
        {

            var quote = _repo.Quotes.Single(x => x.QuoteFull == Quote);
            return View(quote);
        }

        [HttpPost]
        public IActionResult Details(Quote q)
        {
            if (ModelState.IsValid)
            {
                _repo.SaveQuote(q);
                return RedirectToAction("Index");
            }
            else
            {
                return View(q);
            }
        }

    //The following is for deleting a quote
    [HttpGet]
        public IActionResult Delete(string Quote)
        {
            var quote = _repo.Quotes.Single(x => x.QuoteFull == Quote);
            _repo.DeleteQuote(quote);

            var blah = _repo.Quotes
                .ToList();
            return View("DeleteConfirmation", blah);
        }

        [HttpGet]
        public IActionResult DeleteConfirmation()
        {
            return View();
        }

    }

    
}
