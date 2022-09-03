/* Rose Silletto
*  IGME-201 PE4 Flow Control
*  September 3, 2022
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int? var1 = null;
            int? var2 = null;

            start:

            Console.WriteLine("Enter a number: ");
            var1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            var2 = Convert.ToInt32(Console.ReadLine());

            if ((var1 > 10) || (var2 > 10))
            {
                Console.WriteLine("yay! your numbers work");
            }
            else
            {
                Console.WriteLine("nooo. pick better numbers");

                goto start;
            }

        }
    }

}