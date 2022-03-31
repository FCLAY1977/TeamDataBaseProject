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



        protected override bool Main()

        {

            bool quit = false;



            var mainMenu = new Menu<int>();

            mainMenu.AddMenuItem(1, "List Entire Team");

            mainMenu.AddMenuItem(2, "List Players by Position");

            mainMenu.AddMenuItem(3, "List Players by Height");

            mainMenu.AddMenuItem(4, "List Players By Weight");

            mainMenu.AddMenuItem(5, "List Players By Skill Level");

            mainMenu.AddMenuItem(6, "List Players By Uniform Number");

            mainMenu.AddMenuItem(7, "Quit");



            int mainMenuSelection = Prompt4MenuItem<int>("Select a menu option:", mainMenu);



            switch (mainMenuSelection)

            {

                case 1:

                    ListEntireTeam();

                    break;

                case 2:

                    ListPlayersByPosition();

                    break;

                case 3:

                    ListPlayersByHeight();

                    break;

                case 4:

                    ListPlayersByWeight();

                    break;


                case 5:

                    ListPlayersBySkillLevel();

                    break;

                case 6:

                    ListPlayersByUniformNumber();

                    break;

                case 7:

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


        private void ListEntireTeam()
        {

            ListPlayers(MyTeam);

           

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

            switch (skillMenuSelection)

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

                    maxSkill = 99.0M;

                    break;

                default:

                    validSelection = false;

                    Console.WriteLine("Invalid Selection");

                    break;

            }



            if (validSelection)

            {

                List<Player> playersBySkill = MyTeam.FindBySkillLevel(minSkill, maxSkill);

                ListPlayers(playersBySkill);

            }



            Console.Write("Press any key to continue: ");

            Console.ReadKey();

            Console.Clear();

        }








        private void ListPlayersByHeight()

        {

            Console.Clear();



            var HeightMenu = new Menu<int>();

            HeightMenu.AddMenuItem(1, "List Players with Height < 6.0M");

            HeightMenu.AddMenuItem(2, "List Players with Height between 6.0M and 6.5M");

            HeightMenu.AddMenuItem(3, "List Players with Height > 6.5");



            int HeightMenuSelection = Prompt4MenuItem<int>("Select a Height:", HeightMenu);



            bool validSelection = true;

            decimal minHeight = 0.0M;

            decimal maxHeight = 0.0M;

            switch (HeightMenuSelection)

            {

                case 1:

                    maxHeight = 6.0M;

                    break;

                case 2:

                    minHeight = 6.0M;

                    maxHeight = 6.5M;

                    break;

                case 3:

                    minHeight = 6.5M;

                    maxHeight = 8.0M;

                    break;

                default:

                    validSelection = false;

                    Console.WriteLine("Invalid Selection");

                    break;

            }



            if (validSelection)

            {

                List<Player> playersByHeight = MyTeam.FindByHeight(minHeight, maxHeight);

                ListPlayers(playersByHeight);

            }



            Console.Write("Press any key to continue: ");

            Console.ReadKey();

            Console.Clear();

        }


        private void ListPlayersByWeight()

        {

            Console.Clear();



            var weightMenu = new Menu<int>();

            weightMenu.AddMenuItem(1, "List Players with Weight < 150");

            weightMenu.AddMenuItem(2, "List Players with Weight between 150 and 200");

            weightMenu.AddMenuItem(3, "List Players with Weight > 200");



            int weightMenuSelection = Prompt4MenuItem<int>("Select a weight:", weightMenu);



            bool validSelection = true;

            decimal minWeight = 0.0M;

            decimal maxWeight = 0.0M;

            switch (weightMenuSelection)

            {

                case 1:

                    maxWeight = 150.0M;

                    break;

                case 2:

                    minWeight = 150.0M;

                    maxWeight = 200M;

                    break;

                case 3:

                    minWeight = 200;

                    maxWeight = 500;

                    break;

                default:

                    validSelection = false;

                    Console.WriteLine("Invalid Selection");

                    break;

            }



            if (validSelection)

            {

                List<Player> playersByWeight = MyTeam.FindByWeight(minWeight, maxWeight);

                ListPlayers(playersByWeight);

            }



            Console.Write("Press any key to continue: ");

            Console.ReadKey();

            Console.Clear();

        }

        private void ListPlayersByUniformNumber()
        
        {

            Console.Clear();

            int UniformNumber;
            
            Console.WriteLine("Please enter a Uniform Number: ");
;
            string userinput = Console.ReadLine();

            int inputValue = int.Parse(userinput);

            Console.WriteLine($"Your selection is:{inputValue} ");

            List<Player> playersByUniformNumber = MyTeam.FindByUniformNumber(UniformNumber);

            ListPlayers(playersByUniformNumber);



            Console.Write("Press any key to continue: ");

            Console.ReadKey();

            Console.Clear();

































































        }

       











































    }

























































}






















