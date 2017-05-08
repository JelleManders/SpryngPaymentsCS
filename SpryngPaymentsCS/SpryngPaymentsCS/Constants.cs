using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS
{
    public class Constants
    {
        public const string VERSION = "1.0";

        public const string API_VERSION = "v1";

        public const string UTF_8 = "utf-8";

        public const string HTTP_SCHEME = "https";

        public const string DATE_FORMAT = "yyyy-MM-dd'T'HH:mm:ssX";

        public const string URL_PATH_SEPARATOR = "/";

        public const string USER_AGENT = "SpryngPaymentsCS/" + VERSION;

        public const string JSON_CONTENT_TYPE = "application/json";

        public const string HDR_APIKEY = "X-APIKEY";

        //!! copied from org.apache.http.HttpHeaders as copied from Constants.java
        public const string HDR_CONTENT_TYPE = "Content-Type";

        //!! copied from org.apache.http.HttpHeaders as copied from Constants.java
        public const string HDR_USER_AGENT = "User-Agent";
    }
}
