using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 1; i <= 5; i++)
            //{
            //    for(int b = 1; b <= 5; b++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("\n");
            //}
            for (int i = 1; i <= 5; i++)
            {
                for (int b = 1; b <= i; b++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
            for (int i = 10; i >= 1; i--)
            {
                for (int b = 5; b <= i; b++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int b = 1; b <= i; b++)
                {
                    Console.Write(b);
                }
                Console.Write("\n");
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int b = 1; b <= i; b++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int b = 1; b <= i; b++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }
            int t = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int b = 1; b <= i; b++)
                {
                    Console.Write(t);
                    t++;
                }
                Console.Write("\n");
            }
            for (int i = 1; i <= 5; i++)
            {
                for (int b = 4; b >= i; b--)
                {
                    Console.Write("  ");
                }
                for (int c = 1; c >= i; c++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("\n");
            }

        }
    }
}