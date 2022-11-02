using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal abstract class PackageOffer
    {

        public string Pname { get; set; }

        public string Description { get; set; } 

        public double Price { get; protected set; }

        protected bool HasThisPackage { get; set; }

        public virtual void SetDescription()
        {

        }
        //public virtual void Upgrade(PackageOffer obj)
        //{
            
        //}



    }
}
