internal class Calculator
{
       static void Main(string[] args)
    {
        int choice;
        for(int i=0; i<10; i++)
        {    
        Console.WriteLine("Welcome to the Simple Calculator");
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        Console.WriteLine("3. Multiply");
        Console.WriteLine("4. Divide");
        Console.WriteLine("5. Modulus");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
if (choice >= 1 && choice <= 5)
{
            Console.Write("Enter first number: ");
           double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
           double second = Convert.ToDouble(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{first} + {second} = {first + second}");
                    break;
                case 2:
                    Console.WriteLine($"{first} - {second} = {first - second}");
                    break;
                case 3:
                    Console.WriteLine($"{first} * {second} = {first * second}");
                    break;
                case 4:
                    if (second != 0)
                    {
                        Console.WriteLine($"{first} / {second} = {first / second}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                case 5:
                    Console.WriteLine($"{first} % {second} = {first % second}");
                    break;               
            }
                  }
        else if (choice == 6)
        {
            Console.WriteLine("Exiting the Simple Calculator....");
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice..");
            break;
    }
    }
    }
}
    
