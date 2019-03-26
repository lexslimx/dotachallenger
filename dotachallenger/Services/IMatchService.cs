using System;
using System.Collections.Generic;

public interface IMatchService{
   List<Match> GetMatches(int accountId);
}