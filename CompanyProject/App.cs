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
            
           

            Company TheCompany = new Company("The Company");
            AddCustomers(TheCompany);
            AddEmployees(TheCompany);
            TheCompany.CountIncome();
            TheCompany.CountOutcome();
            TheCompany.CountTotalProfit();


            TheCompany.FinanceDescription();
            Console.WriteLine(" ");
            TheCompany.GetStatisticEmployees(TheCompany.AllEmployees, "all");
            TheCompany.GetStatisticCustomers(TheCompany.AllCustomers, "all");
            //TheCompany.GetStatisticEmployees(Company.AllItEmployees, "It");
            //TheCompany.GetStatisticEmployees(Company.AllMEmployees, "Marketing");
            //TheCompany.GetStatisticEmployees(Company.AllLawEmployees, "Law");
            Console.WriteLine(" ");
            SeniorDeveloper bb = new SeniorDeveloper("Bruno Bueno", "Male", 27);
            
            bb.GetInfo();
            Console.WriteLine(" ");
            bb.Promotion();
            Console.WriteLine(" ");
            bb.GetInfo();


        }

        public void AddCustomers(Company c)
        {
             Customer c1 = new Customer("James Franco", "Male", 40, new GoldPackage());
            c.fillCustomersLists(c1, new GoldPackage());
            Customer c2 = new Customer("Milys Clark", "Female", 30, new SilverPackage());
            c.fillCustomersLists(c2, new SilverPackage());
            Customer c3 = new Customer("Dave Sant Mel", "Male", 50, new GoldPackage());
            c.fillCustomersLists(c3, new GoldPackage());


        //    Customer c4 = new Customer("Julia Season", "Female", 22, new BronzePackage());
        //    Customer c5 = new Customer("Soni Max", "Female", 44, new SilverPackage());
        //    Customer c6 = new Customer("James Stall", "Male", 33, new SilverPackage());
       
        
        }

       public void AddEmployees(Company c)
        {
                    ProjectLeaderIT eit1 = new ProjectLeaderIT("Bruno Bueno", "Male", 27);
            c.fillEmployeesLists(eit1,"IT");
            
                    SeniorDeveloper eit2 = new SeniorDeveloper("Tarum Patel", "Male", 37);
            c.fillEmployeesLists(eit2, "IT");

            SeniorDeveloper eit3 = new SeniorDeveloper("Billy Jack", "Male", 40);
            c.fillEmployeesLists(eit3, "IT");

            //    SeniorDeveloper eit4 = new SeniorDeveloper("Jonny Lek", "Male", 47);
                JuniorDeveloper ei6 = new JuniorDeveloper("Bruno Bernardo", "Male", 22);
            c.fillEmployeesLists(ei6, "IT");

            JuniorDeveloper ei7 = new JuniorDeveloper("Jimmy Jinx", "Male", 25);
            c.fillEmployeesLists(ei7, "IT");

            //    JuniorDeveloper ei8 = new JuniorDeveloper("Sarah Kroff", "female", 22);
            //    JuniorDeveloper ei9 = new JuniorDeveloper("Lady Bug", "female", 24);

            //    Lawyer l1 = new Lawyer("Bronx Medy", "Male", 40);
            //    Lawyer l2 = new Lawyer("Frida Nordby", "Female", 29);
            //    Lawyer l3 = new Lawyer("Marina Bernardo", "Female", 32);

            //    HumanResource l4 = new HumanResource("Meg Miles", "Female", 42);
            //    HumanResource l5 = new HumanResource("Per Wix", "Male", 52);

            //    CorporateParalegal l6 = new CorporateParalegal("Thor Nelson", "Male", 50);


            //     ArtDirector m1 = new ArtDirector("Diogo Bueno" ,"Male", 29);
            //    ArtDirector m2 = new ArtDirector("Brigitte Ross", "Female", 39);

            //    BrandManager m3 = new BrandManager("Andre Cigar", "Male", 55);
            //    BrandManager m4 = new BrandManager("Simon Paris", "Female", 29);

            //    ProductionManager m5 = new ProductionManager("John Ter", "Male", 52);







        }
    }
}
