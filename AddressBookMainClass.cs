using Updated_AddressBookSystem;

namespace Update_AddressBookSystem
{
    class AddressBookMainClass
    {

        Dictionary<string, List<Contact>> AddressBookDic = new Dictionary<string, List<Contact>>();
        public void AddDetails()
        {
            List<Contact> con = new List<Contact>();
            Contact newContact = new Contact();


            Console.WriteLine("Enter First Name: ");
            newContact.firstName = Console.ReadLine();
            //Check for no duplicate Entry
            if (AddressBookDic.ContainsKey(newContact.firstName))
            {
                Console.WriteLine("Duplicate Entries are not possible");
                return;
            }
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

            con.Add(newContact);
            AddressBookDic.Add(newContact.firstName, con);
        }

        public void SearchPersonInCityOrState()
        {
            string cityOrStateName = Console.ReadLine();

            var cityResult = AddressBookDic.Values.SelectMany(x => x.Where(x => x.city.ToLower().Equals(cityOrStateName)));
            var stateResult = AddressBookDic.Values.SelectMany(x => x.Where(x => x.state.ToLower().Equals(cityOrStateName)));

            int cityCount = cityResult.Count();
            int stateCount = stateResult.Count();

            if (cityCount == 0 && stateCount == 0)
            {
                Console.WriteLine($"No Person found in {cityOrStateName}");
            }
            else
            {
                Console.WriteLine($"Persons found in {cityOrStateName}");
                Console.WriteLine($"Count by City: {cityCount}");
                Console.WriteLine($"Count by State: {stateCount}");
               
            }
        }


        public void DisplayContact()
        {
            foreach (var key in AddressBookDic.Keys)
            {
                Console.WriteLine($"FirstNmae is {key}");
                Console.WriteLine("################################"); 

                Console.WriteLine("The Details you stored in Address Book:");

                List<Contact> con = AddressBookDic[key];
                foreach (var change in con)
                {

                    Console.WriteLine(change.ToString());
                }

            }
        }
        public static void Main(string[] args)
        {
            bool flag = true;
            Console.WriteLine("!!!!!!Welcome to Updated Adress Book Program!!!!!!");
            Console.WriteLine(" ");
            AddressBookMainClass person = new AddressBookMainClass();

            while (flag == true)
            {
               
                Console.WriteLine("Do you want to add new contact YES(1) or NO(0)");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            //FOR ADD DETAILS
                            Console.WriteLine("Please add new contact details: ");
                            person.AddDetails();
                            person.DisplayContact();
                            flag = true;
                            break;

                        }
                    case 0:
                        { //FOR SEARCH OR EXIT
                            Console.WriteLine("Do you want to search Person in a City or State YES(1) or NO(0)");
                            int option1 = int.Parse(Console.ReadLine());

                            switch (option1)
                            {
                                case 1:
                                    {
                                        //FOR SEARCH 
                                        Console.WriteLine("Enter 1 to search by City, 2 to search by State: ");
                                        int searchOption = int.Parse(Console.ReadLine());
                                        if (searchOption == 1)
                                        {
                                            Console.WriteLine("Enter City  name to search Person: ");
                                            person.SearchPersonInCityOrState();
                                        }
                                        else if (searchOption == 2)
                                        {
                                            Console.WriteLine("Enter  State name to search Person: ");
                                            person.SearchPersonInCityOrState();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid option selected");
                                        }
                                        break;

                                    }
                                case 0:
                                    {
                                        //FOR EXIT
                                        Console.WriteLine("press any key for exit:");
                                        flag = false;
                                        break;
                                    }

                                default:
                                    Console.WriteLine("Invalid option selected");
                                    break;
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid option selected");
                        break;
                }
            }

        }
    }
}
