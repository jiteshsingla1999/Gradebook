using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public class CourseStructure
    {
        /// <summary>
        /// Name of the Course
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// Key Value Pair<Student Name, Score> </Student>
        /// </summary>
        public List<KeyValuePair<string, Marks>> grades { get; set; }

        /// <summary>
        /// Number of students in the class
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// Laying down the Grade Scheme for the Course
        /// </summary>
        public static Dictionary<int, string> gradeGuide { get; set; }

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

        public string getCourseName()
        {
            return "This is the Base Course";
        }

    }
}
