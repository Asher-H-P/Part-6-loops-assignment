using System;
using System.Collections.Generic;
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
                    Console.WriteLine("Goodbye");
                }
            }
        }
        public static void Prompter()
        {

        }
        public static void Percentpassing()
        {

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
            while (money > 0 && !done)
            {
                Console.WriteLine("How much would you like to bet?");
                bet = Convert.ToInt32(Console.ReadLine());
                if (bet >= 1 || bet <= money)
                {
                    Console.WriteLine("What number do you want to bet on? (2-12)");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess >= 2 || guess <= 12)
                    {
                        Console.WriteLine("I'll roll the dice.");
                        die1 = generator.Next(1, 7);
                        die2 = generator.Next(1, 7);
                        Console.WriteLine(die1);
                        Console.WriteLine(die2);
                        Console.WriteLine($"That equals {die1 + die2}.");
                        if (guess == (die1 + die2))
                        {
                            Console.WriteLine($"Congrates! You now have ${money + bet}!");
                            money = money + bet;
                        }
                        else
                        {
                            Console.WriteLine($"Too bad! You now have ${money - bet}");
                            money = money - bet;
                            if (money <= 0)
                            {
                                done = true;
                                Console.WriteLine("Looks like you're out of money. Bye!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("I'll round that to 6.");
                        guess = 2;
                        Console.WriteLine("I'll roll the dice.");
                        die1 = generator.Next(1, 7);
                        die2 = generator.Next(1, 7);
                        Console.WriteLine(die1);
                        Console.WriteLine(die2);
                        Console.WriteLine($"That equals {die1 + die2}.");
                        if (guess == (die1 + die2))
                        {
                            Console.WriteLine($"Congrates! You now have ${money + bet}!");
                            money = money + bet;
                        }
                        else
                        {
                            Console.WriteLine($"Too bad! You now have ${money - bet}");
                            money = money - bet;
                            if (money <= 0)
                            {
                                done = true;
                                Console.WriteLine("Looks like you're out of money. Bye!");
                            }
                        }
                    }
                }
            }
        }
    }
}
