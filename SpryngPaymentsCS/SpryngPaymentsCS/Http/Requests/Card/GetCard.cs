using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Card
{
    public class GetCard : AbstractCardRequest
    {
        public string URL_METHOD = "";

        public readonly IRequestMethod requestMethod = IRequestMethod.GET;

        public GetCard(string id)
        {
            this.URL_METHOD = id;
        }

        public override IRequestMethod getRequestMethod()
        {
            return requestMethod;
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
