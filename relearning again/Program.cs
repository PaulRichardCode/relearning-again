﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace relearning_again
{

   
    class Program
    {
      static void Main()
        {
            int num1;
            int num2;
            string answer;

            Console.WriteLine("welcome to the calculator programme");
            Console.WriteLine("Please enter your first number");

           num1 =  Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(".......");
            Thread.Sleep(3000);



            Console.ReadKey();
        }

        
    }

}
