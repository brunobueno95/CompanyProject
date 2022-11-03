using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class CorporateParalegal : LawEmployees
    {
        public CorporateParalegal(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            JobPosition = "Corporate Paralegal";
            YearsOfExperience = 20;
            SalaryperHour = 355;
            WrkHoursPerDay = 8;
            DaysOfWrkPerWeek = 5;
            CalculateSalaryPerMonth();
        }

        protected override void Promotion()
        {
            base.Promotion();
            SalaryperHour += 50;
        }
    }
}
