class GameAccount
{
    public string UserName { get; private set; }
    public int CurrentRating { get; private set; }
    public int GamesCount { get; private set; }
    private List<Game> gamesHistory;

    public GameAccount(string userName)
    {
        UserName = userName;
        CurrentRating = 1;  // Початковий рейтинг, не може бути менше 1.
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
            CurrentRating = 1;  // Рейтинг не може бути менше 1.
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

class Game
{
    public string Index { get; set; }
    public static int GameIndex = 1234567890;
    public string OpponentName { get; set; }
    public string Result { get; set; }
    public int Rating { get; set; }

    public Game(string opponentName, string result, int rating)
    {
        this.Index = GameIndex.ToString();
        GameIndex++;   
        OpponentName = opponentName;
        Result = result;
        Rating = rating;
    }
   /* public void round()
    {
        Random rnd = new Random();
        int value1 = rnd.Next();
        int value2 = rnd.Next();   

        if (value1 > value2)
        {
            Name.WinGame(OpponentName, 10);
        }
    }*/
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        GameAccount player1 = new GameAccount("Player1");
        GameAccount player2 = new GameAccount("Player2");

        
        player1.WinGame("Player2", 10);
        player2.LoseGame("Player1", 32);

        player1.LoseGame("Player2", 55);
        player2.WinGame("Player1", 35);

        player1.WinGame("Player2", 220);
        player2.LoseGame("Player1", 120);

       
        player1.GetStats();
        player2.GetStats();

        player1.PlayerStats();
        player2.PlayerStats();


    }
}
