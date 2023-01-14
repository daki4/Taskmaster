namespace Taskmaster.Models
{
    public class Company
    {
        public string Name { get; set; }
        public static readonly List<Employee> Employees = new();
        public static readonly List<WorkTask> Tasks = new();

        public Company(string name)
        {
            Name = name;
        }

        public Company(string name, List<Employee> employees, List<WorkTask> tasks)
        {
            Name = name;
            Employees.AddRange(employees);
            Tasks.AddRange(tasks);
        }
        //public static 
    }
}
        //Open,
        //InProgress,
        //Completed,
        //Blocked,
        //Cancelled,
