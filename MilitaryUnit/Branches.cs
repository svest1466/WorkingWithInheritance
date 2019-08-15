using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Branches : Transportation
    {
        public string AFWarCry;
        public string NAWarCry;
        public string MAWarCry;
        public string ARWarCry;
        
        public virtual void Restroom()
        {
            Console.WriteLine("and they call their restroom the Head");
        }
        

       
    }
}
