using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Army : Branches
    {
        public void ARLife()
        {
            this.TranspoSound = "' *sits on couch*";
            ARTranspo = "Let's just let the Marines go" + TranspoSound;
            ARWarCry = "HOOAH";
        }
        public override void Restroom()
        {
            Console.WriteLine("and they call their restroom the latrine");
        }
    }
}
