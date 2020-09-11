using System;
using System.Collections.Generic;
using System.Text;
using GradeBook;

namespace Gradebook
{
    public class Marks
    {
        /// <summary>
        /// Marks obtained from the internal Assessment [0,25]
        /// </summary>
        double internalAssessment;

        /// <summary>
        /// Marks obtained from the Mid Semester Assessment [0,25]
        /// </summary>
        double midSemester;

        /// <summary>
        /// Marks obtained from the End Semester Assessment [0,50]
        /// </summary>
        double endSemester;

        public static Dictionary<int, string> gradeGuide = new Dictionary<int, string>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Marks(int a=0, int b=0, int c=0)
        {
            if (c > 50 || c < 0) 
                throw new Exception("Marks for End Semester Assessment can be between [0, 50] only");
            this.endSemester = c;

            if (a > 25 || a < 0)
                throw new Exception("Marks for Internal Assessment can be between [0, 25] only");
            this.internalAssessment = a;

            if (b > 25 || b < 0)
                throw new Exception("Marks for Mid Semester Assessment can be between [0, 25] only");
            this.midSemester = b;

            createDict();

            
        }

        public static void createDict()
        {
            if (!gradeGuide.ContainsKey(10))
                gradeGuide.Add(10, "Outstanding");
            else
                return;

            if (!gradeGuide.ContainsKey(9))
                gradeGuide.Add(9, "Exceeds Expectation");

            if (!gradeGuide.ContainsKey(8))
                gradeGuide.Add(8, "Acceptable");

            if (!gradeGuide.ContainsKey(7))
                gradeGuide.Add(7, "Acceptable");

            if (!gradeGuide.ContainsKey(6))
                gradeGuide.Add(6, "Poor");

            if (!gradeGuide.ContainsKey(5))
                gradeGuide.Add(5, "Poor");

            if (!gradeGuide.ContainsKey(4))
                gradeGuide.Add(4, "Dreadful");

            if (!gradeGuide.ContainsKey(3))
                gradeGuide.Add(3, "Troll");

            if (!gradeGuide.ContainsKey(2))
                gradeGuide.Add(2, "Troll");

            if (!gradeGuide.ContainsKey(1))
                gradeGuide.Add(1, "Troll");

        }

        /// <summary>
        /// Function to get aggregate marks out of 100
        /// </summary>
        /// <returns></returns>
        public double getaggregatemarks()
        {
            if (internalAssessment + midSemester + endSemester > 100)
                throw new Exception("Invalid Marks");

            return internalAssessment + midSemester + endSemester;
        }

        /// <summary>
        /// Function to return grade
        /// </summary>
        /// <returns></returns>
        public string getGrade()
        {
            return gradeGuide[(int)(this.getaggregatemarks()) / 10];
        }
    }
}
