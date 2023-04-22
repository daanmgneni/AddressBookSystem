using CsvHelper;
using System.Globalization;
using System.IO;
using System.Net;

namespace Updated_AddressBookSystem
{

    public class ReadCsvFile
    {

        // Save contacts to a CSV file
        public static void SaveContactsToCsv(List<Contact> contactList)
        {
            using (var writer = new StreamWriter("Exampe2.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(contactList);
            }
            Console.WriteLine("Contacts saved to CSV file successfully!");
        }

        // Load contacts from a CSV file
         public static void LoadContactsFromCsv(List<Contact> contactList)
         {
             string filePath = "C:\\Users\\Dhanashree\\source\\repos\\Updated_AddressBookSystem\\Exampe2.csv";
             using (var reader = new StreamReader(filePath))
             using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
             {
               contactList = csv.GetRecords<Contact>().ToList();
                 foreach (var addressData in contactList)
                 {
                     Console.WriteLine($"Name: {addressData.firstName} {addressData.lastName}\nMobile Number: {addressData.mobileNumber}\nAddress: {addressData.address}\nCity: {addressData.city}\nState: {addressData.state}\nZip: {addressData.zip}\nEmail: {addressData.email}\n");
                 }
             }
             Console.WriteLine("Contacts loaded from CSV file successfully!");
         }
        

        public static void LoadContactsFromCsv(List<Contact> contactList)
        {
            using (var reader = new StreamReader("Exampe2.csv"))
            using (var csvobj = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                contactList.Clear(); // clear the existing contacts
                contactList.AddRange(csvobj.GetRecords<Contact>()); // add the loaded contacts
            }
            Console.WriteLine("Contacts loaded from CSV file successfully!");
        }



    }
}
