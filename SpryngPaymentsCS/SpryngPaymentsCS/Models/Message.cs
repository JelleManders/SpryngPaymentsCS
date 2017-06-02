using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Models
{
    public class Message : SpryngObject
    {
        [JsonProperty("message")]
        private string message;

        public string getMessage()
        {
            return message;
        }

        public void setMessage(string message) { this.message = message; }

        public Type getType()
        {
            return typeof(Message);
        }
    }
}
