using System.IO;
using System.Net;
using Newtonsoft.Json;

// 5571197343845659

namespace SpryngPaymentsCS.Controllers
{
    class TransactionController
    {
        private string account;
        private int amount;
        private bool capture_now;
        private string card;
        private string customer_ip;
        private string dynamic_descriptor;
        private string merchant_reference;
        private string pares;
        private string user_agent;

        private string descriptor;

        public TransactionController()
        {
            
        }

        public string getAccount() { return account; }

        public void setAccount(string newValue) { account = newValue; }

        public int getAmount() { return amount; }

        public void setAmount(int newValue) { amount = newValue; }

        public bool getCapture_now() { return capture_now; }

        public void setCapture_now(bool newValue) { capture_now = newValue; }

        public string getCard() { return card; }

        public void setCard(string newValue) { card = newValue; }

        public string getCustomer_ip() { return customer_ip; }

        public void setCustomer_ip(string newValue) { customer_ip = newValue; }

        public string getDynamic_descriptor() { return dynamic_descriptor; }

        public void setDynamic_descriptor(string newValue) { dynamic_descriptor = newValue; }

        public string getMerchant_reference() { return merchant_reference; }

        public void setMerchant_reference(string newValue) { merchant_reference = newValue; }

        public string getPares() { return pares; }

        public void setPares(string newValue) { pares = newValue; }

        public string getUser_agent() { return user_agent; }

        public void setUser_agent(string newValue) { user_agent = newValue; }

        public string getDescriptor()
        {
            descriptor = JsonConvert.SerializeObject(this);
            return descriptor;
        }
    }
}
