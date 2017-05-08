using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Models
{
    public class Account : SpryngObject
    {
        private string id;

        private string organisationId;

        private string currencyCode;

        private string name;

        private string transactionWebhook;

        private string chargebackWebhook;

        private string refundWebhook;

        private int[] serviceFees;

        private List<AbstractProcessorConfiguration> processorConfigurations;

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
    }
}
