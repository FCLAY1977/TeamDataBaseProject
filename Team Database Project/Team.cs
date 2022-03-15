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
            player1.Height = 6.3M;
            player1.Name = "John Smith";
            player1.Position = "G";
            player1.Weight = 185;
            player1.TeamNumber = 21;
            player1.SkillLevel = 5;

            Add(player1);
            




        }

     }
}
