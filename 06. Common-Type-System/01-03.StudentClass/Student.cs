using System;
namespace StudentClass
{
    class Student: ICloneable, IComparable
    {
        //Properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialties Specialty { get; set; }
        public Universities University { get; set; }
        public Faculties Faculty { get; set; }

        //Methods
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            var anotherStuden = obj as Student;
            if (anotherStuden.Equals(null))
            {
                return false;
            }
            else
            {
                if (this.SSN == anotherStuden.SSN)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString() =>  string.Format("{0} {1} {2}, SSN: {3}, Address: {4}, Phone: {5}, E-mail address: {6}, Course: {7}, Speciality: {8}, University: {9}, Faculty: {10}",
this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.Phone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);

        public override int GetHashCode() => this.MiddleName.GetHashCode() ^ this.SSN.GetHashCode();

        public object Clone() => this.MemberwiseClone();

        public int CompareTo(object obj)
        {
            string thisFullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            var otherStudent = obj as Student;
            string otherFullName = otherStudent.FirstName + " " + otherStudent.MiddleName + " " + otherStudent.LastName;

            if (thisFullName == otherFullName)
            {
                return this.SSN.CompareTo(otherStudent.SSN);
            }
            else
            {
                return thisFullName.CompareTo(otherFullName);
            }
        }

        //Operators
        public static bool operator ==(Student firstStudent, Student secondStudent) => firstStudent.SSN == secondStudent.SSN;

        public static bool operator !=(Student firstStudent, Student secondStudent) => !(firstStudent.SSN == secondStudent.SSN);
    }
}
