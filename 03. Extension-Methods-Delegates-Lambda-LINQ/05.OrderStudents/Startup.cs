namespace OrderStudents
{
    using System;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            Student[] studentsList = {
            new Student("Pesho", "Goshov", 21),
            new Student("Gosho", "Moshev", 27),
            new Student("Veso", "Peshev", 24),
            new Student("Tosho", "Moshev", 30),
            new Student("Mosho", "Peshev", 32),
            new Student("Pesho", "Vesev", 18),
            new Student("Aaaa!", "Z", 17)};

            var orderedStudents =
                studentsList
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName);

            var orderedStudentsLINQ =
                from student in studentsList
                orderby student.FirstName descending, student.LastName descending
                select student;


            foreach (var student in orderedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.WriteLine(new string('=', 20));

            foreach (var student in orderedStudentsLINQ)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            Console.ReadLine();
        }
    }
}