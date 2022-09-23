/* Rose Silletto
 * Unit Test 1, #12
 * September 23 2022
 */

using System.IO;
using System;

class Program
{
    static void Main()
    {
         string sName;
         double dSalary = 30000;

        Console.Write("Enter your name: ");
        sName = Console.ReadLine();

        static bool GiveRaise( string name, ref double salary)
        {
            if( name.ToLower() == "rose")
            {
                salary += 19999.99;
                return true;
            }
            else
            {
                return false;
            }
        }

        GiveRaise(sName, ref dSalary);

        if(GiveRaise(sName, ref dSalary) == true)
        {
            Console.WriteLine("Congrats! YOU GOT A RAISE!");
        }

        Console.WriteLine("Your salary is: " + dSalary);

    }

}
