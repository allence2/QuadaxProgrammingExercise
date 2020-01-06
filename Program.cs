using System;
using System.Text;

namespace QuadaxProgrammingExerciseChadAllen
{
    class Program
    {
        /**
         * Puts the digits from the answer into an array to be compared againsts the user's input
         */
        private static int[] numberToArray(int num)
        {
            int[] correctDigits = new int[4];
            int count = 3;
            while (num != 0)
            {
                correctDigits[count] = num % 10;
                num /= 10;
                count--;
            }
            return correctDigits;
        }

        /**
         * Creates a string based on how closely correct the user input is to the answer
         */
        public static string compareDigitArrays(int[] correct, int[] user)
        {
            StringBuilder correction = new StringBuilder();
            for (int i = 0; i < user.Length; i++)
            {
                if (user[i] == correct[i])
                {
                    correction.Append("+");
                }
                else if (Array.IndexOf(correct, user[i]) > -1)
                {
                    correction.Append("-");
                }
                else
                {
                    correction.Append(" ");
                }
            }
            return correction.ToString();
        }

        /**
         * Main method
         */
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

            // Calls function to put the correct answer into an array
            int[] correctDigits = numberToArray(answer);

            // User inputs a number until they guess the correct answer
            while (count > 0)
            {
                Console.WriteLine("Enter a 4 digit number with digits being 1-6: (Tries left = " + count + ")");
                int userInput;

                // Check if user correctly entered a 4 digit number
                if (int.TryParse(Console.ReadLine(), out userInput) && userInput > 999 && userInput < 10000)
                {
                    count--;
                    int[] userDigits = numberToArray(userInput);
                    string corrections = compareDigitArrays(correctDigits, userDigits);
                    
                    // If the input from the user equals the answer the user wins 
                    if (corrections.Equals("++++"))
                    {
                        Console.WriteLine("Correct!! The answer is " + userInput + " and was found in " + (10 - count) + " tries");
                        break;
                    }
                    Console.WriteLine("Incorrect answer = (" + corrections + ")");
                }
                else
                {
                    Console.WriteLine("Please enter a 4 digit number");
                }
            }
    
            return 0;
        }
    }
}
