using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class ArtDirector : MarketingEmployees
    {
        public ArtDirector(string fullName, string gender, int age) : base(fullName, gender, age)
        {

            JobPosition = "Art Director";
            YearsOfExperience = 8;
            SalaryperHour = 65;
            WrkHoursPerDay = 7;
            DaysOfWrkPerWeek = 5;
        }

        protected override void Promotion()
        {
            base.Promotion();
            SalaryperHour += 25;
        }
    }
}
