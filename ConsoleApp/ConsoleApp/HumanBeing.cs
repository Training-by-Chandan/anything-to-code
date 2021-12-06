using System;

namespace ConsoleApp
{
    public class HumanBeing
    {
        // this is constructor, a special function that runs only once in a lifetime
        //mostly in public
        //has the same name as that of class
        //does not have return type
        public HumanBeing()
        {
        }

        public HumanBeing(string Name)
        {
            name = Name;
        }

        //public HumanBeing(int i, string Occupation)
        //{
        //}

        //public HumanBeing(string i, int Occupation)
        //{
        //}

        public void RaiseHand()
        {
            Console.WriteLine("either left or right is raised");
        }

        public void RaiseHand(string hand)
        {
            Console.WriteLine("{1} moves {0} hand", hand, name);
        }

        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public string Name { get; set; }

        private string _name;

        public string _Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public void _setName()
        {
            _Name = "";
        }
    }
}
