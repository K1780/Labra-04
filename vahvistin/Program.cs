using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin
{
    class Amplifyer
    {
        private const int MaxVolume = 100;
        private const int MinVolume = 0;
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > MaxVolume)
                    volume = MaxVolume;
                else if (value < MinVolume)
                    volume = MinVolume;
                else
                    volume = value;
            }
        }
        public void TestVolume()
        {
            if (volume == MaxVolume)
            {
                Console.WriteLine("Volume at MAX.");
            }
            else if (volume == MinVolume)
            {
                Console.WriteLine("Volume at MIN.");
            }
            else
            {
                Console.WriteLine("Current volume is: {0}", Volume);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Amplifyer Amp = new Amplifyer();
            do
            {
                Console.WriteLine("Welcome to amplifyer. Press X for more volume and Z to lower it");
                string InputChar = Console.ReadKey().KeyChar.ToString();
                if (InputChar == "z")
                {
                    Amp.Volume = Amp.Volume - 1;
                }
                else if (InputChar == "x")
                {
                    Amp.Volume = Amp.Volume + 1;
                }
                else break;
                Console.Clear();
                Amp.TestVolume();
            } while (true);
        }
    }
}