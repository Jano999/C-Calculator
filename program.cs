using System;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write first number and press enter:");
            double number1;
            while(!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.WriteLine("write first number and press enter:");
            }

            Console.WriteLine("write second number and press enter:");
            double number2;
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.WriteLine("write second number and press enter:");
            }

            Console.WriteLine("choose operation and press enter:");
            Console.WriteLine("\t+");
            Console.WriteLine("\t-");
            Console.WriteLine("\t*");
            Console.WriteLine("\t/");
            string operation = Console.ReadLine();

            Console.Write("result is: ");
            switch (operation)
            {
                case "+":
                    Console.WriteLine(number1 + number2);
                    break;
                case "-":
                    Console.WriteLine(number1 - number2);
                    break;
                case "*":
                    Console.WriteLine(number1 * number2);
                    break;
                case "/":
                    while(number2 == 0)
                    {
                        Console.WriteLine("can not divide by 0 write second " +
                            "number again and press enter:");
                        while (!double.TryParse(Console.ReadLine(), out number2))
                        {
                            Console.WriteLine("write second number and press enter:");
                        }
                    }
                    Console.WriteLine(number1 / number2);
                    break;
            }
        }
    }
}
