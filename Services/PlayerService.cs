using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;

public class PlayerService : IPlayerService
{
    private readonly string apiUrl = "https://api.opendota.com/api/players/";
    public Player GetPlayerprofile(int accountId)
    {

        Player player = GetPlayerInfo(accountId);

        if (player == null)
        {
            return new Player
            {
                solo_competitive_rank = "0",
                rank_tier = 0
            };
        }
        else
        {
            return player;
        }
    }


    //make a network call to opendata api to request player info for the supplied accounid
    private Player GetPlayerInfo(int accountId)
    {
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Player));
        HttpClient httpClient = new HttpClient();
        Stream playerInfoAsStream;
        
        try{
            playerInfoAsStream = httpClient.GetStreamAsync(apiUrl + accountId).Result;
        }
        catch(Exception ex){
            Console.WriteLine("A network exception ocurred, a default player object will be returned");
            return null;
        }
       
        //convert the results into a valid player object for our program and return it
        Player player = serializer.ReadObject(playerInfoAsStream) as Player;
        return new Player();
    }
}