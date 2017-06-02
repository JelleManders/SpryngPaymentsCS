using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SpryngPaymentsCS.Models
{
    public class Account : SpryngObject
    {
        [JsonProperty("_id")]
        private string id;

        [JsonProperty("organisation")]
        private string organisationId;

        [JsonProperty("currency_code")]
        private string currencyCode;

        [JsonProperty("name")]
        private string name;

        [JsonProperty("webhook_transaction_update")]
        private string transactionWebhook;

        [JsonProperty("webhook_chargeback_update")]
        private string chargebackWebhook;

        [JsonProperty("webhook_refund_update")]
        private string refundWebhook;

        [JsonProperty("service_fees")]
        private int[] serviceFees;

        [JsonProperty("Processors_configurations")]
        private List<AbstractProcessorConfiguration> processorConfigurations;

        [JsonProperty("processors")]
        private string[] processors;

        public string getId()
        {
            return id;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getOrganistionId()
        {
            return organisationId;
        }

        public void setOrganistionId(string organistionId)
        {
            this.organisationId = organistionId;
        }

        public string getCurrencyCode()
        {
            return currencyCode;
        }

        public void setCurrencyCode(string currencyCode)
        {
            this.currencyCode = currencyCode;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getTransactionWebhook()
        {
            return transactionWebhook;
        }

        public void setTransactionWebhook(string transactionWebhook)
        {
            this.transactionWebhook = transactionWebhook;
        }

        public string getChargebackWebhook()
        {
            return chargebackWebhook;
        }

        public void setChargebackWebhook(string chargebackWebhook)
        {
            this.chargebackWebhook = chargebackWebhook;
        }

        public string getRefundWebhook()
        {
            return refundWebhook;
        }

        public void setRefundWebhook(string refundWebhook)
        {
            this.refundWebhook = refundWebhook;
        }

        public int[] getServiceFees()
        {
            return serviceFees;
        }

        public void setServiceFees(int[] serviceFees)
        {
            this.serviceFees = serviceFees;
        }

        public List<AbstractProcessorConfiguration> getProcessorConfigurations()
        {
            return processorConfigurations;
        }

        public void setProcessorConfigurations(List<AbstractProcessorConfiguration> processorConfigurations)
        {
            this.processorConfigurations = processorConfigurations;
        }

        public string[] getProcessors()
        {
            return processors;
        }

        public void setProcessors(string[] processors)
        {
            this.processors = processors;
        }

        public Type getClass()
        {
            return typeof(Account);
        }
    }
}
