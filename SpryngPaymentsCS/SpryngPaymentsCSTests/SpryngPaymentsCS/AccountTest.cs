using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpryngPaymentsCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Utilities;
using SpryngPaymentsCS;

namespace SpryngPaymentsCSTests.SpryngPaymentsCS
{
    [TestClass()]
    public class AccountTest : SpryngTest
    {
        public Account account;
        public List<Account> accounts;

        public void testAccount(Account account)
        {
            Assert.IsNotNull(account);
            Assert.AreEqual(account.getClass(), typeof(Account));
            Assert.IsNotNull(account.getId());
            Assert.IsNotNull(account.getOrganistionId());
            Assert.IsNotNull(account.getCurrencyCode());
            Assert.IsNotNull(account.getName());
            //foreach(AbstractProcessorConfiguration apc in account.getProcessorConfigurations()) {
            //    Assert.IsNotNull(apc.getType());
            //}
        }

        [TestMethod()]
        public void testGetAccount()
        {
            Account account = this.spryng.account.get(this.ACCOUNT_ID);
            if (account != null)
            {
                this.testAccount(account);
            }
        }

        public void testAccountList(List<Account> accounts)
        {
            foreach(Account account in accounts)
            {
                this.testAccount(account);
            }
        }

        [TestMethod()]
        public void testListAccounts()
        {
            List<Account> accounts = this.spryng.account.list();

            Assert.IsNotNull(accounts);

            this.testAccountList(accounts);
        }

        [TestMethod()]
        public void testListAccountsWithFilters()
        {
            List<Filter> filterList = new List<Filter>();
            Filter currencyFilter = new Filter("currency_code", IFilterOperator.EQUALS, "EUR");

            filterList.Add(currencyFilter);

            List<Account> accounts = this.spryng.account.list(filterList);

            Assert.IsNotNull(accounts);

            this.testAccountList(accounts);
        }

        [TestMethod()]
        public void testCreateAccount() 
        {
            Account account = new Account();
            account.setName("Test Create Account");
            account.setOrganistionId(this.ORGANISATION_ID);
            account.setCurrencyCode(this.EUR_CURRENCY_CODE);

            Account newAccount = spryng.account.create(account);

            Assert.IsNotNull(newAccount);
            Assert.IsNotNull(newAccount.getId());
            Assert.Equals(newAccount.getCurrencyCode(), this.EUR_CURRENCY_CODE);
            Assert.Equals(newAccount.getOrganistionId(), this.ORGANISATION_ID);
        }
    }
}