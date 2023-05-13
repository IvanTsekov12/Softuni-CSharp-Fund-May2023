using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetsCount = 0;
            int miceCount = 0;
            int keyboardsCount = 0;
            int displaysCount = 0;
            int tempKeyboardCount = 0;

            for (int games = 1; games <= lostGames; games++)
            {
                if (games % 2 == 0)
                {
                    headsetsCount++;
                }
                if (games % 3 == 0)
                {
                    miceCount++;
                }
                if (games % 2 == 0 && games % 3 == 0)
                {
                    keyboardsCount++;
                    tempKeyboardCount++;
                }
                if (tempKeyboardCount % 2 == 0 && tempKeyboardCount > 0)
                {
                    tempKeyboardCount = 0;
                    displaysCount++;
                }
            }

            double total = (headsetPrice * headsetsCount) + (mousePrice * miceCount) + (keyboardsCount * keyboardPrice) + (displaysCount * displayPrice);

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
