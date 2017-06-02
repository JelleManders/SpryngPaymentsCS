using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Utilities;


namespace SpryngPaymentsCS.Http.Requests.Organisation
{
    public abstract class AbstractOrganisationRequest : AbstractRequest
    {
        public static readonly string URL_RESOURCE_IDENTIFIER = "organisation";

        public override string getUrlResourceIdentifier()
        {
            return URL_RESOURCE_IDENTIFIER;
        }
    }
}
