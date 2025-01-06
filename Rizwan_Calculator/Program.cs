using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        int result;
        int num1;
        int num2;
        int answer;
        
        Console.WriteLine("Welcome to Rizwan's Calculator Program, Please enter your name to begin!");
        name = Console.ReadLine();

        Console.WriteLine("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");

        answer = Convert.ToInt32(Console.ReadLine());

        if (answer == 1)
        {
            result = num1 + num2;
            Console.WriteLine(name + " Your answer is = " + result);
        }
        else if (answer == 2)
        {
            result = num1 - num2;
            Console.WriteLine(name + " Your answer is = " + result);
        }
        else if (answer == 3)
        {
            result = num1 * num2;
            Console.WriteLine(name + " Your answer is = " + result);
        }
        else if (answer == 4)
        {
            result = num1 / num2;
            Console.WriteLine(name + " Your answer is = " + result);
        }
        else
        {
            Console.WriteLine("Please choose a valid answer!");
        }

        Console.ReadLine();




    
    }
}