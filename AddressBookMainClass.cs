using System.Collections.Generic;

namespace Updated_AddressBookSystem
{
    class AddressBookMainClass
    {
        // Define a list to store the contacts
        List<Contact> contactList = new List<Contact>();

        // AddDetails method to add new contact to the list
        public void AddDetails()
        {
            Contact newContact = new Contact();

            Console.WriteLine("Enter First Name: ");
            newContact.firstName = Console.ReadLine();

            Console.WriteLine("Enter Last name: ");
            newContact.lastName = Console.ReadLine();

            Console.WriteLine("Enter Your MobileNumber: ");
            newContact.mobileNumber = Console.ReadLine();

            Console.WriteLine("Enter Your Address: ");
            newContact.address = Console.ReadLine();

            Console.WriteLine("Enter Your City: ");
            newContact.city = Console.ReadLine();

            Console.WriteLine("Enter  Your State: ");
            newContact.state = Console.ReadLine();

            Console.WriteLine("Enter Your Zip: ");
            newContact.zip = Console.ReadLine();

            Console.WriteLine("Enter Your Email Id: ");
            newContact.email = Console.ReadLine();

            contactList.Add(newContact);
            Console.WriteLine("Contact added successfully!");
        }




        // DisplayContact method to display all contacts in the address book
        public void DisplayContact()
        {
            if (contactList.Count == 0)
            {
                Console.WriteLine("Address book is empty!");
                return;
            }

            // Sort the contactList alphabetically by Person's name
            contactList.Sort((x, y) => string.Compare(x.firstName, y.firstName));

            // Display the sorted contact list
            Console.WriteLine("Address Book:");
            Console.WriteLine("===================================");
            foreach (var contact in contactList)
            {
                Console.WriteLine(contact.ToString());
                Console.WriteLine("-----------------------------------");
            }
        }

        // Sort the contactList by City
        public void SortByCity()
        {
            contactList.Sort((x, y) => string.Compare(x.city, y.city));
        }

        // Sort the contactList by State
        public void SortByState()
        {
            contactList.Sort((x, y) => string.Compare(x.state, y.state));
        }

        // Sort the contactList by Zip
        public void SortByZip()
        {
            contactList.Sort((x, y) => string.Compare(x.zip, y.zip));
        }

   



        // Main method to execute the program
        static void Main(string[] args)
        {
            Console.WriteLine("!!!!!!Welcome to Updated Adress Book Program!!!!!!");
            Console.WriteLine(" ");
            AddressBookMainClass addressBook = new AddressBookMainClass();


            bool flag = true;

            while (flag)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a new contact");
                Console.WriteLine("2. Display all contacts");
                Console.WriteLine("3. Sort contacts by city");
                Console.WriteLine("4. Sort contacts by state");
                Console.WriteLine("5. Sort contacts by zip");
                Console.WriteLine("6. Save contacts to a file");
                Console.WriteLine("7. Load contacts from a file");
                Console.WriteLine("0. Exit");

                int option =  Convert.ToInt32(Console.ReadLine());
                

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please enter the new contact details:");
                        addressBook.AddDetails();
                        break;
                    case 2:
                        addressBook.DisplayContact();
                        break;
                    case 3:
                        addressBook.SortByCity();
                        addressBook.DisplayContact();
                        break;
                    case 4:
                        addressBook.SortByState();
                        addressBook.DisplayContact();
                        break;
                    case 5:
                        addressBook.SortByZip();
                        addressBook.DisplayContact();
                        break;
                    case 6:
                        
                        ReadTxtFile.SaveContactsToFile(addressBook.contactList);
                        break;
                    case 7:
                        ReadTxtFile.LoadContactsFromFile(addressBook.contactList);
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program...");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter a number from the menu.");
                        break;
                }
            }

        }

    }
}
