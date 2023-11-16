using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isWorking = true;
            int i = 0;
            while (isWorking)
            {
                //this code lines are loop block codes

                Console.WriteLine("{1} - It is working now: Time is {0}", DateTime.Now.ToString(),i);
                Thread.Sleep(3000);

                i++;

                if (i == 10)
                {
                    isWorking = false;
                }
            }
        }
    }
}
