using System;
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
                throw new ArgumentException("Marks for End Semester Assessment can be between [0, 50] only");
            this.endSemester = c;

            if (a > 25 || a < 0)
                throw new ArgumentException("Marks for Internal Assessment can be between [0, 25] only");
            this.internalAssessment = a;

            if (b > 25 || b < 0)
                throw new ArgumentException("Marks for Mid Semester Assessment can be between [0, 25] only");
            this.midSemester = b;

            if (a + b + c < 0 )
                throw new ArgumentException("Sum of the Marks can be between [0, 100] only");
        }



        /// <summary>
        /// Function to get aggregate marks out of 100
        /// </summary>
        /// <returns></returns>
        public double getaggregatemarks()
        {
           double sum = internalAssessment + midSemester + endSemester;
            if (sum > 100 || sum < 0)
                throw new ArgumentException("Invalid Marks");
            return (internalAssessment + midSemester + endSemester);
        }
        /// <summary>
        /// Function to return grade
        /// </summary>
        /// <returns></returns>
        public string getGrade()
        {
            int num = (int)(this.getaggregatemarks()) / 10;
            if(num<0 || num>10)
                throw new ArgumentException("Invalid Grade Point");
            return Book1.gradeGuide[num];
        }
    }
}
