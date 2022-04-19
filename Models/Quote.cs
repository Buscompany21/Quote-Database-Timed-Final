using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Models
{
    public class Quote
    {
        [Key]
        [Required]
        public string QuoteFull { get; set; }
        [Required]
        public string Author { get; set; }

        //optional after this
        public string Date { get; set; }

        //Var for Subject
        public string CitationVar { get; set; }
        //var for citation
        public string Citation { get; set; }
        
    }
}
