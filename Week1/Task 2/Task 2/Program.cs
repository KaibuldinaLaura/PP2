using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name; //creating string name
        public string id;   //and id

        public Student(string name, string id)
        {
            this.name = name; //create student's name
            this.id = id;     //and id
        }

        public void PrintInfo() //function, that output info
        {
            Console.WriteLine(name); //output name
            Console.WriteLine(id); //output id
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Omarov", "11BD111111"); //student with name "Omarov" and id
            int year_of_study = 4; //crete year of study of student
            student.PrintInfo(); //output name and id
            Console.WriteLine($"The next year of study is: {year_of_study+1}"); //output year of study
        }
    }
}