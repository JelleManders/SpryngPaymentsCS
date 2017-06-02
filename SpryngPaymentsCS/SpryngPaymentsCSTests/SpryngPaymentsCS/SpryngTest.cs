using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS;

namespace SpryngPaymentsCSTests.SpryngPaymentsCS
{
    public class SpryngTest
    {
        protected readonly string API_KEY = "TbY7jIRht2JBm-4DLrP67vB5ZSaVaZhFEqPSXw_biJY";

        public readonly string TRANSACTION_ID = "";

        public readonly string ACCOUNT_ID = "58e755e691fbd750f34db63d";

        public readonly string ORGANISATION_ID = "58b93dcd3a7bb705cabcba3d";

        public readonly string CUSTOMER_ID = "";

        public readonly string EUR_CURRENCY_CODE = "EUR";

        public readonly string CARD_ID = "";

        public SpryngPayments spryng;

        public SpryngTest()
        {
            this.spryng = new SpryngPayments(this.API_KEY, true);
        }

        [TestMethod()]
        public void testSpryngTests() { Assert.AreEqual(true, true); }
    }
}
