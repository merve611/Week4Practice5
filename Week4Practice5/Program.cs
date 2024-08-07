using Week4Practice5;

internal class Program
{
    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher("Merve", "Çakıroğlu", 85000);
        teacher.TeacherInfo();

        Student student = new Student("Emirhan", "Akkoyunlu", 150757026);
        student.StudentInfo();
    }
}