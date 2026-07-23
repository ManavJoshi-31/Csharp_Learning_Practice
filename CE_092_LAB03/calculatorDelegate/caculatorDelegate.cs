using System;

namespace Calculator
{
    class Program
    {
        delegate double Operation(double x, double y);

        static double Add(double x, double y) { return x + y; }
        static double Subtract(double x, double y) { return x - y; }
        static double Multiply(double x, double y) { return x * y; }
        static double Divide(double x, double y) { return x / y; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Enter the operation to be performed\n");

            Console.WriteLine("Press '1' : For Addition");
            Console.WriteLine("Press '2' : For Subtraction");
            Console.WriteLine("Press '3' : For Multiplication");
            Console.WriteLine("Press '4' : For Division");
            Console.Write("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter two numbers:");

            Console.Write("Num1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Num2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Operation op;

            switch (choice)
            {
                case 1:
                    op = Add;
                    Console.WriteLine("Addition = " + op(num1, num2));
                    break;

                case 2:
                    op = Subtract;
                    Console.WriteLine("Subtraction = " + op(num1, num2));
                    break;

                case 3:
                    op = Multiply;
                    Console.WriteLine("Multiplication = " + op(num1, num2));
                    break;

                case 4:
                    op = Divide;
                    if (num2 != 0)
                        Console.WriteLine("Division = " + op(num1, num2));
                    else
                        Console.WriteLine("Error! Division by zero is not allowed.");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
