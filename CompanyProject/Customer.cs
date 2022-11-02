using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal  class Customer : Persons
    {
        public static List<Customer> AllCustomers { get; protected set; } = new List<Customer>();
        public static List<Customer> BronzeCustomers { get;  set; } = new List<Customer>();
        public static List<Customer> SilverCustomers { get; protected set; } = new List<Customer>();
        public static  List<Customer> GoldCustomers { get; protected set; } = new List<Customer>();

        private double Payment { get; set; }


        public PackageOffer YourPackage { get; set; }
        public Customer(string fullName, string gender, int age,PackageOffer yourPackage) : base(fullName, gender, age)
        {
            YourPackage = yourPackage;
            AllCustomers.Add(this);
            Payment = yourPackage.Price;
            fillLists();
        }

        public void fillLists()
        {
            if (YourPackage.Pname == "Bronze")
            {
               
                BronzeCustomers.Add(this);
                
            }
            else if (YourPackage.Pname == "Silver")
            {
                
                SilverCustomers.Add(this);
              
            }
            else if (YourPackage.Pname == "Gold")
            {

                GoldCustomers.Add(this);

            }


        }
        public void UpgradePck(string pckName)
        {
            if(pckName == "Bronze")
            {
                YourPackage = new SilverPackage();
                BronzeCustomers.Remove(this);
                SilverCustomers.Add(this);
            }
            else if (pckName == "Silver")
            {
                YourPackage = new GoldPackage();
                SilverCustomers.Remove(this);
                GoldCustomers.Add(this);
            }

            else 
            {
                Console.WriteLine("This customer is already has a Gold Package, we currently dont have higher packages.");
            }
        }
    }
}
