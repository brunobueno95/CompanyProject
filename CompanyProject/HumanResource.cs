using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class HumanResource : LawEmployees
    {
        public HumanResource(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            JobPosition = "Hman Resource";
            YearsOfExperience = 10;
            SalaryperHour = 155;
            WrkHoursPerDay = 8;
            DaysOfWrkPerWeek = 5;
            CalculateSalaryPerMonth();
        }

        protected override void Promotion()
        {
            base.Promotion();
            SalaryperHour += 40;
        }
    }
}
