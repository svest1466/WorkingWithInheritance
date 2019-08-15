using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Navy : Branches
    {
        public void NALife()
        {
            this.TranspoSound = "' *swoosh*";
            NATranspo = "Let's take a boat!";
            NAWarCry = "HOOYAH";
        }
        public override void Restroom()
        {
            base.Restroom();
        }
    }
}
