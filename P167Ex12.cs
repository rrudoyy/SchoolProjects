
namespace ConsoleApp
{

    internal class Program
    {

        public static void Main(string[] args)
        {

            int id = 0, grade = 0;
            bool finishGrades = false;
            Student student;

            List<Student> students = new List<Student>();

            do
            {
                Console.WriteLine("Enter the student ID:");
                id = int.Parse(Console.ReadLine());
                if (id == -1)
                    break;

                student = new Student(id);
                while (!finishGrades)
                {
                    Console.WriteLine("Enter the student grade:");
                    grade = int.Parse(Console.ReadLine());
                    if (grade == -999)
                        break;
                    else
                        student.AddGrade(grade);
                }

                students.Add(student);

            } while (id != -1);

            Console.WriteLine("The amount of students - " + students.Count);
            students.ForEach(s => Console.WriteLine("Student #" + s.GetID() + " - " + s.GetGrades().Average()));
            Console.WriteLine(students.Where(s => s.GetGrades()[0] >= 90).Count());

        }

    }

    public class Student
    {
        private int Id;
        public List<int> grades;

        public Student(int Id)
        {
            this.Id = Id;
            this.grades = new List<int>();
        }

        public void AddGrade(int grade)
        {
            grades.Add(grade);
        }

        public int GetID()
        {
            return Id;
        }
        public List<int> GetGrades()
        {
            return grades;
        }
    }

}