using ProjetC_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC_.DL
{
    public class MockDB
    {
        public IList<Agency> Agencies { get; }
        private static MockDB instance = null;

        public static MockDB GetInstance()
        {
            if (MockDB.instance == null)
                MockDB.instance = new MockDB();
            return MockDB.instance;
        }

        private MockDB()
        {
            this.Agencies = new List<Agency>();
            Agency qc = new Agency("Quebec");
            this.Agencies.Add(qc);
            Agency canada = new Agency("Canada");
            this.Agencies.Add(canada);

            TaxBracket QCtb1 = new TaxBracket(0.0, 51780.0, 0.14);
            qc.TaxBrackets.Add(QCtb1);
            TaxBracket QCtb2 = new TaxBracket(51780.0, 103545.0, 0.19);
            qc.TaxBrackets.Add(QCtb2);
            TaxBracket QCtb3 = new TaxBracket(103545.0, 126000.0, 0.24);
            qc.TaxBrackets.Add(QCtb3);
            TaxBracket QCtb4 = new TaxBracket(126000.0, double.MaxValue, 0.2575);
            qc.TaxBrackets.Add(QCtb4);

            TaxBracket Ctb1 = new TaxBracket(0.0, 55867.0, 0.15);
            canada.TaxBrackets.Add(Ctb1);
            TaxBracket Ctb2 = new TaxBracket(55867.0, 111733.0, 0.205);
            canada.TaxBrackets.Add(Ctb2);
            TaxBracket Ctb3 = new TaxBracket(111733.0, 173205.0, 0.26);
            canada.TaxBrackets.Add(Ctb3);
            TaxBracket Ctb4 = new TaxBracket(173205.0, 246752.0, 0.29);
            canada.TaxBrackets.Add(Ctb4);
            TaxBracket Ctb5 = new TaxBracket(246752.0, double.MaxValue, 0.33);
            canada.TaxBrackets.Add(Ctb5);
        }
    }
}
