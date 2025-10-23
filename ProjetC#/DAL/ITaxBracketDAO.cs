using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC_.DAL
{
    public interface ITaxBracketDAO
    {
        double GetAllTaxRate(string agencyName);
    }
}
