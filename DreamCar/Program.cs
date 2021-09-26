using System;

namespace DreamCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Make your own dream car! ");
            Console.Write(" Select a car type between A: Family, B: Sport and C: Terrain: ");
            string carType = Console.ReadLine();
            Console.Write(" Select a car brand between A: Volvo, B: Skoda and C: Jeep: ");
            string carBrand = Console.ReadLine();

            PickCar(carType, carBrand);

            Console.Write(" Select a color between A: Blue, B: Red, C: Black ");
            string carColor = Console.ReadLine().ToUpper();

            bool boolInput1 = false;  
            bool boolInput2 = false;
            bool boolInput3 = false;

            Console.WriteLine(" Choose different options with 'y' for Yes or 'n' for No. PRESS ENTER PLS!!! "); // "AAC", "Automatic Gears", "Back-Camera" 
            Console.ReadKey();

            Console.Write(" Do you want to have an AAC? ");
            string input1= Console.ReadLine();

            if (input1 == "y" || input1 == "Y")
            {
                boolInput1 = true;
            }
            else if (input1 == "n" || input1 == "N")
            {
                boolInput1 = false;
            }
            Console.Write(" Do you want to have an Automatic Gears? ");
            string input2 = Console.ReadLine();

            if (input2 == "y" || input2 == "Y")
            {
                boolInput2 = true;
            }
            else if (input2 == "n" || input2 == "N")
            {
                boolInput2 = false;
            }
            Console.Write(" Do you want to have a Back-camera? ");
            string input3 = Console.ReadLine();

            if (input3 == "y" || input3 == "Y")
            {
                boolInput3 = true;
            }
            else if (input3 == "n" || input3 == "N")
            {
                boolInput3 = false;
            }

            PickOptions(carColor, boolInput1, boolInput2, boolInput3);

            YourCar.GetFinalCar();
            Console.WriteLine("Congratulations for your new car!!! ");
            Console.ReadKey();

        }

        static void PickCar(string input1, string input2)
        {
            Car car = new Car();
            car.CarTypeSelection(input1.ToUpper());
            Console.WriteLine();
            car.CarBrandSelection(input2.ToUpper());
            Console.WriteLine();
        }

        static void PickOptions(string color, bool input1, bool input2, bool input3)
        {
            Options opt = new Options();
            opt.CarColorSelection(color);
            opt.CarOptionSelection(input1, input2, input3);
            Console.WriteLine();
        }
    }
}
