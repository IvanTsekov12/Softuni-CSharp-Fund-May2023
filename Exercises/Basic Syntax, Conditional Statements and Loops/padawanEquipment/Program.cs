using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace padawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabersTotal = lightsaberPrice * studentsCount;
            lightsabersTotal += Math.Ceiling(0.1 * studentsCount) * lightsaberPrice;
            double robesTotal = robesPrice * studentsCount;
            double beltsTotal = beltsPrice * studentsCount;
            double total = lightsabersTotal + robesTotal + beltsTotal;

            //total = Math.Ceiling((0.1 * studentsCount) * lightsaberPrice) + total;
            
            for (int i = 6; i <= studentsCount; i+= 6)
            {
                total -= beltsPrice;
            }
            

            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {((total - money)):f2}lv more.");
            }
        }
    }
}
