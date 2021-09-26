using System;
using System.Collections.Generic;
using System.Text;

namespace DreamCar
{
    class Car
    {
        //Properties
        public static string CarType { get; set; }
        public static string CarBrand { get; set; }

        //Methods

        public void CarTypeSelection(string input)
        {
            string[] carTypes = new string[]{"Family", "Sports", "Terrain" };

            if (input == "a".ToUpper())
            {
                CarType = carTypes[0];
            }
            else if (input == "b".ToUpper())
            {
                CarType = carTypes[1];
            }
            else if (input == "c".ToUpper())
            {
                CarType = carTypes[2];
            }

        }

        public void CarBrandSelection(string input)
        {
            string[] carBrands = new string[] { "Volvo", "Skoda", "Jeep" };

            if (input == "a".ToUpper())
            {
                CarBrand = carBrands[0];
            }
            else if (input == "b".ToUpper())
            {
                CarBrand = carBrands[1];
            }
            else if (input == "c".ToUpper())
            {
                CarBrand = carBrands[2];
            }

        }

    }
}
