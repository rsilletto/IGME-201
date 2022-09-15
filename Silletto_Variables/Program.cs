/* Rose Silletto
*  IGME-201 PE3 Variables and Expressions
*  August 31, 2022
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
            /* Write a console application that obtains four int values from the user and
             * displays the product. Hint: you may recall that the Convert.ToDouble() 
             * command was used to covert the input from the console to a double; 
             * the equivalent command to convert from a string to an int is 
             * Convert.ToInt32()
             */

            int num1;
            int num2;
            int num3;
            int num4;

            Console.WriteLine("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            int numResult = num1 * num2 * num3 * num4;

            Console.WriteLine("Your result is: " + numResult);

        }

    }

}