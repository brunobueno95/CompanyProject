using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class ProductionManager : MarketingEmployees
    {
        public ProductionManager(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            JobPosition = "Art Director";
            YearsOfExperience = 8;
            SalaryperHour = 100;
            WrkHoursPerDay = 8;
            DaysOfWrkPerWeek = 5;
        }
        public override void Promotion()
        {
            base.Promotion();
            SalaryperHour += 35;
        }
    }
}
