using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Models
{
    public class Header
    {
        private string name;

        private string value;

        public Header(string _name, string _value)
        {
            this.name = _name;
            this.value = _value;
        }

        public string getName()
        {
            return this.name;
        }

        public string getValue()
        {
            return this.value;
        }
    }
}
