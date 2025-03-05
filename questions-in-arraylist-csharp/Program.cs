using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questions_in_arraylist_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter the number of questions they want to input.
                Console.WriteLine("Please enter the number of question(s): ");
                int NumberOfQuestions = int.Parse(Console.ReadLine());

                // Declare an ArrayList to dynamically store the questions entered by the user.
                ArrayList Questions = new ArrayList();

                // Loop through to collect all the questions from the user.
                for (int x = 0; x < NumberOfQuestions; x++)
                {
                    Console.WriteLine($"Enter question number {x + 1}: "); // Prompt for each question.
                    Questions.Add(Console.ReadLine()); // Add the question to the ArrayList.
                }

                // Display all the questions that the user has entered.
                Console.WriteLine($"\nQuestions entered:\n");

                // Loop through the ArrayList to print each question in order.
                for (int x = 0; x < Questions.Count; x++)
                {
                    Console.WriteLine($"Question {x + 1}: {Questions[x]}"); // Display each question.
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that might occur (e.g., invalid input).
                Console.WriteLine($"Error Message: {ex.Message}");
            }
        }
    }
}
