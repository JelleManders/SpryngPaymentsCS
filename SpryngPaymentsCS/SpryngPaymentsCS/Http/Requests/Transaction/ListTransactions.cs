using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Transaction
{
    public class ListTransactions : AbstractTransactionRequest
    {
        public readonly string URL_METHOD = "";

        public ListTransactions()
        {
            this.isCollection = true;
        }

        public readonly IRequestMethod REQUEST_METHOD = IRequestMethod.GET;

        public override IRequestMethod getRequestMethod()
        {
            return REQUEST_METHOD;
        }

        public override string getEndpoint()
        {
            return this.getUrlResourceIdentifier() + URL_PATH_SEPARATOR + URL_METHOD;
        }

        public override string getURLMethod()
        {
            return this.URL_METHOD;
        }
    }
}
