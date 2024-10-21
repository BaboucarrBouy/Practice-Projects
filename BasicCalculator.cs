using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int OperationSelected = 0;
            int num1 = 0;
            int num2 = 0;
            bool runapp = true;
            string operation;
            List <string> calculationHistory = new List<string> ();

            while (runapp)
            {
                if (OperationSelected != 5)
                {
                    Console.WriteLine("CALCULATOR");
                    Console.WriteLine($@" Please choose a number between number 1-5 to perform and operation
             1. ADD
             2. MINUS
             3. MULTIPLY
             4. DIVIDE 
             5. EXIT THE GAME
                ");
                    OperationSelected = int.Parse(Console.ReadLine());
                    switch (OperationSelected)
                    {
                        case 1:
                            operation = "+";
                            Enterbothnumbers();
                            result = num1 + num2;
                            Console.WriteLine($"The result of {num1} + {num2} is: {result} ");
                            calculationHistory.Add($" The result of {num1} {operation} {num2} is: {result}");
                            
                            
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 2:
                            operation = "-";
                            Enterbothnumbers();
                            result = num1 - num2;
                            Console.WriteLine($"The result of {num1} - {num2} is: {result} ");
                            calculationHistory.Add($" The result of {num1} {operation} {num2} is: {result}");

                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 3: 
                            operation = "/";
                            Enterbothnumbers();
                            result = num1 * num2;
                            Console.WriteLine($"The result of {num1} * {num2} is: {result} ");
                            calculationHistory.Add($" The result of {num1} {operation} {num2} is: {result}");

                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case 4:
                            operation = "*";
                            Divide(ref num1, ref num2, out result);
                            Console.WriteLine($"The result of {num1} / {num2} is: {result} ");
                            calculationHistory.Add($" The result of {num1} {operation} {num2} is: {result}");

                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case 5:
                            Console.WriteLine(" Calculation History");
                            foreach (string calculation in calculationHistory)
                            {
                                Console.WriteLine(calculation);
                            }
                            Console.WriteLine(" Goodbye");
                            runapp = false;
                            break;
                    }
                }


                if (OperationSelected > 5 || OperationSelected <= 0)
                {
                    Console.WriteLine("You can only choose a number between 1 -5");
                    Console.ReadKey();
                    Console.Clear();
                }
            }





            void Enterbothnumbers()

            {
                Console.WriteLine("Enter the First Number");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Second Number");
                num2 = int.Parse(Console.ReadLine());

            }

        }

        public static int Divide(ref int num1, ref int num2, out int results)
        {
            Console.WriteLine("Enter the First Number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Second Number");
            num2 = int.Parse(Console.ReadLine());

            while (num2 == 0)
            {
                Console.WriteLine(" You Cannot divide by 0");
                Console.WriteLine("Enter the Second Number");
                num2 = int.Parse(Console.ReadLine());
            }
            results = num1 / num2;
            return results;


        }
    }
}
