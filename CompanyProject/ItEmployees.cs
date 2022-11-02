using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal abstract class ItEmployees : Employees
    {

        protected List<string> CodeProficiency = new List<string>();
        protected List<ItEmployees> AllItEmployees = new List<ItEmployees>();
        public ItEmployees(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            JobDepartment = "IT";
            AllItEmployees.Add(this);

        }

        public void AddCodeProficiency(string l1, string l2, string l3)
        {
            CodeProficiency.Add(l1);
            CodeProficiency.Add(l2);
            CodeProficiency.Add(l3);
        }

        public void AddCodeProficiency(string l1, string l2)
        {
            CodeProficiency.Add(l1);
            CodeProficiency.Add(l2);
           
        }

        public void AddCodeProficiency(string l1)
        {
            CodeProficiency.Add(l1);
            
        }

        protected  void addITEmployeeToList()
        {
            AllItEmployees.Add(this);
        }

    }
}
