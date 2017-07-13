using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ovn16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submissionBtn_Click(object sender, EventArgs e)
        {
            string tempFirstName = firstNameBox.Text;
            string tempLastName = lastNameBox.Text;
            string tempSocialSecurityNumber = socialSecurityNumberBox.Text;

            Person aPerson = new Person();
            aPerson.SetFirstName(tempFirstName);
            aPerson.SetLastName(tempLastName);
            aPerson.SetSocialSecurityNumber(tempSocialSecurityNumber);

            displayListBox.Items.Add($"{aPerson.GetLastName()}, {aPerson.GetFirstName()}, {aPerson.GetSocialSecurityNumber()}");

            lastNameBox.Clear();
            firstNameBox.Clear();
            socialSecurityNumberBox.Clear();

            DataController.AddToList(aPerson);


        }

        private void clearAllFieldsButton_Click(object sender, EventArgs e)
        {
            lastNameBox.Clear();
            firstNameBox.Clear();
            socialSecurityNumberBox.Clear();
        }

        private void addPhoneNumber_Click(object sender, EventArgs e)
        {
            // Lägg till telefonnummer ( i textrutan )
            string phoneNumber = phoneBox.Text;
            phoneNumberListBox.Items.Add($"{phoneNumber}");
            phoneBox.Clear();


            //Måste addera telefonnumret till kontakt.


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataController.PopulateContactList();
            List<Person> persons = DataController.GetContactList();

            foreach (var aPerson in persons)
            {
                displayListBox.Items.Add($"{aPerson.GetLastName()}, {aPerson.GetFirstName()}, {aPerson.GetSocialSecurityNumber()}");
            }
        }

        private void displayListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = displayListBox.SelectedIndex;

            if (index >= 0)
            {
                List<Person> contactList = DataController.GetContactList();
                Person tempPerson = contactList[index];
                firstNameBox.Text = tempPerson.GetFirstName();
                lastNameBox.Text = tempPerson.GetLastName();
                socialSecurityNumberBox.Text = tempPerson.GetSocialSecurityNumber();

                List<Address> addresses = tempPerson.GetAddresses();

                addressListBox.Items.Clear();

                foreach (Address anAddress in addresses)
                {
                    addressListBox.Items.Add($"Type: {anAddress.GetAddressType()}, Street: {anAddress.GetStreet()}");
                }
            }
        }

        private void deleteContactButton_Click(object sender, EventArgs e)
        {
            int index = displayListBox.SelectedIndex;

            if (index >= 0)
            {
                List<Person> contactList = DataController.GetContactList();
                contactList.RemoveAt(index);

                displayListBox.Items.RemoveAt(index);
                addressListBox.Items.Clear();
            }
        }

        private void updateContactButton_Click(object sender, EventArgs e)
        {
            int index = displayListBox.SelectedIndex;

            if (index >= 0)
            {
                List<Person> contactList = DataController.GetContactList();

                string tempFirstName = firstNameBox.Text;
                string tempLastName = lastNameBox.Text;
                string tempSocialSecurityNumber = socialSecurityNumberBox.Text;

                Person aPerson = contactList[index];

                aPerson.SetFirstName(tempFirstName);
                aPerson.SetLastName(tempLastName);
                aPerson.SetSocialSecurityNumber(tempSocialSecurityNumber);

                displayListBox.Items[index] = $"{aPerson.GetLastName()}, {aPerson.GetFirstName()}, {aPerson.GetSocialSecurityNumber()}";

                lastNameBox.Clear();
                firstNameBox.Clear();
                socialSecurityNumberBox.Clear();


            }

        }

        private void deleteNbrFromPhoneListBox_Click(object sender, EventArgs e)
        {
            //görs för att man ska kunna välja fler alternativ:
            phoneNumberListBox.SelectionMode = SelectionMode.MultiExtended;

            //se till att användaren har valt något
            if (phoneNumberListBox.SelectedItems.Count != 0) 
            {

                //gör en removeAt-metod baklänges, för annars tas itemen inte bor ordentligt
                //en omvänd loop ser till att man inte år igenom ett borttaget value (?)
                for (int i = phoneNumberListBox.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    phoneNumberListBox.Items.RemoveAt(phoneNumberListBox.SelectedIndices[i]);


                }
            }
            
        }
    }
}
