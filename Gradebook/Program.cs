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
            gradebook.add("1618", 52.3);
            gradebook.add("1583", 23.43);
            gradebook.add("1585", 34.4);
            gradebook.DisplayStats();

        }
    }
}
