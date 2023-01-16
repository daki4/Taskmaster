namespace Taskmaster.Models
{
    public class Employee
    {
        static int GlobId = 0;
        public int Id { get; private set; }
        public string Ssn { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Gender? Gender { get; private set; }
        public string StreetName { get; private set; }
        public string StreetNumber { get; private set; }
        public string Zipcode { get; private set; }
        public string City { get; private set; }
        public string Email { get; private set; }
        public string Department { get; private set; }

        public Employee(int? id, string ssn, string firstName, string lastName, Gender? gender, string streetName, string streetNumber, string zipcode, string city, string email, string department)
        {
            Id = id ?? (GlobId += 1);
            Ssn = ssn;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            StreetName = streetName;
            StreetNumber = streetNumber;
            Zipcode = zipcode;
            City = city;
            Email = email;
            Department = department;
        }

        public Employee() { }

        public override string ToString()
        {
            return $"{Id},{Ssn},{FirstName},{LastName},{Gender},{StreetName},{StreetNumber},{Zipcode},{City},{Email},{Department}";
        }
    }
}
