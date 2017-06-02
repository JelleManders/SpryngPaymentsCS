using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Models
{
    public class Transaction : SpryngObject
    {
        [JsonProperty("_id")]
        private string id;

        private string processor;

        [JsonProperty("account")]
        private string accountId;

        private int amount;

        [JsonProperty("dynamic_descriptor")]
        private string dynamicDescriptor;

        [JsonProperty("customer_ip")]
        private string customerIP;

        [JsonProperty("user_agent")]
        private string userAgent;

        public class Details
        {
            private string issuer;

            [JsonProperty("redirect_url")]
            private string redirectUrl;

            [JsonProperty("approval_url")]
            private string approvalUrl;

            public string getIssuer()
            {
                return issuer;
            }

            public void setIssuer(string issuer)
            {
                this.issuer = issuer;
            }

            public string getRedirectUrl()
            {
                return redirectUrl;
            }

            public void setRedirectUrl(string redirectUrl)
            {
                this.redirectUrl = redirectUrl;
            }

            public string getApprovalUrl()
            {
                return approvalUrl;
            }

            public void setApprovalUrl(string approvalUrl)
            {
                this.approvalUrl = approvalUrl;
            }
        }

        [JsonProperty("details")]
        private Details details;

        [JsonProperty("payment_product")]
        private string paymentProduct;

        [JsonProperty("payment_product_type")]
        private string paymentProductType;

        private string status;

        [JsonProperty("last_status_update")]
        private string lastStatusUpdate;
    
        [JsonProperty("geo_location")]
        private string[] geoLocation;

        [JsonProperty("created_at")]
        private string createdAt;

        [JsonProperty("card")]
        private string cardId;

        [JsonProperty("capture")]
        private bool capture;

        [JsonProperty("merchant_reference")]
        private string merchantReference;

        private bool blocked;

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getProcessor()
        {
            return processor;
        }

        public void setProcessor(string processor)
        {
            this.processor = processor;
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

        public string getDynamicDescriptor()
        {
            return dynamicDescriptor;
        }

        public void setDynamicDescriptor(string dynamicDescriptor)
        {
            this.dynamicDescriptor = dynamicDescriptor;
        }

        public string getCustomerIP()
        {
            return customerIP;
        }

        public void setCustomerIP(string customerIP)
        {
            this.customerIP = customerIP;
        }

        public string getUserAgent()
        {
            return userAgent;
        }

        public void setUserAgent(string userAgent)
        {
            this.userAgent = userAgent;
        }

        public Details getDetails()
        {
            return details;
        }

        public void setDetails(Details details)
        {
            this.details = details;
        }

        public string getPaymentProduct()
        {
            return paymentProduct;
        }

        public void setPaymentProduct(string paymentProduct)
        {
            this.paymentProduct = paymentProduct;
        }

        public string getPaymentProductType()
        {
            return paymentProductType;
        }

        public void setPaymentProductType(string paymentProductType)
        {
            this.paymentProductType = paymentProductType;
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

        public string[] getGeoLocation()
        {
            return geoLocation;
        }

        public void setGeoLocation(string[] geoLocation)
        {
            this.geoLocation = geoLocation;
        }

        public string getCreatedAt()
        {
            return createdAt;
        }

        public void setCreatedAt(string createdAt)
        {
            this.createdAt = createdAt;
        }

        public bool isBlocked()
        {
            return blocked;
        }

        public void setBlocked(bool blocked)
        {
            this.blocked = blocked;
        }

        public string getCardId()
        {
            return cardId;
        }

        public void setCardId(string cardId)
        {
            this.cardId = cardId;
        }

        public bool isCapture()
        {
            return capture;
        }

        public void setCapture(bool capture)
        {
            this.capture = capture;
        }

        public string getMerchantReference()
        {
            return merchantReference;
        }

        public void setMerchantReference(string merchantReference)
        {
            this.merchantReference = merchantReference;
        }

        public Type getType()
        {
            return typeof(Transaction);
        }
    }
}
