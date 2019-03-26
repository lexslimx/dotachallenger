using System;

namespace dotachallenger
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Dota Challenger!");                                    
            PlayerService playerService = new PlayerService();
            Player player = playerService.GetPlayerProfile(87285329);
            
            if(player == null)     {
                Console.WriteLine("An error occurred, received no data about the player id used");
            }
            else{
                Console.WriteLine($"The player name is {player.profile.name} competitive rank: {player.solo_competitive_rank}");
            }
        }
    }
}
