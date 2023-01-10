using System.Runtime.Serialization;

namespace Taskmaster.Models
{
    [DataContract]
    public class Employee
    {
        static int GlobId = 0;
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string Ssn { get; private set; }
        [DataMember]
        public string FirstName { get; private set; }
        [DataMember]
        public string LastName { get; private set; }
        [DataMember]
        public Gender? Gender { get; private set; }
        [DataMember]
        public string StreetName { get; private set; }
        [DataMember]
        public string StreetNumber { get; private set; }
        [DataMember]
        public string Zipcode { get; private set; }
        [DataMember]
        public string City { get; private set; }
        [DataMember]
        public string Email { get; private set; }
        [DataMember]
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
    }
}
