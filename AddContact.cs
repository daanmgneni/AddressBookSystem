using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookAssignment
{
    public class AddPerson
    {
        public void details()
        {
            List<Contact_UC1> list = new List<Contact_UC1>();

            {
                Contact_UC1 address = new Contact_UC1();
                Console.Write("Enter firstName: ");
                address.firstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                address.lastName = Console.ReadLine();
                Console.Write("Enter Address: ");
                address.address = Console.ReadLine();
                Console.Write("Enter city: ");
                address.city = Console.ReadLine();
                Console.Write("Enter state: ");
                address.state = Console.ReadLine();
                Console.Write("Enter phone umber: ");
                address.phoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter zip: ");
                address.zip = Convert.ToInt32(Console.ReadLine());
                list.Add(address);
                Console.Write("Enter email: ");
                address.eMail = Console.ReadLine();
                list.Add(address);
                Console.WriteLine(address.firstName + "\n" + address.lastName + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNumber + "\n" + address.zip + "\n" + address.eMail);
            }
        }
    }
}