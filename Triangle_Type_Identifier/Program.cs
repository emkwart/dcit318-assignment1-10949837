using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        // Prompt the user to enter the lengths of the sides
        Console.Write("Enter the length of side 1: ");
        double side1 = GetValidSideLength();

        Console.Write("Enter the length of side 2: ");
        double side2 = GetValidSideLength();

        Console.Write("Enter the length of side 3: ");
        double side3 = GetValidSideLength();

        // Determine and display the type of triangle
        string triangleType = GetTriangleType(side1, side2, side3);
        Console.WriteLine($"The triangle with sides {side1}, {side2}, and {side3} is a {triangleType} triangle.");
    }

    static double GetValidSideLength()
    {
        double side;
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out side) && side > 0)
            {
                return side;
            }
            else
            {
                Console.Write("Invalid input. Please enter a positive number: ");
            }
        }
    }

    static string GetTriangleType(double side1, double side2, double side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
    }
}
