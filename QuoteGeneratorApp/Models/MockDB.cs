using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteGeneratorApp.Models
{
    public class MockDB
    {
        public IEnumerable<Quote> Quotes()
        {
            return new List<Quote>()
            {
            new Quote { Id = 1, Author="Sage Unruly", QuoteBody="It be an infinite number of things", When=DateTime.Now},
            new Quote { Id = 2, Author="Napoleon Bonaparte", QuoteBody="Never interrupt your enemy when he's making a mistake", When=DateTime.Now},
            new Quote { Id = 3, Author="Pamela Zave", QuoteBody="The purpose of software engineering is to control complexity not to create it", When=DateTime.Now},
            new Quote { Id = 4, Author="Napoleon Bonaparte", QuoteBody="Never obtain by force what could be obtained by cunning", When=DateTime.Now},
            };
        }
        
    }
}
