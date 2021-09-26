using System;
using System.Collections.Generic;
using System.Text;

namespace DreamCar
{
    static class YourCar
    {
        public static string FinalCar { get; set; }

        public static void GetFinalCar()
        {
            CarCombo();
        }

        private static void CarCombo()
        {
            Console.WriteLine("This is your " + Options.CarColor + " " + Car.CarBrand + " " + Car.CarType + " car with" + "\n" + 
                "*** "+ Options.CarOptions[0] + "\n"+
                "*** " + Options.CarOptions[1] + "\n"+
                "*** " + Options.CarOptions[2] + ".");
        }
    }
}
