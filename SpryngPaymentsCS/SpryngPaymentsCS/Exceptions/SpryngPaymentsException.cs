using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Exceptions
{
    public class SpryngPaymentsException : Exception
    {
        //!! field necessary?
        protected string field;

        public SpryngPaymentsException(string message, int code) : base(message) { }

        public string getField()
        {
            return field;
        }

        public void setField(string field)
        {
            this.field = field;
        }
    }
}
