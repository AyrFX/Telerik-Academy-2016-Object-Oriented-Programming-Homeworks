namespace PersonClass
{
    public class Person
    {
        //Properties
        public string Name { get; set; }
        public byte? Age { get; set; }

        //Constructors
        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }

        //Methods
        public override string ToString()
        {
            if (this.Age == null)
            {
                return "Name: " + this.Name + "; Age:s unspecified";
            }
            else
            {
                return "Name: " + this.Name + "; Age: " + this.Age;
            }
        }
    }
}
