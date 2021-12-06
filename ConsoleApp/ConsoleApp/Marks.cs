namespace ConsoleApp
{
    public class Marks
    {
        public Marks()
        {
        }

        public Marks(decimal math, decimal science)
        {
            this.Math = math;
            this.Science = science;
        }

        private decimal _math;

        public decimal Math
        {
            get { return _math; }
            set { _math = _validateMarks(value); }
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
