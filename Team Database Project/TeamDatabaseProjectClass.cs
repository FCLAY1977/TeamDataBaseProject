using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLouisvilleLibrary;



namespace Team_Database_Project 

{ 

    public class TeamDatabaseProjectClass : CodeLouisvilleAppBase 

    { 

        private Team MyTeam = new Team("Wildcats"); 

  

        public TeamDatabaseProjectClass() : base("Team Database Project") 

        { 

        }

        internal void Run()
        {
            throw new NotImplementedException();
        }

        protected override bool Main() 

        { 

            bool quit = false; 

  

            var mainMenu = new Menu<int>(); 

            mainMenu.AddMenuItem(1, "List Entire Team");

            mainMenu.AddMenuItem(2, "List Players By Name");
            
            mainMenu.AddMenuItem(3, "List Players by Position"); 

            mainMenu.AddMenuItem(4, "List Players by Height"); 

            mainMenu.AddMenuItem(5, "List Players By Weight");

            mainMenu.AddMenuItem(6, "List Players By Unifrom Number");

            mainMenu.AddMenuItem(7, "List Players By Skill Level");

            mainMenu.AddMenuItem(8, "List Players By Field Goal Percentage");            
            
            mainMenu.AddMenuItem(9, "Quit"); 

  

            int mainMenuSelection = Prompt4MenuItem<int>("Select a menu option:", mainMenu); 

  

            switch( mainMenuSelection) 

            { 

                case 1:

                    ListPlayersbyName();  

                    break; 

                case 2: 

                    ListPlayersByPosition(); 

                    break; 

                case 3:

                     

                    break; 

                case 4: 

                    ListPlayersBySkillLevel(); 

                    break; 

                case 5: 

                    quit = true; 

                    break; 

                default: 

                    Console.WriteLine("Invalid Selection!"); 

                    Console.Write("Press any key to continue: "); 

                    Console.ReadKey(); 

                    Console.Clear(); 

                    break; 

            } 

  

            return !quit; 

        }

        private void ListPlayersbyName()
        {
            throw new NotImplementedException();
        }

        private T Prompt4MenuItem<T>(string v, Menu<T> mainMenu)
        {
            throw new NotImplementedException();
        }

        private void ListPlayers(List<Player> players) 

        { 

            foreach (Player player in players) 

            { 

                Console.WriteLine(player); 

            } 

        } 

  

        private void ListPlayersByPosition() 

        { 

            Console.Clear(); 

            var positionMenu = new Menu<char>(); 

            positionMenu.AddMenuItem('G', "List Guards"); 

            positionMenu.AddMenuItem('F', "List Forwards"); 

            positionMenu.AddMenuItem('C', "List Centers"); 

  

            string positionMenuSelection = Prompt4MenuItem<char>("Select a position:", positionMenu).ToString().ToUpper(); 

  

            if (positionMenuSelection != "G" && positionMenuSelection != "F" && positionMenuSelection != "C") 

                Console.WriteLine("Invalid Selection"); 

            else 

            { 

                List<Player> playersByPosition = MyTeam.FindByName(positionMenuSelection); 

                ListPlayers(playersByPosition); 

            } 

  

            Console.Write("Press any key to continue: "); 

            Console.ReadKey(); 

            Console.Clear(); 

        }

        private void ListPlayersByName(void v)

        {

            Console.Clear();

            var nameMenu = new Menu<string>();

            nameMenu.AddMenuItem("List Name");

           



            string nameMenuSelection = Prompt4MenuItem<string>("Select a name:", nameMenu).ToString().ToUpper();
            

            

            {

                List<Player> playersByName = MyTeam.FindByName(nameMenuSelection);

                ListPlayers(playersByName);

            }



            Console.Write("Press any key to continue: ");

            Console.ReadKey();

            Console.Clear();

        }










        private void ListPlayersBySkillLevel() 

        { 

            Console.Clear(); 

  

            var skillMenu = new Menu<int>(); 

            skillMenu.AddMenuItem(1, "List Players with Skill Level < 4"); 

            skillMenu.AddMenuItem(2, "List Players with Skill Level between 4 and 4.5"); 

            skillMenu.AddMenuItem(3, "List Players with Skill Level > 4.5"); 

  

            int skillMenuSelection = Prompt4MenuItem<int>("Select a skill level:", skillMenu); 

  

            bool validSelection = true; 

            decimal minSkill = 0.0M; 

            decimal maxSkill = 0.0M; 

            switch(skillMenuSelection) 

            { 

                case 1: 

                    maxSkill = 4.0M; 

                    break; 

                case 2: 

                    minSkill = 4.0M; 

                    maxSkill = 4.5M; 

                    break; 

                case 3: 

                    minSkill = 40M; 

                    maxSkill = 100.0M;  

                    break; 

                default: 

                    validSelection = false; 

                    Console.WriteLine("Invalid Selection"); 

                    break; 

            } 

  

            if(validSelection) 

            { 

                List<Player> playersBySkill = MyTeam.FindBySkillLevel(minSkill, maxSkill); 

                ListPlayers(playersBySkill); 

            } 

  

            Console.Write("Press any key to continue: "); 

            Console.ReadKey(); 

            Console.Clear(); 

        } 

    } 

} 
