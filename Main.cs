using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Calculator!");

        while (true)
        {
            Console.WriteLine("Enter the first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /):");
            char op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }

            Console.WriteLine("Result: " + result);
            Console.WriteLine("Do you want to perform another calculation? (Y/N)");
            string choice = Console.ReadLine();

            if (choice.ToLower() != "y")
                break;
        }

        Console.WriteLine("Thank you for using the Calculator!");
    }
}
