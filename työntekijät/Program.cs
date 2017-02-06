using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace työntekijät
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public Person() { }
        public Person(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Salary: " + Salary;
        }
    }
    class Teacher : Person
    {

        public Teacher() { }
        public Teacher(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Salary: " + Salary;
        }
    }
    class Boss : Person
    {

        public int Bonus { get; set; }
        public string Car { get; set; }

        public Boss() { }
        public Boss(string name, int age, int salary, int bonus, string car)
        {
            Name = name;
            Age = age;
            Salary = salary;
            Bonus = bonus;
            Car = car;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Age: " + Age + ", Salary: " + Salary + ", Bonus: " + Bonus + ", Car: " + Car;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Person PekkaPuupää = new Person("Pekka Puupää", 40, 1100);
            Teacher Santeri = new Teacher("Santeri", 32, 1500);
            Boss Jesse = new Boss("Jesse", 21, 8700, 1500, "Ferrari");
            Console.WriteLine(PekkaPuupää.ToString());
            Console.WriteLine(Santeri.ToString());
            Console.WriteLine(Jesse.ToString());
        }
    }
}