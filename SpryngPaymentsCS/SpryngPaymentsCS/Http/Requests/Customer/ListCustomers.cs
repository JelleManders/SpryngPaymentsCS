using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Customer
{
    public class ListCustomers : AbstractCustomerRequest
    {
        public readonly String URL_METHOD = "";

        public readonly IRequestMethod requestMethod = IRequestMethod.GET;

        public ListCustomers()
        {
            this.isCollection = true;
        }

        public override IRequestMethod getRequestMethod()
        {
            return this.requestMethod;
        }

        public override string getURLMethod()
        {
            return this.URL_METHOD;
        }

        public override string getEndpoint()
        {
            return this.getUrlResourceIdentifier() + URL_PATH_SEPARATOR + URL_METHOD;
        }
    }
}
