using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Models;

namespace SpryngPaymentsCS.Http.Requests.Account
{
    public class CreateAccount : AbstractAccountRequest
    {
        public readonly string URL_METHOD = "";

        public readonly IRequestMethod requestMethod = IRequestMethod.POST;

        public CreateAccount()
        {
            this.isCollection = false;
        }

        public override string getEndpoint()
        {
            return this.getUrlResourceIdentifier() + URL_PATH_SEPARATOR + this.getURLMethod();
        }

        public override IRequestMethod getRequestMethod()
        {
            return this.requestMethod;
        }

        public override string getURLMethod()
        {
            return URL_METHOD;
        }
    }
}
