using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FootballGameEngine
{
    public class Team
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Name cannot be null!");
                }
                name = value;
            }
        }
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }
        public int AverageAge { get; set; }

        public Team(string name, Coach coach, List<FootballPlayer> players)
        {
            Name = name;
            Coach = coach;

            if(players.Count<11 || players.Count > 22)
            {
                throw new ArgumentOutOfRangeException("Number of players must be between 11 and 22!");
            }
            Players = players;

            AverageAge = (int) Math.Round(players.Average(x => x.Age));
        }
    }
}
