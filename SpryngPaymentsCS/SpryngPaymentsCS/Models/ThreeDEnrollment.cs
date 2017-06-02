using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Models
{
    public class ThreeDEnrollment : SpryngObject
    {
        [JsonProperty("account")]
        private string accountId;

        [JsonProperty("amount")]
        private int amount;

        [JsonProperty("card")]
        private string cardId;

        [JsonProperty("description")]
        private string description;

        public string getAccountId()
        {
            return accountId;
        }

        public void setAccountId(string accountId)
        {
            this.accountId = accountId;
        }

        public int getAmount()
        {
            return amount;
        }

        public void setAmount(int amount)
        {
            this.amount = amount;
        }

        public string getCardId()
        {
            return cardId;
        }

        public void setCardId(string cardId)
        {
            this.cardId = cardId;
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }
    }
}
