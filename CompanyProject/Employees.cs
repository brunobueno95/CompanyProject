using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal abstract class Employees : Persons
    {
        public List<int> AllIds = new List<int>();
        public int EmployeeID { get; private set; }
        public string JobDepartment { get; protected set; }
        public string JobPosition { get; protected set; }

        public int YearsOfExperience { get; protected set; }

        public double SalaryperMonth { get; protected set; }

        public double SalaryperHour { get; protected set; }

        public int WrkHoursPerDay { get; protected set; }

        public int DaysOfWrkPerWeek { get; protected set; }
        public Employees(string fullName, string gender, int age) : base(fullName, gender, age)
        {
            GenerateId();
            
            Company.AllEmployees.Add(this);
        }

        protected virtual void Promotion()
        {
            SalaryperHour = SalaryperHour * 1.3;
            WrkHoursPerDay = Convert.ToInt32(Convert.ToDouble(WrkHoursPerDay) * 1.3);
            DaysOfWrkPerWeek++;
            if(DaysOfWrkPerWeek >= 5 )
            {
                DaysOfWrkPerWeek = 5;
            }
            if (WrkHoursPerDay >= 8)
            {
                WrkHoursPerDay = 8;
            }

        }

        protected void GenerateId()
        {
            Random random = new Random();
            var checkR = random.Next(0,1000);
            if(!AllIds.Contains(checkR))
            {
                AllIds.Add(checkR);
                EmployeeID = checkR;
            }
            else
            {
               GenerateId();
            }
             
        }

        public void CalculateSalaryPerMonth()
        {
            SalaryperMonth = SalaryperHour * Convert.ToDouble(WrkHoursPerDay) * Convert.ToDouble(DaysOfWrkPerWeek) * 4;
        }

        public void GetInfo()
        {
            Console.WriteLine($"First Name: {FirstName}\n Last Name: {LastName} \n " +
                $"Gender : {Gender}\n Age:{Age}\n Job Department : {JobDepartment}\n" +
                $"Job Position : {JobPosition}\n Years of experience : {YearsOfExperience}\n" +
                $"Salary per Month : {SalaryperMonth}\n Salary per Hour: {SalaryperHour}\n" +
                $"Work hours per day : {WrkHoursPerDay}\n Days of work per week {DaysOfWrkPerWeek}");
        }

        //protected virtual void addEmployeeToList( List<Object> list)
        //{

        //}

        
    }
}
