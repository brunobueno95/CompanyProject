using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject
{
    internal class GoldPackage : PackageOffer
    {
        public GoldPackage()
        {
            this.Price = 150;
            this.HasThisPackage = true;
            this.Pname = "Gold";
            SetDescription();
        }






        public override void SetDescription()
        {
            Description = $"The {Pname} package offers you unlimited access of all our content for free, and it costs only {Price} per month!";


        }
    }
}
