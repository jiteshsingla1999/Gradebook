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
        /// [90-100] -> O
        /// [80-90) -> A+
        /// [70-80) -> A
        /// [60-70) -> B+
        /// [50-60) -> B
        /// [40-50) -> C+
        /// [30-40) -> C
        /// (<30)   -> T
        /// </summary>
        /// <returns></returns>
        public string getGrade()
        {
            switch ((this.getaggregatemarks() / 10))
            {
                case 9:
                    {
                        return "O";
                    }
                case 8:
                    {
                        return "A+";
                    }
                case 7:
                    {
                        return "A";
                    }
                case 6:
                    {
                        return "B+";
                    }
                case 5:
                    {
                        return "B";
                    }
                case 4:
                    {
                        return "C+";
                    }
                case 3:
                    {
                        return "C";
                    }
                default:
                    {
                        return "T";
                    }

            }

        }
    }
}
