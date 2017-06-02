using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SpryngPaymentsCS.Http.Requests
{
    public class Response
    {
        private AbstractRequest request;

        private JObject data;

        private bool requestWasSuccessful;

        public Response() { }

        //!! Only instance of this function was found in RequestHandler.java,
        //!! Changed this instance to include data parameter to resolve c# issues
        //public Response(AbstractRequest request, bool requestWasSuccessful)
        //{
        //    this.Response(request, null, requestWasSuccessful);
        //}

        public Response(AbstractRequest request, dynamic data, bool requestWasSuccessful)
        {
            this.request = request;
            this.data = data;
            this.requestWasSuccessful = requestWasSuccessful;
        }

        public AbstractRequest getRequest()
        {
            return request;
        }

        public void setRequest(AbstractRequest request)
        {
            this.request = request;
        }

        public dynamic getData()
        {
            return data;
        }

        public void setData(dynamic data)
        {
            this.data = data;
        }

        public bool isRequestWasSuccessfull()
        {
            return requestWasSuccessful;
        }

        public void setRequestWasSuccessfull(bool requestWasSuccessful)
        {
            this.requestWasSuccessful = requestWasSuccessful;
        }
    }
}
