using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Models
{
    public class Refund : SpryngObject
    {
        [JsonProperty("_id")]
        private string id;

        [JsonProperty("account")]
        private string accountId;

        [JsonProperty("amount")]
        private int amount;

        [JsonProperty("reason")]
        private string reason;

        [JsonProperty("transaction")]
        private string transactionId;

        [JsonProperty("status")]
        private string status;

        [JsonProperty("last_status_update")]
        private string lastStatusUpdate;

        [JsonProperty("created_at")]
        private string createdAt;

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

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

        public string getReason()
        {
            return reason;
        }

        public void setReason(string reason)
        {
            this.reason = reason;
        }

        public string getTransactionId()
        {
            return transactionId;
        }

        public void setTransactionId(string transactionId)
        {
            this.transactionId = transactionId;
        }

        public string getStatus()
        {
            return status;
        }

        public void setStatus(string status)
        {
            this.status = status;
        }

        public string getLastStatusUpdate()
        {
            return lastStatusUpdate;
        }

        public void setLastStatusUpdate(string lastStatusUpdate)
        {
            this.lastStatusUpdate = lastStatusUpdate;
        }

        public string getCreatedAt()
        {
            return createdAt;
        }

        public void setCreatedAt(string createdAt)
        {
            this.createdAt = createdAt;
        }

        public Type getType()
        {
            return typeof(Refund);
        }
    }
}
