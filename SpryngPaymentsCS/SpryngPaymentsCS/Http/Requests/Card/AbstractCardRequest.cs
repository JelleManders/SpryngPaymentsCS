using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Card
{
    public abstract class AbstractCardRequest : AbstractRequest
    {
        public static readonly string URL_RESOURCE_IDENTIFIER = "card";

        public override string getUrlResourceIdentifier()
        {
            return URL_RESOURCE_IDENTIFIER;
        }
    }
}
