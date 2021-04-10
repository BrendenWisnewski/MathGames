using System;

namespace MathGames
{
    class Program
    {
        
        public static void Start()
        {
            try
            {
                Console.WriteLine("Welcome to Brenden's Math Game!");
                Console.WriteLine("To add press 1");
                Console.WriteLine("To subtract press 2");
                Console.WriteLine("To multiply press 3");
                Console.WriteLine("To divide press 4");

                int userChoice = int.Parse(Console.ReadLine());
                if(userChoice <= 4 && userChoice > 0)
                { 

                Console.WriteLine("\nHow many equations would you like? Please enter the number of equations");

                int reps = int.Parse(Console.ReadLine());
                int correct;
                
                
                    switch (userChoice)
                    {
                        case 1:
                            correct = Add(reps);
                            Console.WriteLine(Report(correct, reps));
                            break;
                        case 2:
                            correct = Subtract(reps);
                            Console.WriteLine(Report(correct, reps));
                            break;
                        case 3:
                            correct = Multiply(reps);
                            Console.WriteLine(Report(correct, reps));
                            break;
                        case 4:
                            correct = Divide(reps);
                            Console.WriteLine(Report(correct, reps));
                            break;
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to try again");
                Console.ReadKey();
                Console.Clear();
                Start();
            }
        }
        public static string Report(int correct, int reps)
        {
            double ratio = (double)correct / reps;
            double score = ((double)Math.Round(ratio ,2)*100);

            return $"You got {correct} out of {reps} correct and your score was {score}";
        }

        public static Random rand = new Random();
        public static int Add(int reps)
        {
            int correct = 0;
            while (reps > 0)
            {
                int x = rand.Next(1, 13);
                int y = rand.Next(1, 13);
                Console.Write($"{x} + {y} = ");
                int userAnswer = int.Parse(Console.ReadLine());
                int answer = x + y;
                if(answer == userAnswer)
                {
                    Console.WriteLine("Correct");
                    correct++;
                }
                else
                {
                    Console.WriteLine($"The correct answer is {answer}");
                }
                reps--;
            }
            return correct;
        }
        public static int Subtract(int reps)
        {
            int correct = 0;
            int answer;
            
            while (reps > 0)
            {
                int x = rand.Next(1, 13);
                int y = rand.Next(1, 13);
                if(x > y)
                {
                    Console.Write($"{x} - {y} = ");
                    answer = x - y;
                }
                else
                {
                    Console.Write($"{y} - {x} = ");
                    answer = y - x;
                }

                int userAnswer = int.Parse(Console.ReadLine());
                
                if (answer == userAnswer)
                {
                    Console.WriteLine("Correct");
                    correct++;
                }
                else
                {
                    Console.WriteLine($"The correct answer is {answer}");
                }
                reps--;
            }
            return correct;
        }

        public static int Multiply(int reps)
        {
            int correct = 0;
            while (reps > 0)
            {
                int x = rand.Next(1, 13);
                int y = rand.Next(1, 13);
                Console.Write($"{x} * {y} = ");
                int userAnswer = int.Parse(Console.ReadLine());
                int answer = x * y;
                if (answer == userAnswer)
                {
                    Console.WriteLine("Correct");
                    correct++;
                }
                else
                {
                    Console.WriteLine($"The correct answer is {answer}");
                }
                reps--;
            }
            return correct;
        }

        public static int Divide(int reps)
        {
            int correct = 0;
            while (reps > 0)
            {
                int x = rand.Next(1, 13);
                int y = rand.Next(1, 13);
                Console.Write($"{x} / {y} = ");
                double userAnswer = double.Parse(Console.ReadLine());
                float answer = (float)x / y;
                double roundAnswer = (double)Math.Round(answer, 2);
                if (roundAnswer == userAnswer)
                {
                    Console.WriteLine("Correct");
                    correct++;
                }
                else
                {
                    Console.WriteLine($"The correct answer is {roundAnswer}");
                }
                reps--;
            }
            return correct;
        }
        static void Main(string[] args)
        {
            bool play = true;
            while (play == true)
            {
                Start();

                Console.WriteLine("Practice again? Type 1 for yes, type 2 for no:");
                try
                {
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == 1 || answer == 2)
                    {
                        if (answer == 1) play = true;
                        else play = false;
                        Console.Clear();
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                    


                }
            }

        }
    }
}
