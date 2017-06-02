using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Models;
using SpryngPaymentsCS.Utilities;

namespace SpryngPaymentsCSTests.SpryngPaymentsCS
{
    [TestClass()]
    public class TransactionTest : SpryngTest
    {
        protected readonly string CAPTURE_TRANSACTION_ID = "";

        protected readonly int CAPTURE_TRANSACTION_AMOUNT = 100;

        protected readonly string REFUND_TRANSACTION_ID = "";

        protected readonly int REFUND_TRANSACTION_AMOUNT = 100;

        protected readonly string UPDATE_TRANSACTION_ID = "";

        public TransactionTest() : base() { }

        [TestMethod()]
        public void testGetTransaction() 
        {
            Transaction transaction = this.spryng.transaction.get(this.TRANSACTION_ID);

            Assert.IsNotNull(transaction);
        }

        [TestMethod()]
        public void testListTransactions() 
        {
            List<Transaction> transactions = this.spryng.transaction.list();

            Assert.IsNotNull(transactions);

            foreach(Transaction transaction in transactions)
            {
                Assert.IsNotNull(transaction.getId());
            }
        }

        [TestMethod()]
        public void testListTransactionsWithFilters() 
        {
            List<Filter> filterList = new List<Filter>();
            Filter amountFilter = new Filter("amount", IFilterOperator.GREATER_THAN_OR_EQUALS, "1000");
            Filter accountFilter = new Filter("account", IFilterOperator.EQUALS, this.ACCOUNT_ID);

            filterList.Add(amountFilter);
            filterList.Add(accountFilter);

            List<Transaction> transactions = this.spryng.transaction.list(filterList);

            Assert.IsNotNull(transactions);

            foreach (Transaction transaction in transactions)
            {
                Assert.IsTrue((transaction.getAmount() >= 1000));
                Assert.AreEqual(transaction.getAccountId(), this.ACCOUNT_ID);
            }
        }

        [TestMethod()]
        public void testCreateTransaction() 
        {
            Transaction transaction = new Transaction();
            transaction.setAccountId(this.ACCOUNT_ID);
            transaction.setAmount(1000);
            transaction.setCardId(this.CARD_ID);
            transaction.setCapture(true);
            transaction.setCustomerIP("127.0.0.1");
            transaction.setDynamicDescriptor("TEST_0001");
            transaction.setMerchantReference("SpryngPaymentsJavaTest");
            transaction.setPaymentProduct("card");
            transaction.setUserAgent("Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_0) AppleWebKit/537.36 (KHTML, like Gecko)" +
                            " Chrome/53.0.2785.116 Safari/537.36");

            Transaction newTransaction = spryng.transaction.create(transaction);

            Assert.IsNotNull(newTransaction);
            Assert.IsNotNull(newTransaction.getId());
            Assert.AreEqual(newTransaction.getCardId(), this.CARD_ID);
            Assert.AreEqual(newTransaction.getAccountId(), this.ACCOUNT_ID);
        }

        [TestMethod()]
        public void testUpdateTransaction() 
        {
            Transaction updatedTransaction = this.spryng.transaction.update(this.UPDATE_TRANSACTION_ID, "UPDATED_MR");
            Assert.AreEqual(updatedTransaction.getMerchantReference(), "UPDATED_MR");
        }

        [TestMethod()]
        public void testCaptureTransaction() 
        {
            Transaction transaction = this.spryng.transaction.capture(
            this.CAPTURE_TRANSACTION_ID, this.CAPTURE_TRANSACTION_AMOUNT);

            Assert.IsNotNull(transaction);
            Assert.AreEqual(typeof(Transaction), transaction.getType());
        }

        [TestMethod()]
        public void testRefundTransaction() 
        {
            Refund refund = this.spryng.transaction.refund(this.REFUND_TRANSACTION_ID, this.REFUND_TRANSACTION_AMOUNT);

            Assert.IsNotNull(refund);
            Assert.AreEqual(typeof(Refund), refund.getType());
            Assert.IsNotNull(refund.getAccountId());
            Assert.AreEqual(this.REFUND_TRANSACTION_AMOUNT, refund.getAmount());
            Assert.AreEqual(this.REFUND_TRANSACTION_ID, refund.getTransactionId());
            Assert.IsNotNull(refund.getStatus());
            Assert.IsNotNull(refund.getLastStatusUpdate());
            Assert.IsNotNull(refund.getCreatedAt());
        }
    }
}
