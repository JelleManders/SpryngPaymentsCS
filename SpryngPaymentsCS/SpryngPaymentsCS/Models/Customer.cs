using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Models
{
    public class Customer : SpryngObject
    {
        [JsonProperty("_id")]
        private string id;

        [JsonProperty("title")]
        private string title;

        [JsonProperty("gender")]
        private string gender;

        [JsonProperty("first_name")]
        private string firstName;

        [JsonProperty("last_name")]
        private string lastName;

        [JsonProperty("date_of_birth")]
        private string birthday;

        [JsonProperty("email_address")]
        private string emailAddress;

        [JsonProperty("phone_number")]
        private string phoneNumber;

        [JsonProperty("organisation")]
        private string organisationId;

        [JsonProperty("street_address")]
        private string address;

        [JsonProperty("postal_code")]
        private string postalCode;

        [JsonProperty("city")]
        private string city;

        [JsonProperty("country_code")]
        private string countryCode;

        [JsonProperty("mandates")]
        private List<Mandate> mandates;

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getTitle()
        {
            return title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public string getGender()
        {
            return gender;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getBirthday()
        {
            return birthday;
        }

        public void setBirthday(string birthday)
        {
            this.birthday = birthday;
        }

        public string getEmailAddress()
        {
            return emailAddress;
        }

        public void setEmailAddress(string emailAddress)
        {
            this.emailAddress = emailAddress;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public string getOrganisationId()
        {
            return organisationId;
        }

        public void setOrganisationId(string organisationId)
        {
            this.organisationId = organisationId;
        }

        public string getAddress()
        {
            return address;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getPostalCode()
        {
            return postalCode;
        }

        public void setPostalCode(string postalCode)
        {
            this.postalCode = postalCode;
        }

        public string getCity()
        {
            return city;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public string getCountryCode()
        {
            return countryCode;
        }

        public void setCountryCode(string countryCode)
        {
            this.countryCode = countryCode;
        }

        public List<Mandate> getMandates()
        {
            return mandates;
        }

        public void setMandates(List<Mandate> mandates)
        {
            this.mandates = mandates;
        }

        public Type getType()
        {
            return typeof(Customer);
        }
    }
}
