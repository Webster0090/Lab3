using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum, newNum;

            Console.WriteLine("Hello, please enter your name:");
            string Username = Console.ReadLine();

            do
            {
                Console.WriteLine("Hello {0}, please enter a number between 1 and 100", Username);
                userNum = int.Parse(Console.ReadLine());

                newNum = userNum % 2;

                if (newNum == 0)
                {
                    if (userNum <= 25 && userNum >= 2)
                    {
                        Console.WriteLine("{0}: Even and less than 25", Username);
                    }

                    else if (userNum > 26 && userNum < 60)
                    {
                        Console.WriteLine("{0}: Even", Username);
                    }

                    else if (userNum > 60)
                    {
                        Console.WriteLine("{0}: Even", Username);
                    }

                }

                else if (newNum == 1)
                {
                    Console.WriteLine("{0}: Your number is {1} and odd", Username, userNum);

                    if (userNum > 60)
                    {
                        Console.WriteLine("Odd");
                    }
                }


                Console.WriteLine("\nWould you like to run the program again? y or n");
            }

            while (Console.ReadLine() == "y");
            {
                Console.WriteLine("Goodbye");
            }

        }
    }
}
