using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegatesTutorial
{
    class TaxFormulas
    {
        public delegate float TaxFormula(float salary);
        public static float UsaFormula(float salary)
        {
            return 10 * salary / 100;
        }
        public static float VietNamFormula(float salary)
        {
            return 5 * salary / 100;
        }
        public static float DefautFormula(float salary)
        {
            return 7 * salary / 100;
        }
        public static TaxFormula GetSalaryFormula(string countryCode)
        {
            if (countryCode=="VN")
            {
                return TaxFormulas.VietNamFormula;
            }
            else if (countryCode == "US")
            {
                return TaxFormulas.UsaFormula;
            }
            else
            {
                return TaxFormulas.DefautFormula;
            }
        }
    }


}