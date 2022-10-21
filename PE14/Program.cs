/* Rose Silletto
 * IGME 202
 * PE 14 Classy
 * Oct. 21 2022
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE14
{
    internal class Program
    {
        interface IPerson
        {
            void Greet();
        }

        public static void MyMethod(object myObject)
        {
            IPerson.Greet(myObject);
        }

        public class Class1 : IPerson
        {
            public void Greet(object myObject)
            {
                Console.WriteLine("Hello! Nice to meet you!");
            }

            public void MyMethod()
            {
            }
        }

         public class Class2 : IPerson
            {
              public void Greet(object MyObject)
              {
                  Console.WriteLine("Hi!!");
              }

            public void MyMethod()
            {
            }
        }

          static void Main(string[] args)
          {
            Class1 steve = new Class1();
            Class2 dave = new Class2();

            steve.MyMethod();
            dave.MyMethod();
          }
    }

}
