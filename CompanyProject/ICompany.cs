using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal interface ICompany
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
        public static List<ItEmployees> AllItEmployees { get; protected set; } = new List<ItEmployees>();
        public static List<NotYetACustomer> NotCustomersList { get; private set; } = new List<NotYetACustomer>();

        public static List<MarketingEmployees> AllMEmployees { get; protected set; } = new List<MarketingEmployees>();

        public static List<LawEmployees> AllLawEmployees { get; protected set; } = new List<LawEmployees>();

        public void CountIncome();

        public void CountOutcome();

        public void CountTotalProfit();

        public void GetStatisticEmployees(List<Employees> listType, string department);

        

        public void GetStatisticCustomers(List<Customer> listType, string department);

        public void FinanceDescription();
        

    










    }
}
