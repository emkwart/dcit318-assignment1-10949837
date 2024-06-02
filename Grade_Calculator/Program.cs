using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter a numerical grade between 0 and 100: ");
        string input = Console.ReadLine();
        int grade;

        // Attempt to parse the input to an integer
        if (int.TryParse(input, out grade))
        {
            // Check if the grade is within the valid range
            if (grade >= 0 && grade <= 100)
            {
                // Determine the letter grade based on the numerical grade
                string letterGrade = GetLetterGrade(grade);
                Console.WriteLine($"The letter grade for {grade} is {letterGrade}.");
            }
            else
            {
                Console.WriteLine("The grade must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical grade between 0 and 100.");
        }
    }

    static string GetLetterGrade(int grade)
    {
        if (grade >= 90)
        {
            return "A";
        }
        else if (grade >= 80)
        {
            return "B";
        }
        else if (grade >= 70)
        {
            return "C";
        }
        else if (grade >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
}
