using System;

namespace Interview
{
    class Problems
    {
        static void Main(string[] args)
        {
            //InterviewPG();
            //InterviewPH();
            //InterviewPI();
            //InterviewPR();
            //InterviewPS();
        }

        private static void InterviewPG()
        {

            int number = Utils.GetNumber("How big do you want the square? ");
            string space = "".PadRight(number * 2 - 3);
            for (int i = 0; i < number; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("*");
                Console.Write(space);
                Console.WriteLine("*");
            }
            for (int i = 0; i < number; i++)
            {
                Console.Write("* ");
            }
        }

        private static void InterviewPH()
        {
            while (true)
            {
                int number = Utils.GetNumber("How tall do you want the triangle? ");
                string pad = "";
                for (int i = 1; i <= number; i++)
                {
                    Console.Write(pad.PadLeft(number - i));
                    for (int j = 0; j < i *2 - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                string again = Utils.GetInput("Would you like to do another, 'yes' or 'no'? ");
                if (again == "yes")
                {
                    continue;
                }
                else if (again == "no")
                {
                    break;
                }
            }
        }

        private static void InterviewPI()
        {
            string phrase = Utils.GetInput("Enter a sentance: ");
            string[] words = phrase.Split(" ");
            int bigWordLength = words[0].Length;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > bigWordLength)
                {
                    bigWordLength = words[i].Length;
                }
            }
            for (int i = 0; i < bigWordLength + 2; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            foreach (var word in words)
            {
                Console.Write("*");
                Console.Write(word.PadLeft(bigWordLength, '.').PadRight(bigWordLength, '.'));
                Console.WriteLine("*");
            }
            for (int i = 0; i < bigWordLength + 2; i++)
            {
                Console.Write("*");
            }
        }

        private static void InterviewPR()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " = Fizz/Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " = Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " = Buzz");
                }
                else
                {
                    Console.WriteLine(i + " = #");
                }
            }
        }

        private static void InterviewPS()
        {
            int total = 0;
            for (int num = 0; num < 1000; num++)
            {
                if (num % 3 == 0 || num % 5 == 0)
                {
                    total += num;
                }
            }
            int answer = total;
            Console.WriteLine("The total for all the numbers divisible by 3 or 5 eqauls " + answer);
        }


    }
}
