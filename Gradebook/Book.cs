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
        public int count { get; set; }

        /// <summary>
        /// Stats variable to store statistical information
        /// </summary>
        private Statistics stats { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Book(string name = "SampleCourse")
        {
            this.CourseName = name;
            grades = new List<KeyValuePair<string, double>>();
            count = 0;
            stats = new Statistics();
        }

        /// <summary>
        /// Function to add score to the list
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="score"></param>
        public void add(string studentName, double score)
        {
            if (Math.Round(score) > findMax())
            {
                stats.pos1_student = studentName;
            }

            grades.Add(new KeyValuePair<string, double>(studentName, Math.Round(score,2)));
            count += 1;
            updateStats();

            return;
        }

        /// <summary>
        /// Function to find sum of marks in the list
        /// </summary>
        /// <returns></returns>
        private double findSum()
        {
            double sum = 0;
            foreach (var i in grades)
            {
                sum += i.Value;
            }

            return sum;
        }

        /// <summary>
        /// Function to find average marks in the list
        /// </summary>
        /// <returns></returns>
        public double findAVG()
        {
            return Math.Round(findSum() / count, 2);
        }

        /// <summary>
        /// Function to find minimum marks in the list
        /// </summary>
        /// <returns></returns>
        public double findMin()
        {
            double minn = 101;

            foreach(var i in grades)
            {
                minn = Math.Min(minn, i.Value);
            }

            return minn;
        }

        /// <summary>
        /// Function to find maximum marks in the list
        /// </summary>
        /// <returns></returns>
        public double findMax()
        {
            double maxx = -1;

            foreach (var i in grades)
            {
                maxx = Math.Max(maxx, i.Value);
            }

            return maxx;
        }

        /// <summary>
        /// Function to update the statistics 
        /// </summary>
        public void updateStats()
        {
            if (count == 0)
            {
                Console.WriteLine("Record List is empty");
                return;
            }
                    

            stats.avg = findAVG();
            stats.highval = findMax();
            stats.lowval = findMin();



        }

        /// <summary>
        /// Function to display statistics in the list
        /// </summary>
        public void DisplayStats()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Number of students enrolled: {count}");

            if (count == 0)
                return;

            Console.WriteLine($"Class Avergae: {stats.avg}");
            Console.WriteLine($"Highest marks in class: {stats.highval}");
            Console.WriteLine($"Lowest marks in class: {stats.lowval}");
            Console.WriteLine($"Class Topper: {stats.pos1_student}");

            return;
        }
        
    }
}

