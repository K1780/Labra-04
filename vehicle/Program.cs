using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle
{
    class Vehicle
    {

        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
    }
    class Bike : Vehicle
    {

        public bool Gears { get; set; }
        private string gearmodel;
        public string GearModel
        {
            get
            {
                return gearmodel;
            }
            set
            {
                if (Gears)
                {
                    gearmodel = value;
                }
            }
        }

        public Bike() { }
        public Bike(string name, string model, int year, string colour, bool gears, string gearmodel)
        {
            Name = name;
            Model = model;
            Year = year;
            Colour = colour;
            Gears = gears;
            GearModel = gearmodel;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Model: " + Model + " Year: " + Year + " Colour: " + Colour + " Gears:" + Gears + " Gears model: " + GearModel;
        }
    }
    class Boat : Vehicle
    {

        public string Type { get; set; }
        public int SeatCount { get; set; }

        public Boat() { }
        public Boat(string name, string model, int year, string colour, string type, int seatcount)
        {
            Name = name;
            Model = model;
            Year = year;
            Colour = colour;
            Type = type;
            SeatCount = seatcount;
        }

        public override string ToString()
        {
            return "Name: " + Name + " Model: " + Model + " Year: " + Year + " Colour: " + Colour + " Type:" + Type + " Seat count: " + SeatCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bike Shimano = new Bike("Shimano", "Speed", 2011, "Yellow", true, "Shimano v3");
            Bike Jopo = new Bike("Jopo", "Street", 2006, "Blue", false, "");
            Boat Merilainen = new Boat("Tauno", "Rower 100", 1991, "Black", "Rowboat", 5);
            Boat Busteri = new Boat("Buster", "XL", 2012, "Red", "Motor boat", 3);
            Console.WriteLine(Shimano.ToString());
            Console.WriteLine(Jopo.ToString());
            Console.WriteLine(Merilainen.ToString());
            Console.WriteLine(Busteri.ToString());
        }
    }
}