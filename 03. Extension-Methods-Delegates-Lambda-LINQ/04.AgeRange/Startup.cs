namespace AgeRange
{
    using System;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            Student[] studentsList = {
            new Student("Pesho", "Goshov", 21),
            new Student("Gosho", "Moshev", 27),
            new Student("Veso", "Peshev", 24),
            new Student("Tosho", "Moshev", 30),
            new Student("Mosho", "Peshev", 32),
            new Student("Pesho", "Vesev", 18),
            new Student("Aaaa!", "Z", 17)};

            var selectedStudents =
                from student in studentsList
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var student in selectedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.ReadLine();
        }
    }
}