/* Spryngpayments API library
 * Author: Jelle Manders
 * Date: April through May 2017
 */

using System.Net;
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

        /**
         * Public instance of the TransactionController
         */
        public TransactionController transaction;

        /**
         * Public instance of the AccountController.
         */
        public AccountController account;

        /**
         * Public instance of the OrganisationController
         */
        public OrganisationController organisation;

        /**
         * Public instance of the CustomerController
         */
        public CustomerController customer;

        /**
         * Public instance of the CardController
         */
        public CardController card;

        /**
         * Public instance of the ThreeDController
         */
        public ThreeDController threeD;

        public SpryngPayments(string apiKey, bool sandboxEnabled)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

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

            this.account       = new AccountController(this);
            this.transaction   = new TransactionController(this);
            this.organisation  = new OrganisationController(this);
            this.customer      = new CustomerController(this);
            this.card          = new CardController(this);
            this.threeD        = new ThreeDController(this);
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
