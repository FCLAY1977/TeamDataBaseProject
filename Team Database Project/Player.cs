using Team_Database_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeLouisvilleLibrary;


namespace Team_Database_Project
{
    public class Player
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Height { get; set; }
        public int Weight { get; set; }
        public int UniformNumber { get; set; }
        public decimal SkillLevel { get; set; }
        public decimal FieldGoalPercentage { get; set; }



        private string HeightAsString

        {

            get

            {

                return Height.ToString("0.0#").Replace(".", "'") + "\"";

            }

        }



        // this will display a player. \t is a tab 

        // FRED YOU MAY WANT TO CHANGE THIS TO DISPLAY DIFFERENTLY 

        public override string ToString()

        {

            return $"{UniformNumber}\t{Position}\t{Name}\t{HeightAsString}\\{Weight}lbs\t{SkillLevel}\t{FieldGoalPercentage}";

        }

    }

} 
    
    
    

 













































