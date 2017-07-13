using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn16
{
    class Address
    {
        string type; 
        string street;
        //string zidCode;
        //string city;

        public string GetAddressType()
        {
            return type;
        }

        public void SetAddressType(string type)
        {
            this.type = type;
        }

        public string GetStreet()
        {
            return street;
        }

        public void SetStreet(string street)
        {
            this.street = street;
        }

    }
}
