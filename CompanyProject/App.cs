using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class App
    {

       public App()
        {
            RunApp();
        }

        public void RunApp()
        {
            AddCustomers();
            AddEmployees();
            Company TheCompany = new Company("The Company");
            //TheCompany.FinanceDescription();
            //Console.WriteLine(" ");
            //TheCompany.GetStatisticEmployees(Company.AllEmployees, "all");
            //TheCompany.GetStatisticEmployees(Company.AllItEmployees, "It");
            //TheCompany.GetStatisticEmployees(Company.AllMEmployees, "Marketing");
            //TheCompany.GetStatisticEmployees(Company.AllLawEmployees, "Law");

            SeniorDeveloper bb = new SeniorDeveloper("Bruno Bueno", "Male", 27);
            
            bb.GetInfo();
            bb.Promotion();
            bb.GetInfo();


        }

        public void AddCustomers()
        {
            Customer c1 = new Customer("James Franco", "Male", 40, new GoldPackage());
            Customer c2 = new Customer("Milys Clark", "Female", 30, new SilverPackage());
            Customer c3 = new Customer("Dave Sant Mel", "Male", 50, new GoldPackage());
            Customer c4 = new Customer("Julia Season", "Female", 22, new BronzePackage());
            Customer c5 = new Customer("Soni Max", "Female", 44, new SilverPackage());
            Customer c6 = new Customer("James Stall", "Male", 33, new SilverPackage());
            Customer c7 = new Customer("Rex Pack", "Male", 64, new GoldPackage());
            Customer c8 = new Customer("James Franco", "Male", 44, new GoldPackage());
            Customer c9 = new Customer("James Franco", "Male", 30, new BronzePackage());
            Customer c10 = new Customer("James Franco", "Male", 50, new BronzePackage());
            Customer c11 = new Customer("James Franco", "Male", 23, new BronzePackage());
            Customer c12 = new Customer("James Franco", "Male", 26, new BronzePackage());
            Customer c13 = new Customer("James Franco", "Male", 34, new GoldPackage());
            Customer c14 = new Customer("James Franco", "Male", 36, new BronzePackage());
            Customer c15 = new Customer("James Franco", "Male", 48, new GoldPackage());
            Customer c16 = new Customer("James Franco", "Male", 57, new GoldPackage());
            Customer c17 = new Customer("James Franco", "Male", 44, new SilverPackage());
            Customer c18 = new Customer("James Franco", "Male", 26, new BronzePackage());
            Customer c19 = new Customer("James Franco", "Male", 29, new BronzePackage());
            Customer c20 = new Customer("James Franco", "Male", 32, new BronzePackage());
            Customer c22 = new Customer("James Franco", "Male", 48, new SilverPackage());
            Customer c23 = new Customer("James Franco", "Male", 54, new SilverPackage());
            Customer c24 = new Customer("James Franco", "Male", 65, new GoldPackage());


            Customer c25 = new Customer("James Franco", "Male", 63, new GoldPackage());
            Customer c26 = new Customer("James Franco", "Male", 58, new GoldPackage());
        }

        public void AddEmployees()
        {
            ProjectLeaderIT eit1 = new ProjectLeaderIT("Bruno Bueno", "Male", 27);
            SeniorDeveloper eit2 = new SeniorDeveloper("Tarum Patel", "Male", 37);
            SeniorDeveloper eit3 = new SeniorDeveloper("Billy Jack", "Male", 40);
            SeniorDeveloper eit4 = new SeniorDeveloper("Jonny Lek", "Male", 47);
            JuniorDeveloper ei6 = new JuniorDeveloper("Bruno Bernardo", "Male", 22);
            JuniorDeveloper ei7 = new JuniorDeveloper("Jimmy Jinx", "Male", 25);
            JuniorDeveloper ei8 = new JuniorDeveloper("Sarah Kroff", "female", 22);
            JuniorDeveloper ei9 = new JuniorDeveloper("Lady Bug", "female", 24);

            Lawyer l1 = new Lawyer("Bronx Medy", "Male", 40);
            Lawyer l2 = new Lawyer("Frida Nordby", "Female", 29);
            Lawyer l3 = new Lawyer("Marina Bernardo", "Female", 32);

            HumanResource l4 = new HumanResource("Meg Miles", "Female", 42);
            HumanResource l5 = new HumanResource("Per Wix", "Male", 52);

            CorporateParalegal l6 = new CorporateParalegal("Thor Nelson", "Male", 50);

           
             ArtDirector m1 = new ArtDirector("Diogo Bueno" ,"Male", 29);
            ArtDirector m2 = new ArtDirector("Brigitte Ross", "Female", 39);

            BrandManager m3 = new BrandManager("Andre Cigar", "Male", 55);
            BrandManager m4 = new BrandManager("Simon Paris", "Female", 29);

            ProductionManager m5 = new ProductionManager("John Ter", "Male", 52);







        }
    }
}
