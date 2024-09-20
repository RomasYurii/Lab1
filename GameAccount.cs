namespace lab1;
class GameAccount
{
    private int rating = 1;
    public string UserName { get; private set; }
    public int CurrentRating
    {
        get
        { return rating; }
        set
        {
            if (value < 1)
            {
                rating = 1;
            }
            else
            {
                rating = value;
            }
        }
    }
    public int GamesCount
    {
        get
        {
            return gamesHistory.Count;
        }
    }

    private List<Game> gamesHistory;

    public GameAccount(string userName)
    {
        UserName = userName;
        // CurrentRating = 1;  // ���������� �������, �� ���� ���� ����� 1.
        // GamesCount = 0;
        gamesHistory = new List<Game>();
    }

    public void WinGame(string opponentName, int rating)
    {
        if (rating <= 0)
        {
            throw new ArgumentException("������� �� ���� ������ �� ���� ���� ��'����� ��� ��������.");
        }

        CurrentRating += rating;
        //GamesCount++;
        Game game = new Game(opponentName, "��������", rating);
        gamesHistory.Add(game);
    }

    public void LoseGame(string opponentName, int rating)
    {
        if (rating <= 0)
        {
            throw new ArgumentException("������� �� ���� ������ �� ���� ���� ��'����� ��� ��������.");
        }

        CurrentRating -= rating;
        // if (CurrentRating < 1)
        //{
        //    CurrentRating = 1;  // ������� �� ���� ���� ����� 1.
        // }

        //GamesCount++;
        Game game = new Game(opponentName, "�������", rating);
        gamesHistory.Add(game);
    }

    public void GetStats()
    {
        Console.WriteLine($"\n������ ���� ��� {UserName}:");
        foreach (var game in gamesHistory)
        {
            Console.WriteLine($"{game.Index} | {game.OpponentName} | {game.Result} | {game.Rating}");
        }
    }
    public void PlayerStats()
    {
        Console.WriteLine($"\n���������� ��� {UserName}:");
        Console.WriteLine($"\n������� | ���� ������");
        Console.WriteLine($"{CurrentRating} | {GamesCount}");
    }
}