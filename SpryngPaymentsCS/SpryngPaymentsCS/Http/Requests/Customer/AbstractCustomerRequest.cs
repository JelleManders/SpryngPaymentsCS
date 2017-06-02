using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Customer
{
    public abstract class AbstractCustomerRequest : AbstractRequest
    {
        public static readonly string URL_RESOURCE_IDENTIFIER = "customer";

        public override string getUrlResourceIdentifier()
        {
            return URL_RESOURCE_IDENTIFIER;
        }
    }
}
