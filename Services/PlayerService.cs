using System;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;


public class PlayerService : IPlayerService
{
    private readonly string apiUrl = "https://api.opendota.com/api/players/38867839";
    public Player GetPlayerprofile(int accountId)
    {

        Player player = GetPlayerInfo(accountId);

        if (player == null)
        {
            Console.WriteLine("Error");
            return null;
        }
        else
        {
            return player;
        }
    }


    //make a network call to opendata api to request player info for the supplied accounid
    private Player GetPlayerInfo(int accountId)
    {        
        HttpClient httpClient = new HttpClient();
        string playerAsJsonString;
        
        try{
            playerAsJsonString = httpClient.GetStringAsync(apiUrl + accountId).Result;
        }
        catch(Exception ex){
            Console.WriteLine("A network exception ocurred, a default player object will be returned");
            return null;
        }
       
        //convert the results into a valid player object for our program and return it
        Player player = Newtonsoft.Json.JsonConvert.DeserializeObject<Player>(playerAsJsonString);
        return player;
    }
}