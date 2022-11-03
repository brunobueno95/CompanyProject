using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class SeniorDeveloper : ItEmployees
    {
        public SeniorDeveloper(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            JobPosition = "Senior Developer";
            YearsOfExperience = 7;
            SalaryperHour = 85;
            WrkHoursPerDay = 7;
            DaysOfWrkPerWeek = 5;
            AddCodeProficiency("JavaScript", "C#","Python");
            AddCodeProficiency("Java", "SQL", ".Net");
            CalculateSalaryPerMonth();
        }

        public override void Promotion()
        {
            base.Promotion();
            SalaryperHour += 50;
        }

    }
}
