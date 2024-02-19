using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Yahtzee!");

        Console.Write("Enter the number of players: ");
        int numberOfPlayers = int.Parse(Console.ReadLine());

        List<Player> players = new List<Player>();
        for (int i = 0; i < numberOfPlayers; i++)
        {
            Console.Write($"Enter the name of Player {i + 1}: ");
            string playerName = Console.ReadLine();
            players.Add(new Player(playerName));
        }

        YahtzeeGame game = new YahtzeeGame(players);
        game.Play();

        Console.WriteLine("Game Over!");
    }
}

