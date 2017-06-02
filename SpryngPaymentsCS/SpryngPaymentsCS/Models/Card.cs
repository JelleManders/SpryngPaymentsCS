using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Models
{
    public class Card : SpryngObject
    {
        [JsonProperty("_id")]
        private string id;

        [JsonProperty("last_four")]
        private string lastFour;

        [JsonProperty("expiry_year")]
        private int expiryYear;

        [JsonProperty("expiry_month")]
        private int expiryMonth;

        [JsonProperty("brand")]
        private string brand;

        [JsonProperty("bin")]
        private string bin;

        [JsonProperty("organisation")]
        private string organisationId;

        [JsonProperty("cvv_verified")]
        private bool cvvVerified;

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getLastFour()
        {
            return lastFour;
        }

        public void setLastFour(string lastFour)
        {
            this.lastFour = lastFour;
        }

        public int getExpiryYear()
        {
            return expiryYear;
        }

        public void setExpiryYear(int expiryYear)
        {
            this.expiryYear = expiryYear;
        }

        public int getExpiryMonth()
        {
            return expiryMonth;
        }

        public void setExpiryMonth(int expiryMonth)
        {
            this.expiryMonth = expiryMonth;
        }

        public string getBrand()
        {
            return brand;
        }

        public void setBrand(string brand)
        {
            this.brand = brand;
        }

        public string getBin()
        {
            return bin;
        }

        public void setBin(string bin)
        {
            this.bin = bin;
        }

        public string getOrganisationId()
        {
            return organisationId;
        }

        public void setOrganisationId(string organisationId)
        {
            this.organisationId = organisationId;
        }

        public bool isCvvVerified()
        {
            return cvvVerified;
        }

        public void setCvvVerified(bool cvvVerified)
        {
            this.cvvVerified = cvvVerified;
        }

        public Type getType()
        {
            return typeof(Card);
        }
    }
}
