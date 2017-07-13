using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn16
{
    class Person
    {
        string firstName;
        string lastName;
        string socialSecurityNumber;
        List<Address> addresses = new List<Address>();
        List<string> phoneNumbers = new List<string>();

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string firstN)
        {
            firstName = firstN.Trim();
            firstName = firstName[0].ToString().ToUpper() + firstName.Substring(1).ToLower();

        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string lastN)
        {
            lastName = lastN.Trim();
            lastName = lastName[0].ToString().ToUpper() + lastName.Substring(1).ToLower();

        }

        public string GetSocialSecurityNumber()
        {
            return socialSecurityNumber;
        }

        public void SetSocialSecurityNumber(string socialSecurityNumber)
        {
            this.socialSecurityNumber = socialSecurityNumber;

        }

        public List<Address> GetAddresses()
        {
            return addresses;
        }

    }
}
