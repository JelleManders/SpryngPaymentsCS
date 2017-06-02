using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Http.Requests.Card;
using SpryngPaymentsCS.Models;

namespace SpryngPaymentsCS.Controllers
{
    public class CardController : BaseController
    {
        public CardController(SpryngPayments api) : base(api) { }

        public Card get(string id)
        {
            this.http.setRequest(new GetCard(id));
            Task send = this.http.send();

            send.Wait();

            return (Card)this.http.getDeserializedResponse().getData().ToObject<Card>();
        }
    }
}
