using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.ThreeD
{
    public class Enroll : AbstractThreeDRequest
    {
        public readonly string URL_METHOD = "enroll";

        public readonly IRequestMethod requestMethod = IRequestMethod.POST;

        public Enroll()
        {
            this.isCollection = false;
        }

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
