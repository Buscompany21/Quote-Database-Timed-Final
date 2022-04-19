using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models.ViewModels
{
    public class QuotesViewModel
    {
        public IQueryable<Quote> Quotes { get; set; }
    }
}
