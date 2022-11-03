using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class Lawyer : LawEmployees
    {
        public Lawyer(string fullName, string gender, int age) : base(fullName, gender, age)
        {

            JobPosition = "Lawyer";
            YearsOfExperience = 10;
            SalaryperHour = 165;
            WrkHoursPerDay = 8;
            DaysOfWrkPerWeek = 5;
            CalculateSalaryPerMonth();
        }

        public override void Promotion()
        {
            base.Promotion();
            SalaryperHour += 40;
        }
    }
}
