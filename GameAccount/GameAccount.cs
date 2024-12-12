using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laboratorna1.Games;

namespace laboratorna1.GameAccount
{
    class GameAccount
    {
        public string UserName { get; private set; }
        public int CurrentRating { get; private set; }
        public int GamesCount { get; private set; }
        private List<Game> gamesHistory;

        public GameAccount(string userName)
        {
            UserName = userName;
            CurrentRating = 1;
            GamesCount = 0;
            gamesHistory = new List<Game>();
        }

        public void WinGame(string opponentName, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentException("Рейтинг на який грають не може бути від'ємним або нульовим.");
            }

            CurrentRating += rating;
            GamesCount++;
            Game game = new Game(opponentName, "Перемога", rating);
            gamesHistory.Add(game);
        }

        public void LoseGame(string opponentName, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentException("Рейтинг на який грають не може бути від'ємним або нульовим.");
            }

            CurrentRating -= rating;
            if (CurrentRating < 1)
            {
                CurrentRating = 1;
            }

            GamesCount++;
            Game game = new Game(opponentName, "Поразка", rating);
            gamesHistory.Add(game);
        }

        public void GetStats()
        {
            Console.WriteLine($"\nІсторія ігор для {UserName}:");
            foreach (var game in gamesHistory)
            {
                Console.WriteLine($"{game.Index} | {game.OpponentName} | {game.Result} | {game.Rating}");
            }
        }
        public void PlayerStats()
        {
            Console.WriteLine($"\nСтатистика для {UserName}:");
            Console.WriteLine($"\nРейтинг | Ігор зіграно");
            Console.WriteLine($"{CurrentRating} | {GamesCount}");
        }
    }
}
