using System;
using System.Collections.Generic;
using System.Text;

using GradeBook;

namespace Gradebook
{
    public class Statistics
    {
        /// <summary>
        /// average marks in class
        /// </summary>
        public double avg { get; set; }

        /// <summary>
        /// highest marks in class
        /// </summary>
        public double highval { get; set; }

        /// <summary>
        /// lowest marks in class
        /// </summary>
        public double lowval { get; set; }

        /// <summary>
        /// Name of student with highest marks
        /// </summary>
        public List<string> pos1_student { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Statistics()
        {
            avg = 0;
            highval = 0;
            lowval = 0;
            pos1_student = new List<string>();
        }

    }


}
