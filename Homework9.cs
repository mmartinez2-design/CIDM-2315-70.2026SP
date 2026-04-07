using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework9;
    class Student
    {
        private int studentID;
        private string studentName = "";

        public static List<Student> studentList = new List<Student>();

        // add to list
        public Student()
        {
            studentList.Add(this);
        }

        // ID and Name
        public Student(int id, string name) : this()
        {
            studentID = id;
            studentName = name;
        }

        // print
        public void PrintInfo()
        {
            Console.WriteLine("ID: " + studentID + ", Name: " + studentName);
        }

        // look up GPA
        public string GetName()
        {
            return studentName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create students
            new Student(111, "Alice");
            new Student(222, "Bob");
            new Student(333, "Cathy");
            new Student(444, "David");

            // dictionary
            Dictionary<string, double> gradebook = new Dictionary<string, double>();
            gradebook.Add("Alice", 4.0);
            gradebook.Add("Bob", 3.6);
            gradebook.Add("Cathy", 2.5);
            gradebook.Add("David", 1.8);

            //find tom
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook.Add("Tom", 3.3);
            }

            // calculate average GPA
            double average = gradebook.Values.Average();
            Console.WriteLine("The average GPA: " + average.ToString("F2"));

            // gpa above average
            Console.WriteLine("GPA above average: ");

            var aboveAverageStudents = Student.studentList
                .Where(s => gradebook.ContainsKey(s.GetName()) && gradebook[s.GetName()] > average);

            foreach (var stu in aboveAverageStudents)
            {
                // studentinfo and GPA
                stu.PrintInfo();
            }
        }
    }
