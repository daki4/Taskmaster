using System.Net.NetworkInformation;
using System.Runtime.Serialization;

namespace Taskmaster.Models
{
    [DataContract]
    public class Company
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public static readonly List<Employee> Employees = new();
        [DataMember]
        public static readonly List<WorkTask> Tasks = new();

        public Company(string name)
        {
            Name = name;
        }

        public Company(string name, List<Employee> employees, List<WorkTask> tasks)
        {
            Name = name;
            Employees = employees;
            Tasks = tasks;
        }
        public static WorkTask? UpStatus(WorkTask task)
        {
            if (task.Status == WorkTaskStatus.Completed || task.Status == WorkTaskStatus.InProgress)
            {
                return null;
            }
            else
            {
                task.Status++;
                
                return task;
            }
        }
    }
}
