using Taskmaster.Models;
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
            Company company = new("TestCompany");
            Employee employee1 = new(null, "asdasd", "Test1", "Testov1", Gender.Male, "Fuckoff", "123", "3355FK", "Eindhoven", "test1.testov1@test.com", "r&d");
            Employee employee2 = new(null, "asdasd", "Test2", "Testov2", Gender.Male, "Fuckoff", "123", "3355FK", "Eindhoven", "test2.testov2@test.com", "business");
            company.Employees.Add(employee1);
            company.Employees.Add(employee2);
            company.Tasks.Add(new WorkTask("testTask1", new HashSet<string> { "r&d" }, WorkTaskStatus.Blocked, DateTime.Now, new HashSet<Employee> { employee1, employee2 }, "This is a test task1."));
            company.Tasks.Add(new WorkTask("testTask2", new HashSet<string> { "r&d", "business" }, WorkTaskStatus.Blocked, DateTime.Now, new HashSet<Employee> { employee1, employee2 }, "This is a test task2."));
            company.Tasks.Add(new WorkTask("testTask3", new HashSet<string> { "r&d", "business" }, WorkTaskStatus.Blocked, DateTime.Now, new HashSet<Employee> { employee1, employee2 }, "This is a test task3."));
            company.Tasks.Add(new WorkTask("testTask4", new HashSet<string> { "r&d", "business" }, WorkTaskStatus.Blocked, DateTime.Now, new HashSet<Employee> { employee1, employee2 }, "This is a test task4."));

            State.CompanyContainer = company;
            State.Departments = departments;



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindowForm(null));
        }
    }
}