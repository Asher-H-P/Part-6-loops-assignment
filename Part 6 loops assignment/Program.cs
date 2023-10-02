using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_6_loops_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Please input a number for one of the following.");
                Console.WriteLine("1. Prompter");
                Console.WriteLine("2. Percent Passing");
                Console.WriteLine("3. Odd Sum");
                Console.WriteLine("4. Random Numbers");
                Console.WriteLine("5. Dice Game");
                Console.WriteLine("6. Quit");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Prompter();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (menu == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Percentpassing();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (menu == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Oddsum();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (menu == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Randomnumbers();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (menu == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Dicegame();
                    Console.WriteLine();
                    Console.WriteLine();
                }
                else if (menu == 6)
                {
                    done = true;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Goodbye.");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
        public static void Prompter()
        {
            int min, max, between;
            string redo;
            bool done, btwn;
            done = false;
            btwn = false;
            while (!done)
            {
                btwn = false;
                Console.WriteLine("Please give me a minimum and a maximum number.");
                min = Convert.ToInt32(Console.ReadLine());
                max = Convert.ToInt32(Console.ReadLine());
                if (min < max)
                {
                    while (!btwn)
                    {
                        Console.WriteLine($"Please pick a number between {min} and {max}");
                        between = Convert.ToInt32(Console.ReadLine());
                        if (between >= min && between <= max)
                        {
                            Console.WriteLine($"You chose {between}. Good choise.");
                            Console.WriteLine("Would you like to do it again? (Y/N)");
                            redo = Console.ReadLine().ToUpper();
                            if (redo == "Y")
                            {
                                btwn = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (redo != "Y")
                            {
                                btwn = true;
                                done = true;
                                Console.WriteLine("Goodbye.");
                            }
                        }
                        else if (between < min || between > max)
                        {
                            Console.WriteLine("INVALID");
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                }
                else if (min > max)
                {
                    while (!btwn)
                    {
                        Console.WriteLine($"Please pick a number between {max} and {min}");
                        between = Convert.ToInt32(Console.ReadLine());
                        if (between <= min && between >= max)
                        {
                            Console.WriteLine($"You chose {between}. Good choise.");
                            Console.WriteLine("Would you like to do it again? (Y/N)");
                            redo = Console.ReadLine().ToUpper();
                            if (redo == "Y")
                            {
                                btwn = true;
                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            else if (redo != "Y")
                            {
                                btwn = true;
                                done = true;
                                Console.WriteLine("Goodbye.");
                            }
                        }
                        else if (between > min || between < max)
                        {
                            Console.WriteLine("INVALID");
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error!");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
        public static void Percentpassing()
        {
            int scr1, scr2, scr3;
            string redo;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Please input three scores between 0-100.");
                scr1 = Convert.ToInt32(Console.ReadLine());
                scr2 = Convert.ToInt32(Console.ReadLine());
                scr3 = Convert.ToInt32(Console.ReadLine());
                if (scr1 >= 0 && scr1 <= 100 && scr2 >= 0 && scr2 <= 100 && scr3 >= 0 && scr3 <= 100)
                {
                    if ((scr1 >= 70 && scr2 <= 69 && scr3 <= 69) || (scr1 <= 69 && scr2 >= 70 && scr3 <= 69) || (scr1 <= 69 && scr2 <= 69 && scr3 >=70))
                    {
                        Console.WriteLine($"With the scores {scr1}, {scr2}, & {scr3}, 33% are over 70%");
                        Console.WriteLine();
                        Console.WriteLine("Would you like to do it again? (Y/N)");
                        redo = Console.ReadLine().ToUpper();
                        if (redo == "Y")
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        else if (redo != "Y")
                        {
                            done = true;
                            Console.WriteLine("Goodbye.");
                        }
                    }
                    else if ((scr1 >= 70 && scr2 >= 70 && scr3 <= 69) || (scr1 <= 69 && scr2 >= 70 && scr3 >= 70) || (scr1 >= 70 && scr2 <= 69 && scr3 >= 70))
                    {
                        Console.WriteLine($"With the scores {scr1}, {scr2}, & {scr3}, 67% are over 70%");
                        Console.WriteLine();
                        Console.WriteLine("Would you like to do it again? (Y/N)");
                        redo = Console.ReadLine().ToUpper();
                        if (redo == "Y")
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        else if (redo != "Y")
                        {
                            done = true;
                            Console.WriteLine("Goodbye.");
                        }
                    }
                    else if (scr1 >= 70 && scr2 >= 70 && scr3 >= 70)
                    {
                        Console.WriteLine($"With the scores {scr1}, {scr2}, & {scr3}, 100% are over 70%");
                        Console.WriteLine();
                        Console.WriteLine("Would you like to do it again? (Y/N)");
                        redo = Console.ReadLine().ToUpper();
                        if (redo == "Y")
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        else if (redo != "Y")
                        {
                            done = true;
                            Console.WriteLine("Goodbye.");
                        }
                    }
                    else if (scr1 <= 69 && scr2 <= 69 && scr3 <= 69)
                    {
                        Console.WriteLine($"With the scores {scr1}, {scr2}, & {scr3}, 0% are over 70%");
                        Console.WriteLine();
                        Console.WriteLine("Would you like to do it again? (Y/N)");
                        redo = Console.ReadLine().ToUpper();
                        if (redo == "Y")
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        else if (redo != "Y")
                        {
                            done = true;
                            Console.WriteLine("Goodbye.");
                        }
                    }
                }
                else if (scr1 < 0 || scr1 > 100 || scr2 < 0 || scr2 > 100 || scr3 < 0 || scr3 > 100)
                {
                    Console.WriteLine("INVALID SCORE!");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
        public static void Oddsum()
        {
            
        }
        public static void Randomnumbers()
        {
            Random generator = new Random();
            int min, max;
            Console.WriteLine("Please put in a minimum and a maximum number.");
            min = Convert.ToInt32(Console.ReadLine());
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            if (min < max)
            {
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
                Console.WriteLine(generator.Next(min, (max + 1)));
            }
            else if (min > max)
            {
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
                Console.WriteLine(generator.Next(max, (min + 1)));
            }
        }
        public static void Dicegame()
        {
            Random generator = new Random();
            int money, bet, die1, die2, guess;
            money = 20;
            bool done = false;
            while (money > 0)
            {
                done = false;
                Console.WriteLine($"You have ${money}. How much would you like to bet?");
                bet = Convert.ToInt32(Console.ReadLine());
                if (bet >= 1 && bet <= money)
                {
                    while (done == false)
                    {
                        Console.WriteLine("What number do you want to bet on? (2-12)");
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        if (guess >= 2 && guess <= 12)
                        {
                            Console.WriteLine("I'll roll the dice.");
                            die1 = generator.Next(1, 7);
                            die2 = generator.Next(1, 7);
                            Console.WriteLine(die1);
                            Console.WriteLine(die2);
                            Console.WriteLine($"That equals {die1 + die2}.");
                            Console.WriteLine();
                            if (guess == (die1 + die2))
                            {
                                Console.WriteLine($"Congrats! You now have ${money + bet}!");
                                Console.WriteLine();
                                money = money + bet;
                                done = true;
                            }
                            else if (guess != (die1 + die2))
                            {
                                Console.WriteLine($"Sorry. You now have ${money - bet}.");
                                Console.WriteLine();
                                money = money - bet;
                                done = true;
                            }
                            else
                            {
                                Console.WriteLine("ERROR!");
                                Console.WriteLine("As compensation here's $5");
                                Console.WriteLine();
                                money = money + 5;
                                done = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine("INVALID RESPONSE.");
                            Console.WriteLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("INVALID RESPONSE.");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("You're out of money. Goodbye.");
        }
    }
}
