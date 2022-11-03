using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class NotYetACustomer : Persons
    {
      
        public PackageOffer YourPackage { get; set; }
        public NotYetACustomer(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            Company.NotCustomersList.Add(this);
        }

        public void BuyAPackage(PackageOffer obj)
        {
            YourPackage = obj;
            Company.NotCustomersList.Remove(this);

            if (YourPackage.Pname == "Bronze")
            {
                Customer newCustomer = new Customer(FullName,Gender,Age,new BronzePackage());
                

            }
            else if (YourPackage.Pname == "Silver")
            {
                Customer newCustomer = new Customer(FullName, Gender, Age, new SilverPackage());

              

            }
            else if (YourPackage.Pname == "Gold")
            {
                Customer newCustomer = new Customer(FullName, Gender, Age, new GoldPackage());
            

            }
        }
    }
}
