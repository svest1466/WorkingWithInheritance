using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
       
        static void Main(string[] args)
        {

            
            Airforce AF = new Airforce();
            AF.AFLife();
            
            Navy NA = new Navy();
            NA.NALife();
           
            Marines MA = new Marines();
            MA.MALife();
           
            Army AR = new Army();
            AR.ARLife();
            


            Console.WriteLine($"The Air Force's way of getting around is '{AF.AFTranspo}, their WarCry is '{AF.AFWarCry}'");
            AF.Restroom();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"The Army's way of getting around is '{AR.ARTranspo}, their WarCry is '{AR.ARWarCry}'");
            AR.Restroom();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"The Navy's way of getting around is '{NA.NATranspo}, their WarCry is '{NA.NAWarCry}'");
            NA.Restroom();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"The Marine's way of getting around is '{MA.MATranspo}, their WarCry is '{MA.MAWarCry}'");
            MA.Restroom();
            Console.ReadLine();
            Console.Clear();





        }
        
    }
}
