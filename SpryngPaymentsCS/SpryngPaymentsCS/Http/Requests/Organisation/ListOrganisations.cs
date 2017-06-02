using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Organisation
{
    class ListOrganisations : AbstractOrganisationRequest
    {
        public readonly string URL_METHOD = "";

        public readonly IRequestMethod requestMethod = IRequestMethod.GET;

        public ListOrganisations()
        {
            this.isCollection = false;
        }

        public override IRequestMethod getRequestMethod()
        {
            return this.requestMethod;
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
