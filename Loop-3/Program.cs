using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<string>() { 
                "Aslı",
                "Berkay",
                "Mehmet Berke",
                "Ogulcan",
                "Sadık",
                "Selin"
                
            };

            foreach(String name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
