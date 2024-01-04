namespace DesignPatternsCourse.BehavioralPatterns.TemplateMethod;

public class FunctionalTemplateMethod : IDemo
{
    public void Run()
    {
        var numberOfPlayers = 2;
        int currentPlayer = 0;
        int turn = 1, maxTurns = 10;

        void Start(int test)
        {
            Console.WriteLine($"Starting a game of chess with {numberOfPlayers} players.");
        }

        bool HaveWinner()
        {
            return turn == maxTurns;
        }

        void TakeTurn()
        {
            Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
            currentPlayer = (currentPlayer + 1) % numberOfPlayers;
        }

        int WinningPlayer(int test)
        {
            return currentPlayer;
        }

        GameTemplate.Run(Start, TakeTurn, HaveWinner, WinningPlayer);
    }

    public static class GameTemplate
    {
        public static void Run(
          Action<int> start,
          Action takeTurn,
          Func<bool> haveWinner,
          Func<int, int> winningPlayer)
        {
            start(1);
            while (!haveWinner())
                takeTurn();
            Console.WriteLine($"Player {winningPlayer(1)} wins.");
        }
    }
}
