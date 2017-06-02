using System.Web;
using System.Net;
using SpryngPaymentsCS;
using System;
using SpryngPaymentsCS.Models;
using SpryngPaymentsCS.Exceptions;
using SpryngPaymentsCS.Utilities;
using System.Collections.Generic;

public class SpryngPaymentsUsage
{
    protected SpryngPayments spryng;

    public static void Main(string[] args)
    {
        SpryngPaymentsUsage test = new SpryngPaymentsUsage();
    }

    public SpryngPaymentsUsage()
    {
        this.spryng = new SpryngPayments("YOUR_API_KEY", true);
        // New instance, which uses the sandbox

        Transaction transaction = new Transaction();
        transaction.setAccountId("YOUR_ACCOUNT_ID");
        transaction.setAmount(1000);
        transaction.setCardId("CREDIT_CARD_TOKEN");
        transaction.setCapture(false);
        transaction.setCustomerIP("127.0.0.1");
        transaction.setDynamicDescriptor("TEST_0001");
        transaction.setMerchantReference("SpryngPayments Example");
        transaction.setPaymentProduct("card");
        transaction.setUserAgent("Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_0) AppleWebKit/537.36 (KHTML, like Gecko)" +
                " Chrome/53.0.2785.116 Safari/537.36");

        Transaction newTransaction = spryng.transaction.create(transaction);

        // Capture the new transaction
        this.spryng.transaction.capture(newTransaction.getId(), newTransaction.getAmount()); // Capture the full amount

        // Refund the new transaction
        this.spryng.transaction.refund(newTransaction.getId(), newTransaction.getAmount()); // Refund the full amount

        // Let's list all transactions for which the amount is > 1000 (€10)
        List<Filter> filterList = new List<Filter>();
        Filter amountFilter = new Filter("amount", IFilterOperator.GREATER_THAN_OR_EQUALS, "1000");
        filterList.Add(amountFilter);

        List<Transaction> transactions = this.spryng.transaction.list(filterList);

        foreach (Transaction subTransaction in transactions)
        {
            Console.WriteLine(subTransaction.ToString());
        }
    }
}
