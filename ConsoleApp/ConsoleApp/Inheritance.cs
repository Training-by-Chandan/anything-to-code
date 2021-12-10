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

        public virtual void Move()
        {
            Console.WriteLine("Living things may or may not move");
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

        public void Eat()
        {
        }

        public override void Move()
        {
            Console.WriteLine("Animal can move");
        }

        //public void AnimalEat()
        //{
        //    base.Eat();
        //}
    }

    public class Plant : LivingThings
    {
        public Plant() : base("Plant")
        {
            this.name = "Plant";
        }

        public void Move()
        {
            Console.WriteLine("Plant cannot move");
        }
    }

    public class Apes : Animal
    {
        public Apes()
        {
        }

        public void Move()
        {
            Console.WriteLine("Apes can move");
        }

        public override string ToString()
        {
            return "I am apes and I am evolving";
        }
    }

    public class Human : Apes
    {
        public Human()
        {
        }
    }

    public sealed class Man : Human
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

    public class SomeAnimal : Animal
    {
        public void SomeFunction()
        {
        }
    }
}
