using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using SpryngPaymentsCS.Http.Requests;
using SpryngPaymentsCS.Models;
using SpryngPaymentsCS.Exceptions;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Utilities
{
    public class RequestHandler : Constants
    {
        protected AbstractRequest request;

        protected HttpClient httpClient;

        //protected Gson deserialize

        //protected JsonParser jsonParser

        protected string baseUrl;

        protected readonly new string DATE_FORMAT = "yyyy-MM-dd'T'HH:mm:ssX";

        protected List<Header> headers = new List<Header>();

        protected LinkedList<Filter> filters = new LinkedList<Filter>();

        protected int responseCode;

        protected string response;

        protected SpryngObject postEntity;

        public RequestHandler()
        {
            this.headers.Add(new Header(HDR_USER_AGENT, USER_AGENT));

            this.httpClient = new HttpClient();

            this.setBaseUrl(SpryngPayments.getActiveEndpoint());
            Console.WriteLine("Initialised Handler...\n");
        }

        public async Task send()
        {
            Console.WriteLine("Started send function...\n");

            Uri uri = this.createUri(this.request);
            Console.WriteLine("Uri = "+uri);
            HttpResponseMessage httpResponse;

            try
            {
                httpResponse = await executeHttpRequest(uri, this.request.getRequestMethod());
                Console.WriteLine("!!  Finished execute, starting evaluate...\n");
                evaluateResponse(httpResponse);
                Console.WriteLine("Evaluated Response, no exceptions occurred...\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught (RequestHandler.cs line 61)\n" + ex);
                throw new RequestException("Request was unsuccesful", 101);
            }

            Task toString = httpResponseToString(httpResponse);
            toString.Wait();
        }

        private async Task<HttpResponseMessage> executeHttpRequest(Uri uri, IRequestMethod method)
        {
            Console.WriteLine("Started executeHttpRequest function...\n");

            string name = "";
            string value;

            foreach (Header header in this.headers)
            {
                name = header.getName();
                value = header.getValue();
                Console.WriteLine("Adding Header " + name + " with value " + value + "...\n");
                this.httpClient.DefaultRequestHeaders.Add(name, value);
            }

            Console.WriteLine("Added Headers...\n");

            HttpResponseMessage httpResponse = null;

            if (method == IRequestMethod.GET)
            {
                Console.WriteLine("About to Call GetAsync...\n");
                httpResponse = await httpClient.GetAsync(uri);
                Console.WriteLine("Called GetAsync...\n");
            }
            else if (method == IRequestMethod.POST)
            {
                this.headers.Add(new Header(HDR_CONTENT_TYPE, JSON_CONTENT_TYPE));

                string jsonString = JsonConvert.SerializeObject(this.getPostEntity());
                HttpContent content = new StringContent(jsonString);
                httpResponse = await httpClient.PostAsync(uri, content);
            }
            else if (method == IRequestMethod.DELETE)
            {
                httpResponse = await httpClient.DeleteAsync(uri);
            }

            return httpResponse;
        }

        public Response getDeserializedResponse()
        {
            Response response = new Response(this.request, null, true);

            try
            {
                var responseType = this.request.getClass();
                if (this.getResponse() == null) { Console.WriteLine("yup, it's NULL..."); }
                else { Console.WriteLine("Response: "+this.getResponse()); }
                response.setData(JsonConvert.DeserializeObject<Account>(this.getResponse())); //HERE
            }
            catch (JsonException jse)
            {
                SpryngPayments.LOG.Error("Could not parse JSON", jse);
                response.setRequestWasSuccessfull(false);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught (RequestHandler.cs line 118)\n" + ex);
            }

            return response;
        }

        private string evaluateResponse(HttpResponseMessage httpResponse)
        {
            this.responseCode = (int) httpResponse.StatusCode;
            string response = "";

            if (this.responseCode == 200)
            {
                response = httpResponse.ToString();
            }
            else
            {
                throw new RequestException("Request is not 200 OK: " + httpResponse.ToString(), 101);
            }
            return response;
        }

        private async Task httpResponseToString(HttpResponseMessage httpResponse)
        {
            string response = "";
            try
            {
                response = await httpResponse.Content.ReadAsStringAsync();
            }
            catch (Exception)
            {
                throw new RequestException("Could not read response", 101);
            }
            this.response = response;
            Console.WriteLine("Response was set...");
        }

        private Uri createUri(AbstractRequest request)
        {
            UriBuilder ub = new UriBuilder();
            ub.Scheme = HTTP_SCHEME;
            ub.Host = SpryngPayments.getActiveEndpoint();
            ub.Path = createPath(request);

            int filterAmount = this.filters.Count();

            if (filterAmount > 0)
            {
                string query = "?";
                //int index = 0;
                query += filters.First;
                filters.RemoveFirst();
                for(int _ = 1; _ < filterAmount; _++)
                {
                    query += "&";
                    query += filters.First;
                    filters.RemoveFirst();
                }
                ub.Query = query;
            }

            Uri uri = null;
            try
            {
                uri = ub.Uri;
            }
            catch (Exception)
            {
                return uri;
            }
            return uri;
        }

        private string createPath(AbstractRequest request)
        {
            return URL_PATH_SEPARATOR + API_VERSION + URL_PATH_SEPARATOR + request.getEndpoint();
        }

        public void setRequest(AbstractRequest request)
        {
            this.request = request;
        }

        public void addHeader(string key, string value)
        {
            this.headers.Add(new Header(key, value));
        }

        public string getResponse()
        {
            return response;
        }

        public void addFilter(Filter filter)
        {
            this.filters.AddFirst(filter);
        }

        public string getBaseUrl()
        {
            return baseUrl;
        }

        public void setBaseUrl(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        protected SpryngObject getPostEntity()
        {
            return postEntity;
        }

        public void setPostEntity(SpryngObject postEntity)
        {
            this.postEntity = postEntity;
        }
    }
}
