using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_Database_Project
{
    public class Team:List<Player>
    {
        public string Name { get; set; }

        public Team(string name)
        {
            Name = name;
            Init();
        }


        private void Init()
        { 
            var player1 = new Player();
            player1.Name = "Paul Smith";
            player1.Height = 6.3M;
            player1.Position = "G";
            player1.Weight = 155;
            player1.TeamNumber = 21;
            player1.SkillLevel = 3;

            Add(player1);

            var player2 = new Player();
            player2.Name = "Denny Skywalker";
            player2.Height = 6.1M;
            player2.Position = "F";
            player2.Weight = 168;
            player2.TeamNumber = 15;
            player2.SkillLevel = 5;

            Add(player2);

            var player3 = new Player();
            player2.Name = "Joey Meeks";
            player2.Height = 5.8M;
            player2.Position = "G";
            player2.Weight = 154;
            player2.TeamNumber = 23;
            player2.SkillLevel = 4.5M;

            Add(player3);


            var player4 = new Player();
            player2.Name = "Derico Anderson";
            player2.Height = 6.4M;
            player2.Position = "G";
            player2.Weight = 163;
            player2.TeamNumber = 23;
            player2.SkillLevel = 4.75M;

            Add(player4);


            var player5 = new Player();
            player2.Name = "Kai Towns";
            player2.Height = 6.11M;
            player2.Position = "F";
            player2.Weight = 223;
            player2.TeamNumber = 12;
            player2.SkillLevel = 5;

            Add(player5);

            var player6 = new Player();
            player2.Name = "Stan Issel";
            player2.Height = 6.8M;
            player2.Position = "F";
            player2.Weight = 168;
            player2.TeamNumber = 44;
            player2.SkillLevel = 4.43M;

            Add(player6);

            var player7 = new Player();
            player2.Name = "Travis Board";
            player2.Height = 5.7M;
            player2.Position = "G";
            player2.Weight = 156;
            player2.TeamNumber = 5;
            player2.SkillLevel = 3.65M;

            Add(player7);

            var player8 = new Player();
            player2.Name = "Pat Wiley";
            player2.Height = 6.9M;
            player2.Position = "F";
            player2.Weight = 168;
            player2.TeamNumber = 42;
            player2.SkillLevel = 4;

            Add(player8);

            var player9 = new Player();
            player2.Name = "Tony Davis";
            player2.Height = 6.99M;
            player2.Position = "F";
            player2.Weight = 212;
            player2.TeamNumber = 23;
            player2.SkillLevel = 5;

            Add(player9);

            var player10 = new Player();
            player2.Name = "John Paul";
            player2.Height = 6.7M;
            player2.Position = "G";
            player2.Weight = 164;
            player2.TeamNumber = 11;
            player2.SkillLevel = 4.75M;

            Add(player10);

            var player11 = new Player();
            player2.Name = "Skyler Ulis";
            player2.Height = 5.6M;
            player2.Position = "G";
            player2.Weight = 151;
            player2.TeamNumber = 3;
            player2.SkillLevel = 4.89M;

            Add(player11);

            var player12 = new Player();
            player2.Name = "Devin Cooker";
            player2.Height = 6.6M;
            player2.Position = "G";
            player2.Weight = 172;
            player2.TeamNumber = 1;
            player2.SkillLevel = 4.95M;

            Add(player12);
























        }

     }
}
