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
            
        }

        public void BuyAPackage(Company company, PackageOffer obj)
        {
            YourPackage = obj;
            company.NotCustomersList.Remove(this);

            if (YourPackage.Pname == "Bronze")
            {
                Customer newCustomer = new Customer(FullName,Gender,Age,new BronzePackage());
                company.AllCustomers.Add(newCustomer);
                

            }
            else if (YourPackage.Pname == "Silver")
            {
                Customer newCustomer = new Customer(FullName, Gender, Age, new SilverPackage());
                company.AllCustomers.Add(newCustomer);



            }
            else if (YourPackage.Pname == "Gold")
            {
                Customer newCustomer = new Customer(FullName, Gender, Age, new GoldPackage());
                company.AllCustomers.Add(newCustomer);


            }
        }
    }
}
