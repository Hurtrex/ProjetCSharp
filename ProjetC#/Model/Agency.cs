using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC_.Model
{
    public class Agency
    {
        public string Name { get; set; }
        public IList<TaxBracket> TaxBrackets { get; set; }

        public Agency(string name)
        {
            Name = name;
            TaxBrackets = new List<TaxBracket>();
        }
        //we only need the name aka canada and quebec and the taxbrackets that they use in mock db and online bd
    }
}
