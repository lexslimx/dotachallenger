using System;
using System.Collections.Generic;

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
        MatchService matchservice=new MatchService();

            //use the method GetMatches to retrieve the recent matches of the player using the accountId above and assign them to a variable recentMatches below
           
            List<Match> recentMatches=matchservice.GetMatches(accountId);
            
           

           
            //Print out all the received matches in the format "PLAYERNAME:  KILLS , DEATHS , MATCHDURATION , K/D RATIO (Create a method in this class to calculate this You have to calculate this)
                //HINT:  User a foreach loop i.e foreach(Match item in recentMatches){}....
                foreach(Match x in recentMatches)
                {
                   
                   
                    Console.WriteLine("Kills:"+"\t" +x.kills+"\t"+"  Deaths:"+"\t"+x.deaths+"\t"+"  Assists:"+"\t"+x.assists);
                
                }

            //reffer to the entities folder fo the  Match class to find out the necessary properties of matches

        }


        //Create method to calculat the K/D ratio here take in two int parameters and returna d double recision number


    }
}
