using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn16
{
    static class DataController
    {
        static List<Person> contactList = new List<Person>();

        public static void PopulateContactList()
        {
            // ================= PERSON 1 =================== //

            Person aPerson = new Person();
            aPerson.SetFirstName("Niklas");
            aPerson.SetLastName("Livfors");
            aPerson.SetSocialSecurityNumber("751023-9988");

            Address anAddress = new Address();
            anAddress.SetAddressType("Home");
            anAddress.SetStreet("Kulinggatan 5");

            List<Address> addresslist = aPerson.GetAddresses();

            addresslist.Add(anAddress);

            anAddress = new Address();
            anAddress.SetAddressType("Work");
            anAddress.SetStreet("Borgarfjordsgatan 4");

            addresslist.Add(anAddress);

            contactList.Add(aPerson);

            // ================= PERSON 2 ================== //

            aPerson = new Person();
            aPerson.SetFirstName("Lisa");
            aPerson.SetLastName("Eriksson");
            aPerson.SetSocialSecurityNumber("920314-2641");

            anAddress = new Address();
            anAddress.SetAddressType("Home");
            anAddress.SetStreet("Kattungegatan 8");

            addresslist = aPerson.GetAddresses();
            addresslist.Add(anAddress);

            contactList.Add(aPerson);

            // ================= PERSON 3 =================== //

            aPerson = new Person();
            aPerson.SetFirstName("Anna");
            aPerson.SetLastName("Larsson");
            aPerson.SetSocialSecurityNumber("911204-7645");

            contactList.Add(aPerson);
        }

        public static void AddToList(Person aPerson)
        {
            contactList.Add(aPerson);
        }

        public static List<Person> GetContactList()
        {
            return contactList;
        }

    }
}
