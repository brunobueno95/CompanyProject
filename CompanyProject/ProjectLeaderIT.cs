using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class ProjectLeaderIT : ItEmployees
    {
        public ProjectLeaderIT(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            JobPosition = "Project Leader";
            YearsOfExperience = 15;
            SalaryperHour = 500;
            WrkHoursPerDay = 8;
            DaysOfWrkPerWeek = 6;
            AddCodeProficiency("JavaScript", "C#", "Python");
            AddCodeProficiency("Java", "SQL", ".Net");
            AddCodeProficiency("Azure");
            CalculateSalaryPerMonth();

        }

        protected override void Promotion()
        {
            base.Promotion();
            SalaryperHour += 50;
        }

    }
}
