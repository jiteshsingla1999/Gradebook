using System;
using System.Collections.Generic;
using System.Text;

namespace Gradebook
{
    public class PracticalMarks : Marks
    {
        public double internalPracMarks;

        public double externalPracMarks;


        public PracticalMarks(int a = 0, int b = 0, int c = 0, int d = 0, int e=0)
        {
            if (c > 40 || c < 0)
                throw new ArgumentException("Marks for End Semester Assessment can be between [0, 40] only");
            this.endSemester = c;

            if (a > 15 || a < 0)
                throw new ArgumentException("Marks for Internal Assessment can be between [0, 15] only");
            this.internalAssessment = a;

            if (b > 15 || b < 0)
                throw new ArgumentException("Marks for Mid Semester Assessment can be between [0, 15] only");
            this.midSemester = b;

            if (d > 15 || d < 0)
                throw new ArgumentException("Marks for Internal Practical Assessment can be between [0, 15] only");
            this.internalPracMarks = d;

            if (e > 15 || e < 0)
                throw new ArgumentException("Marks for External Practical Assessment can be between [0, 15] only");
            this.externalPracMarks = e;


            if (a + b + c + d + e < 0)
                throw new ArgumentException("Sum of the Marks can be between [0, 100] only");
        }



        /// <summary>
        /// Function to get aggregate marks out of 100
        /// </summary>
        /// <returns></returns>
        public new double getaggregatemarks()
        {
            double sum = internalAssessment + midSemester + endSemester + internalPracMarks + externalPracMarks;
            if (sum > 100 || sum < 0)
                throw new ArgumentException("Invalid Marks");
            return sum;
        }

        public string getGrade(Dictionary<int, string> gradeGuide)
        {
            int num = (int)(this.getaggregatemarks()) / 10;
            if (num < 0 || num > 10)
                throw new ArgumentException("Invalid Grade Point");
            return gradeGuide[num];
        }

    }
}
