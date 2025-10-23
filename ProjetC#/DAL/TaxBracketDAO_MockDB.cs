using ProjetC_.DL;
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
    }
}
