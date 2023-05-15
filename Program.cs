class Calculator
{
    static void Main(string[] args)
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;

        bool calculate = true;

        while (calculate)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("C# Calculator Program");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("\nEnter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSelect an operation: ");
            Console.WriteLine(" [+] Add");
            Console.WriteLine(" [-] Subtract");
            Console.WriteLine(" [*] Multiply");
            Console.WriteLine(" [/] Divide\n");

            Console.Write("Type in Operation: ");
            String userResponse = Convert.ToString(Console.ReadLine());

            if(userResponse.ToLower() == "add")
            {
                result = num1 + num2;

            } else if (userResponse.ToLower() == "subtract")
            {
                result = num1 - num2;

            } else if (userResponse.ToLower() == "multiply")
            {
                result = num1 * num2;

            } else if (userResponse.ToLower() == "divide") {

                result = num1 / num2;

            } else
            {
                Console.WriteLine("Invalid Operation");
            }

            Console.WriteLine("Result: " + result);

            Console.WriteLine("\nWould you like to continue ?");
            Console.WriteLine("[Y] Yes");
            Console.WriteLine("[N] No\n");

            Console.Write("Type in Operation: ");
            userResponse = Convert.ToString(Console.ReadLine());

            if (userResponse.ToLower() == "no") calculate = false;

        }
        Console.WriteLine("\n----------------------------------------------");
        Console.WriteLine("Thanks for calculating!!");
        Console.WriteLine("----------------------------------------------");
        Console.ReadKey();
    }
}
