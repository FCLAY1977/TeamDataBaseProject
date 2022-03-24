﻿using System;
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

  

        protected override bool Main() 

        { 

            bool quit = false; 

  

            var mainMenu = new Menu<int>(); 

            mainMenu.AddMenuItem(1, "List Entire Team"); 

            mainMenu.AddMenuItem(2, "List Players by Position"); 

            mainMenu.AddMenuItem(3, "List Players by Height"); 

            mainMenu.AddMenuItem(4, "List Players By Skill Level"); 

            mainMenu.AddMenuItem(5, "Quit"); 

  

            int mainMenuSelection = Prompt4MenuItem<int>("Select a menu option:", mainMenu); 

  

            switch( mainMenuSelection) 

            { 

                case 1: 

                    // you do this 

                    break; 

                case 2: 

                    ListPlayersByPosition(); 

                    break; 

                case 3: 

                    // you do this 

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

                List<Player> playersByPosition = MyTeam.FindByPosition(positionMenuSelection); 

                ListPlayers(playersByPosition); 

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

                    minSkill = 4.5M; 

                    maxSkill = 99.0M; // just some number larger than any skill level 

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
