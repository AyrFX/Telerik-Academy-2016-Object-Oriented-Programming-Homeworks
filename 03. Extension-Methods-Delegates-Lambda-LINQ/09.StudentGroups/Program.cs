﻿namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        public static void Main()
        {
            var studentsList = new List<Student>();
            studentsList.Add(new Student("Pesho", "Goshev", 1111111, 1, "+359(88)9999999", "pesho@goshev.com", new List<int> { 3, 4, 2, 6 }));
            studentsList.Add(new Student("Gosho", "Moshev", 2222222, 2, "+359(88)8888888", "gosho@moshev.com", new List<int> { 5, 5, 6, 5 }));
            studentsList.Add(new Student("Veso", "Peshev", 3333333, 3, "+359(88)7777777", "veso@peshev.com", new List<int> { 2, 5, 6, 6 }));
            studentsList.Add(new Student("Tosho", "Moshev", 4444444, 2, "+359(88)6666666", "tosho@moshev.com", new List<int> { 6, 6, 2, 6 }));
            studentsList.Add(new Student("Mosho", "Peshev", 5555555, 3, "+359(88)5555555", "mosho@peshev.com", new List<int> { 3, 3, 3, 3 }));
            studentsList.Add(new Student("Pesho", "Vesev", 6666666, 2, "+359(88)4444444", "pesho@vesev.com", new List<int> { 4, 4, 5, 6 }));
            studentsList.Add(new Student("Mesho", "Geshev", 7777777, 1, "+359(88)3333333", "mesho@geshev.com", new List<int> { 5, 6, 4, 3 }));

            var secondGroupExt =
                studentsList
                .Where(x => x.GroupNumber == 2)
                .Select(x => x)
                .OrderBy(x => x.FirstName);

            var secondGroupLINQ =
                from student in studentsList
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in secondGroupExt)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('=', 20));

            foreach (var student in secondGroupLINQ)
            {
                Console.WriteLine(student);
            }

            Console.ReadKey(true);
        }
    }
}