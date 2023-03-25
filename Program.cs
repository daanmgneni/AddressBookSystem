
using AddressBookAssignment;
using System;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace AdressBookAssignment
{
    class AdressBookMainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Adress Book Program");
            AddPerson contact = new AddPerson();
            contact.details();
        }
    }
}