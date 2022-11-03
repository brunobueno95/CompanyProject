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

        public static List<Customer> AllCustomers { get; protected set; } = new List<Customer>();
        public static List<Customer> BronzeCustomers { get; set; } = new List<Customer>();
        public static List<Customer> SilverCustomers { get; protected set; } = new List<Customer>();
        public static List<Customer> GoldCustomers { get; protected set; } = new List<Customer>();

        public static List<Employees> AllEmployees { get; protected set; } = new List<Employees>();
        public static List<Employees> AllItEmployees { get; protected set; } = new List<Employees>();
        public static List<NotYetACustomer> NotCustomersList { get; private set; } = new List<NotYetACustomer>();

        public static List<Employees> AllMEmployees { get; protected set; } = new List<Employees>();

        public static List<Employees> AllLawEmployees { get; protected set; } = new List<Employees>();


        public Company(string nameOfCompany)
        {
            NameOfCompany = nameOfCompany;
            CountIncome();
            CountOutcome();
            CountTotalProfit();


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
                
            var AmountofEmployees = Convert.ToDouble(listType.Count());
            //check age
            var EmployeesAge21to30 = listType.FindAll(e => e.Age >= 21 && e.Age <= 30);
            var AmountE22to30 = Convert.ToDouble(EmployeesAge21to30.Count());
           var x  = 100  * AmountE22to30 / AmountofEmployees;
            var PercentageE22to30 = x;

            var EmployeesAge31to40 = listType.FindAll(e => e.Age >= 31 && e.Age <= 40);
            var AmountE31to40 = Convert.ToDouble(EmployeesAge31to40.Count());
            var PercentageE31to40 = 100 * AmountE31to40 / AmountofEmployees ;

            var EmployeesAge41to50 = listType.FindAll(e => e.Age >= 41 && e.Age <= 50);
            var AmountE41to50 = Convert.ToDouble(EmployeesAge41to50.Count());
            var PercentageE41to50 =100 * AmountE41to50 / AmountofEmployees;

            var EmployeesAge51to65 = listType.FindAll(e => e.Age >= 51 && e.Age <= 65);
            var AmountE51to65 = Convert.ToDouble(EmployeesAge51to65.Count());
            var PercentageE51to65 =100 * AmountE51to65 / AmountofEmployees ;

            Console.WriteLine($"Analys about the employees ages from {department} department:");
            Console.WriteLine($"There are {AmountofEmployees} employees on this department\n ");
            Console.WriteLine($"* {AmountE22to30} -- {PercentageE22to30}% Of the employees are between 22 to 30 years.");
            Console.WriteLine($"* {PercentageE31to40}% Of the employees are between 31 to 40 years.");
            Console.WriteLine($"* {PercentageE41to50}% Of the employees are between 41 to 50 years.");
            Console.WriteLine($"* {PercentageE51to65}% Of the employees are between 51 to 65 years.");


            //check salary

            var EmployeesSalary3to10 = listType.FindAll(e => e.SalaryperMonth >= 3000 && e.Age <= 10000);
            var AmountES3to10 = Convert.ToDouble(EmployeesSalary3to10.Count());
            var PercentageES3to10 = 100 * AmountES3to10 / AmountofEmployees;

            var EmployeesSalary10to30 = listType.FindAll(e => e.Age >= 10001 && e.Age <= 30000);
            var AmountES10to30 = Convert.ToDouble(EmployeesSalary10to30.Count());
            var PercentageES10to30 = 100 * AmountES10to30 / AmountofEmployees;

            var EmployeesSalary30to60 = listType.FindAll(e => e.Age >= 3001 && e.Age <= 60000);
            var AmountES30to60 = Convert.ToDouble(EmployeesSalary30to60.Count());
            var PercentageES30to60 = 100 * AmountES30to60 / AmountofEmployees ;

            var EmployeesSalaryhiger60 = listType.FindAll(e => e.Age >60000);
            var AmountEShigher60 = Convert.ToDouble(EmployeesSalaryhiger60.Count());
            var PercentageEShigher60 = 100 * AmountEShigher60 / AmountofEmployees;

            Console.WriteLine($"Analys about the employees salary from {department} department:");
            Console.WriteLine(" ");
            Console.WriteLine($"* {AmountES3to10} -- {PercentageES3to10}% Of the employees have a monthly salary between 3.000$ to 10.000$ years.");
            Console.WriteLine($"* {PercentageES10to30}% Of the employees have a monthly salary between 10.000$ to 30.000$ years.");
            Console.WriteLine($"* {PercentageES30to60}% Of the employees have a monthly salary between 30.000$ to 60.000$ years.");
            Console.WriteLine($"* {PercentageEShigher60}% Of the employees have a monthly salary higher than 60.000$.");


        }
        public void FinanceDescription()
        {
            Console.WriteLine($"This month {NameOfCompany} had a total income of {Income}, and {Outcome} of expenses.The final profit was {TotalProfit}$");

        }



        public void GetStatisticCustomers(List<Employees> listType, string typeofC)
        {
            var AmountofCustomers = Convert.ToDouble(listType.Count());
            //check age
            var CustomersAge21to30 = listType.FindAll(c => c.Age >= 21 && c.Age <= 30);
            var AmountC22to30 = Convert.ToDouble(CustomersAge21to30.Count());
            var PercentageE22to30 = 100 * AmountC22to30 / AmountofCustomers ;

            var CustomersAge31to40 = listType.FindAll(c => c.Age >= 31 && c.Age <= 40);
            var AmountE3Cto40 = Convert.ToDouble(CustomersAge31to40.Count());
            var PercentageE31to40 = 100 * AmountE3Cto40 / AmountofCustomers ;

            var CustomersAge41to50 = listType.FindAll(e => e.Age >= 41 && e.Age <= 50);
            var AmountC41to50 = Convert.ToDouble(CustomersAge41to50.Count());
            var PercentageE41to50 = 100 * AmountC41to50 / AmountofCustomers;

            var CustomersAge51to65 = listType.FindAll(c => c.Age >= 51 && c.Age <= 65);
            var AmountC51to65 = Convert.ToDouble(CustomersAge51to65.Count());
            var PercentageC51to65 = 100 * AmountC51to65 / AmountofCustomers;

            Console.WriteLine($"Analys about the customers ages from {typeofC} package:");
            Console.WriteLine($"There are {AmountofCustomers} customers with the package{typeofC} \n");
            Console.WriteLine($"* {AmountC22to30} --- {PercentageE22to30}% Of the customers are between 22 to 30 years.");
            Console.WriteLine($"* {PercentageE31to40}% Of the customers are between 31 to 40 years.");
            Console.WriteLine($"* {PercentageE41to50}% Of the customers are between 41 to 50 years.");
            Console.WriteLine($"* {PercentageC51to65}% Of the customers are between 51 to 65 years.");

            //check gender

            var CustomersGender = listType.FindAll(c => c.Gender == "Male");
            var MaleCustomers = Convert.ToDouble(CustomersGender.Count());
            var PercentageMaleC = MaleCustomers / AmountofCustomers;

        }

       
    }
}
