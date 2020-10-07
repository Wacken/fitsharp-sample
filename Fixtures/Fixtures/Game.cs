using System.Collections;

namespace Fixtures
{
    public class Game {
        private ArrayList players;

        public Game() {
            players = new ArrayList();
        }

        public Player addPlayer(string aPlayerName) {
            Player aPlayer = new Player(aPlayerName);
            players.Add(aPlayer);
            return aPlayer;
        }

        public bool playerIsPlaying(Player aPlayer) {
            return players.Contains(aPlayer);
        }

        public int getNumberOfPlayers() {
            return players.Count;
        }
    } 
}