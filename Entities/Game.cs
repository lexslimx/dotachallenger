 using System;
 class Game
    {  
       
        public Game(int killcount, int deaths, int assists)
        {
        this.killcount=killcount;
        this.deaths=deaths;
        this.assists=assists;
        }
        
       public int killcount;
       public int deaths;
       public int assists;
       DateTime gametime;

    }