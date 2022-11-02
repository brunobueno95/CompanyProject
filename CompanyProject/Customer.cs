using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class Customer : Persons
    {   
        
        public Customer(string fullName, string gender, int age) : base(fullName, gender, age)
        {
        }
    }
}
