using System;
namespace Lab09.Assignment09
{
    internal class TeamPlayer
    {
        // Relationship Type: Aggregation
        // player can switch teams
    }

    internal class Player
    {
        public string Name;

        public Player(string name)
        {
            Name = name;
        }
    }

    internal class Team
    {
        //private List<Player> players = new List<Player>();
        private List<Player> players;

        public void AddPlayer(Player p)
        {
            players.Add(p);
        }

        public void ShowPlayers()
        {
            Console.WriteLine("Team Players:");

            foreach (Player p in players)
            {
                Console.WriteLine(p.Name);
            }
        }

    }
}
