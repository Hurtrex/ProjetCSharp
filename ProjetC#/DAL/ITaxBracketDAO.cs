using ProjetC_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC_.DAL
{
    public interface ITaxBracketDAO
    {
        IList<TaxBracket> GetAllTaxRate(string agencyName);
        IList<TaxBracket> FindApplicableTaxBrackets(string agency, double income);
    }
}
