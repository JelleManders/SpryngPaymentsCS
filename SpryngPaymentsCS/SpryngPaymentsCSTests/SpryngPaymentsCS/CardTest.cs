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
    public class CardTest : SpryngTest
    {
        [TestMethod]
        public void testGetCard()
        {
            Card card = this.spryng.card.get(this.CARD_ID);

            Assert.IsNotNull(card);
            Assert.AreEqual(card.getType(), typeof(Card));
            Assert.IsNotNull(card.getBrand());
            Assert.IsNotNull(card.getExpiryMonth());
            Assert.IsNotNull(card.getExpiryYear());
            Assert.IsNotNull(card.getLastFour());
            Assert.IsNotNull(card.getBin());
            Assert.IsNotNull(card.getOrganisationId());
            Assert.IsNotNull(card.isCvvVerified());
        }
    }
}
