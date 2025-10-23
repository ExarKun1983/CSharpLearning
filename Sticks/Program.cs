namespace Sticks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = Solution(10000000, 12345678);
        }

        public static int Solution(int a, int b)
        {
            if (a == b)
            {
                return a / 2;
            }

            int total = a + b;

            int divTotal = total / 4;
            if (divTotal == 0) {
                return 0;
                    }

            int counter = 0;
            while(true)
            {
                Console.WriteLine(++counter);
                int divA = a / divTotal;
                int divB = b / divTotal;

                if (divA + divB >= 4)
                {
                    Console.WriteLine(divTotal);
                    return divTotal;
                }
                else
                {
                    divTotal--;
                }                
            }
        }
    }
}
