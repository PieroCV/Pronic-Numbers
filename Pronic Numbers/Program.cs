using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronic_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number;
                Console.WriteLine("Enter a number to proceed:");
                try { number = Convert.ToInt32(Console.ReadLine()); IsPronic(number); }
                catch (Exception) { Console.WriteLine("Invalid input"); }
                ;
            } 

        }

        static void IsPronic(int number, bool state = true, int original = 0)
        {
            if (state)
                original = number;

            if (!(number == 0))
            {
                int mult = number * (number - 1);
                if (original == mult)
                    Console.WriteLine(true);
                else { IsPronic(number - 1,false,original); }
                    
            }

            else
            {
                Console.WriteLine(false);
            }
        } 
    }
}
