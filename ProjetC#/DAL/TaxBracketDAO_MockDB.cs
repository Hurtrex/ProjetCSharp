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
            throw new NotImplementedException();
        }

        public double GetAllTaxRate(string agencyName)
        {
            foreach (Agency gov in this.Datastore.Agencies)
                if (gov.Name.ToLower().Equals(agencyName.ToLower()))
                    return gov.TaxBrackets;
            return null;
        }
    }
}
