/* Rose Silletto
 * IGME 201
 * Final Exam #1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam_1
{
    public class MyStack
    {
        public List<int> myStack = new List<int>();

        public void Push(int x)
        {
            myStack.Add(x);
        }

        public int? Pop()
        {
            if (myStack.Count > 0)
            {
                int? r = myStack[myStack.Count + 1];
                myStack.RemoveAt(myStack.Count - 1);

                return r;
            }
            else
            {
                return null;
            }
        }

        public int? Peek()
        {
            if (myStack.Count > 0)
            {
                return myStack[myStack.Count - 1];
            }
            else
            {
                return null;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
