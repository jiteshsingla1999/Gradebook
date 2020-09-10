using GradeBook;
using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gradebook");
            Book gradebook = new Book();
            gradebook.add(12.3);
            gradebook.add(23.43);
            gradebook.add(34.4);

            Console.WriteLine(gradebook.findAVG());
        }
    }
}
