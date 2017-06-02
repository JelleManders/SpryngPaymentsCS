using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Models
{
    public class ThreeD : SpryngObject
    {
        [JsonProperty("pareq")]
        private string pareq;

        [JsonProperty("url")]
        private string url;

        [JsonProperty("cavv2")]
        private string cavv2;

        [JsonProperty("code")]
        private string code;

        [JsonProperty("eci")]
        private string eci;

        [JsonProperty("status")]
        private string status;

        public string getPareq()
        {
            return pareq;
        }

        public void setPareq(string pareq)
        {
            this.pareq = pareq;
        }

        public string getUrl()
        {
            return url;
        }

        public void setUrl(string url)
        {
            this.url = url;
        }

        public string getCavv2()
        {
            return cavv2;
        }

        public void setCavv2(string cavv2)
        {
            this.cavv2 = cavv2;
        }

        public string getCode()
        {
            return code;
        }

        public void setCode(string code)
        {
            this.code = code;
        }

        public string getEci()
        {
            return eci;
        }

        public void setEci(string eci)
        {
            this.eci = eci;
        }

        public string getStatus()
        {
            return status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }
    }
}
