using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.ThreeD
{
    public class Authorization : AbstractThreeDRequest
    {
        private readonly string URL_METHOD = "authorization";

        private readonly IRequestMethod requestMethod = IRequestMethod.POST;

        public override IRequestMethod getRequestMethod()
        {
            return this.requestMethod;
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
