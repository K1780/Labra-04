using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hissi
{
    class Elevator
    {
        private const int MaxFloor = 5;
        private int floor;
        public int Floor
        {
            get { return floor; }
            set
            {
                if (value > MaxFloor)
                    floor = MaxFloor;
                else if (value < 1)
                    floor = 1;
                else
                    floor = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Elevator Dynamo = new Elevator();
            do
            {
                Console.WriteLine("Input desired floor. Invalid input will exit program.");
                string InputString = Console.ReadLine();
                int InputInt;
                bool res = int.TryParse(InputString, out InputInt);
                if (res) { Dynamo.Floor = InputInt; }
                else break;
                Console.WriteLine("You went to floor {0}", Dynamo.Floor);
            } while (true);




        }
    }
}