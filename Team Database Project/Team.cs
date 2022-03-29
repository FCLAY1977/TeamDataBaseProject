using Team_Database_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLouisvilleLibrary;

namespace Team_Database_Project
{
    public class Team : List<Player>
    {
        public string Name { get; set; }

        public Team(string name)
        {
            Name = name;
            Init();
        }

        public List<Player> FindByPosition(string position)

        {

            return this.Where(p => p.Position == position).OrderBy(p => p.UniformNumber).ToList();

        }



        public List<Player> FindBySkillLevel(decimal minSkill, decimal maxSkill)

        {

            return this.Where(p => p.SkillLevel >= minSkill && p.SkillLevel < maxSkill).OrderBy(p => p.SkillLevel).ThenBy(p => p.UniformNumber).ToList();

        }


        public List<Player> FindByWeight(decimal minWeight, decimal maxWeight)

        {

            return this.Where(p => p.Weight >= minWeight && p.Weight < maxWeight).OrderBy(p => p.SkillLevel).ThenBy(p => p.UniformNumber).ToList();

        }



        public List<Player> FindByHeight(decimal minHeight, decimal maxHeight)

        {

            return this.Where(p => p.Height >= minHeight && p.Height < maxHeight).OrderBy(p => p.SkillLevel).ThenBy(p => p.UniformNumber).ToList();

        }



        public List<Player> FindByUniformNumber(int UniformNumber)

        {

            return this.Where(p => p.UniformNumber).OrderBy(p => p.SkillLevel).ThenBy(p => p.UniformNumber).ToList();

        }










        private void Init()
        {
            var player1 = new Player();
            player1.Name = "Paul Smith";
            player1.Height = 6.3M;
            player1.Position = "G";
            player1.Weight = 155;
            player1.UniformNumber = 21;
            player1.SkillLevel = 3;
            player1.FieldGoalPercentage = 42.5M;

            Add(player1);

            var player2 = new Player();
            player2.Name = "Denny Skywalker";
            player2.Height = 6.1M;
            player2.Position = "F";
            player2.Weight = 168;
            player2.UniformNumber = 15;
            player2.SkillLevel = 5;
            player2.FieldGoalPercentage = 56;

            Add(player2);

            var player3 = new Player();
            player3.Name = "Joey Meeks";
            player3.Height = 5.8M;
            player3.Position = "G";
            player3.Weight = 154;
            player3.UniformNumber = 23;
            player3.SkillLevel = 4.5M;
            player3.FieldGoalPercentage = 52.5M;
            Add(player3);


            var player4 = new Player();
            player4.Name = "Derico Anderson";
            player4.Height = 6.4M;
            player4.Position = "G";
            player4.Weight = 163;
            player4.UniformNumber = 23;
            player4.SkillLevel = 4.75M;
            player4.FieldGoalPercentage = 49;

            Add(player4);


            var player5 = new Player();
            player5.Name = "Kai Towns";
            player5.Height = 6.11M;
            player5.Position = "C";
            player5.Weight = 223;
            player5.UniformNumber = 12;
            player5.SkillLevel = 5;
            player5.FieldGoalPercentage = 59;

            Add(player5);

            var player6 = new Player();
            player6.Name = "Stan Issel";
            player6.Height = 6.8M;
            player6.Position = "F";
            player6.Weight = 168;
            player6.UniformNumber = 44;
            player6.SkillLevel = 4.43M;
            player6.FieldGoalPercentage = 49.75M;
            Add(player6);

            var player7 = new Player();
            player7.Name = "Travis Board";
            player7.Height = 5.7M;
            player7.Position = "G";
            player7.Weight = 156;
            player7.UniformNumber = 5;
            player7.SkillLevel = 3.65M;
            player7.FieldGoalPercentage = 43;

            Add(player7);

            var player8 = new Player();
            player8.Name = "Pat Wiley";
            player8.Height = 6.9M;
            player8.Position = "C";
            player8.Weight = 168;
            player8.UniformNumber = 42;
            player8.SkillLevel = 4;
            player8.FieldGoalPercentage = 42.5M;

            Add(player8);

            var player9 = new Player();
            player9.Name = "Tony Davis";
            player9.Height = 6.99M;
            player9.Position = "F";
            player9.Weight = 212;
            player9.UniformNumber = 23;
            player9.SkillLevel = 5;
            player9.FieldGoalPercentage = 63.9M;

            Add(player9);

            var player10 = new Player();
            player10.Name = "John Paul";
            player10.Height = 6.7M;
            player10.Position = "G";
            player10.Weight = 164;
            player10.UniformNumber = 11;
            player10.SkillLevel = 4.75M;
            player10.FieldGoalPercentage = 41.5M;

            Add(player10);

            var player11 = new Player();
            player11.Name = "Skyler Ulis";
            player11.Height = 5.6M;
            player11.Position = "G";
            player11.Weight = 151;
            player11.UniformNumber = 3;
            player11.SkillLevel = 4.89M;
            player11.FieldGoalPercentage = 51;

            Add(player11);

            var player12 = new Player();
            player12.Name = "Devin Cooker";
            player12.Height = 6.6M;
            player12.Position = "G";
            player12.Weight = 172;
            player12.UniformNumber = 1;
            player12.SkillLevel = 4.95M;
            player12.FieldGoalPercentage = 62;

            Add(player12);
























        }

    }
}
