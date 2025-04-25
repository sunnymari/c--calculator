using System;
using System.Data;

namespace MyCalculator 
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1=0;
            double num2=0;
            double result =0;


            Console.WriteLine("Calculator Program");

            Console.WriteLine("Enter number 1");
            num1= Convert.ToDouble(Console.ReadLine());
             
            Console.WriteLine("Enter number 1");
            num2= Convert.ToDouble(Console.ReadLine());
             

             Console.WriteLine("Enter an option");

             Console.WriteLine("+ : Add ");

             Console.WriteLine("  - : Subtract");

             Console.WriteLine(" * : Multiply");

             Console.WriteLine("/ : Divide ");

             switch (Console.ReadLine())
             {
                 case "+":
                 result= num1+num2;
                 Console.WriteLine($"Your result is:   {num1}+ {num2} = " +result );
                 break;

                 case "-":
                 result= num1+num2;
                 Console.WriteLine($"Your result is:   {num1}+ {num2} = " +result );
                 break;

                 case " * ":
                 result= num1+num2;
                 Console.WriteLine($"Your result is:   {num1}+ {num2} = " +result );
                 break;

                 case "/":
                 result= num1+num2;
                 Console.WriteLine($"Your result is:   {num1}+ {num2} = " +result );
                 break;

                default:
                 Console.WriteLine("Your result is invalid");
                break;

             }
            Console.ReadKey();
        }

    }
}