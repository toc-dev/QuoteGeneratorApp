using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteGeneratorApp.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string QuoteBody { get; set; }
        public DateTime When { get; set; }
    }
}
