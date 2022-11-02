using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class SilverPackage : PackageOffer
    {
        public SilverPackage()
        {

            this.Price = 150;
            this.HasThisPackage = true;
            this.Pname = "Silver";
            SetDescription();


        }

        public override void SetDescription()
        {
            Description = $"The {Pname} package offers you 50% of access to all our content for free, and it costs only {Price} per month!";


        }
    }
}
