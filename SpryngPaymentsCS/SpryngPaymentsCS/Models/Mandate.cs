using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Models
{
    public class Mandate : SpryngObject
    {
        [JsonProperty("merchant")]
        private string merchant;

        [JsonProperty("processor")]
        private string processor;

        [JsonProperty("referenc")]
        private string reference;

        [JsonProperty("signed_at")]
        private string signedAt;

        [JsonProperty("status")]
        private string status;

        [JsonProperty("_type")]
        private string type;
    }
}
