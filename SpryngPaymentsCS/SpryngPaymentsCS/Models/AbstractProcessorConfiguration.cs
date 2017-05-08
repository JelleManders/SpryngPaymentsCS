using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpryngPaymentsCS.Models
{
    public abstract class AbstractProcessorConfiguration : SpryngObject
    {
        public string _type;

        public string getType()
        {
            return _type;
        }

        public abstract string getTypeIdentifier();
    }
}
