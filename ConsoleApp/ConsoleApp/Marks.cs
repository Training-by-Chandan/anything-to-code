using System;

namespace ConsoleApp
{
    public class Marks
    {
        public Marks()
        {
        }

        public Marks(Marks m1)
        {
            Math = m1.Math;
            Science = m1.Science;
            English = m1.English;
        }

        public Marks(decimal Math, decimal Science)
        {
            this.Math = Math;
            Science = Science;
        }

        public Marks(decimal math, decimal science, decimal english)
        {
            this.Math = math;
            this.Science = science;
            this.English = english;
        }

        private decimal _math;

        public decimal Math
        {
            get { return _math; }
            set { _math = _validateMarks(value); }
        }

        private decimal _english;

        public decimal English
        {
            get { return _english; }
            set { _english = _validateMarks(value); }
        }

        private decimal _science;

        private decimal _validateMarks(decimal val)
        {
            return (val < 0) ? 0 : (val > 100) ? 100 : val;
        }

        public decimal Science
        {
            get { return _science; }
            set { _science = _validateMarks(value); }
        }

        public decimal Total
        { get { return Math + Science; } }

        public decimal Percentage
        { get { return (Total / 2); } }

        public string Division
        {
            get
            {
                if (Percentage >= 80)
                    return "Distinction";
                else if (Percentage >= 60)
                    return "First Division";
                else if (Percentage >= 45)
                    return "Second Division";
                else if (Percentage >= 32)
                    return "Third Division";
                else
                    return "Failed";
            }
        }

        public static Marks operator +(Marks m1, Marks m2) => new Marks(m1.Math + m2.Math, m1.Science + m2.Science, m1.English + m2.English);

        public static Marks operator +(Marks m1, int number)
        {
            return new Marks(m1.Math + number, m1.Science + number, m1.English + number);
        }

        public static Marks operator ++(Marks m1)
            => new Marks(m1.Math + 1, m1.Science + 1, m1.English + 1);

        public static bool operator ==(Marks m1, Marks m2)
        {
            return (m1.Math == m2.Math && m1.Science == m2.Science);
        }

        public static bool operator !=(Marks m1, Marks m2)
        {
            return !(m1.Math == m2.Math && m1.Science == m2.Science && m1.English == m2.English);
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(MiddleName)) return FirstName + " " + LastName;
                else return $"{FirstName} {MiddleName} {LastName}";
            }
        }
    }

    public class OurList
    {
        public string[] test;

        public OurList(string[] test)
        {
            this.test = test;
        }

        public string this[int i]
        {
            get { return test[i]; }
            set { test[i] = value; }
        }

        public void Resize(int newSize)
        {
            Array.Resize(ref test, newSize);
        }
    }

    public class Rootobject
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public float ppu { get; set; }
        public Batters batters { get; set; }
        public Topping[] topping { get; set; }
    }

    public class Batters
    {
        public Batter[] batter { get; set; }
    }

    public class Batter
    {
        public string id { get; set; }
        public string type { get; set; }
    }

    public class Topping
    {
        public string id { get; set; }
        public string type { get; set; }
    }
}
