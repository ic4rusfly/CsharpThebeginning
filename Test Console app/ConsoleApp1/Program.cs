using System;

namespace xx
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;

            while (x++ < 5)

            {
                Console.Write(x);

                if (x % 2 == 0)
                    Console.Write(x);
                    x += 2;

            }

        }
    }
}
