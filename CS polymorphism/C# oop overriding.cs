using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearingCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat obj = new Cat();
            //obj.name = "Pussy Cat";
            //obj.category = "Omnivorous";
            //obj.food = "Milk";
            //obj.age = 1;

            //obj.run();
            //obj.eat();

            //Objective: Wite a program that takes 10 user input numbers and store it in int array then print array 

            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter any number:");
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }

            //Objective To Sort an Array in Ascending order

            for (int i = 0; i < 10; i++)
            {
                for(int j=0;j<10-1;j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j+1]=temp;
                    }

                }
            }

            Console.WriteLine("This is our Sorted Array");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }



            Console.ReadLine();

        }
    }

    public class Animal
    {
        public string name = "";
        public string food = "";
        public string category = "";
        public int age = 0;

        public void eat()
        {
            Console.WriteLine("This is eat method");
        }

        public virtual void run()
        {
            Console.WriteLine("This is parent class run method");
        }


    }

    public class Cat : Animal
    {
        public override void run()
        {
            Console.WriteLine(string.Format("Name:{0} Age:{1} Category:{2} Food:{3}", name, age, category, food));

            Console.WriteLine("This is Child class:Cat");
        }
    }

    public class Cow : Animal
    {
        public override void run()
        {
            Console.WriteLine();
            Console.WriteLine("This is Child class:Cow");
        }
    }

    public class Lion : Animal
    {
        public override void run()
        {
            Console.WriteLine("This is Child class:Lion");
        }
    }

}
