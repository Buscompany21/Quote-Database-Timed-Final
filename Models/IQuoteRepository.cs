using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public interface IQuoteRepository
    {
        IQueryable<Quote> Quotes { get; }

        public void SaveQuote(Quote q);
        public void CreateQuote(Quote q);
        public void DeleteQuote(Quote q);
    }
}

