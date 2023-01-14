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
        public static WorkTask? UpStatus(WorkTask task)
        {
            if (task.Status == WorkTaskStatus.Completed || task.Status == WorkTaskStatus.InProgress)
            {
                return null;
            }
            else
            {
                var idx = Tasks.FindIndex(x => x == task);
                task.Status++;
                Tasks[idx] = task;
                return Tasks[idx];
            }
        }
        public static WorkTask? DownStatus(WorkTask task)
        {
            if (task.Status == WorkTaskStatus.Open || task.Status == WorkTaskStatus.Blocked)
            {
                return null;
            }
            else
            {
                var idx = Tasks.FindIndex(x => x == task);
                Tasks[idx] = task;
                return Tasks[idx];
            }
        }
        public static WorkTask? AddTask(WorkTask task)
        {
            if (Tasks.Contains(task))
            {
                return null;
            }
            Tasks.Add(task);
            return task;
        }
        public static WorkTask? RemoveTask(WorkTask task)
        {
            if (!Tasks.Contains(task))
            {
                return null;
            }
            if (task.Status == WorkTaskStatus.InProgress || task.Status == WorkTaskStatus.Completed)
            {
                return null;
            }
            Tasks.Remove(task);
            return task;
        }
        //public static 
    }
}
        //Open,
        //InProgress,
        //Completed,
        //Blocked,
        //Cancelled,
