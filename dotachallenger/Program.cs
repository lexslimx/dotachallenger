using System;

namespace dotachallenger
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Dota Challenger!");
            PlayerService playerService = new PlayerService();
            int accountId = 87285329;
            Player player = playerService.GetPlayerProfile(accountId);

            if (player.profile == null)
            {
                Console.WriteLine($"The player with id {accountId} cannot be found");
                //exit the program if the player cannot be found
                return;
            }       
            Console.WriteLine($"The player name is {player.profile.name} competitive rank: {player.solo_competitive_rank}");    

            //Create a new instance of the new match service found in services folder (MatchService.cs)

            //use the method GetMatches to retrievee the recent matches of the player

            //Print out all the received matches in the format "PLAYERNAME:  KILLS  DEATHS  MATCHDURATION

            //reffer to the entities folder fo the  Match class to find out the necessary properties of matches

        }
    }
}
