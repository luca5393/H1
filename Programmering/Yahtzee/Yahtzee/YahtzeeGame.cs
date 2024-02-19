using System;

class YahtzeeGame
{
    private List<Player> players;

    public YahtzeeGame(List<Player> players)
    {
        this.players = players;
    }

    public void Play()
    {
        int rounds = 2;
        for (int round = 1; round <= rounds; round++)
        {
            Console.WriteLine($"\nRound {round}");
            foreach (var player in players)
            {
                player.ResetRerolls();
                Console.WriteLine($"\n{player.Name}'s turn:");
                player.RollDice();
                player.DisplayDice();
                player.ChooseCategory();
            }
        }

        Console.WriteLine("\nFinal Scores:");
        foreach (var player in players)
        {
            Console.WriteLine($"{player.Name}: {player.Score}");
        }
    }
}
