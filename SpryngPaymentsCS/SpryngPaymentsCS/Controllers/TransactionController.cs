using System.IO;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Threading.Tasks;
using SpryngPaymentsCS.Models;
using SpryngPaymentsCS.Http.Requests.Transaction;
using SpryngPaymentsCS.Utilities;

namespace SpryngPaymentsCS.Controllers
{
    public class TransactionController : BaseController
    {
        public TransactionController(SpryngPayments api) : base(api) { }

        public Transaction get(string transactionId)
        {
            this.http.setRequest(new GetTransaction(transactionId));
            Task send = this.http.send();

            send.Wait();

            return (Transaction)this.http.getDeserializedResponse().getData().ToObject<Transaction>();
        }

        public List<Transaction> list(List<Filter> filters)
        {
            this.addFilters(filters);

            return this.list();
        }

        public List<Transaction> list()
        {
            this.http.setRequest(new ListTransactions());
            Task send = this.http.send();

            send.Wait();

            return (List<Transaction>)this.http.getDeserializedResponse().getData().ToObject<List<Transaction>>();
        }

        public Transaction create(Transaction transaction)
        {
            this.http.setRequest(new CreateTransaction());
            this.http.setPostEntity(transaction);
            Task send = this.http.send();

            send.Wait();

            return (Transaction) this.http.getDeserializedResponse().getData().ToObject<Transaction>();
        }

        public Transaction voidAuth(string id)
        {
            this.http.setRequest(new VoidTransaction(id));
            Task send = this.http.send();

            send.Wait();

            return (Transaction)this.http.getDeserializedResponse().getData().ToObject<Transaction>();
        }

        public Transaction voidCapture(string id)
        {
            this.http.setRequest(new VoidCaptureTransaction(id));
            Task send = this.http.send();

            send.Wait();

            return (Transaction) this.http.getDeserializedResponse().getData().ToObject<Transaction>();
        }

        public Transaction update(string id, string merchantReference)
        {
            this.http.setRequest(new UpdateTransaction(id));
            TransactionSpecialParameters tsp = new TransactionSpecialParameters();
            tsp.setMerchantReference(merchantReference);
            this.http.setPostEntity(tsp);

            Task send = this.http.send();

            send.Wait();

            return (Transaction)this.http.getDeserializedResponse().getData().ToObject<Transaction>();
        }

        public Transaction update(Transaction transaction)
        {
            this.http.setRequest(new UpdateTransaction(transaction.getId()));
            TransactionSpecialParameters tsp = new TransactionSpecialParameters();
            tsp.setMerchantReference(transaction.getMerchantReference());
            this.http.setPostEntity(tsp);

            Task send = this.http.send();

            send.Wait();

            return (Transaction)this.http.getDeserializedResponse().getData().ToObject<Transaction>();
        }

        public Transaction capture(string id, int amount)
        {
            this.http.setRequest(new CaptureTransaction(id));
            TransactionSpecialParameters tsp = new TransactionSpecialParameters();
            tsp.setAmount(amount);
            this.http.setPostEntity(tsp);

            Task send = this.http.send();

            send.Wait();

            return (Transaction)this.http.getDeserializedResponse().getData().ToObject<Transaction>();
        }

        public Refund refund(string id, int amount)
        {
            this.http.setRequest(new RefundTransaction(id));
            TransactionSpecialParameters tsp = new TransactionSpecialParameters();
            tsp.setAmount(amount);
            this.http.setPostEntity(tsp);

            Task send = this.http.send();

            send.Wait();

            return (Refund)this.http.getDeserializedResponse().getData().ToObject<Refund>();
        }

        public Refund refund(string id, int amount, string reason)
        {
            this.http.setRequest(new RefundTransaction(id));
            TransactionSpecialParameters tsp = new TransactionSpecialParameters();
            tsp.setAmount(amount);
            tsp.setReason(reason);
            this.http.setPostEntity(tsp);

            Task send = this.http.send();

            send.Wait();

            return (Refund)this.http.getDeserializedResponse().getData().ToObject<Refund>(); 
        }

        private class TransactionSpecialParameters : SpryngObject
        {
            [JsonProperty("amount")]
            private int amount;

            [JsonProperty("reason")]
            private string reason;

            [JsonProperty("merchant_reference")]
            private string merchantReference;

            public int getAmount() { return amount; }

            public void setAmount(int amount) { this.amount = amount; }

            public string getReason() { return this.reason; }

            public void setReason(string reason) { this.reason = reason; }

            public string getMerchantReference() { return this.merchantReference; }

            public void setMerchantReference(string merchantReference) { this.merchantReference = merchantReference; }
        }
    }
}
