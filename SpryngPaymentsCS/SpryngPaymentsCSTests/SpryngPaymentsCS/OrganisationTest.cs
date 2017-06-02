using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Models;

namespace SpryngPaymentsCSTests.SpryngPaymentsCS
{
    [TestClass()]
    public class OrganisationTest : SpryngTest
    {
        private Organisation newOrganisation;

        private string newName = "Updated Java Test Organisation";

        public void testOrganisation(Organisation organisation)
        {
            Assert.IsNotNull(organisation);
            Assert.AreEqual(organisation.getType(), typeof(Organisation));
            Assert.IsNotNull(organisation.getId());
            Assert.IsNotNull(organisation.getName());
        }

        public void testOrganisationList(List<Organisation> organisations)
        {
            foreach (Organisation organisation in organisations)
            {
                this.testOrganisation(organisation);
            }
        }

        [TestMethod()]
        public void testGetOrganisation() 
        {
            Organisation organisation = this.spryng.organisation.get(this.ORGANISATION_ID);

            Assert.IsNotNull(organisation);
            Assert.AreEqual(organisation.getType(), typeof(Organisation));
            Assert.IsNotNull(organisation.getId());
            Assert.IsNotNull(organisation.getName());
        }

        [TestMethod()]
        public void testListOrganisations() 
        {
            List<Organisation> organisations = this.spryng.organisation.list();

            this.testOrganisationList(organisations);
        }

        [TestMethod()]
        public void testCreateUpdateAndDeleteOrganisation() 
        {
            Organisation organisation = new Organisation();
            organisation.setParentId(this.ORGANISATION_ID);
            organisation.setName("Java Test Organisation");

            Organisation newOrganisation = this.spryng.organisation.create(organisation);
            this.testOrganisation(newOrganisation);
            this.newOrganisation = newOrganisation;

            this.testUpdateOrganisation();
        }

        public void testUpdateOrganisation() 
        {
            this.newOrganisation.setName(this.newName);

            Organisation updatedOrganisation = this.spryng.organisation.update(this.newOrganisation.getId(), this.newOrganisation);

            this.testOrganisation(updatedOrganisation);
            Assert.AreEqual(newOrganisation.getName(), this.newName);

            this.testDeleteOrganisation();
        }

        public void testDeleteOrganisation() 
        {
            Message message = this.spryng.organisation.delete(this.newOrganisation.getId());

            Assert.IsNotNull(message);
            Assert.AreEqual(message.getType(), typeof(Message));
            Assert.IsNotNull(message.getMessage());
        }
    }
}
