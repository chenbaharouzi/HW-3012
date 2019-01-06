using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2512
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question1();

            // Question2();

            // Question3();

            // Question4();

            // Question5();

            Question6();
        }

      

        private static void Question6()
        {

            int x;
            int sum = 1;
            int i = 2;

            Console.WriteLine("please enter a number:");
            x = Convert.ToInt32(Console.ReadLine());

            while (i <= x)
            {
                sum = sum * i;
                i++;

            }
            {
                Console.WriteLine($"the sum is: {sum}");
            }

            Console.ReadLine();
        }

        private static void Question5()
        {
            int x, y;

            Console.WriteLine("please enter a nummer to SECRET:");

            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter a number to GUESS:");

            y = Convert.ToInt32(Console.ReadLine());

            while (x = y)
            {
                Console.WriteLine("Bingo");
            }


            {
                if (y > x)
                {
                    Console.WriteLine("Too big");
                }
                else
                {
                    Console.WriteLine("Too small");
                }
            }




            Console.ReadLine();
        }

        private static void Question4()
        {
            Console.WriteLine("please enter a number:");
            int x= Convert.ToInt32(Console.ReadLine());
            int i = 2;

            while (x % i != 0)
            {
                i++;
            }


            {
                if (x == i)
                {
                    Console.WriteLine($"{x} is a prime number");

                }
                else
                {
                    Console.WriteLine($"{x} is NOT a prime number");
                }

            }

            Console.ReadLine();
        }

        private static void Question3()
        {
            Console.WriteLine("please enter a number:");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (x >= 0)
            {
                sum = sum + x;
                Console.WriteLine($"The sum is {sum}");
                Console.WriteLine("Please enter a number:");
                x = Convert.ToInt32(Console.ReadLine());

            }

            Console.ReadLine();
        }

        private static void Question2()
        {
            Console.WriteLine("Please enter two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            double avg = sum / 2.0;
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {avg}");

            Console.ReadLine();
        }

        private static void Question1()
        {
            Console.WriteLine("Please enter two numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine($"{a} divides by {b} without remainder");
            }
            else
            {
                Console.WriteLine($"{a} NOT divides by {b} without remainder");
            }
            Console.ReadLine();
        }
    }
}
