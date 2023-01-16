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
        public HashSet<string> Employees { get; set; }
        public string Description { get; set; }
        public string SearchableText { get; }

        public WorkTask(string name, HashSet<string> departments, WorkTaskStatus? status, DateTime deadline, HashSet<string> employees, string description)
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
        public WorkTask(int id, string name, HashSet<string> departments, WorkTaskStatus? status, DateTime deadline, HashSet<string> employees, string description)
        {
            Id = id;
            Name = name;
            Departments = departments;
            Status = status ?? WorkTaskStatus.Open;
            Deadline = deadline;
            Employees = employees;
            Description = description;
            SearchableText = $"{Name} {Description}";
        }
        public WorkTask(string name, HashSet<string>? departments, WorkTaskStatus? status, DateTime deadline, HashSet<string>? employees, string description, string searchableText)
        {
            Id = ++GlobId;

        }

        public override string ToString()
        {
            return $"{Id},{Name},{string.Join("\\@", Departments)},{(int?)Status ?? 0},{Deadline},{string.Join("\\@", Employees)},{Description}";
        }
    }
}
