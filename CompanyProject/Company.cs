using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class Company : ICompany
    {
        public string NameOfCompany { get; set; }
        public double Income { get; set; }

        public double Outcome { get; set; }

        public double TotalProfit { get; set; }

        public  List<Customer> AllCustomers { get; protected set; } = new List<Customer>();
        public  List<Customer> BronzeCustomers { get; set; } = new List<Customer>();
        public  List<Customer> SilverCustomers { get; protected set; } = new List<Customer>();
        public  List<Customer> GoldCustomers { get; protected set; } = new List<Customer>();

        public  List<Employees> AllEmployees { get; protected set; } = new List<Employees>();
        public  List<Employees> AllItEmployees { get; protected set; } = new List<Employees>();
        public  List<NotYetACustomer> NotCustomersList { get; private set; } = new List<NotYetACustomer>();

        public  List<Employees> AllMEmployees { get; protected set; } = new List<Employees>();

        public  List<Employees> AllLawEmployees { get; protected set; } = new List<Employees>();


        public Company(string nameOfCompany)
        {
            NameOfCompany = nameOfCompany;
            


        }

        public void CountIncome()
        {
            foreach(var customer in AllCustomers)
            {
                Income += customer.Payment;
            }
        }

        public void CountOutcome()
        {
            foreach(var employee in AllEmployees)
            {
                Outcome += employee.SalaryperMonth;
            }
        }

        public void CountTotalProfit()
        {
            TotalProfit = Income - Outcome;
        }

        public void GetStatisticEmployees(List<Employees> listType, string department)
        {
                
            var AmountofEmployees = listType.Count();
            //check age
            var EmployeesAge21to30 = listType.FindAll(e => e.Age >= 21 && e.Age <= 30);
            var AmountE22to30 = EmployeesAge21to30.Count();
           var x  = 100  * AmountE22to30 / AmountofEmployees;
            var PercentageE22to30 = x;

            var EmployeesAge31to40 = listType.FindAll(e => e.Age >= 31 && e.Age <= 40);
            var AmountE31to40 = EmployeesAge31to40.Count();
            var PercentageE31to40 = 100 * AmountE31to40 / AmountofEmployees ;

            var EmployeesAge41to50 = listType.FindAll(e => e.Age >= 41 && e.Age <= 50);
            var AmountE41to50 = EmployeesAge41to50.Count();
            var PercentageE41to50 =100 * AmountE41to50 / AmountofEmployees;

            var EmployeesAge51to65 = listType.FindAll(e => e.Age >= 51 && e.Age <= 65);
            var AmountE51to65 = EmployeesAge51to65.Count();
            var PercentageE51to65 =100 * AmountE51to65 / AmountofEmployees ;

            Console.WriteLine($"Analys about the employees ages from {department} department:");
            Console.WriteLine($"There are {AmountofEmployees} employees on this department\n ");
            Console.WriteLine($"* {AmountE22to30} -- {PercentageE22to30}% Of the employees are between 22 to 30 years.");
            Console.WriteLine($"* {PercentageE31to40}% Of the employees are between 31 to 40 years.");
            Console.WriteLine($"* {PercentageE41to50}% Of the employees are between 41 to 50 years.");
            Console.WriteLine($"* {PercentageE51to65}% Of the employees are between 51 to 65 years.\n");


            //check salary

            var EmployeesSalary3to5 = listType.FindAll(e => e.SalaryperMonth >= 3000 && e.SalaryperMonth <= 5000);
            var AmountES3to5 = EmployeesSalary3to5.Count();
            var PercentageES3to5 = 100 * AmountES3to5 / AmountofEmployees;

            var EmployeesSalary5to10 = listType.FindAll(e => (e.SalaryperMonth >= 5001) && (e.SalaryperMonth <= 10000));
            var AmountES5to10 = EmployeesSalary5to10.Count();
            var PercentageES5to10 = 100 * AmountES5to10 / AmountofEmployees;

            var EmployeesSalary10to20 = listType.FindAll(e => e.SalaryperMonth >= 10001 && e.SalaryperMonth <= 20000);
            var AmountES10to20 = EmployeesSalary10to20.Count();
            var PercentageES10to20 = 100 * AmountES10to20 / AmountofEmployees ;

            var EmployeesSalaryhiger20 = listType.FindAll(e => e.SalaryperMonth > 20000);
            var AmountEShigher20 = EmployeesSalaryhiger20.Count();
            var PercentageEShigher20 = 100 * AmountEShigher20 / AmountofEmployees;

            Console.WriteLine($"Analys about the employees salary from {department} department:");
            Console.WriteLine(" ");
            Console.WriteLine($"* {AmountES3to5} -- {PercentageES3to5}% Of the employees have a monthly salary between 3.000$ to 5.000$ years.");
            Console.WriteLine($"* {AmountES5to10} {PercentageES5to10}% Of the employees have a monthly salary between 5.000$ to 10.000$ years.");
            Console.WriteLine($"* {PercentageES10to20}% Of the employees have a monthly salary between 10.000$ to 20.000$ years.");
            Console.WriteLine($"* {PercentageEShigher20}% Of the employees have a monthly salary higher than 20.000$.\n");


        }
        public void FinanceDescription()
        {
            Console.WriteLine($"This month {NameOfCompany} had a total income of {Income}, and {Outcome} of expenses.The final profit was {TotalProfit}$");

        }



        public void GetStatisticCustomers(List<Customer> listType, string typeofC)
        {
            var AmountofCustomers =listType.Count();
            //check age
            var CustomersAge21to30 = listType.FindAll(c => c.Age >= 21 && c.Age <= 30);
            var AmountC22to30 = CustomersAge21to30.Count();
            var PercentageE22to30 = 100 * AmountC22to30 / AmountofCustomers ;

            var CustomersAge31to40 = listType.FindAll(c => c.Age >= 31 && c.Age <= 40);
            var AmountE3Cto40 = CustomersAge31to40.Count();
            var PercentageE31to40 = 100 * AmountE3Cto40 / AmountofCustomers ;

            var CustomersAge41to50 = listType.FindAll(e => e.Age >= 41 && e.Age <= 50);
            var AmountC41to50 = CustomersAge41to50.Count();
            var PercentageE41to50 = 100 * AmountC41to50 / AmountofCustomers;

            var CustomersAge51to65 = listType.FindAll(c => c.Age >= 51 && c.Age <= 65);
            var AmountC51to65 = CustomersAge51to65.Count();
            var PercentageC51to65 = 100 * AmountC51to65 / AmountofCustomers;

            Console.WriteLine($"Analys  {typeofC} customers  -  Ages ");
            if(typeofC == "all")
            {
            
            Console.WriteLine($"There are {AmountofCustomers} customers in total \n");
        }
            else { Console.WriteLine($"There are {AmountofCustomers} customers with the package{typeofC} \n"); }
            
            Console.WriteLine($"* {AmountC22to30} --- {PercentageE22to30}% Of the customers are between 22 to 30 years.");
            Console.WriteLine($"* {PercentageE31to40}% Of the customers are between 31 to 40 years.");
            Console.WriteLine($"* {PercentageE41to50}% Of the customers are between 41 to 50 years.");
            Console.WriteLine($"* {PercentageC51to65}% Of the customers are between 51 to 65 years.\n");

            //check gender

            var CustomersGender = listType.FindAll(c => c.Gender == "Male");
            var MaleCustomers = CustomersGender.Count();
            var PercentageMaleC = 100 * MaleCustomers / AmountofCustomers;
            Console.WriteLine($"* {PercentageMaleC}% Of the customers are male.\n");

        }

        public void fillCustomersLists(Customer c, PackageOffer cpkg)
        {
            AllCustomers.Add(c);

            if (cpkg.Pname == "Bronze")
            {

                BronzeCustomers.Add(c);

            }
            else if (cpkg.Pname == "Silver")
            {

                SilverCustomers.Add(c);

            }
            else if (cpkg.Pname == "Gold")
            {

                GoldCustomers.Add(c);

            }


        }

        public void fillEmployeesLists(Employees e, string eJobDepartment)
        {
            AllEmployees.Add(e);

            if (eJobDepartment == "Law")
            {

                AllLawEmployees.Add(e);

            }
            else if (eJobDepartment == "IT")
            {

                AllItEmployees.Add(e);

            }
            else if (eJobDepartment == "Marketing")
            {

                AllMEmployees.Add(e);

            }


        }


    }
}
