namespace Updated_AddressBookSystem
{
    public class ReadTxtFile
    {
        public static void SaveContactsToFile(List<Contact> contactList)
        {
            AddressBookMainClass addressBook = new AddressBookMainClass();
           

            using (StreamWriter writer = File.AppendText("C:\\Users\\Dhanashree\\source\\repos\\Updated_AddressBookSystem\\Exampe1.txt"))  //DIRECTLY GIVEN PATH
            {
                foreach (Contact contact in contactList)
                {
                    writer.WriteLine(contact.firstName);
                    writer.WriteLine(contact.lastName);
                    writer.WriteLine(contact.mobileNumber);
                    writer.WriteLine(contact.address);
                    writer.WriteLine(contact.city);
                    writer.WriteLine(contact.state);
                    writer.WriteLine(contact.zip);
                    writer.WriteLine(contact.email);
                }
            }


        }
        public static void LoadContactsFromFile(List<Contact> contactList)
        {
       
            string path = "C:\\Users\\DHanashree\\source\\repos\\Updated_AddressBookSystem\\Exampe1.txt"; //FIRST ASSIGN PATH TO VARIABLE THEN PASS

            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist.");
                return;
            }

            
            using (StreamReader reader = new StreamReader(path))

            {
                while (!reader.EndOfStream)
                {
                    Contact contact = new Contact();
                    contact.firstName = reader.ReadLine();
                    contact.lastName = reader.ReadLine();
                    contact.mobileNumber = reader.ReadLine();
                    contact.address = reader.ReadLine();
                    contact.city = reader.ReadLine();
                    contact.state = reader.ReadLine();
                    contact.zip = reader.ReadLine();
                    contact.email = reader.ReadLine();
                    contactList.Add(contact);
                }
            }
        }


    }
}
