public class Profile
{
    public Profile(int account_id,string name)
    {
this.account_id=account_id;
this.name=name;
    }
    public Profile(int account_id)
    {
        this.account_id=account_id;
    }
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