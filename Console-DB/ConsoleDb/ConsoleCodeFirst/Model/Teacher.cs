using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleCodeFirst.Model
{
    public class Teacher
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        [ForeignKey("ClassId")]
        public Classes Class { get; set; }
    }
}