namespace binaryDigitsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = int.Parse(Console.ReadLine());
            int count = 0; ;

            while (number > 0)
            {
                int remainder = number % 2;
                if (remainder == digit)
                {
                    count++;
                }

                number /= 2;
            }

            Console.WriteLine(count);
        }
    }
}