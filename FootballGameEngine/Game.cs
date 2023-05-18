using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballGameEngine
{
    public class Game
    {
        public Game(Team team1, Team team2, Referee referee, Referee refereeAssistant1, Referee refereeAssistant2)
        {
            
            Team1 = team1;
            Team2 = team2;

            //Take first eleven players to enter the game
            Team1.Players = Team1.Players.Take(11).ToList();
            Team2.Players = Team2.Players.Take(11).ToList();

            Referee = referee;
            RefereeAssistant1 = refereeAssistant1;
            RefereeAssistant2 = refereeAssistant2;

            Goals = new Dictionary<int, FootballPlayer>();
            GameResult = new int[2];
        }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Referee RefereeAssistant1 { get; set; }
        public Referee RefereeAssistant2 { get; set; }
        private Dictionary<int, FootballPlayer> Goals { get; set; }
        private int[] GameResult { get; set; }
        public Team Winner { get; set; }

        public void AddGoal(int minute, FootballPlayer player)
        {
            Goals.Add(minute, player);
        }

        //Evaluate the result at the moment
        private void EvaluateResult()
        {
            int countTeam1Goals = 0;
            int countTeam2Goals = 0;
            foreach (KeyValuePair<int, FootballPlayer> goal in Goals)
            {
                if (Team1.Players.Contains(goal.Value))
                {
                    countTeam1Goals++;
                }
                else
                {
                    countTeam2Goals++;
                }
            }

            GameResult[0] = countTeam1Goals;
            GameResult[1] = countTeam2Goals;
        }
        public void ShowResult()
        {
            EvaluateResult();
            Console.WriteLine($"The result is: {GameResult[0]}:{GameResult[1]}");
        }

        public void TheWinner()
        {
            EvaluateResult();
            if (GameResult[0] > GameResult[1])
            {
                Console.WriteLine($"The winner is {Team1.Name}");
                Winner = Team1;
            }
            else if(GameResult[0] < GameResult[1])
            {
                Console.WriteLine($"The winner is {Team2.Name}");
                Winner = Team2;
            }
            else
            {
                Console.WriteLine("Even score.");
            }
        }
    }
}
