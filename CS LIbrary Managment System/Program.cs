using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Managment_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************LIBRARY MANAGMENT SYSTEM*********************");
            Console.WriteLine("Enter Your Username");
            string username = Console.ReadLine();
            Console.WriteLine(string.Format("Welcome {0}", username));
            Console.WriteLine("Enter the Pasword");
            string password = "1234";
            string pass = Console.ReadLine();
            if (pass == password)
            {
                Console.WriteLine("You are Good to GO");
                Console.WriteLine("Welcome Admin");
            }
            else
            {
                Console.WriteLine("Plz Try again");
                string pas = Console.ReadLine();
                pas = pass; 
            }
            Library_Managment_System lMS = new Library_Managment_System();
            Console.WriteLine(string.Format("Press 1 for: Add Books \nPress 2 for: Update Books \nPress 3 for: Search Book"));
            int i = int.Parse(Console.ReadLine());
            if(i == 1)
            {
                lMS.Add_Book("Physics");
            }
        }
        class Library_Managment_System
        {
            //Public Array Books = new Array[10];
            public List<string> Books = new List<string>();
            string book_name;

            public void Add_Book(string book_name)
            {
                Books.Add(book_name);
                foreach b in Books{
                    Console.WriteLine(b);
                }
            }
            public void Update_book(string book_name, string new_name)
            {
                book_name = new_name;
            }
        }
        
    }
}
