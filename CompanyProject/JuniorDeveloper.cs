using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class JuniorDeveloper :ItEmployees
    {
        public JuniorDeveloper(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            JobPosition = "Junior Developer";
            YearsOfExperience = 2;
            SalaryperHour = 35;
            WrkHoursPerDay = 6;
            DaysOfWrkPerWeek = 4;
            AddCodeProficiency("JavaScript", "C#");
            CalculateSalaryPerMonth();
        }

        public override void Promotion()
        {
            base.Promotion();
            SalaryperHour += 10;
        }
    }
}
