using System.Runtime.Serialization;

namespace Taskmaster.Models
{
    [DataContract]
    public class WorkTask
    {
        static int GlobId = 0;
        [DataMember]
        public int Id { get; private set; }
        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public HashSet<string> Departments { get; private set; }
        [DataMember]
        public WorkTaskStatus? Status { get; private set; }
        [DataMember]
        public DateTime Deadline { get; private set; }
        [DataMember]
        public HashSet<Employee> Employees { get; private set; }
        [DataMember]
        public string Description { get; private set; }
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
