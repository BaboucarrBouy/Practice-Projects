using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correctNumber = random.Next(1, 101);
            int userGuess = 0;
            int userAttempts = 0;
            string response = "";
           

            while (userGuess != correctNumber || response == "y")
            {
                Console.WriteLine("enter your guess");
                userGuess = int.Parse(Console.ReadLine());
                userAttempts++;

                if (userGuess > correctNumber)
                   
                {
                    Console.WriteLine("too high");
                }
                else if (userGuess < correctNumber)
                {
                    Console.WriteLine("too low");
                }
               

                else
                {
                  
                    Console.WriteLine($"congrats, you guessed it in {userAttempts} attempts");
                    Console.WriteLine("would you like to play again, enter y or n");
                    response = Console.ReadLine();

                    if (response == "y")
                    { 
                        Console.WriteLine("Loading the game again");
                        Console.Clear();
                        
                    }
                    else if (response == "n")
                    {
                        Console.WriteLine(" thank you for playing");
                        break;
                    }
                    userAttempts = 0;
                    random = new Random();
                    correctNumber = random.Next(1, 101);

                }
            }
        }
    }
}
