using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal abstract class Persons
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public Persons(string fullName, string gender, int age)
        {

            FullName = fullName;
            Gender = gender;
            Age = age;

            GetFirstAndLastName();
        }

       


            public void GetFirstAndLastName()
            {


                var punctuation = FullName.Where(Char.IsPunctuation).Distinct().ToArray();
                var NameDivided = FullName.Split().Select(x => x.Trim(punctuation));
                Refactoring(NameDivided);
            }

        public void Refactoring(IEnumerable<string> list)
        {
            var array = new List<string>();

            foreach (var name in list)
            {

                array.Add(name);
            }
            for (int i = 0; i < array.Count; i++)
            {
                if (i == 0)
                {
                    FirstName = array[i];
                }
                if (i == array.Count - 1)
                {
                    LastName = array[i];
                }

            }
        }
    }

    } 


