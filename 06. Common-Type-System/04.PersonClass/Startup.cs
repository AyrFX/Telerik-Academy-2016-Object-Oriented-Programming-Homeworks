namespace PersonClass
{
    class Startup
    {
        static void Main()
        {
            Person[] personsArray =
            {
                new Person("Pesho"),
                new Person("Gosho", 27),
                new Person("Tosho"),
                new Person("Mosho", 31)
            };

            foreach (var person in personsArray)
            {
                System.Console.WriteLine(person);
            }
        }
    }
}
