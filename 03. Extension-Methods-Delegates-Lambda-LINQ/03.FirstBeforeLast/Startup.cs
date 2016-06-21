namespace FirstBeforeLast
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            Student[] studentsList = new Student[] {
            new Student("Pesho", "Goshov"),
            new Student("Gosho", "Moshev"),
            new Student("Veso", "Peshev"),
            new Student("Tosho", "Moshev"),
            new Student("Mosho", "Peshev"),
            new Student("Pesho", "Vesev"),
            new Student("Aaaa!", "Z")};

            var selectedStudents =
                from student in studentsList
                where string.Compare(student.FristName, student.LastName, StringComparison.Ordinal) < 0
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine("{0} {1}", student.FristName, student.LastName);
            }
        }
    }
}
