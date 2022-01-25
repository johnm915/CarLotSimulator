using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Carlot lot = new Carlot();

            Car toyota = new Car();
            lot.CarList.Add(toyota);


            
            toyota.Year = 2015;
            toyota.Make = "Toyota";
            toyota.Model = "Corolla";
            toyota.EnginNoise = "vroooom";
            toyota.HonkNoise = "beep beep";
            toyota.IsDriveAble = true;

            
            toyota.MakeEnginNoise(toyota.EnginNoise);
            toyota.MakeHonkNoise(toyota.HonkNoise);

            //object
            Car Camery = new Car() { Year = 2020, Make = "Toyota", Model="Camery", EnginNoise= "vrom vrom", HonkNoise = "ting ting" };
            Camery.MakeEnginNoise(Camery.EnginNoise);
            Camery.MakeHonkNoise(Camery.HonkNoise);
            lot.CarList.Add(Camery);

            //constructor
            Car Junk = new Car { Year = 1980, Make = "Junk", Model = "Black", EnginNoise = "nothing", HonkNoise = "loud" };
            Junk.MakeEnginNoise(Junk.EnginNoise);
            Junk.MakeHonkNoise(Junk.HonkNoise);

            Console.WriteLine("---------------");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            foreach (var car in lot.CarList)
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }



            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
