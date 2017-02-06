using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Radio
    {
        public bool OnOff { get; set; }
        public double Frequency { get; set; }
        public string StationName { get; set; }

        public Radio(string stationname, double frequency)
        {
            StationName = stationname;
            Frequency = frequency;
        }
        public double TuneUp()
        {
            return Math.Round((Frequency + 0.1), 1);
        }
        public double TuneDown()
        {
            return Math.Round((Frequency - 0.1), 1);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Radio PinellSupersoundII = new Radio("default", 99.2);
            List<Radio> StationList = new List<Radio>();

            bool electricity = true;
            while (electricity == true)
            {

                Console.WriteLine("Current frequency: {0}", PinellSupersoundII.Frequency);
                Console.WriteLine();
                Console.WriteLine("0. Pull the plug");
                Console.WriteLine("1. Set preset");
                Console.WriteLine("2. Tune up");
                Console.WriteLine("3. Tune down");
                Console.WriteLine("4. Show preset list");
                Console.WriteLine("5. Switch to preset");

                int MenuChoice = 0;
                bool Loop = true;
                while (Loop == true)
                {
                    int num;
                    bool res = int.TryParse(Console.ReadKey().KeyChar.ToString(), out num);
                    if (res == true)
                    {
                        MenuChoice = num;
                        Loop = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice");
                    }
                }

                Console.Clear();
                switch (MenuChoice)
                {
                    case 0:
                        electricity = false;
                        break;
                    case 1:
                        Console.WriteLine("Write name for saved preset: ");
                        string presetName = Console.ReadLine();
                        StationList.Add(new Radio(presetName, PinellSupersoundII.Frequency));
                        break;

                    case 2:
                        PinellSupersoundII.Frequency = PinellSupersoundII.TuneUp();
                        break;
                    case 3:
                        PinellSupersoundII.Frequency = PinellSupersoundII.TuneDown();
                        break;
                    case 4:
                        for (int x = 0; x < StationList.Count; x++)
                        {
                            Console.WriteLine("Station {0}: {1}, Frequency: {2}.", (x + 1), StationList[x].StationName, StationList[x].Frequency);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Choose channel:");
                        for (int x = 0; x < StationList.Count; x++)
                        {
                            Console.WriteLine("Station {0}: {1}, Frequency: {2}.", (x + 1), StationList[x].StationName, StationList[x].Frequency);
                        }
                        int num;
                        bool res = int.TryParse(Console.ReadLine(), out num);
                        if (res == true)
                        {
                            PinellSupersoundII.Frequency = StationList[num - 1].Frequency;
                        }
                        break;
                }
            }

        }
    }
}
