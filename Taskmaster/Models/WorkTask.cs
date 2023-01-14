using System.Runtime.Serialization;

namespace Taskmaster.Models
{
    public class WorkTask
    {
        static int GlobId = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public HashSet<string> Departments { get; set; }
        public WorkTaskStatus? Status { get; set; }
        public DateTime Deadline { get; set; }
        public HashSet<Employee> Employees { get; set; }
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
