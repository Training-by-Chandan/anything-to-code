using System;

namespace ConsoleApp
{
    public class LivingThings
    {
        protected string name { get; set; }

        public LivingThings()
        {
            this.name = "Living Things";
        }

        public LivingThings(string name)
        {
            this.name = name;
        }

        public void Eat()
        {
            Console.WriteLine($"{name} can eat");
        }
    }

    public class Animal : LivingThings
    {
        public Animal() : base("Animal")
        {
            this.name = "Animal";
        }

        public Animal(string name) : base()
        {
            this.name = name;
        }

        public void AnimalEat()
        {
            base.Eat();
        }
    }

    public class Plant : LivingThings
    {
        public Plant() : base("Plant")
        {
            this.name = "Plant";
        }
    }

    public class Apes : Animal
    {
        public Apes()
        {
        }
    }

    public class Human : Apes
    {
        public Human()
        {
        }
    }

    public class Man : Human
    {
        public Man()
        {
        }
    }

    public class Woman : Human
    {
        public Woman()
        {
        }
    }
}
