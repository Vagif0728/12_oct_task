using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace HOmeTask10
{
    internal class Bicycle : Vehicle
    {
        public string Type { get; set; }
        public Bicycle(string factoryname, string model, string color, int driveTime, int drivePath, string type) : base(factoryname, model, color, driveTime, drivePath)
        {
            Type = type;
        }

        public override void DefineNatureHarmness()
        {
            Console.WriteLine("Motorsuz iwleyir");
        }

        public override void ToString()
        {
            FactoryName= FactoryName;
            Model= Model;
        }
    }
}
