using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {
        int doors, horsePower;
        string color, mark, vinNumber;
        public int Doors
        {
            get => doors;
            set
            {
                this.doors = value;
            }
        }
        public int HorsePower
        {
            get => horsePower;
            set
            {
                this.horsePower = value;
            }
        }
        public string Color
        {
            get => color;
            set
            {
                this.color = value;
            }
        }
        public string Mark
        {
            get => mark;
            set
            {
                this.mark = value;
            }
        }
        public string VinNumber
        {
            get => vinNumber;
            set
            {
                this.vinNumber = value;
            }
        }
        public override string ToString() => $"Mark: {Mark}\n" +
            $"VIN-Number: {VinNumber}\n" +
            $"Color: {Color}\n" +
            $"Count of doors: {Doors}\n" +
            $"Horse power: {HorsePower}\n";
    }

    public class Sedan : Car
    {
        bool presenceOfSpareWheel;
        public bool PresenceOfSpareWheel
        {
            get => presenceOfSpareWheel;
            set
            {
                this.presenceOfSpareWheel = value;
            }
        }
        public override string ToString() => base.ToString() + 
            $"The presence of a spare wheel: {PresenceOfSpareWheel}\n";
    }
    public class Hatchback : Car
    {
        int trunkVolume;
        public int TrunkVolume
        {
            get => trunkVolume;
            set
            {
                this.trunkVolume = value;
            }
        }
        public override string ToString() => base.ToString() +
            $"The trunk volume: {TrunkVolume}\n";
    }
    public class Liftback : Car 
    {
        double timeTo100;
        public double TimeTo100
        {
            get => timeTo100;
            set
            {
                this.timeTo100 = value;
            }
        }
        public override string ToString() => base.ToString() +
            $"Time to 100: {TimeTo100}\n";
    }
}
