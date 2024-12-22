using System;

namespace CodeRefactoring
{
    public class Task4
    {
        /// <summary>
        /// In this Task, you have a Fibonacci program with some logical errors.
        /// </summary>
        public static int Fibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            int prev = 1;
            int current = 1;

            for (int i = 3; i <= n; i++)
            {
                int next = prev + current;
                prev = current;
                current = next;
            }

            return prev;
        }
    }
}
