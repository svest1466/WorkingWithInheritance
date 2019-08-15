using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Airforce : Branches
    {
        
        public void AFLife()
        {
            AFTranspo = "Let's take a plane!" + TranspoSound;               
            AFWarCry = "Hell Yeah!";
        }
        public override void Restroom()
        {
            Console.WriteLine("and they call their restroom the powder room");
        }

    }
}
