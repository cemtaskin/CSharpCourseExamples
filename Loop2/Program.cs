using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("How many random numbers do u wnat to generate?");
            int numberCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numberCount; i++)
            {
                Console.WriteLine("{0}. number : {1}", (i + 1),random.Next(101));
            }
            Console.ReadLine();
        }
        
    }
}
