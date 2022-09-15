/* Rose Silletto
*  IGME-201 PE8 More Variables Part 2
*  September 14, 2022
*/

using System;
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

            /*
             * Write a console application that accepts a string from the user
             * and outputs a string with the characters in reverse order.
             */

            string? userInput;

            Console.WriteLine("Write something: ");
            userInput = Console.ReadLine();


            for(int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
                
            }

            Console.Write(" \n"); // for spacing
        }
    }
}
