using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.ThreeD
{
    public abstract class AbstractThreeDRequest : AbstractRequest
    {
        public static readonly string URL_RESOURCE_IDENTIFIER = "3d";

        public override string getUrlResourceIdentifier()
        {
            return URL_RESOURCE_IDENTIFIER;
        }
    }
}
