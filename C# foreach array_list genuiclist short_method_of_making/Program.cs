using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            string[] array = new string[10];

            //array_list
            List<String> list_names = new List<string>();
            list_names.Add("Mustafa");
            list_names.Add("Salman");
            list_names.Add("Zaran");

            Console.WriteLine(list_names[0]);

            //For each loop 

            foreach (var name in list_names)
            {
                Console.WriteLine(name);
            }

            //Dictionary Data type
            Dictionary<string, string> Country_Code = new Dictionary<string, string>();
            Country_Code.Add("England","UK");
            Country_Code.Add("America", "USA");
            Country_Code.Add("Pakistan", "PK");

            Console.WriteLine(Country_Code["England"]);

            foreach(var country in Country_Code)
            {
                Console.Write(string.Format("The Key is {0} and Value is {1}\n", country.Key, country.Value));
            }

            //Setting Student Class Attributes/Methods 
            Student std = new Student();
            std.Name = "Mustafa";
            std.Age = "20";
            std.ID = 36;
            std.PhoneNumber = 313200832;
            std.Gender = "Male";
            std.DOB = DateTime.UtcNow;

            Student std1 = new Student();
            std1.Name = "Salman";
            std1.Age = "20";
            std1.ID = 36;
            std1.PhoneNumber = 313200832;
            std1.Gender = "Male";
            std1.DOB = DateTime.UtcNow;

            Student std2 = new Student();
            std2.Name = "Zaran";
            std2.Age = "20";
            std2.ID = 36;
            std2.PhoneNumber = 313200832;
            std2.Gender = "Male";
            std2.DOB = DateTime.UtcNow;

            //Getting Student Class Attributes/Methods
            Console.WriteLine(std.Name);
            Console.WriteLine(std.ID);
            Console.WriteLine(std.Gender);
            Console.WriteLine(std.DOB);

            //To Store the details of student class (obj) we use:
            //Genuic List

            List<Student> Student_List = new List<Student>();

            Student_List.Add(std);
            Student_List.Add(std1);
            Student_List.Add(std2);

            Console.WriteLine("############Final Output################");

            foreach(var student in Student_List)
            {
                Console.WriteLine(string.Format("student ID: {0} Student Name: {1} Student Class: {0}",student.ID,student.Name, student.Class));
            }
        }
    }

    //CTRL + K + D  to do proper formating

    //New way of making methods (short and easiest way)
    class Student
    {
        public String Name { get; set; }
        public int ID { get; set; }
        public String Gender { get; set; }
        public String Age { get; set; }
        public String Class { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DOB { get; set; }
    }
}
