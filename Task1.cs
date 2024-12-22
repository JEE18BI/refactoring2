using System;

namespace CodeRefactoring
{
    /// <summary>
    /// In this example, you have a simple login system that allows a maximum of three login attempts.
    /// If the user enters an incorrect password, they have two remaining attempts before the 
    /// account gets locked.
    /// This task covers:
    /// 1. Introduce Explaining Variable
    /// 2. Replace With Constant
    /// 3. Replace Conditional With Guard Clause
    /// </summary>
    public class Task1
    {
        public int CurrentAttempt { get; private set; } = 0;
        public bool IsLockedOut { get; private set; }

        public bool Login(string password)
        {
            if (!IsLockedOut)
            {
                if (password == "password123")
                {
                    Console.WriteLine("Login successful!");
                    return true;
                }
                else
                {
                    CurrentAttempt++;

                    // check the remaining attempts
                    if (3 - CurrentAttempt > 0)
                    {
                        //print the remaining attempts
                        Console.WriteLine("Invalid password. Remaining attempts: " + (3 - CurrentAttempt));
                    }
                    else
                    {
                        IsLockedOut = true;
                        Console.WriteLine("Invalid password. Account locked.");
                    }
                    return false;
                }
            }
            return false;
        }
    }
}
