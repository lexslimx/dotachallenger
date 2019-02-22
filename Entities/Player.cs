
// TODO
/*
In this file:

1. Create a class called Player I've started off player for you DONE
2. Player should have the following public properties ( name : type )DONE
    solo_competitive_rank : stringDONE
    rank_tier : int,DONE
    leaderboard_rank : int DONE
    mmr_estimate: Object DONE


3. Create a class called Profile DONE
4. Profile should have the following public properties ( name : type) 
    "account_id": int,DONE
    "personaname": "string",DONE
        "name": "string",DONE
    "cheese": int,DONE
    "steamid": "string",DONE
    "avatar": "string",DONE
    "avatarmedium": "string",DONE
    "avatarfull": "string",DONE
    "profileurl": "string",DONE
    "last_login": "string",DONE
    "loccountrycode": "string",DONE
    "is_contributor": booleanDONE

 */

public class Player
{


    public string solo_competitive_rank { get; set; }
    public int rank_tier { get; set; }
    public int leaderboard_rank;
    public object mmr_estimate;

    //The rest of the properties go here
}
public class Profile
{
public int account_id;
public string personaname;
public string name;
public int cheese;
public string steamid;
public string avatar;
public string avatarmedium;
public string avatarfull;
public string profileurl;
public string last_login;
public string loccountrycode;
public bool is_contributor;
}

//create the class Profile here: