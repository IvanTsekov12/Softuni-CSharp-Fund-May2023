namespace counterStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingEnergy = int.Parse(Console.ReadLine());

            int wonBattles = 0;

            string command = "";

            while ((command = Console.ReadLine()) != "End of battle")
            {
                int distanceToEnemy = int.Parse(command);
                if (startingEnergy - distanceToEnemy < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {startingEnergy} energy");
                    break;
                }
                wonBattles++;
                startingEnergy -= distanceToEnemy;

                if (wonBattles % 3 == 0)
                {
                    startingEnergy += wonBattles;
                }
            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {startingEnergy}");
            }
        }
    }
}