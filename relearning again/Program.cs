using System;
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
            string[] text = File.ReadAllLines("questions.txt");
            int sleepTime = 3000;
            Thread.Sleep(sleepTime);

            for(int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text[i]);
            }

            List<string> options = new List<string>();
            options.Add("Cat");
            options.Add("Lion");
            options.Add("Tiger");

            Console.WriteLine("what is the name of the largest cat?");
            int number = 1;
            for(int i = 0; i < options.Count; i++)
            {
                options[i] = $"{number}. {options[i]}";

                number++;
            }


            foreach(string option in options) {
                Console.WriteLine(option);
            }
            string userInput = Console.ReadLine();

            try
            {
                int userValue = int.Parse(userInput);

                Console.WriteLine("you have entered: " + userValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }




            Console.ReadKey();
        }

        
    }

}
