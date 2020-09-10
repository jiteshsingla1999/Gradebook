using System;
using System.Collections.Generic;
using System.Text;

using GradeBook;

namespace Gradebook
{
    public class Statistics
    {
        public double avg { get; set; }

        public double highval { get; set; }

        public double lowval { get; set; }

        public string pos1_student { get; set; }

        public Statistics()
        {
            avg = 0;
            highval = 0;
            lowval = 0;
        }

    }


}
