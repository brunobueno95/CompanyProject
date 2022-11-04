using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class MarketingEmployees : Employees
    {
        protected List<string> DesignProficiency = new List<string>();
        

        public MarketingEmployees(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            JobDepartment = "Marketing";
            
        }

      
            
        

        public void AddDesignProficiency(string l1, string l2, string l3)
        {
            DesignProficiency.Add(l1);
            DesignProficiency.Add(l2);
            DesignProficiency.Add(l3);
        }

        public void AddDesignProficiency(string l1, string l2)
        {
            DesignProficiency.Add(l1);
            DesignProficiency.Add(l2);

        }

        public void AddDesignProficiency(string l1)
        {
            DesignProficiency.Add(l1);

        }


    }
}
