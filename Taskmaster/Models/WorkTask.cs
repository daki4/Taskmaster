using System.Runtime.Serialization;
using FileHelpers;

namespace Taskmaster.Models
{
    [DataContract]
    [DelimitedRecord(",")]
    public class WorkTask
    {
        static int GlobId = 0;
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public HashSet<string> Departments { get; set; }
        [DataMember]
        public WorkTaskStatus? Status { get; set; }
        [DataMember]
        [FieldConverter(ConverterKind.Date, "dd-MM-yyyy")]
        public DateTime Deadline { get; set; }
        [DataMember]
        public HashSet<Employee> Employees { get; set; }
        [DataMember]
        public string Description { get; set; }
        public string SearchableText { get; }

        public WorkTask(string name, HashSet<string> departments, WorkTaskStatus? status, DateTime deadline, HashSet<Employee> employees, string description)
        {
            Id = ++GlobId;
            Name = name;
            Departments = departments;
            Status = status ?? WorkTaskStatus.Open;
            Deadline = deadline;
            Employees = employees;
            Description = description;
            SearchableText = $"{Name} {Description}";
        }
    }
}
