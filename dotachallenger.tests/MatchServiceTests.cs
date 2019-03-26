using System;
using Xunit;
using dotachallenger;
using System.Linq;

namespace dotachallenger.tests
{
    public class MatchServiceTests
    {
        [Fact]
        public void WrongAccountIdGivesZeroMatches()
        {
            //arrange
            IMatchService matchService = new MatchService();
            var accountId = 1;
            //act
            var recentMatchesCount = matchService.GetMatches(accountId).Count();
            var expectedResult = 0;
            //assert
            Assert.Equal(expectedResult,recentMatchesCount);
        } 
    }
}
