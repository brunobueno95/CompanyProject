using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal  class Customer : Persons
    {
       

        public double Payment { get; protected set; }


        public PackageOffer YourPackage { get; set; }
        public Customer(string fullName, string gender, int age,PackageOffer yourPackage) : base(fullName, gender, age)
        {
            YourPackage = yourPackage;
            Company.AllCustomers.Add(this);
            Payment = yourPackage.Price;
            fillLists();
        }

        public void fillLists()
        {
            if (YourPackage.Pname == "Bronze")
            {

                Company.BronzeCustomers.Add(this);
                
            }
            else if (YourPackage.Pname == "Silver")
            {

                Company.SilverCustomers.Add(this);
              
            }
            else if (YourPackage.Pname == "Gold")
            {

                Company.GoldCustomers.Add(this);

            }


        }
        public void UpgradePck(string pckName)
        {
            if(pckName == "Bronze")
            {
                YourPackage = new SilverPackage();
                Company.BronzeCustomers.Remove(this);
                Company.SilverCustomers.Add(this);
            }
            else if (pckName == "Silver")
            {
                YourPackage = new GoldPackage();
                Company.SilverCustomers.Remove(this);
                Company.GoldCustomers.Add(this);
            }

            else 
            {
                Console.WriteLine("This customer is already has a Gold Package, we currently dont have higher packages.");
            }
        }
    }
}
