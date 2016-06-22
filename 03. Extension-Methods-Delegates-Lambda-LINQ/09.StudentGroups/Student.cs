namespace StudentGroups
{
    using System.Collections.Generic;

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FacultyNumber { get; set; }
        public int GroupNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public List<int> Marks { get; set; }

        public Student(string firstName, string lastName, int facultyNumber, int groupNumber, string phoneNumber, string email, List<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.GroupNumber = groupNumber;
            this.PhoneNumber = phoneNumber;
            this.EMail = email;
            this.Marks = marks;
        }

        public override string ToString()
        {
            string result = this.FirstName + " " + this.LastName + ", faculty Number: " +
                this.FacultyNumber + ", Group: " + this.GroupNumber + ", Phone: " +
                this.PhoneNumber + ", e-mail: " + this.EMail + ", Marks: " +
                string.Join(",", this.Marks);
            return result;
        }
    }
}