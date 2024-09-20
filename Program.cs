using lab1;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        
        GameAccount player1 = new GameAccount("Player1");
        GameAccount player2 = new GameAccount("Player2");
        GameAccount player3 = new GameAccount("Player3");


        player1.WinGame("Player2", 10);
        player2.LoseGame("Player1", 32);

        player1.LoseGame("Player2", 55);
        player2.WinGame("Player1", 35);

        player1.WinGame("Player2", 220);
        player2.LoseGame("Player1", 20);

        player3.WinGame("Player2", 100);
        player3.WinGame("Player1", 100);
        player3.WinGame("Player2", 100);


        player1.GetStats();
        player2.GetStats();
        player3.GetStats();

        player1.PlayerStats();
        player2.PlayerStats();
        player3.PlayerStats();

    }
}
