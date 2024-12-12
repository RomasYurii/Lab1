using laboratorna1.GameAccount;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        GameAccount player1 = new GameAccount("Player1");
        GameAccount player2 = new GameAccount("Player2");

        
        player1.WinGame(player2.UserName, 10);
        player2.LoseGame(player1.UserName, 32);

        player1.LoseGame(player2.UserName, 55);
        player2.WinGame(player1.UserName, 35);

        player1.WinGame(player2.UserName, 220);
        player2.LoseGame(player1.UserName, 20);

       
        player1.GetStats();
        player2.GetStats();

        player1.PlayerStats();
        player2.PlayerStats();


    }
}
