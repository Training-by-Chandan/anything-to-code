using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class StudentModel
    {
        public StudentModel()
        {
            this.Subjects = new List<SubjectModel>();
            this.Claases = new List<Claases>();
        }

        public string FName { get; set; }
        public string LName { get; set; }
        public List<SubjectModel> Subjects { get; set; }
        public List<Claases> Claases { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    public class Claases
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }

    public class SubjectModel
    {
        public string Name { get; set; }
        public float Marks { get; set; }
    }

    public class SubjectModelNew
    {
        public string Name { get; set; }
        public float Exam1 { get; set; }
        public float Exam2 { get; set; }
    }

    public static class StudentData
    {
        public static StudentModel GenerateDummyData()
        {
            var st = new StudentModel();
            st.FName = "Kamlesh";
            st.LName = "Singh";
            st.Subjects.Add(new SubjectModel { Name = "English", Marks = 50 });
            st.Subjects.Add(new SubjectModel { Name = "Science", Marks = 80 });
            st.Subjects.Add(new SubjectModel { Name = "Nepali", Marks = 70 });
            st.Subjects.Add(new SubjectModel { Name = "Math", Marks = 60 });
            st.Subjects.Add(new SubjectModel { Name = "Account", Marks = 40 });
            st.Claases.Add(new Claases { Name = "Class 1", Year = 2000 });
            st.Claases.Add(new Claases { Name = "Class 2", Year = 2001 });
            st.Claases.Add(new Claases { Name = "Class 3", Year = 2002 });
            st.Claases.Add(new Claases { Name = "Class 4", Year = 2003 });
            st.Claases.Add(new Claases { Name = "Class 5", Year = 2004 });
            st.Claases.Add(new Claases { Name = "Class 6", Year = 2005 });
            st.Claases.Add(new Claases { Name = "Class 7", Year = 2006 });
            return st;
        }

        public static List<SubjectModel> GenerateDummySubjects()
        {
            return new List<SubjectModel>() {
            new SubjectModel(){ Name="English", Marks=20 },
            new SubjectModel(){ Name="Nepali", Marks=20 },
            new SubjectModel(){ Name="Science", Marks=20 },
            new SubjectModel(){ Name="Computer", Marks=20 },
            new SubjectModel(){ Name="Math", Marks=20 },
            };
        }

        public static List<SubjectModel> GenerateDummySubjectsV2()
        {
            return new List<SubjectModel>() {
            new SubjectModel(){ Name="English", Marks=30 },
            new SubjectModel(){ Name="Nepali", Marks=30 },
            new SubjectModel(){ Name="Science", Marks=30 },
            new SubjectModel(){ Name="Computer", Marks=30 },
            new SubjectModel(){ Name="Math", Marks=30 },
            };
        }
    }
}
