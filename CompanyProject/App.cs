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
            Company c2 = new Company("C2");
            Company TheCompany = new Company("The Company");
            c2.FinanceDescription();
            TheCompany.FinanceDescription();
            //Console.WriteLine(" ");
            //TheCompany.GetStatisticEmployees(Company.AllEmployees, "all");
            //TheCompany.GetStatisticEmployees(Company.AllItEmployees, "It");
            //TheCompany.GetStatisticEmployees(Company.AllMEmployees, "Marketing");
            //TheCompany.GetStatisticEmployees(Company.AllLawEmployees, "Law");

            //SeniorDeveloper bb = new SeniorDeveloper("Bruno Bueno", "Male", 27);
            
            //bb.GetInfo();
            //bb.Promotion();
            //bb.GetInfo();


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
            Customer c1wewew = new Customer("James Franco", "Male", 40, new GoldPackage());
            Customer c2e = new Customer("Milys Clark", "Female", 30, new SilverPackage());
            Customer c3w = new Customer("Dave Sant Mel", "Male", 50, new GoldPackage());
            Customer c4a = new Customer("Julia Season", "Female", 22, new BronzePackage());
            Customer c5f = new Customer("Soni Max", "Female", 44, new SilverPackage());
            Customer c6g = new Customer("James Stall", "Male", 33, new SilverPackage());
            Customer c7c = new Customer("Rex Pack", "Male", 64, new GoldPackage());
            Customer c8v = new Customer("James Franco", "Male", 44, new GoldPackage());
            Customer c9d = new Customer("James Franco", "Male", 30, new BronzePackage());
            Customer c10q = new Customer("James Franco", "Male", 50, new BronzePackage());
            Customer c11a = new Customer("James Franco", "Male", 23, new BronzePackage());
            Customer c12c = new Customer("James Franco", "Male", 26, new BronzePackage());
            Customer c13x = new Customer("James Franco", "Male", 34, new GoldPackage());
            Customer c14c = new Customer("James Franco", "Male", 36, new BronzePackage());
            Customer c15x= new Customer("James Franco", "Male", 48, new GoldPackage());
            Customer c16x = new Customer("James Franco", "Male", 57, new GoldPackage());
            Customer c17x = new Customer("James Franco", "Male", 44, new SilverPackage());
            Customer c18x = new Customer("James Franco", "Male", 26, new BronzePackage());
            Customer c19x = new Customer("James Franco", "Male", 29, new BronzePackage());
            Customer c20x = new Customer("James Franco", "Male", 32, new BronzePackage());
            Customer c22c = new Customer("James Franco", "Male", 48, new SilverPackage());
            Customer c23e = new Customer("James Franco", "Male", 54, new SilverPackage());
            Customer c24rr = new Customer("James Franco", "Male", 65, new GoldPackage());
            Customer c1re = new Customer("James Franco", "Male", 40, new GoldPackage());
            Customer c2te = new Customer("Milys Clark", "Female", 30, new SilverPackage());
            Customer c3dfg = new Customer("Dave Sant Mel", "Male", 50, new GoldPackage());
            Customer c4gdfg = new Customer("Julia Season", "Female", 22, new BronzePackage());
            Customer c5dfgf = new Customer("Soni Max", "Female", 44, new SilverPackage());
            Customer c6fg = new Customer("James Stall", "Male", 33, new SilverPackage());
            Customer c7ere = new Customer("Rex Pack", "Male", 64, new GoldPackage());
            Customer c8eewew = new Customer("James Franco", "Male", 44, new GoldPackage());
            Customer c9rwere = new Customer("James Franco", "Male", 30, new BronzePackage());
            Customer c10rrr = new Customer("James Franco", "Male", 50, new BronzePackage());
            Customer c11rrew = new Customer("James Franco", "Male", 23, new BronzePackage());
            Customer c12eee = new Customer("James Franco", "Male", 26, new BronzePackage());
            Customer c13ere = new Customer("James Franco", "Male", 34, new GoldPackage());
            Customer c14ee = new Customer("James Franco", "Male", 36, new BronzePackage());
            Customer c15rer = new Customer("James Franco", "Male", 48, new GoldPackage());
            Customer c16eee = new Customer("James Franco", "Male", 57, new GoldPackage());
            Customer c17rrr = new Customer("James Franco", "Male", 44, new SilverPackage());
            Customer c18ew = new Customer("James Franco", "Male", 26, new BronzePackage());
            Customer c19re = new Customer("James Franco", "Male", 29, new BronzePackage());
            Customer c20er = new Customer("James Franco", "Male", 32, new BronzePackage());
            Customer c22ee = new Customer("James Franco", "Male", 48, new SilverPackage());
            Customer c23rr = new Customer("James Franco", "Male", 54, new SilverPackage());
            Customer c24rer = new Customer("James Franco", "Male", 65, new GoldPackage());
            Customer c1ee = new Customer("James Franco", "Male", 40, new GoldPackage());
            Customer c2weww = new Customer("Milys Clark", "Female", 30, new SilverPackage());
            Customer c3644= new Customer("Dave Sant Mel", "Male", 50, new GoldPackage());
            Customer c454 = new Customer("Julia Season", "Female", 22, new BronzePackage());
            Customer c5345 = new Customer("Soni Max", "Female", 44, new SilverPackage());
            Customer c6dvs = new Customer("James Stall", "Male", 33, new SilverPackage());
            Customer c7422 = new Customer("Rex Pack", "Male", 64, new GoldPackage());
            Customer c854 = new Customer("James Franco", "Male", 44, new GoldPackage());
            Customer c9542 = new Customer("James Franco", "Male", 30, new BronzePackage());
            Customer c1035 = new Customer("James Franco", "Male", 50, new BronzePackage());
            Customer c1135 = new Customer("James Franco", "Male", 23, new BronzePackage());
            Customer c1252 = new Customer("James Franco", "Male", 26, new BronzePackage());
            Customer c13222 = new Customer("James Franco", "Male", 34, new GoldPackage());
            Customer c1433 = new Customer("James Franco", "Male", 36, new BronzePackage());
            Customer c15df = new Customer("James Franco", "Male", 48, new GoldPackage());
            Customer c1643 = new Customer("James Franco", "Male", 57, new GoldPackage());
            Customer c17gfg = new Customer("James Franco", "Male", 44, new SilverPackage());
            Customer c1843 = new Customer("James Franco", "Male", 26, new BronzePackage());
            Customer c1944 = new Customer("James Franco", "Male", 29, new BronzePackage());
            Customer c20fgf = new Customer("James Franco", "Male", 32, new BronzePackage());
            Customer c2255 = new Customer("James Franco", "Male", 48, new SilverPackage());
            Customer c23gg = new Customer("James Franco", "Male", 54, new SilverPackage());
            Customer c24gfg = new Customer("James Franco", "Male", 65, new GoldPackage());
            Customer c1ss = new Customer("James Franco", "Male", 40, new GoldPackage());
            Customer c2sss= new Customer("Milys Clark", "Female", 30, new SilverPackage());
            Customer c33232 = new Customer("Dave Sant Mel", "Male", 50, new GoldPackage());
            Customer c443 = new Customer("Julia Season", "Female", 22, new BronzePackage());
            Customer c5443 = new Customer("Soni Max", "Female", 44, new SilverPackage());
            Customer c643 = new Customer("James Stall", "Male", 33, new SilverPackage());
            Customer c743 = new Customer("Rex Pack", "Male", 64, new GoldPackage());
            Customer c8433 = new Customer("James Franco", "Male", 44, new GoldPackage());
            Customer c9343 = new Customer("James Franco", "Male", 30, new BronzePackage());
            Customer c104 = new Customer("James Franco", "Male", 50, new BronzePackage());
            Customer c1143 = new Customer("James Franco", "Male", 23, new BronzePackage());
            Customer c1243 = new Customer("James Franco", "Male", 26, new BronzePackage());
            Customer c1344 = new Customer("James Franco", "Male", 34, new GoldPackage());
            Customer c14333 = new Customer("James Franco", "Male", 36, new BronzePackage());
            Customer c15433 = new Customer("James Franco", "Male", 48, new GoldPackage());
            Customer c16434 = new Customer("James Franco", "Male", 57, new GoldPackage());
            Customer c17232 = new Customer("James Franco", "Male", 44, new SilverPackage());
            Customer c18332 = new Customer("James Franco", "Male", 26, new BronzePackage());
            Customer c19df = new Customer("James Franco", "Male", 29, new BronzePackage());
            Customer c20aaa = new Customer("James Franco", "Male", 32, new BronzePackage());
            Customer c22wew = new Customer("James Franco", "Male", 48, new SilverPackage());
            Customer c232323 = new Customer("James Franco", "Male", 54, new SilverPackage());
            Customer c24232 = new Customer("James Franco", "Male", 65, new GoldPackage());


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
