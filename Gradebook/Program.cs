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



            Console.WriteLine("Welcome to Gradebook 2");
            Book2 gradebook2 = new Book2("Practical Course");
            gradebook2.add("2017UCO1618", 14, 14, 40, 14, 14);
            gradebook2.add("2017UCO1583", 14, 13, 40, 14, 14);
            gradebook2.add("2017UCO1585", 14, 14, 40, 14, 13);

            gradebook2.DisplayStats();
            gradebook2.DisplayGrads();

        }
    }
}
