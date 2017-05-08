using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Exceptions
{
    class RequestException : SpryngPaymentsException
    {
        public static readonly int INVALID_RESPONSE = 100;
        public static readonly int MALFORMED_URL = 101;
        public static readonly int INVALID_HTTP_METHOD = 102;
        public static readonly int UNSUPPORTED_ENCODING = 103;

        public RequestException(string message, int code) : base(message, code) { }
    }
}
