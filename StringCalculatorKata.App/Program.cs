using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Calculator..enter your numbers...");
            var numbers = Console.ReadLine();

            var calculator = new StringCalculator();
            var retunValue = calculator.Sum(numbers);
            Console.WriteLine(retunValue);

            // Keep the console window open so the use can see the response.  
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
