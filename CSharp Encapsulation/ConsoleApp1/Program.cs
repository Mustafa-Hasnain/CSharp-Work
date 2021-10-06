using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Set_Personal_Details("Mustafa", 20, DateTime.Now);
            std.Set_School_Details("UIT", "SE", 036);
            std.Get_Personal_Details();
        }
    }
    public class Student
    {
        private string Name;
        private int Rollno;
        private string Department;
        private string School;
        private int Age;
        private DateTime DOB;

        //constructor
        public Student()
        {
            Console.WriteLine("Constructor Created");
        }
    /*In Public Class the variables/attributes can be access by any class
    *In Private Class the variables can only be accessed within the class (here methods are mostly used for accessing and to set the variable). 
     The variable in the class is default private so "public" and "protected" keywords are used for it.
    *In Protected Class the variables/attributes are only accessed by Child classes.
    *             "THE WHOLE PROCESS OF MAKING CLASSES PUBLIC, PRIVATE AND PROTECTED IS KNOWN AS ENCAPSULATION" */


        public void Set_Personal_Details(string name, int age, DateTime dob)
        {
            Name = name;
            Age = age;
            DOB = dob;
        }
        public string Get_Personal_Details()
        {
            Age.ToString();
            Console.WriteLine("Name: " + Name + "\nAge: " + Age + "\nDateOfBirth: " + DOB);
            return Name +  Age +  DOB; 
        }
        public void Set_School_Details(string school, string dep, int rollno)
        {
            School = school;
            Department = dep;
            Rollno = rollno;
        }
        public string Get_School_Details()
        {
            return "School: " + School + "\nDepartment: " + Department + "\nRollno: " + Rollno;
        }
    }
    
}
