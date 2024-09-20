namespace lab1;
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