/* Rose Silletto
 * Unit Test 1, #4
 * September 23 2022
 */

using System.IO;
using System;

class Program
{
    static void Main()
    {
        
        // question picker
        string numQuestion = "0";

        // variable to check if they want to play again
        string tryAgain = "";


    // label to return to if they want to play again
    start:

        Console.Write("Choose your question (1-3): ");
        numQuestion = Console.ReadLine();

        // display the prompt for the question they picked

        if (numQuestion == "1")
        {
            Console.Write("What is your favorite color?");
            Console.WriteLine(" ");
        }
        else if (numQuestion == "2")
        {
            Console.WriteLine("What is the answer to life, the universe, and everything?");
            Console.WriteLine(" ");
        }
        else
        {
            Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
        }
        // input answer
        string userAnswer = Console.ReadLine();

        // display result and correct answer if they got it wrong

        if (numQuestion == "1" && userAnswer == "black") // question 1 right
        {
            Console.WriteLine("Well done!");
        }
        else if (numQuestion == "1" && userAnswer != "black") // question 1 wrong
        {
            Console.WriteLine("Wrong! The answer is: black");
        }
        else if (numQuestion == "2" && userAnswer == "42") // question 2 right
        {
            Console.WriteLine("Well done!");
        }
        else if (numQuestion == "2" && userAnswer != "42") // question 2 wrong
        {
            Console.WriteLine("Wrong! The answer is: 42");
        }
        else if (numQuestion == "3" && userAnswer == "What do you mean? African or European swallow?") // question 3 right
        {
            Console.WriteLine("Well done!");
        }
        else if (numQuestion == "3" && userAnswer != "What do you mean? African or European swallow?") // question 3 wrong
        {
            Console.WriteLine("Wrong! The answer is: What do you mean? African or European swallow?");
        }
        else
        {
            Console.WriteLine("Try again");
        }


        do
        {
            // ask if they want to play again
            Console.Write("Do you want to play again? ");

            tryAgain = Console.ReadLine();

            if (tryAgain.ToLower().StartsWith("y"))
            {
                goto start;
            }
            else if (tryAgain.ToLower().StartsWith("n"))
            {
                break;
            }
        } while (true);
    }
}
