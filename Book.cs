using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Book
    {
        /*Construktor
        I've add a strig name as param to the constructor
        now we HAVE to add a string to invoke this constructor
        */
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                //Math.Min(Byte, Byte): Returns the smaller of the two 8-bit unsigned integers.
                result.Low = Math.Min(grade, result.Low);

                //Math.Max(Byte, Byte): Returns the larger of the two 8-bit unsigned integers.
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }

            result.Average /= grades.Count;
            
            return result;
          
        }

        public void AddGrade(double grade)
        {
            //add validation logic for check user input
            this.grades.Add(grade);

        }

        //adding variables that I can rech inside of methods.
        private List<double> grades;
        private string name;

    }
}
