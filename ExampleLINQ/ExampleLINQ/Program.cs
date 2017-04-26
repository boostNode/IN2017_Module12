/*
 *  Author: Troy Davis
 *  Project: Module12 - ExampleLINQ - Console
 *  Class: IN 2017 (Advanced C#)
 *  Date: Apr 25, 2017 
 *  Revision: Original
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // greeting
            Console.WriteLine("Module 12 - Example LINQ");

            // Create List of Students
            List<Student> myStudents = new List<Student>
            {
                new Student() { NameFirst="Purdy", NameLast="Smarty", Age=22, GPA=3.7 },
                new Student() { NameFirst="Super", NameLast="Smarty", Age=21, GPA=4.0 },
                new Student() { NameFirst="Little", NameLast="Dummy", Age=23, GPA=1.2 },
                new Student() { NameFirst="Kinda", NameLast="Average", Age=26, GPA=2.8 },
                new Student() { NameFirst="Gettin", NameLast="Smarter", Age=24, GPA=3.2 },
            };

            //s1.DisplayProperties("");

            // LINQ query
            var honorRoll = from student in myStudents
                            orderby student.GPA descending
                            where student.GPA >= 3.5
                            select student;

            var probation = from student in myStudents
                            orderby student.GPA ascending
                            where student.GPA < 2.0
                            select student;

            // LINQ method
            var alphaRoster = myStudents.OrderBy(p => p.NameLast).ThenBy(p => p.NameFirst);

            var oldestStudent = myStudents.OrderByDescending(p => p.Age).First();

            // Display output
            foreach (var student in honorRoll)
            {
                student.DisplayProperties("Honor Roll: ");
            }
            foreach (var student in probation)
            {
                student.DisplayProperties("Probation: ");
            }
            foreach (var student in alphaRoster)
            {
                student.DisplayProperties("Alpha Roster: ");
            }
            oldestStudent.DisplayProperties("Oldest Student: ");

            // wait on user to close console
            Console.Write("\nPress 'Enter' to exit: "); Console.ReadLine();
        }
    }

    class Student
    {
        // setters / getters
        public string NameFirst { get; set; }
        public string NameLast{ get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }

        // methods
        public void DisplayProperties(string leader)
        {
            Console.WriteLine("\n\t{0}{1}, {2} - Age: {3}, GPA = {4:0.00}", leader, this.NameLast, this.NameFirst, this.Age, this.GPA);
        }
    }
}
