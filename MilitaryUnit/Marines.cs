using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Marines : Branches
    {
      public void MALife()
        {
            this.TranspoSound = "' *Marines' grunting*";
            MAWarCry = "OORAH";
            MATranspo = "Lets hike!'";
        }
        public override void Restroom()
        {
            base.Restroom();
        }
    }
}
