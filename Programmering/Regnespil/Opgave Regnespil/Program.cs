using System;

namespace Opgave_Regnespil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regnespil();
        }

        static void Regnespil()
        {
            bool gamemodeSelected = false;
            string gamemode = "";

            while (!gamemodeSelected)
            {
                Console.WriteLine("Chose (a)addition, (s)subtraction, (m)multiplication, or (d)division to play");
                int charCode = Console.Read();
                Console.ReadLine();

                switch (charCode)
                {
                    case 97:
                        gamemodeSelected = true;
                        gamemode = "a";
                        break;

                    case 115:
                        gamemodeSelected = true;
                        gamemode = "s";
                        break;

                    case 109:
                        gamemodeSelected = true;
                        gamemode = "m";
                        break;

                    case 100:
                        gamemodeSelected = true;
                        gamemode = "d";
                        break;

                    default:
                        Console.WriteLine("Incorrect input");
                        break;

                }
            }
            string nl = Environment.NewLine;

            bool difficultySelected = false;
            string difficulty = "";

            while (!difficultySelected)
            {
                Console.WriteLine($"Chose difficulty: {nl}1. Numbers from 1-10{nl}2. Numbers from 1-100{nl}3. Numbers from 1-1000{nl}4. Numbers from 1-10000");
                int number = Console.Read();
                Console.ReadLine();

                switch (number)
                {
                    case 1:
                        difficultySelected = true;
                        difficulty = "let";
                        break;

                    case 2:
                        difficultySelected = true;
                        difficulty = "normal";
                        break;

                    case 3:
                        difficultySelected = true;
                        difficulty = "svær";
                        break;

                    case 4:
                        difficultySelected = true;
                        difficulty = "ultrasvær";
                        break;

                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }


            Random random = new Random();
            int score = 0;

            for (int i = 0; i < 10; i++)
            {
                int num1 = GetRandomNumber(difficulty);
                int num2 = GetRandomNumber(difficulty);
                int correctAnswer = CalculateAnswer(num1, num2, gamemode);

                Console.Write($"Question {i + 1}: What is {num1} {GetOperator(gamemode)} {num2}? ");

                for (int attempt = 0; attempt < 3; attempt++)
                {
                    int userAnswer;

                    if (int.TryParse(Console.ReadLine(), out userAnswer))
                    {
                        if (userAnswer == correctAnswer)
                        {
                            Console.WriteLine("Correct!");
                            score += GetScore(difficulty);
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Incorrect. Attempts left: {2 - attempt}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }
            }

            Console.WriteLine($"Game Over! Your final score is: {score}");
        }


        static int GetRandomNumber(string difficulty)
        {
            Random random = new Random();

            switch (difficulty)
            {
                case "let":
                    return random.Next(1, 11);

                case "normal":
                    return random.Next(1, 101);

                case "svær":
                    return random.Next(1, 1001);

                case "ultrasvær":
                    return random.Next(1, 10001);

                default:
                    return 0;
            }
        }

        static string GetOperator(string gamemode)
        {
            switch (gamemode)
            {
                case "a":
                    return "+";

                case "s":
                    return "-";

                case "m":
                    return "*";

                case "d":
                    return "/";

                default:
                    return "";
            }
        }

        static int CalculateAnswer(int num1, int num2, string gamemode)
        {
            switch (gamemode)
            {
                case "a":
                    return num1 + num2;

                case "s":
                    return num1 - num2;

                case "m":
                    return num1 * num2;

                case "d":
                    return num1 / num2;

                default:
                    return 0;
            }
        }

        static int GetScore(string difficulty)
        {
            switch (difficulty)
            {
                case "1":
                    return 1;

                case "2":
                    return 2;

                case "3":
                    return 3;

                case "4":
                    return 4;

                default:
                    return 0;
            }
        }
    }
}
