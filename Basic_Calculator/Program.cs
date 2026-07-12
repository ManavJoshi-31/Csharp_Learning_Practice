using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome! Enter the operation to be performed");
        Console.WriteLine();

        Console.WriteLine("Press '1' : For Addition");
        Console.WriteLine("Press '2' : For Subtraction");
        Console.WriteLine("Press '3' : For Multiplication");
        Console.WriteLine("Press '4' : For Division");
        Console.WriteLine("Press '5' : For Modulus");

        Console.Write("\nEnter your choice: ");
        int operation = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nEnter two numbers:");

        Console.Write("Num1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Num2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine("Addition = " + (num1 + num2));
                break;

            case 2:
                Console.WriteLine("Subtraction = " + (num1 - num2));
                break;

            case 3:
                Console.WriteLine("Multiplication = " + (num1 * num2));
                break;

            case 4:
                if (num2 != 0)
                    Console.WriteLine("Division = " + (num1 / (double)num2));
                else
                    Console.WriteLine("Error! Division by zero is not allowed.");
                break;

            case 5:
                if (num2 != 0)
                    Console.WriteLine("Modulus = " + (num1 % num2));
                else
                    Console.WriteLine("Error! Modulus by zero is not allowed.");
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}