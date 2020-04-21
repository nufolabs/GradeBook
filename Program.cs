using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Transactions;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($" : {}");

            var book = new Book("Patriks Book");
            book.AddGrade(56.1);
            book.AddGrade(126.1);
            book.AddGrade(222.1);
            book.GetStatistics();

            var stats = new Statistics();

            Console.WriteLine($"This lowest is: {stats.Low}");
            Console.WriteLine($"This Highest is: {stats.High}");
            Console.WriteLine($"This is median {stats}");



        }
    }
}
