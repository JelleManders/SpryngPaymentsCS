using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Utilities;
using SpryngPaymentsCS.Models;
using SpryngPaymentsCS.Http.Requests.Customer;

namespace SpryngPaymentsCS.Controllers
{
    public class CustomerController : BaseController
    {
        public CustomerController(SpryngPayments api) : base(api) { }

        public Customer get(string customerId)
        {
            this.http.setRequest(new GetCustomer(customerId));
            Task send = this.http.send();

            send.Wait();

            return (Customer) this.http.getDeserializedResponse().getData();
        }

        public List<Customer> list(List<Filter> filters)
        {
            this.addFilters(filters);

            return this.list();
        }

        public List<Customer> list()
        {
            this.http.setRequest(new ListCustomers());
            Task send = this.http.send();

            send.Wait();

            return (List<Customer>) this.http.getDeserializedResponse().getData();
        }

        public Customer create(Customer customer)
        {
            this.http.setRequest(new CreateCustomer());
            this.http.setPostEntity(customer);
            Task send = this.http.send();

            send.Wait();

            return (Customer) this.http.getDeserializedResponse().getData();
        }

        public Customer update(string id, Customer customer) 
        {
            this.http.setRequest(new UpdateCustomer(id));
            this.http.setPostEntity(customer);
            Task send = this.http.send();

            send.Wait();

            return (Customer) this.http.getDeserializedResponse().getData();
        }
    }
}
