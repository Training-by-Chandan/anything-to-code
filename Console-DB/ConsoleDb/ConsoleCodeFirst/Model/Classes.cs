using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleCodeFirst.Model
{
    public class Classes
    {
        [Key]
        public int Id { get; set; }

        public string ClassName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}