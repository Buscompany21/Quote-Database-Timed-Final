using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class QuoteContext : DbContext
    {
        //constructor
        public QuoteContext (DbContextOptions<QuoteContext> options) : base(options)
        {

        }

        public DbSet<Quote> quotes { get; set; }
    }
}
