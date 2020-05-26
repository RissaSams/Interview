using System;
using System.Linq;

namespace Interview
{
    class Problems
    {
        static void Main(string[] args)
        {
            //ProblemA();
            //ProblemB();
            //ProblemC();
            //ProblemD();
            //ProblemE();
            //ProblemF():
            //ProblemG();
            //ProblemH(); 
            //ProblemI();
            //ProbelmJ();
            //ProblemK();
            //ProblemL();
            //ProblemM();
            //ProblemN();
            //ProblemO();
            //ProblemP();
            //ProblemQ();
            //ProblemR();
            //ProblemS();
            //ProblemT();
            //ProblemU();
            //ProblemV();
            //ProblemW();
            //Problemx();
        }

        private static void ProblemA()
        {
            int num1, num2;
            num1 = Utils.GetNumber("Number 1: ");
            num2 = Utils.GetNumber("Number 2: ");

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is the bigger than " + num2);
            }
            else
            {
                Console.WriteLine(num2 + " is bigger than " + num1);
            }
        }

        private static void ProblemB()
        {
            int[] numbers = {349, 340, 49, 529, 23, 23, 53, 64};
            var biggest = numbers.Max();
            var smallest = numbers.Min();
            var ave = numbers.Average();
            var total = numbers.Aggregate((number, total) => total += number);

            Console.WriteLine("The largest number is " + biggest);
            Console.WriteLine("The smallest number is " + smallest);
            Console.WriteLine("The average is " + ave);
            Console.WriteLine("The total is " + total);

        }

        private static void ProblemC()
        {
            int[] numbers = { 234, 54, 45, 452, 2452, 45, 45, 43, 2, 425};
            Array.Sort(numbers);
            Console.WriteLine("The second smallest is " + numbers[1]);

            Array.Reverse(numbers);
            Console.WriteLine("The second biggest is " + numbers[1]);
        }

        private static void ProblemD()
        {
            int[] numbers = {23, 3, 2, 4, 4, 2, 4, 24, 5, 13, 5, 846, 236, 24, 6};
            foreach (var num in numbers)
            {
                if (num > 30)
                {
                    
                }
            }
        }

        private static void ProblemG()
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

        private static void ProblemH()
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

        private static void ProblemI()
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

        private static void ProblemJ()
        {
            string name = Utils.GetInput("Type in your full name: ");

            
        }

        private static void ProblemR()
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

        private static void ProblemS()
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
