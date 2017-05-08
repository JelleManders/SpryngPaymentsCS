using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Account
{
    public abstract class AbstractAccountRequest : AbstractRequest
    {
        public static readonly string URL_RESOURCE_IDENTIFIER = "account";

        public override string getUrlResourceIdentifier()
        {
            return URL_RESOURCE_IDENTIFIER;
        }
    }
}
