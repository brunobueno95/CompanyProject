using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class BrandManager : MarketingEmployees
    {
        public BrandManager(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            JobPosition = "Brand Manager";
            YearsOfExperience = 5;
            SalaryperHour = 55;
            WrkHoursPerDay = 6;
            DaysOfWrkPerWeek = 4;
            CalculateSalaryPerMonth();
        }

        protected override void Promotion()
        {
            base.Promotion();
            SalaryperHour += 10;
        }
    }
}
