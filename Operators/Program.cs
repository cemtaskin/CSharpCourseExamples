using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum1 = 100 + 50;
            //int sum2 = sum1 + 250;
            //int sum3 = sum2 + sum2;

            //Console.WriteLine(sum1);
            //Console.WriteLine(sum2);
            //Console.WriteLine(sum3);

            Console.WriteLine("Enter the first number : ");
            String num1Value = Console.ReadLine();

            int num1 = Convert.ToInt32(num1Value);

            Console.WriteLine("Enter the second number : ");
            String num2Value = Console.ReadLine();

            int num2 = Convert.ToInt32(num2Value);

            Console.WriteLine("The addition of two numbers is : {0}", num1 + num2);
            Console.WriteLine("The substraciton of two numbers is : {0}", num1 - num2);
            Console.WriteLine("The multiplication of two numbers is : {0}", num1 * num2);
            Console.WriteLine("The divison of two numbers is : {0}", num1 /  num2);
            Console.WriteLine("The modus of two numbers is : {0}", num1 % num2);
            Console.WriteLine("The increment of first number is : {0}", (++num1));
            Console.WriteLine("The decrement of second numbers is : {0}", (--num2));

            num1 *= 3;
            Console.WriteLine("The multiplication assignment opertaror used on first number is : {0}", num1);










            Console.ReadKey();

        }
    }
}
