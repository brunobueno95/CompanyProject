﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class LawEmployees:Employees
    {
        //protected List<string> LawProficiency = new List<string>();
        public List<LawEmployees> AllLawEmployees { get; protected set; } = new List<LawEmployees>();
        public LawEmployees(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            JobDepartment = "Law";
        }
        protected void addLawEmployeeToList()
        {
            AllLawEmployees.Add(this);

        }
    }
}
