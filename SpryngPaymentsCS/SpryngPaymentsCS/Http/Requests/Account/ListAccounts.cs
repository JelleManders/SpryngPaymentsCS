using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Account
{
    public class ListAccounts : AbstractAccountRequest
    {
        public readonly string URL_METHOD = "";

        public ListAccounts()
        {
            this.isCollection = true;
        }

        public override IRequestMethod getRequestMethod()
        {
            return this.getRequestMethod();
        }

        public override string getEndpoint()
        {
            return this.getUrlResourceIdentifier() + URL_PATH_SEPARATOR;
        }

        public override string getURLMethod()
        {
            return URL_METHOD;
        }
    }
}
