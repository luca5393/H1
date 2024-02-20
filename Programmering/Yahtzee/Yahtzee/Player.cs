using System;

class Player
{
    public string Name { get; }
    public List<int> Dice { get; private set; }
    public int Score { get; private set; }

    private List<string> selectedCategories = new List<string>();

    public Player(string name)
    {
        Name = name;
        Dice = new List<int>();
        Score = 0;
    }

    public void ResetRerolls()
    {
        remainingRerolls = 2;
    }

    public void RollDice()
    {
        Random random = new Random();
        Dice.Clear();
        for (int i = 0; i < 5; i++)
        {
            Dice.Add(random.Next(1, 7));
        }
    }

    public void DisplayDice()
    {
        Console.WriteLine($"Dice: {string.Join(", ", Dice)}");
    }

    private int remainingRerolls = 2;

    public void RerollDice()
    {
        if (remainingRerolls > 0)
        {
            Console.WriteLine($"Remaining rerolls: {remainingRerolls}");
            Console.Write("Enter the position of dice to reroll (e.g., 1 3 5): ");
            string input = Console.ReadLine();

            string[] indices = input.Split(' ');
            bool[] diceToReroll = new bool[5];

            foreach (var index in indices)
            {
                if (int.TryParse(index, out int i) && i >= 1 && i <= 5)
                {
                    diceToReroll[i - 1] = true;
                }
            }

            RollDice(diceToReroll);
            DisplayDice();
            remainingRerolls--;
            RerollDice();
        }
        else
        {
            Console.WriteLine("No more rerolls left.");
        }
    }

    public void ChooseCategory()
    {
        RerollDice();

        Console.Write("Choose a category (e.g., Ones, Twos, Threes, Fours, Fives, Sixes, ThreeOfAKind, FourOfAKind, FullHouse, SmallStraight, LargeStraight, Yahtzee, Chance): ");
        string category = Console.ReadLine().ToLower();

        if (selectedCategories.Contains(category))
        {
            Console.WriteLine($"Category '{category}' has already been chosen. Choose a different category.");
            ChooseCategory();
            return;
        }

        switch (category)
        {
            case "ones":
                Score += SumOfSameNumber(1);
                break;
            case "twos":
                Score += SumOfSameNumber(2);
                break;
            case "threes":
                Score += SumOfSameNumber(3);
                break;
            case "fours":
                Score += SumOfSameNumber(4);
                break;
            case "fives":
                Score += SumOfSameNumber(5);
                break;
            case "sixes":
                Score += SumOfSameNumber(6);
                break;
            case "threeofakind":
                Score += ThreeOfAKind();
                break;
            case "fourofakind":
                Score += FourOfAKind();
                break;
            case "fullhouse":
                Score += FullHouse();
                break;
            case "smallstraight":
                Score += SmallStraight();
                break;
            case "largestraight":
                Score += LargeStraight();
                break;
            case "yahtzee":
                if (IsYahtzee())
                {
                    Score += 50;
                }
                break;
            case "chance":
                Score += SumOfAllDice();
                break;
            default:
                Console.WriteLine("Invalid category. Try again.");
                ChooseCategory();
                return; 
        }

        selectedCategories.Add(category);

        Console.WriteLine($"Score for {Name}: {Score}");
    }


    private int CountOccurrences(int value)
    {
        return Dice.Count(d => d == value);
    }

    private int SumOfAllDice()
    {
        return Dice.Sum();
    }

    private int SumOfSameNumber(int number)
    {
        return CountOccurrences(number) * number;
    }

    private int ThreeOfAKind()
    {
        foreach (var value in Dice.Distinct())
        {
            if (CountOccurrences(value) >= 3)
            {
                return SumOfAllDice();
            }
        }
        return 0;
    }

    private int FourOfAKind()
    {
        foreach (var value in Dice.Distinct())
        {
            if (CountOccurrences(value) >= 4)
            {
                return SumOfAllDice();
            }
        }
        return 0;
    }

    private int FullHouse()
    {
        bool hasThreeOfAKind = false;
        bool hasPair = false;

        foreach (var value in Dice.Distinct())
        {
            if (CountOccurrences(value) == 3)
            {
                hasThreeOfAKind = true;
            }
            else if (CountOccurrences(value) == 2)
            {
                hasPair = true;
            }
        }

        if (hasThreeOfAKind && hasPair)
        {
            return 25;
        }

        return 0;
    }

    public void RollDice(bool[] diceToReroll)
    {
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            if (diceToReroll[i])
            {
                Dice[i] = random.Next(1, 7);
            }
        }
    }

    private bool IsYahtzee()
    {
        return Dice.All(d => d == Dice[0]);
    }

    private int SmallStraight()
    {
        int[] counts = new int[6];

        foreach (var value in Dice)
        {
            counts[value - 1]++;
        }

        for (int i = 0; i <= 2; i++)
        {
            if (counts[i] > 0 && counts[i + 1] > 0 && counts[i + 2] > 0 && counts[i + 3] > 0)
            {
                return 30;
            }
        }

        return 0;
    }

    private int LargeStraight()
    {
        int[] counts = new int[6];

        foreach (var value in Dice)
        {
            counts[value - 1]++;
        }

        for (int i = 0; i <= 1; i++)
        {
            if (counts[i] > 0 && counts[i + 1] > 0 && counts[i + 2] > 0 && counts[i + 3] > 0 && counts[i + 4] > 0)
            {
                return 40;
            }
        }

        return 0;
    }
}
