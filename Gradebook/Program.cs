using GradeBook;
using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gradebook");
            Book1 gradebook = new Book1("Sample_Course");
            gradebook.add("2017UCO1618", 24, 24, 50);
            gradebook.add("2017UCO1583", 24, 24, 50);
            gradebook.add("2017UCO1585", 24, 24, 50);

            gradebook.DisplayStats();
            gradebook.DisplayGrads();

        }
    }
}
