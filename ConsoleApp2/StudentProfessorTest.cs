using ConsoleApp2.Staff;

namespace ConsoleApp2
{
    public class StudentProfessorTest
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.SetAge(19);
            student.Greet();
            student.ShowAge();
            Teacher teacher = new Teacher();
            teacher.SetAge(47);
            teacher.Greet();
            teacher.Explain();
        }
    }
}