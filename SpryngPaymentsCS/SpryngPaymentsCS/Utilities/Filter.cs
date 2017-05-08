using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Utilities
{
    public class Filter
    {
        public string operantA;

        public string operantB;

        public IFilterOperator fOperator;

        public Filter() { }

        public Filter(string operantA, IFilterOperator fOperator, string operantB)
        {
            this.operantA = operantA;
            this.fOperator = fOperator;
            this.operantB = operantB;
        }

        public string operantAToString()
        {
            string result = WebUtility.UrlEncode(this.operantA);
            return result;
        }

        public string operantBToString()
        {
            string result = "";
            switch(this.fOperator)
            {
                case IFilterOperator.EQUALS:
                    result = "=";
                    break;
                case IFilterOperator.DOES_NOT_EQUAL:
                    result = "!=";
                    break;
                case IFilterOperator.GREATER_THAN:
                    result = ">";
                    break;
                case IFilterOperator.GREATER_THAN_OR_EQUALS:
                    result = ">=";
                    break;
                case IFilterOperator.LESS_THAN:
                    result = "<";
                    break;
                case IFilterOperator.LESS_THAN_OR_EQUALS:
                    result = "<=";
                    break;
            }
            return WebUtility.UrlEncode(result);
        }
    }
}
