using System;

namespace cosc_1436_lab_03_csharp
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter the score for test 1: ");
            var test1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the score for test 2: ");
            var test2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the score for test 3: ");
            var test3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the score for test 4: ");
            var test4 = Convert.ToDouble(Console.ReadLine());

            var testAverage = (test1 + test2 + test3 + test4) / 4;

            var letterGrade = GetLetterGrade(testAverage);
            
            Console.WriteLine($"The test average is: { testAverage }");
            Console.WriteLine($"The letter grade is: { letterGrade }");
        }

        private static string GetLetterGrade(double testAverage)
        {
            string letterGrade;
            
            if (testAverage >= 90)
            {
                letterGrade = "A";
            } else if (testAverage >= 80)
            {
                letterGrade = "B";
            } else if (testAverage >= 70)
            {
                letterGrade = "C";
            } else if (testAverage >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            return letterGrade;
        }
    }
}