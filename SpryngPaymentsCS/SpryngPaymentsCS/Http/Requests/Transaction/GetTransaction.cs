using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Transaction
{
    public class GetTransaction : AbstractTransactionRequest
    {
        public readonly IRequestMethod REQUEST_METHOD = IRequestMethod.GET;

        protected string URL_METHOD = "";

        public GetTransaction(string id)
        {
            this.URL_METHOD = id;
            this.isCollection = false;
        }

        public override IRequestMethod getRequestMethod()
        {
            return REQUEST_METHOD;
        }

        public override string getEndpoint()
        {
            return this.getUrlResourceIdentifier() + URL_PATH_SEPARATOR + this.getURLMethod();
        }

        public override string getURLMethod()
        {
            return this.URL_METHOD;
        }
    }
}
