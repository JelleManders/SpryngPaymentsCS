using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Models;
using SpryngPaymentsCS.Http.Requests.ThreeD;

namespace SpryngPaymentsCS.Controllers
{
    public class ThreeDController : BaseController
    {
        public ThreeDController(SpryngPayments api) : base(api) { }

        public ThreeD enroll(string accountId, int amount, string cardId, string description)
        {
            ThreeDEnrollment enrollment = new ThreeDEnrollment();
            enrollment.setAccountId(accountId);
            enrollment.setAmount(amount);
            enrollment.setCardId(cardId);
            enrollment.setDescription(description);

            return this.enroll(enrollment);
        }

        public ThreeD enroll(ThreeDEnrollment enrollment)
        {
            this.http.setRequest(new Enroll());
            this.http.setPostEntity(enrollment);
            Task send = this.http.send();

            send.Wait();

            return (ThreeD) this.http.getDeserializedResponse().getData().ToObject<ThreeD>();
        }
    }
}
