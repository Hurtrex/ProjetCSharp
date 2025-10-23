using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetC_.Model
{
    public class TaxBracket
    {
        public double MinIncome { get; set; }
        public double MaxIncome { get; set; }
        public double Rate { get; set; }

        public TaxBracket(double minIncome, double maxIncome, double rate)
        {
            MinIncome = minIncome;
            MaxIncome = maxIncome;
            Rate = rate;
        }

        public override string ToString()
        {
            return $"MinIncome: {this.MinIncome}, MaxIncome: {this.MaxIncome}, Rate: {Rate}";
        }
    }
}
