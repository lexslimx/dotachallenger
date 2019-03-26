using System;
using Xunit;
using dotachallenger;
using System.Linq;

namespace dotachallenger.tests
{
    public class PlayerServiceTests
    {
        [Fact]
        public void ReturnProfileIfPlayerIsNotFound(){
            //arrange 
            IPlayerService playerService = new PlayerService();
            var invalidAccountId = 0;
            //act
            var player = playerService.GetPlayerProfile(invalidAccountId);
            //assert
            Assert.Null(player.profile);
        }
    }
}