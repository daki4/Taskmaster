using System.Runtime.Serialization;

namespace Taskmaster.Models
{
    [DataContract]
    public class Company
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<Employee> Employees { get; private set; }
        [DataMember]
        public List<WorkTask> Tasks { get; private set; }

        public Company(string name)
        {
            Name = name;
            Employees = new List<Employee>();
            Tasks = new List<WorkTask>();
        }

        public Company(string name, List<Employee> employees, List<WorkTask> tasks)
        {
            Name = name;
            Employees = employees;
            Tasks = tasks;
        }
    }
}
