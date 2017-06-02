using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Transaction
{
    public class CreateTransaction : AbstractTransactionRequest
    {
        public readonly string URL_METHOD = "";

        public CreateTransaction()
        {
            this.isCollection = false;
        }

        public override IRequestMethod getRequestMethod() { return IRequestMethod.POST; }

        public override string getURLMethod() { return this.URL_METHOD; }

        public override string getEndpoint()
        {
            return this.getUrlResourceIdentifier() + URL_PATH_SEPARATOR + this.getURLMethod();
        }
    }
}
