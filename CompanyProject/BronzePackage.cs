using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class BronzePackage : PackageOffer
    {
        public BronzePackage()
        {
            this.Price = 100;
            this.HasThisPackage = true;
            this.Pname = "Bronze";
            SetDescription();
           


        }

        public override void SetDescription()
        {
          Description =  $"The {Pname} package offers you 25% of access to all our content for free, and it costs only {Price} per month!";
           
            
        }

        //public override void Upgrade(PackageOffer obj)
        //{
        // obj = new BronzePackage();
        //}
    }
}
