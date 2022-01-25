using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EnginNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveAble { get; set; }

        
        

        
        public Car(int year, string make, string model, string enginNoise, string honkNoise, bool isDriveAble = false)
        {
            Year = year;
            Make = make;
            Model = model;
            EnginNoise = enginNoise;
            HonkNoise = honkNoise;

        }
        
        public void  MakeEnginNoise(string enginNoise)
        {
            Console.WriteLine(enginNoise);
        }
        public void MakeHonkNoise(string HonkNoise)
        {
           Console.WriteLine(HonkNoise);
        }
        






    }
}
