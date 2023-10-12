using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOmeTask10
{
    internal abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DriveTime { get; set; }
        public int DrivePath { get; set;}

        public int ProductionDate { get; }


        public Vehicle(string factoryname,string model,string color,int driveTime,int drivePath)
        {
            FactoryName = factoryname;
            Model = model;
            Color = color;
            DriveTime = driveTime;
            DrivePath = drivePath;


        }

        public int AvarageSpeed(int time,int way)
        {
            int speed=0;

           if (way >= 0 && time > 0)
           {
                speed = way / time; 
           }
            return speed ;
        }
        public virtual void GetInfo()
        {
            AvarageSpeed(20, 100);
        }

        public abstract void ToString();
        public abstract void DefineNatureHarmness();

    }
}
