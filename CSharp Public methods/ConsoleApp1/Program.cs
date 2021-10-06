using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DOB = DateTime.Now;
            Console.WriteLine(DateTime.UtcNow);
            Console.WriteLine("Hello World!");
            Student std = new Student();
            std.Name = "Mustafa";
            std.RollNo = 036;
            std.Gender = "male";
            std.Class = 11;
            std.DateOfBirth = DateTime.Now;

            std.Print();
        }
    }
    public class Student
    {
        public string Name;
        public int RollNo;
        public string Gender;
        public int Class;
        public DateTime DateOfBirth;

        public Student()
        {

        }

        public void Print()
        {
            Console.WriteLine("Student Name:" + Name);
            Console.WriteLine("Student RollNo:" + RollNo);
            Console.WriteLine("Student Gender:" + Gender);
            Console.WriteLine("Student Class:" + Class);
            Console.WriteLine("Student DateOfBirth:" + DateOfBirth.ToString("dd_MM_yyyy"));
        }
    }

}