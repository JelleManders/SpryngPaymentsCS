using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Transaction
{
    public class RefundTransaction : AbstractTransactionRequest
    {
        public readonly IRequestMethod REQUEST_METHOD = IRequestMethod.POST;

        protected string URL_METHOD = "refund";

        public RefundTransaction(string id)
        {
            this.URL_METHOD = id + URL_PATH_SEPARATOR + this.URL_METHOD;
        }

        public override IRequestMethod getRequestMethod()
        {
            return this.REQUEST_METHOD;
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
