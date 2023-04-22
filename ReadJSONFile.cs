using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Updated_AddressBookSystem
{
   public class ReadJsonFile
    {
        public static string importPath = "C:\\Users\\Dhanashree\\source\\repos\\Updated_AddressBookSystem\\Exampe3.json";
        public static string exportPath = "C:\\Users\\Dhanshree\\source\\repos\\Updated_AddressBookSystem\\Exampe3.json";
        public static void SaveContactsToJson(List<Contact> contactList)
        {
            string jsonobj = JsonConvert.SerializeObject(contactList, Formatting.Indented);
            File.WriteAllText(importPath, jsonobj);
            Console.WriteLine($"Contacts saved to json file.");
        }
        public static void LoadContactsFromJson(List<Contact> contactList)
        {
            if (File.Exists(exportPath))
            {
                string jsonobj=  File.ReadAllText(exportPath);
                contactList = JsonConvert.DeserializeObject<List<Contact>>(jsonobj);
                Console.WriteLine("Contacts loaded from json file.");
            }
            else
            {
                Console.WriteLine("json file not found!");
            }
        }




        }
}
