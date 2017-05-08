using System;
using System.Net.Http;
using SpryngPaymentsCS.Controllers;
using log4net;


namespace SpryngPaymentsCS
{
    public class SpryngPayments : Constants
    {
        private static readonly HttpClient client = new HttpClient();

        public readonly string API_ENDPOINT_PRODUCTION = "api.spryngpayments.com";

        public readonly string API_ENDPOINT_SANDBOX = "sandbox.spryngpayments.com";

        public static readonly ILog LOG;

        protected static string activeEndpoint;

        protected string apiKey;

        protected bool sandboxEnabled;

        public AccountController account;

        public SpryngPayments(string apiKey, bool sandboxEnabled)
        {
            this.setApiKey(apiKey);
            this.setSandboxEnabled(sandboxEnabled);

            if (sandboxEnabled)
            {
                this.setActiveEndpoint(this.API_ENDPOINT_SANDBOX);
            }
            else
            {
                this.setActiveEndpoint(this.API_ENDPOINT_PRODUCTION);
            }

            this.account = new AccountController(this);
        }

        public string getApiKey()
        {
            return apiKey;
        }

        public void setApiKey(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public bool isSandboxEnabled()
        {
            return sandboxEnabled;
        }

        public void setSandboxEnabled(bool sandboxEnabled)
        {
            this.sandboxEnabled = sandboxEnabled;

            if (this.sandboxEnabled)
            {
                this.setActiveEndpoint(this.API_ENDPOINT_SANDBOX);
            }
            else
            {
                this.setActiveEndpoint(this.API_ENDPOINT_PRODUCTION);
            }
        }

        public static string getActiveEndpoint()
        {
            return activeEndpoint;
        }

        public void setActiveEndpoint(string newActiveEndpoint)
        {
            activeEndpoint = newActiveEndpoint;
        }
    }
}
