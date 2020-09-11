using GradeBook;
using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gradebook");
            Book gradebook = new Book("Sample_Course");
            gradebook.add("1618", 25, 25, 50);
            gradebook.add("1583", 25, 24, 50);
            gradebook.add("1585", 24, 24, 50);


            gradebook.DisplayStats();
            gradebook.DisplayGrads();
     

        }
    }
}
