using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Models
{
    public class Organisation : SpryngObject
    {
        [JsonProperty("_id")]
        private string id;

        [JsonProperty("country_code")]
        private string countryCode;

        [JsonProperty("email")]
        private string email;

        [JsonProperty("extended_address")]
        private string extendedAddress;

        [JsonProperty("generate_invoice")]
        private bool generateInvoice;

        [JsonProperty("locality")]
        private string locality;

        [JsonProperty("name")]
        private string name;

        [JsonProperty("parent_id")]
        private string parentId;

        [JsonProperty("phone")]
        private string phone;

        [JsonProperty("postal_code")]
        private string postalCode;

        [JsonProperty("region")]
        private string region;

        [JsonProperty("street")]
        private string street;

        [JsonProperty("street_number")]
        private string streetNumber;

        [JsonProperty("tax_number")]
        private string taxNumber;

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getCountryCode()
        {
            return countryCode;
        }

        public void setCountryCode(string countryCode)
        {
            this.countryCode = countryCode;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getExtendedAddress()
        {
            return extendedAddress;
        }

        public void setExtendedAddress(string extendedAddress)
        {
            this.extendedAddress = extendedAddress;
        }

        public bool isGenerateInvoice()
        {
            return generateInvoice;
        }

        public void setGenerateInvoice(bool generateInvoice)
        {
            this.generateInvoice = generateInvoice;
        }

        public string getLocality()
        {
            return locality;
        }

        public void setLocality(string locality)
        {
            this.locality = locality;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getParentId()
        {
            return parentId;
        }

        public void setParentId(string parentId)
        {
            this.parentId = parentId;
        }

        public string getPhone()
        {
            return phone;
        }

        public void setPhone(string phone)
        {
            this.phone = phone;
        }

        public string getPostalCode()
        {
            return postalCode;
        }

        public void setPostalCode(string postalCode)
        {
            this.postalCode = postalCode;
        }

        public string getRegion()
        {
            return region;
        }

        public void setRegion(string region)
        {
            this.region = region;
        }

        public string getStreet()
        {
            return street;
        }

        public void setStreet(string street)
        {
            this.street = street;
        }

        public string getStreetNumber()
        {
            return streetNumber;
        }

        public void setStreetNumber(string streetNumber)
        {
            this.streetNumber = streetNumber;
        }

        public string getTaxNumber()
        {
            return taxNumber;
        }

        public void setTaxNumber(string taxNumber)
        {
            this.taxNumber = taxNumber;
        }

        public Type getType()
        {
            return typeof(Organisation);
        }
    }
}
