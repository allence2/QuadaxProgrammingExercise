using System;
using System.Text;

namespace QuadaxProgrammingExerciseChadAllen
{
    class Program
    {
        static int Main(string[] args)
        {
            int answer = 0;

            StringBuilder builder = new StringBuilder();
            Random rnd = new Random();

            // Randomly generate number with each digit between 1-6
            builder.Append(rnd.Next(1, 7));
            builder.Append(rnd.Next(1, 7));
            builder.Append(rnd.Next(1, 7));
            builder.Append(rnd.Next(1, 7));
            answer = Int32.Parse(builder.ToString());

            return 0;
        }
    }
}
