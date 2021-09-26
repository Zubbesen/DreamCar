using System;
using System.Collections.Generic;
using System.Text;

namespace DreamCar
{
    class Options
    {
        //Properties
        public static string CarColor { get; set; }
        public static string[] CarOptions { get; set; }

        //Methods
        public void CarColorSelection(string input)
        {
            string[] carColor = new string[] { "Blue", "Red", "Black" };

            if (input == "a".ToUpper())
            {
                CarColor = carColor[0];
            }
            else if (input == "b".ToUpper())
            {
                CarColor = carColor[1];
            }
            else if (input == "c".ToUpper())
            {
                CarColor = carColor[2];
            }

        }

        public void CarOptionSelection(bool input1, bool input2, bool input3)
        {
            CarOptions = new string[] {"","","" }; 
            string[] carOptionsInputs = new string[] { "AAC", "Automatic Gears", "Back-Camera" };

            if (input1 == true)
            {
                CarOptions[0] = carOptionsInputs[0];
            }
            else
                CarOptions[0] = " ";

            if (input2 == true)
            {
                CarOptions[1] = carOptionsInputs[1];
            }
            else
                CarOptions[1] = " ";
            if (input3 == true)
            {
                CarOptions[2] = carOptionsInputs[2];
            }
            else
                CarOptions[2] = " ";
        }
    }
}
