using Gradebook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace GradeBook
{
    public class Book1 : CourseStructure
    {
        /// <summary>
        /// Key Value Pair<Student Name, Score> </Student>
        /// </summary>
        public List<KeyValuePair<string, Marks>> grades { get; set; }

        /// <summary>
        /// Number of students in the class
        /// </summary>
        public int count { get; set; }
        public static void createDictBook1()
        {
            gradeGuide = new Dictionary<int, string>();

            gradeGuide.Add(10, "O");
            gradeGuide.Add(9, "A+");
            gradeGuide.Add(8, "A");
            gradeGuide.Add(7, "B+");
            gradeGuide.Add(6, "B");
            gradeGuide.Add(5, "C");
            gradeGuide.Add(4, "D");
            gradeGuide.Add(3, "F");
            gradeGuide.Add(2, "F");
            gradeGuide.Add(1, "F");
            gradeGuide.Add(0, "F");
        }
        /// <summary>
        /// Stats variable to store statistical information
        /// </summary>
        public Statistics stats { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Book1(string name = "Software Testing")
        {
            this.CourseName = name;
            grades = new List<KeyValuePair<string, Marks>>();
            count = 0;
            stats = new Statistics();
            createDictBook1();
        }

        /// <summary>
        /// Function to add score to the list
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="score"></param>
        public void add(string studentID, int internalAssmt = 0, int midAssmt = 0, int endAssmt = 0)
        {
            ///Integrity check for Student ID
            if (studentID.Length != 11)
                throw new ArgumentException("Please enter a valid Student ID");

            string year = studentID.Substring(0, 4);
            int val = Int16.Parse(year);
            if (val != 2017)
                throw new ArgumentException("Course only for 4th Years");

            if (studentID[4] != 'U')
                throw new ArgumentException("Course only for Undergraduate");

            string branch = studentID.Substring(5, 2);

            if (branch != "CO")
                throw new ArgumentException("Course only for Computer Science Students");

            string rollnum = studentID.Substring(7, 4);
            val = Int16.Parse(rollnum);

            if (val < 1500 || val > 1700)
                throw new ArgumentException("Wrong Range of Roll Number for Computer Science Students");

            Marks score = new Marks(internalAssmt, midAssmt, endAssmt);
            double aggregate = Math.Round(score.getaggregatemarks());
            double curmaxval = findMax();

            if (aggregate > curmaxval)
            {
                if (stats.pos1_student.Any())
                    stats.pos1_student.Clear();
                stats.pos1_student.Add(studentID);
            }
            else if (aggregate == curmaxval)
                stats.pos1_student.Add(studentID);

            grades.Add(new KeyValuePair<string, Marks>(studentID, score));
            count += 1;
            updateStats();
            return;
        }

        /// <summary>
        /// Function to find sum of marks in the list
        /// </summary>
        /// <returns></returns>
        public double findSum()
        {
            double sum = 0;
            foreach (var i in grades)
            {
                sum += i.Value.getaggregatemarks();
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

            foreach (var i in grades)
            {
                minn = Math.Min(minn, i.Value.getaggregatemarks());
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
                maxx = Math.Max(maxx, i.Value.getaggregatemarks());
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
        /// Function to return Current Course Name
        /// </summary>
        public string getCourseName()
        {
            return this.CourseName;
        }

        public string getParentCourseName()
        {
            return base.getCourseName();
        }

        /// <summary>
        /// Function to display statistics in the list
        /// </summary>
        public void DisplayStats()
        {
            Console.Write($"Course Name:".PadRight(30));
            Console.WriteLine($"{CourseName}".PadRight(20));

            Console.Write($"Number of students enrolled:".PadRight(30));
            Console.WriteLine($"{count}".PadRight(20));

            if (count == 0)
                return;

            Console.Write($"Class Average".PadRight(30));
            Console.WriteLine($"{stats.avg}".PadRight(20));
            Console.Write($"Highest marks in class:".PadRight(30));
            Console.WriteLine($"{stats.highval}".PadRight(20));
            Console.Write($"Lowest marks in class:".PadRight(30));
            Console.WriteLine($"{stats.lowval}".PadRight(20));
            Console.Write($"Class Topper:".PadRight(30));
            foreach (var i in stats.pos1_student)
            {
                Console.Write(value: $"{i}".PadRight(15));
            }
            Console.WriteLine();
            return;
        }

        public void DisplayGrads()
        {
            Console.WriteLine();
            Console.Write($"Student ID".PadRight(30));
            Console.Write($"Total Marks".PadRight(30));
            Console.WriteLine($"Grade".PadRight(20));

            foreach (var i in grades)
            {
                Console.Write($"{i.Key}".PadRight(30));
                Console.Write($"{i.Value.getaggregatemarks()}".PadRight(30));
                Console.WriteLine($"{i.Value.getGrade()}".PadRight(20));
            }
        }
    }
}