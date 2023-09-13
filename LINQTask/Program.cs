using System.Linq;

namespace LINQTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

         static string[] GetAllStudents(Classroom[] classes)
         {    
           var result = from student in classes from person in student.Students select person;
            return result.ToArray();
         }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}