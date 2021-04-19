using System;

namespace CalculatorPract2
{
    public class Program
    {
        static void Main(string[] args)
        {
             int a, b;
             string action;
             Console.WriteLine("Type an expression (3 - 2 for example):");
             string[] line = Console.ReadLine().Split(' ');
             a = Int32.Parse(line[0]);
             b = Int32.Parse(line[2]);
             action = line[1];

             switch (action)
             {
                 case "+":
                     showResult(add(a, b));
                     break;
                 case "-":
                     showResult(sub(a, b));
                     break;
                 case "*":
                     showResult(mul(a, b));
                     break;
                 case "/":
                     showResult(div(a, b));
                     break;
                 default:
                     Console.WriteLine("Invalid format!");
                     break;
             }
        }

        static void showResult(int res)
        {
            Console.WriteLine("Result: " + res);
        }

        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int sub(int a, int b)
        {
            return a - b;
        }

        public static int mul(int a, int b)
        {
            return a * b;
        }

        public static int div(int a, int b)
        {
            return a / b;
        }
    }
}
