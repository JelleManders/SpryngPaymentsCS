using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpryngPaymentsCS.Utilities;

namespace SpryngPaymentsCS.Http.Requests
{
    public abstract class AbstractRequest : Constants
    {
        public bool isCollection;

        public LinkedList<Filter> filters = new LinkedList<Filter>();

        public abstract IRequestMethod getRequestMethod();

        public abstract string getUrlResourceIdentifier();

        public abstract string getEndpoint();
        //{
            //return this.getUrlResourceIdentifier() + URL_PATH_SEPARATOR + this.getURLMethod(); ;
        //}

        //!! Probably not functional in the way it is supposed to
        //public abstract Type getClass();

        public LinkedList<Filter> getFilters()
        {
            return this.filters;
        }

        public void addFilter(Filter filter)
        {
            this.filters.AddFirst(filter);
        }

        public bool getIsCollection()
        {
            return this.isCollection;
        }

        public abstract string getURLMethod();
    }
}
