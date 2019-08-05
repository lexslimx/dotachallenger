using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft;

public class MatchService : IMatchService
{
    private string ApiUrl = "https://api.opendota.com/api/players/{0}/matches?limit=100";
    

    public List<Match> GetMatches(int accountId)
    {
        string requestUrl = String.Format(ApiUrl, accountId);
        var matches = GetPlayerMatches(requestUrl);
        return matches;
    }

    private List<Match> GetPlayerMatches(string url)
    {
        HttpClient httpClient = new HttpClient();
        string matchesAsJsonString;
        try
        {
            matchesAsJsonString = httpClient.GetStringAsync(url).Result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An exception ocurred, Exception details: {ex.Message}");
            return null;
        }
        //convert the results into a valid matches objects for our program and return it
        List<Match> matches = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Match>>(matchesAsJsonString);
        return matches;
    }
}