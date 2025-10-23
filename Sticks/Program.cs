namespace Sticks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = Solution(10, 21);
            Console.WriteLine(a);
        } 

        public static int Solution(int a, int b)
        {
            if (a <= 0 || b <= 0)
                return 0;

            if (a == b)
                return a / 2;

            int left = 1;
            Console.WriteLine("Left:"+left);
            int right = Math.Max(a, b);
            Console.WriteLine("Right:" + right);
            int result = 0;

            int counter = 0;
            while (left <= right)
            {
                Console.WriteLine("Loop no:" + ++counter);
                int mid = (right + left) / 2;
                Console.WriteLine("mid:" + mid);

                
                int divA = a / mid;
                Console.WriteLine("divA:" + divA);
                int divB = b / mid;
                Console.WriteLine("divB:" + divB);

                if (divA + divB >= 4)
                {
                    Console.WriteLine("Sum >= 4");
                    result = mid;
                    Console.WriteLine("Result:"+ mid);
                    left = mid + 1;
                    Console.WriteLine("Left:" + left);
                    Console.WriteLine("Right:" + right);
                }
                else
                {
                    Console.WriteLine("Sum < 4");
                    right = mid - 1;
                    Console.WriteLine("Left:" + left);
                    Console.WriteLine("Right:" + right);
                }

                Console.WriteLine("------------------------------------------------------");
            }
            return result;
        }
    }
}
