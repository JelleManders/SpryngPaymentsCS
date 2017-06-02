using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Utilities;
using SpryngPaymentsCS.Http.Requests.Organisation;
using SpryngPaymentsCS.Models;


namespace SpryngPaymentsCS.Controllers
{
    public class OrganisationController : BaseController
    {
        public OrganisationController(SpryngPayments api) : base(api) { }

        public Organisation get(string id)
        {
            this.http.setRequest(new GetOrganisation(id));
            Task send = this.http.send();

            send.Wait();

            return (Organisation) this.http.getDeserializedResponse().getData().ToObject<Organisation>();
        }

        public List<Organisation> list(List<Filter> filters)
        {
            this.addFilters(filters);

            return this.list();
        }

        public List<Organisation> list()
        {
            this.http.setRequest(new ListOrganisations());
            Task send = this.http.send();

            send.Wait();

            return (List<Organisation>) this.http.getDeserializedResponse().getData().ToObject<List<Organisation>>();
        }

        public Organisation create(Organisation organisation)
        {
            this.http.setRequest(new CreateOrganisation());
            this.http.setPostEntity(organisation);
            Task send = this.http.send();

            send.Wait();

            return (Organisation) this.http.getDeserializedResponse().getData().ToObject<Organisation>();
        }

        public Organisation update(string id, Organisation organisation)
        {
            this.http.setRequest(new UpdateOrganisation(id));
            this.http.setPostEntity(organisation);
            Task send = this.http.send();

            send.Wait();

            return (Organisation) this.http.getDeserializedResponse().getData().ToObject<Organisation>();
        }

        public Message delete(string id)
        {
            this.http.setRequest(new DeleteOrganisation(id));
            Task send = this.http.send();

            send.Wait();

            return (Message) this.http.getDeserializedResponse().getData().ToObject<Message>();
        }
    }
}