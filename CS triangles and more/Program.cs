using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static void Factorial(int a)
        {
            int fac = 1;
            for(int i = a; i>=1; i--)// 1*5 =5 ; 5*4=20 ; 20*3=60; 60*2=120 ; 120*1=120
            {
                fac = fac * i;
            }
            Console.WriteLine(fac);
        }
        public static void Odd(int o)
        {
            for(int i=0; i<o; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Triangle(int b)
        {
            for(int c = 0; c< b; c++)
            {
                for(int d = 5; d>= c; d--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("d");
            }
            for (int i = 0; i < b; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            Factorial(5);
            Triangle(10);
            Odd(10);
        }
    }
}
