using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int customaztionselected = 0;
            int drinkselected = 0;
            int snackselected = 0;
            string answerformorecust = "";
            string answerfordrinks = "";
            string answerforcust = "";
            string answerforsnacks = "";


            while (drinkselected <= 0 || drinkselected > 3)
            {
                Console.WriteLine($@" please choose a drink, Enter 1, 2 or 3
                    1.coffe
                    2. Tea
                    3. smoothie");


                drinkselected = int.Parse(Console.ReadLine());

                switch (drinkselected)
                {
                    case 1:
                        answerfordrinks = " coffee";
                        break;
                    case 2:
                        answerfordrinks = " Tea";
                        break;
                    case 3:
                        answerfordrinks = " Smoothie";
                        break;

                }

                if (drinkselected <= 0 || drinkselected > 3)
                {
                    Console.WriteLine(" INVALID the number has to be betweem 1 and 3");
                }
            }

            while (customaztionselected <= 0 || customaztionselected > 3 || answerformorecust == "yes")
            {
                Console.WriteLine($@" please 1, 2 or 3 for customization)
                    1.milk
                    2. sugar
                    3. Jam");

                customaztionselected = int.Parse(Console.ReadLine());

                if (customaztionselected <= 0 || customaztionselected > 3)
                {
                    Console.WriteLine(" INVALID the number has to be betweem 1 and 3");


                    switch (customaztionselected)
                    {
                        case 1:
                            answerforcust = "milk";
                            break;
                        case 2:
                            answerforcust = "suagr";
                            break;
                        case 3:
                            answerforcust = " Jam";
                            break;
                    }
                }

                if (customaztionselected > 0 && customaztionselected <= 3)
                {
                    Console.WriteLine(" would you like to add more customisatiom, enter yes or no");
                    answerformorecust = Console.ReadLine().ToLower();


                    if (answerformorecust == "yes")
                    {
                        Console.WriteLine(" thank you for added service");
                    }
                    else if (answerformorecust == "no")
                    {
                        Console.WriteLine("no addition selected, onto snack");

                        answerforcust = "No Additions";
                    }

                }
            }

            while (snackselected <= 0 || snackselected > 3)
            {
                Console.WriteLine($@" please choose a Snack, enter 1, 2 or 3
                    1.Muffin
                    2. Cookie
                    3. Brownie");

                snackselected = int.Parse(Console.ReadLine());



                if (snackselected <= 0 || snackselected > 3)
                {
                    Console.WriteLine(" INVALID the number has to be betweem 1 and 3");
                }

                switch (snackselected)

                {
                    case 1:
                        answerforsnacks = " muffin";
                        break;
                    case 2:
                        answerforsnacks = "cookie";
                        break;
                    case 3:
                        answerforsnacks = " brownie";
                        break;
                }


            }

            Console.WriteLine($@" order review
                        you have selected  {answerfordrinks} 
                        with {answerforcust}
                        and with a {answerforsnacks}
                        

                ");
        }
    }
}
