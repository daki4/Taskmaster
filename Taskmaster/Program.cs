using Taskmaster.Models;
using Taskmaster.Models.DataHandling;
using Taskmaster.StateManagement;

namespace Taskmaster
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> departments = new(new string[4] { "r&d", "business", "marketing", "sales" });
            Employee employee1 = new(null, "asdasd", "Test1", "Testov1", Gender.Male, "Fuckoff", "123", "3355FK", "Eindhoven", "test1.testov1@test.com", "r&d");
            Employee employee2 = new(null, "asdasd", "Test2", "Testov2", Gender.Male, "Fuckoff", "123", "3355FK", "Eindhoven", "test2.testov2@test.com", "business");
            //company.Employees.Add(employee1);
            //company.Employees.Add(employee2);
            TaskHandler.AddTask(new WorkTask("testTask1", new HashSet<string> { "r&d" }, WorkTaskStatus.Blocked, DateTime.Now, new HashSet<string> { $"{employee1.FirstName} {employee1.LastName}", $"{employee2.FirstName} {employee2.LastName}" }, "This is a test task1."));
            TaskHandler.AddTask(new WorkTask("testTask2", new HashSet<string> { "r&d", "business" }, WorkTaskStatus.Blocked, DateTime.Now, new HashSet<string> { $"{employee1.FirstName} {employee1.LastName}", $"{employee2.FirstName} {employee2.LastName}" }, "This is a test task2."));
            TaskHandler.AddTask(new WorkTask("testTask3", new HashSet<string> { "r&d", "marketing" }, WorkTaskStatus.Open, DateTime.Now, new HashSet<string> { $"{employee1.FirstName} {employee1.LastName}", $"{employee2.FirstName} {employee2.LastName}" }, "This is a test task3."));
            TaskHandler.AddTask(new WorkTask("testTask4", new HashSet<string> { "r&d", "business" }, WorkTaskStatus.Blocked, DateTime.Now, new HashSet<string> { $"{employee1.FirstName} {employee1.LastName}", $"{employee2.FirstName} {employee2.LastName}" }, "This is a test task4."));

            State.Departments = departments;



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindowForm(null));
        }
    }
}