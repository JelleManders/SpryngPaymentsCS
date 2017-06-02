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
    public class ThreeDTest : SpryngTest
    {
        [TestMethod()]
        public void testThreeDEnrollment()
        {
            ThreeDEnrollment enrollment = new ThreeDEnrollment();
            enrollment.setAccountId(this.ACCOUNT_ID);
            enrollment.setCardId(this.CARD_ID);
            enrollment.setAmount(1000);
            enrollment.setDescription("Test test test");

            ThreeD threeD = this.spryng.threeD.enroll(enrollment);

            Assert.IsNotNull(threeD);
            Assert.IsNotNull(threeD.getPareq());
            Assert.IsNotNull(threeD.getUrl());
        }
    }
}
