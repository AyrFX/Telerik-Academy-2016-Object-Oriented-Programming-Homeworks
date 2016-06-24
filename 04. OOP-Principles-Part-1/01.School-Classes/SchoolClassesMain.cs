namespace School_Classes
{
    using System;
    using School_Classes.Classes;

    public class SchoolClassesMain
    {
        public SchoolClassesMain()
        {
            throw new System.NotImplementedException();
        }
    
        public static void Main()
        {
            var p = new Person("Tosho", "Boshev");
            Console.WriteLine(p);

            var s = new Student("Mitko", "Pitkov", 23);
            Console.WriteLine(s);

            var t = new Teacher("Gosho", "Toshev");
            t.AddDiscipline(new Discipline("Mathematics", 20, 15));
            t.AddDiscipline(new Discipline("Geometry", 20, 25));
            t.AddDiscipline(new Discipline("Trigonometry", 25, 20));
            Console.WriteLine(t);

            var d = new Discipline("Mathematics", 20, 15);
            Console.WriteLine(d);

            var c = new Class("B");
            Console.WriteLine(c);
        }
    }
}
