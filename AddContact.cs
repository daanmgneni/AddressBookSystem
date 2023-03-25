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
        List<Contact_UC1> list = new List<Contact_UC1>();

        public void details()
        {
            //List<Contact_UC1> list = new List<Contact_UC1>();
            Console.WriteLine("Enter no.of details want to print:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)

            {
                if (i == 0)
                {
                    Console.WriteLine("Information 1");
                }
                else if (i == 1)
                {
                    Console.WriteLine("Information 2");

                }
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
                Console.Write("Enter email: ");
                address.eMail = Console.ReadLine();
                list.Add(address);
                Console.WriteLine(address.firstName + "\n" + address.lastName + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNumber + "\n" + address.zip + "\n" + address.eMail);

                ///Edit by name///

                Console.WriteLine("Edit by using First Name: ");
                String name = Console.ReadLine();
                foreach (var data in list)
                {
                    if (data.firstName == name)
                    {
                        Console.WriteLine("Enter option to edit:\n1.First Name\n2.Second Name\n3.Address\n4.city\n5.state\n6.phone number\n7.email");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter first name ");
                                data.firstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter last name ");
                                data.lastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.WriteLine("Enter address");
                                data.address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter city");
                                data.city = Console.ReadLine();
                                break;
                            case 5:
                                address.state = Console.ReadLine();
                                Console.Write("Enter phone umber: ");
                                break;
                            case 6:
                                address.state = Console.ReadLine();
                                Console.WriteLine("Enter state");
                                break;
                            case 7:
                                address.phoneNumber = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter phne number");
                                break;
                            case 8:
                                address.zip = Convert.ToInt32(Console.ReadLine());
                                list.Add(address);
                                break;
                            case 9:
                                Console.WriteLine("Enter email");
                                data.eMail = Console.ReadLine();
                                break;
                        }
                        Console.WriteLine(data.firstName + "\n" + data.lastName + "\n" + data.address + "\n" + data.city + "\n" + data.state + "\n" + data.phoneNumber + "\n" + data.zip + "\n" + data.eMail);

                    }

                }

            }
        }

        public void deleteContact()
        {
            Contact_UC1 address = new Contact_UC1();
            Console.WriteLine("Enter name to delete details");
            String name = Console.ReadLine();
            foreach (var data in list)
            {
                if (data.firstName.Equals(name))
                    address = data;

            }
            list.Remove(address);
            Console.WriteLine("contact was deleted" + address.lastName + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNumber + "\n" + address.zip + "\n" + address.eMail);

        }
    }
}