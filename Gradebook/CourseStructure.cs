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
        /// Laying down the Grade Scheme for the Course
        /// </summary>
        public static Dictionary<int, string> gradeGuide { get; set; }

        public string getCourseName()
        {
            return "This is the Base Course";
        }

    }
}
