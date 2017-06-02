using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Models;

namespace SpryngPaymentsCSTests.SpryngPaymentsCS
{
    [TestClass]
    public class CustomerTest : SpryngTest
    {
        public Customer customer;

        public List<Customer> customers;

        private void testCustomer()
        {
            Assert.AreEqual(customer.getType(), typeof(Customer));
            Assert.IsNotNull(customer.getFirstName());
            Assert.IsNotNull(customer.getLastName());
        }

        [TestMethod()]
        public void testGetCustomer() 
        {
            Customer customer = this.spryng.customer.get(this.CUSTOMER_ID);

            this.testCustomer();
        }

        [TestMethod()]
        public void testListCustomers() 
        {
            List<Customer> customers = this.spryng.customer.list();

            foreach (Customer customer in customers)
            {
                this.testCustomer();
            }
        }

        [TestMethod()]
        public void testCreateAndUpdateCustomer() 
        {
            Customer customer = new Customer();
            customer.setGender("");
            customer.setTitle("");
            customer.setOrganisationId(this.ORGANISATION_ID);
            customer.setFirstName("");
            customer.setLastName("");
            customer.setEmailAddress("");
            customer.setPhoneNumber("");
            customer.setAddress("");
            customer.setPostalCode("");
            customer.setCity("");
            customer.setCountryCode("");

            Customer newCustomer = this.spryng.customer.create(customer);

            this.testCustomer();
            this.testCustomer();

            this.testUpdateCustomer(customer);
        }

        private void testUpdateCustomer(Customer customer) 
        {
            customer.setFirstName("Something");
            customer.setLastName("Different");

            Customer updatedCustomer = this.spryng.customer.update(this.CUSTOMER_ID, customer);

            Assert.AreEqual(customer.getFirstName(), "Something");
            Assert.AreEqual(customer.getLastName(), "Different");

            this.customer = updatedCustomer;
            this.testCustomer();
        }
    }
}
