using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Http.Requests.Account
{
    public class GetAccount : AbstractAccountRequest
    {
        public readonly IRequestMethod REQUEST_METHOD = IRequestMethod.GET;

        protected string URL_METHOD = "";

        public GetAccount(string id)
        {
            this.URL_METHOD = id;
            this.isCollection = false;
        }

        //public override Type getClass()
        //{
        //    return typeof(Models.Account);
        //}

        public override string getEndpoint()
        {
            return this.getUrlResourceIdentifier() + URL_PATH_SEPARATOR + this.getURLMethod();
        }

        public override IRequestMethod getRequestMethod()
        {
            return this.REQUEST_METHOD;
        }

        public override string getURLMethod()
        {
            return this.URL_METHOD;
        }
    }
}
