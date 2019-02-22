using System;

namespace dotachallenger
{
    
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
            Console.WriteLine("The time is "+FirstGame.gametime);
            //CREATING A NEW PLAYER
            Player playerone=new Player(12);
            Console.WriteLine($"Your rank is {playerone.rank_tier}");
            //read the accountId from the console (**hint user Console.ReadLine) to get rid of the compile error
            Profile playerprofile=new Profile(1234,"LILIESSS");
            Console.WriteLine($"Your SteamID is {playerprofile.account_id} and your Name is {playerprofile.name}");
            Profile playerprofiletwo=new Profile(256);
            Console.WriteLine($"Player Two's Account ID is {playerprofiletwo.account_id}")   ; 
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
