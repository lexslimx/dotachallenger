using System;

namespace dotachallenger
{
     class Game
    {  
       
        public Game(int killcount, int deaths, int assists)
        {
        this.killcount=killcount;
        this.deaths=deaths;
        this.assists=assists;
        }
        
       public int killcount;
       public int deaths;
       public int assists;
        DateTime gametime;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Dota!");                        
            Console.WriteLine("Please enter your steam account id");
            string accountId = null;
           
            Game FirstGame=new Game(5,3,8);
            Console.WriteLine($"Your KDA is {FirstGame.killcount}:{FirstGame.deaths}:{FirstGame.assists}");
            Console.WriteLine("Thanks for playing");
            //read the accountId from the console (**hint user Console.ReadLine) to get rid of the compile error
         
            //Console.WriteLine($"You Entered: {accountId}");
            
             // TODO
            /*
                1. Create a new  player (instance) object  based on the entered account id   //DONE FOR YOU         
                2. Print out the player rank_tier and leaderboard_rank from the created player instance
             */

            PlayerService playerService = new PlayerService();
            Player player = playerService.GetPlayerprofile(77735678);

            if(player == null)     {
                Console.WriteLine("An error occurred");
            }
            else{
                Console.WriteLine($"player is at rank tier {player.rank_tier}");
            }
        }
    }
}
