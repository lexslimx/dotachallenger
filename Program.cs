using System;

namespace dotachallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Dota!");                        
            Console.WriteLine("Please enter your steam account id");
            string accountId;
            //read the accountId from the console (**hint user Console.ReadLine) to get rid of the compile error

            Console.WriteLine($"You Entered: {accountId}");
            
             // TODO
            /*
                1. Create a new  player (instance) object  based on the entered account id   //DONE FOR YOU         
                2. Print out the player rank_tier and leaderboard_rank from the created player instance
             */

            var playerService = new PlayerService();
            var player = playerService.GetPlayerprofile(38867839);
            
           
        }
    }
}
