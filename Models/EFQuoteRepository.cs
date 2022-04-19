using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class EFQuoteRepository : IQuoteRepository
    {
        private QuoteContext context { get; set; }
        public EFQuoteRepository(QuoteContext temp)
        {
            context = temp;
        }
        public IQueryable<Quote> Quotes => context.quotes;

        public void SaveQuote(Quote q)
        {
            context.Update(q);
            context.SaveChanges();
        }

        public void CreateQuote(Quote q)
        {
            context.Add(q);
            context.SaveChanges();
        }

        public void DeleteQuote(Quote q)
        {
            context.Remove(q);
            context.SaveChanges();
        }
    }
}
