using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Transaction
{
    public class CaptureTransaction : AbstractTransactionRequest
    {
        public readonly IRequestMethod REQUEST_METHOD = IRequestMethod.GET;

        protected string URL_METHOD = "capture";

        public CaptureTransaction(string id)
        {
            this.URL_METHOD = id + URL_PATH_SEPARATOR + this.URL_METHOD;
        }

        public override IRequestMethod getRequestMethod()
        {
            return IRequestMethod.POST;
        }

        public override string getURLMethod()
        {
            return "capture";
        }

        public override string getEndpoint()
        {
            return this.getUrlResourceIdentifier() + URL_PATH_SEPARATOR + this.getURLMethod();
        }
    }
}
