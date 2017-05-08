using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Utilities;

namespace SpryngPaymentsCS.Controllers
{
    public class BaseController
    {
        protected SpryngPayments api;

        protected RequestHandler http;

        public BaseController(SpryngPayments api)
        {
            this.setApi(api);
            this.http = new RequestHandler();
            this.http.addHeader("X-APIKEY", this.api.getApiKey());
        }

        public SpryngPayments getApi()
        {
            return api;
        }

        public void setApi(SpryngPayments api)
        {
            this.api = api;
        }

        public void addFilters(List<Filter> filters)
        {
            foreach (Filter filter in filters)
            {
                this.http.addFilter(filter);
            }
        }
    }
}
