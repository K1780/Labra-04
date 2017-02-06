using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kirjahylly
{
    class Item
    {
        //variables
        public string Name { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
    }
    class CdDisk : Item
    {

        public int TrackCount { get; set; }

        public CdDisk() { }
        public CdDisk(string name, int amount, int price, int trackcount)
        {
            Name = name;
            Amount = amount;
            Price = price;
            TrackCount = trackcount;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Amount: " + Amount + ", Price: " + Price + ", Track count: " + TrackCount;
        }
    }
    class Book : Item
    {

        public int PageCount { get; set; }

        public Book() { }
        public Book(string name, int amount, int price, int pagecount)
        {
            Name = name;
            Amount = amount;
            Price = price;
            PageCount = pagecount;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Amount: " + Amount + ", Price: " + Price + ", Page count: " + PageCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CdDisk Muumit = new CdDisk("Muumien parhaat", 2, 20, 24);
            Book Juoppohullu = new Book("Juoppohullun päiväkirja", 1, 15, 345);
            Console.WriteLine("Bookcase inventory: ");
            Console.WriteLine(Muumit.ToString());
            Console.WriteLine(Juoppohullu.ToString());
        }
    }
}