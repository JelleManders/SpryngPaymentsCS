using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using SpryngPaymentsCS.Models;
using SpryngPaymentsCS.Http.Requests.Account;
using SpryngPaymentsCS.Utilities;

namespace SpryngPaymentsCS.Controllers
{
    public class AccountController : BaseController
    {
        public AccountController(SpryngPayments api) : base(api) { }

        public Account get(string accountId)
        {
            this.http.setRequest(new GetAccount(accountId));
            Task send = this.http.send();

            send.Wait();

            Account account = this.http.getDeserializedResponse().getData().ToObject<Account>();

            return account;
        }

        public List<Account> list(List<Filter> filters)
        {
            this.addFilters(filters);

            return this.list();
        }

        public List<Account> list()
        {
            this.http.setRequest(new ListAccounts());
            Task list = this.http.send();

            list.Wait();

            return (List<Account>) this.http.getDeserializedResponse().getData().ToObject<List<Account>>();
        }

        public Account create(Account account)
        {
            this.http.setRequest(new CreateAccount());
            this.http.setPostEntity(account);
            Task create = this.http.send();

            create.Wait();

            return (Account) this.http.getDeserializedResponse().getData().ToObject<Account>();
        }
    }
}
