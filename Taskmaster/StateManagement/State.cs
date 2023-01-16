using Taskmaster.Models;

namespace Taskmaster.StateManagement
{
    public static class State
    {
        public static List<string> Departments { get; set; }
        public static readonly List<Employee> Employees = new();

    }
}
