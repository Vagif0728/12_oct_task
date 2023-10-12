using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOmeTask10
{
    internal class Car : Vehicle
    {

        public int DoorCount { get; set; }
        public bool IsElectricCar { get; set; }

        public Car(string factoryname, string model, string color, int driveTime, int drivePath, int doorCount, bool ısElectricCar) : base(factoryname, model, color, driveTime, drivePath)
        {
            DoorCount = doorCount;
            IsElectricCar = ısElectricCar;
        }



        public override void DefineNatureHarmness()
        {
            if (IsElectricCar)
            {
                Console.WriteLine("Elektrikle iwleyir");
            }
            else
            {
                Console.WriteLine("Benzinle iwleyir");
            }
        }

        public override void ToString()
        {
            FactoryName= FactoryName;
            Model= Model;
        }
    }
}
