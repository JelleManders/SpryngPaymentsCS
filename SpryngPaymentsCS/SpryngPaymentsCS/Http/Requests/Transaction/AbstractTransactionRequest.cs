using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Transaction
{
    public abstract class AbstractTransactionRequest : AbstractRequest
    {
        public static readonly string URL_RESOURCE_IDENTIFIER = "transaction";

        public override string getUrlResourceIdentifier()
        {
            return URL_RESOURCE_IDENTIFIER;
        }
    }
}
