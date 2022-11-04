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
            
            Payment = yourPackage.Price;
           
        }

        
        public void UpgradePck(Company c, string pckName)
        {
            if(pckName == "Bronze")
            {
                YourPackage = new SilverPackage();
                c.BronzeCustomers.Remove(this);
                c.SilverCustomers.Add(this);
            }
            else if (pckName == "Silver")
            {
                YourPackage = new GoldPackage();
                c.SilverCustomers.Remove(this);
                c.GoldCustomers.Add(this);
            }

            else 
            {
                Console.WriteLine("This customer is already has a Gold Package, we currently dont have higher packages.");
            }
        }
    }
}
