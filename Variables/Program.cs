﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";

            Console.WriteLine(name);
            Console.WriteLine("The lenght of the variable name is : {0}",name.Length);
            Console.WriteLine("The uppercase version of the variable name is : {0}", name.ToUpper());
            Console.WriteLine("The lowercase version of the variable name is : {0}", name.ToLower());
            Console.WriteLine("The sub string version of the variable name is : {0}", name.Substring(2));


            int myNum = 10;
            Console.WriteLine(myNum);

            myNum += 5;
            Console.WriteLine(myNum);

            double myDoubleNumber = 5.99D;
            char myChar = 'C';
            bool myBool = true;
            string myText = "text";

            Console.WriteLine(myDoubleNumber);
            Console.WriteLine(myChar);
            Console.WriteLine(myBool);
            Console.WriteLine(myText);
           

            Console.ReadKey();    
        }
    }
}
