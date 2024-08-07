using Week4Practice5;

internal class Program
{
    public static void Main(string[] args)
    {
        BasePerson teacher = new Teacher("Merve", "Çakıroğlu", 85000);
        teacher.InfoPerson();

        BasePerson student = new Student("Emirhan", "Akkoyunlu", 150757026);
        student.InfoPerson();
    }
}