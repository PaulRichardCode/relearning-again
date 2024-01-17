using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relearning_again
{
    class Program
    {
      static void Main()
        {
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
            Console.ReadLine();
          



            Console.ReadKey();
        }

        
    }

}
