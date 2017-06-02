using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Transaction
{
    public class VoidTransaction : AbstractTransactionRequest
    {
        public string URL_METHOD = "void";

        public readonly IRequestMethod requestMethod = IRequestMethod.POST;

        public VoidTransaction(string id)
        {
            this.URL_METHOD = id + URL_PATH_SEPARATOR + this.URL_METHOD;
            this.isCollection = false;
        }

        public override IRequestMethod getRequestMethod()
        {
            return requestMethod;
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
