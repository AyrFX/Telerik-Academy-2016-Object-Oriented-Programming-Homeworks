namespace StudentClass
{
    using System;
    class Startup
    {
        static void Main()
        {
            var someStudent = new Student();
            someStudent.FirstName = "Pesho";
            someStudent.MiddleName = "Goshev";
            someStudent.LastName = "Toshev";
            someStudent.SSN = "33344477712";
            someStudent.Address = "First Student's Address";
            someStudent.Phone = "First Students Phone";
            someStudent.Email = "First Student's E-mail";
            someStudent.Course = "fift";
            someStudent.Specialty = Specialties.Economics;
            someStudent.University = Universities.UNSS;
            someStudent.Faculty = Faculties.Economics_Sciences;
            var anotherStudent = new Student();
            anotherStudent.FirstName = "Gosho";
            anotherStudent.MiddleName = "Toshev";
            anotherStudent.LastName = "Peshov";
            anotherStudent.SSN = "44477712333";
            anotherStudent.Address = "Second Student's Address";
            anotherStudent.Phone = "Second Students Phone";
            anotherStudent.Email = "First Student's E-mail";
            anotherStudent.Course = "third";
            anotherStudent.Specialty = Specialties.Mathematics;
            anotherStudent.University = Universities.SU;
            anotherStudent.Faculty = Faculties.Mathematics_Sciences;
            
            Console.WriteLine(someStudent.Equals(someStudent));
            Console.WriteLine(someStudent);
        }
    }
}
