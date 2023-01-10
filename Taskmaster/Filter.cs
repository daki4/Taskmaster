using Taskmaster.Models;
using Taskmaster.StateManagement;

namespace Taskmaster
{
    public static class Filter
    {        // filter types
        // search
        // department
        // status
        // dateFrom
        // dateTo
        public static List<WorkTask>? filter(string baseSearch, string dept, string status, DateTime start, DateTime end)
        {
            try
            {
                List<WorkTask> tasksToDisplay;
                if (baseSearch != "")
                {
                    tasksToDisplay = State.CompanyContainer.Tasks.Where(task => task.SearchableText.Contains(baseSearch)).ToList();
                }
                else
                {
                    tasksToDisplay = State.CompanyContainer.Tasks;
                }
                if (dept != "")
                {
                    tasksToDisplay = tasksToDisplay.FindAll(task => task.Departments.Contains(dept));
                }
                if (status != "")
                {
                    tasksToDisplay = tasksToDisplay.FindAll(task => task.Status == Enum.Parse<WorkTaskStatus>(status));
                }
                tasksToDisplay = tasksToDisplay.FindAll(task => task.Deadline.Date >= start.Date && task.Deadline.Date <= end.Date);
                return tasksToDisplay;
            }
            catch (Exception)
            {
                return new List<WorkTask>();
            }
        }
    }
}
