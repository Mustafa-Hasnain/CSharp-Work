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
            Console.WriteLine("Press 1 for Admin Login \nPress 2 for User Login");
            int j = int.Parse(Console.ReadLine());
            Library_Managment_System LMS = new Library_Managment_System();
            Admin_Login ad_login = new Admin_Login();
            User_Login us_login = new User_Login();
            List<string> Book = new List<string>();
            if (j == 1)
            {
                Console.WriteLine("Enter the Pasword");
                string pass = Console.ReadLine();
                ad_login.admin_login(pass);
                if (ad_login.p == 1)
                {
                    int i = int.Parse(Console.ReadLine());
                    while (i != 0)
                    {
                        if (i == 1)
                        {
                            Console.WriteLine("Enter the Book Name");
                            string b = Console.ReadLine();
                            Book.Add(b);
                            LMS.Add_Book(b);
                        }
                        if (i == 2)
                        {
                            Console.WriteLine("Enter the Old Book Name");
                            string bookName = Console.ReadLine();
                            Console.WriteLine("Enter the New Book Name");
                            string newName = Console.ReadLine();
                            LMS.Update_book(bookName, newName);
                        }
                        if (i == 3)
                        {
                            Console.WriteLine("Enter the book for search: ");
                            string bookName = Console.ReadLine();
                            LMS.Search_Books(bookName);
                        }
                        if (i == 4)
                        {
                            LMS.Show_books();
                        }
                        Console.WriteLine(string.Format("Press 1 for: Add Books \nPress 2 for: Update Books \nPress 3 for: Search Book \nPress 4 to Show Books \nPress 0 To exit"));
                        i = int.Parse(Console.ReadLine());
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("Press 1 for Admin Login \nPress 2 for User Login \nPress 0 for exit");
                    }
                }
            }

            j = int.Parse(Console.ReadLine());
            if (j == 2)
            {
                Console.WriteLine("Enter the Pasword");
                string pass = Console.ReadLine();
                us_login.user_login(pass);
                if (us_login.o == 1)
                {
                    int k = int.Parse(Console.ReadLine());
                    while (k != 0)
                    {
                        if (k == 1)
                        {
                            LMS.Show_books();
                        }
                        if (k == 2)
                        {
                            Console.WriteLine("Enter the book for search: ");
                            string bookName = Console.ReadLine();
                            LMS.Search_Books(bookName);
                        }
                        if(k == 3)
                        {
                            Console.WriteLine("Enter the Book");
                            string book = Console.ReadLine();
                            LMS.Place_Order(book);
                        }
                        Console.WriteLine("Press 1 for: View Available Books \nPress 2 for: Search Book \nPress 3 for: Place Order \nPress 0 for: Exit");
                        k = int.Parse(Console.ReadLine());
                    }
                    if (k == 0)
                    {
                        Console.WriteLine("Press 1 for Admin Login \nPress 2 for User Login \nPress 0 for exit");
                    }
                }
            }
            j = int.Parse(Console.ReadLine());
        }
    }
    class Library_Managment_System
    {
        //Public Array Books = new Array[10];
        public List<string> Books = new List<string>();
        public int ind = 0;
        public void Add_Book(string book_name)
        {
            Books.Add(book_name);
        }
        public int Search_Books(string bookName)
        {
            var flag = 0;
            foreach (var b in Books)
            {
                if (bookName.ToLower() == b.ToLower())
                {
                    flag += 1;
                    ind += Books.IndexOf(b);
                }
            }
            if (flag == 1)
            {
                Console.WriteLine(string.Format("Book Found on: {0}",ind));

            }
            else
            {
                Console.WriteLine("Book Not Found");
            }
            return flag;
        }
        public void Update_book(string book_name, string new_name)
        {
            var search = Search_Books(book_name);
            if (search == 1)
            {
                Books[ind] = new_name;
                Console.WriteLine("book updated");
            }
            else
            {
                Console.WriteLine("book not found");
            }

        }
        public void Show_books()
        {
            foreach (var j in Books)
            {
                Console.WriteLine(j);
            }
        }
        public void Place_Order(string book)
        {
            var srch = Search_Books(book);
            if(srch == 1)
            {
                Console.WriteLine(string.Format("{0} book has found \nOrder Placed",book));
            }
            else
            {
                Console.WriteLine(string.Format("{0} book not found", book));
            }
        }
        public void Delete(string book)
        {
            var search = Search_Books(book);
            if (search == 1)
            {
                Books.Remove(book);
                Console.WriteLine("book updated");
            }
            else
            {
                Console.WriteLine(string.Format("{0} book not found", book));
            }
        }
    }
    class Admin_Login
    {
        string password = "1234";
        public int p = 0;
        public void admin_login(string pass)
        {
            while (pass != password)
            {
                Console.WriteLine("Plz Try again");
                pass = Console.ReadLine();
            }
            if (pass == password)
            {
                Console.WriteLine("You are Good to GO");
                Console.WriteLine("Welcome Admin");
                Console.WriteLine(string.Format("Press 1 for: Add Books \nPress 2 for: Update Books \nPress 3 for: Search Book \nPress 4 for: Show Books \nPress 0 for:  exit"));
                p += 1;
            }
        }
    }
    class User_Login
    {
        string userpassword = "123";
        public int o = 0;

        public void user_login(string pass)
        {
            while(pass != userpassword)
            {
                Console.WriteLine("Plz Try again");
                pass = Console.ReadLine();
            }
            if (pass == userpassword)
            {
                Console.WriteLine("Welcome User");
                Console.WriteLine("You are Good to GO");
                Console.WriteLine("Press 1 for: View Available Books \nPress 2 for: Search Book \nPress 3 for: Place Order \nPress 0 for: Exit");
                o += 1;
            }
        }
    }
 }
