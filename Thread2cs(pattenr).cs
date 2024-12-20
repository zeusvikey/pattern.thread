using System;
using System.Threading;

namespace oopsProject1
{
    internal class Thread2cs
    {
        // Non-Parameterized Thread
        //static void NonPara()
        //{

        // }

        // Parameterized Thread
        public int Parametrized()
        {
            int r = 12, c = 12, b = 12;
            for (int i = 0; i < b; i++)
            {

                // loop for printing leading whitespaces
                for (int j = 0; j < 2 * (b - i) - 1; j++)
                {
                    Console.Write(" ");
                }

                // loop for printing * character
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                Thread.Sleep(500);



                for (int a = 1; a <= c; a++)
                {
                    for (int j = 1; j <= a; j++)
                    {
                        Console.Write(" * ");
                    }
                    Console.WriteLine();
                    Thread.Sleep(1000); // Simulate some work
                }


                for (int f = 1; f <= r; f++)
                {
                    for (int j = r; j > f; j--)
                    {
                        Console.Write(" * ");
                    }
                    //for (int k = 1; k <= i; k++)
                    //{
                    //    Console.Write(" * ");
                    //}
                    Console.WriteLine();
                    Thread.Sleep(500); // Simulate some work

                }
               
            }
            return 0;
        }

        // Sum Method (Example of Regular Functionality)
        public int Sum(int a, int b)
        {
            int result = a + b;
            Console.WriteLine($"Sum of numbers: {result}");
            return result;
        }

        static void Main()
        {
            // Starting the Non-Parameterized Thread
            //Thread t1 = new Thread(NonPara);
            //t1.Start();

            // Starting the Parameterized Thread
            Thread2cs obj = new Thread2cs();
            Thread t2 = new Thread(() => obj.Parametrized());
            t2.Start();

            // Wait for both threads to complete
           //t1.Join();
            t2.Join();

            // Example of a regular method call
            obj.Sum(5, 10);

            Console.WriteLine("Main thread completed.");
        }
    }
}
