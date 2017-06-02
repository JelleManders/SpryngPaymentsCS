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
        }

        public async Task send()
        {
            Uri uri = this.createUri(this.request);
            HttpResponseMessage httpResponse;

            try
            {
                httpResponse = await executeHttpRequest(uri, this.request.getRequestMethod());
                evaluateResponse(httpResponse);
            }
            catch (Exception ex)
            {
                throw new RequestException("Request was unsuccesful", 101);
            }

            Task toString = httpResponseToString(httpResponse);
            toString.Wait();
        }

        private async Task<HttpResponseMessage> executeHttpRequest(Uri uri, IRequestMethod method)
        {
            string name = "";
            string value;

            foreach (Header header in this.headers)
            {
                name = header.getName();
                value = header.getValue();
                this.httpClient.DefaultRequestHeaders.Add(name, value);
            }

            HttpResponseMessage httpResponse = null;

            if (method == IRequestMethod.GET)
            {
                httpResponse = await httpClient.GetAsync(uri);
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
                response.setData(JsonConvert.DeserializeObject<dynamic>(this.getResponse()));
            }
            catch (JsonException jse)
            {
                SpryngPayments.LOG.Error("Could not parse JSON", jse);
                response.setRequestWasSuccessfull(false);
            }
            catch (Exception ex)
            {
                SpryngPayments.LOG.Error("Unexpected Exception Occurred", ex);
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
