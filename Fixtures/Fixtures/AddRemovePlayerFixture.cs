using System;

namespace Fixtures
{
    public class AddRemovePlayerFixture {
        private String playerName;
        private Game theGame;

        public void setPlayerName(String playerName) {
            this.playerName = playerName;
        }

        public bool addPlayer() {
            theGame = StaticGame.theGame;
            Player thePlayer = theGame.addPlayer(playerName);
            return theGame.playerIsPlaying(thePlayer);
        }

        public int countPlayers() {
            return theGame.getNumberOfPlayers();
        }
    }

    public class Player
    {
        
        public Player(string aPlayerName)
        {
            
        }
    }
}