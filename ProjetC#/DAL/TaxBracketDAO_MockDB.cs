using ProjetC_.DL;
using ProjetC_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC_.DAL
{
    public class TaxBracketDAO_MockDB: ITaxBracketDAO
    {
        private readonly MockDB Datastore = null;

        public TaxBracketDAO_MockDB()
        {
            this.Datastore = MockDB.GetInstance();
        }

        public IList<TaxBracket> FindApplicableTaxBrackets(string agency, double income)
        {
            IList<TaxBracket> applicable = new List<TaxBracket>();
            IList<TaxBracket> allTaxBrackets = GetAllTaxRate(agency);
            foreach (TaxBracket tb in allTaxBrackets)
                if (income > tb.MaxIncome)
                    applicable.Add(tb);
                else
                {
                    applicable.Add(tb);
                    break;
                }

            return applicable;
        }

        public IList<TaxBracket> GetAllTaxRate(string agency)
        {
            foreach (Agency gov in this.Datastore.Agencies)
                if (gov.Name.ToLower().Equals(agency.ToLower()))
                    return gov.TaxBrackets;
            return null;
        }
    }
}
