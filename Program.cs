using System;
using System.Text;

namespace QuadaxProgrammingExerciseChadAllen
{
    class Program
    {
        static int Main(string[] args)
        {
            int answer = 0, count = 10;

            StringBuilder builder = new StringBuilder();
            Random rnd = new Random();

            // Randomly generate number with each digit between 1-6
            builder.Append(rnd.Next(1, 7));
            builder.Append(rnd.Next(1, 7));
            builder.Append(rnd.Next(1, 7));
            builder.Append(rnd.Next(1, 7));
            answer = Int32.Parse(builder.ToString());


            // User inputs a number until they guess the correct answer
            while (count > 0)
            {
                Console.WriteLine("Enter a Number: (Tries left = " + count + ")");
                int userInput;

                // Check if user correctly entered a 4 digit number
                if(int.TryParse(Console.ReadLine(), out userInput) && userInput > 999 && userInput < 10000)
                {
                    
                }
                Console.WriteLine("Please enter a 4 digit number");
            }
    
            return 0;
        }
    }
}
