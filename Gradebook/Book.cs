using Gradebook;
using System;
using System.Collections.Generic;
namespace GradeBook
{
    public class Book
    {
        /// <summary>
        /// Name of the Course
        /// </summary>
        private string CourseName { get; set; }

        /// <summary>
        /// Key Value Pair<Student Name, Score> </Student>
        /// </summary>
        private List<KeyValuePair<string, double> > grades { get; set; }

        /// <summary>
        /// Number of students in the class
        /// </summary>
        private int count;


        public Book(string name = "SampleCourse")
        {
            this.CourseName = name;
            grades = new List<KeyValuePair<string, double>>();
            count = 0;
        }
        public void add(string studentName, double score)
        {
            grades.Add(new KeyValuePair<string, double>(studentName, score));
            count += 1;
        }

        private double findSum()
        {
            double sum = 0;
            foreach(var i in grades)
            {
                sum += i.Value;
            }

            return sum;
        }

        public double findAVG()
        {
            return findSum() / count;
        }

        public Statistics ShowStats()
        {
            var result = new Statistics();
            result.lowval = lowestGrade;
            result.highval = highestGrade;
            result.avg = findAVG();
            System.Console.WriteLine($"The Lowest Grade is {lowestGrade}");
            System.Console.WriteLine($"The Highers Grade is {highestGrade}");

            System.Console.WriteLine($"The Average Grade is {result.avg:N1}");
            return result;
        }
    }
}

