namespace Taskmaster.Models.DataHandling
{
    public static class TaskHandler
    {
        // the tasks
        public static List<WorkTask> Tasks
        {
            get
            {
                return _tasks;
            }
        }
        private static readonly List<WorkTask> _tasks = new();
        
        #region Tasks functionality
        public static WorkTask? UpStatus(WorkTask task)
        {
            if (task.Status >= WorkTaskStatus.Completed)
            {
                return null;
            }
            else
            {
                var idx = _tasks.FindIndex(x => x == task);
                task.Status++;
                _tasks[idx] = task;
                return _tasks[idx];
            }
        }
        public static WorkTask? DownStatus(WorkTask task)
        {
            if (task.Status == WorkTaskStatus.Open || task.Status >= WorkTaskStatus.Blocked)
            {
                return null;
            }
            else
            {
                var idx = _tasks.FindIndex(x => x == task);
                _tasks[idx] = task;
                return _tasks[idx];
            }
        }
        public static WorkTask? Block(WorkTask task)
        {
            if (task.Status == WorkTaskStatus.Blocked)
            {
                return null;
            }
            else
            {
                var idx = _tasks.FindIndex(x => x == task);
                task.Status = WorkTaskStatus.Blocked;
                _tasks[idx] = task;
                return _tasks[idx];
            }
        }
        public static WorkTask? Cancel(WorkTask task)
        {
            if (task.Status == WorkTaskStatus.Cancelled)
            {
                return null;
            }
            else
            {
                var idx = _tasks.FindIndex(x => x == task);
                task.Status = WorkTaskStatus.Cancelled;
                _tasks[idx] = task;
                return _tasks[idx];
            }
        }
        public static WorkTask? AddTask(WorkTask task)
        {
            if (_tasks.Contains(task))
            {
                return null;
            }
            _tasks.Add(task);
            return task;
        }
        public static WorkTask? RemoveTask(WorkTask task)
        {
            if (!_tasks.Contains(task))
            {
                return null;
            }
            if (task.Status == WorkTaskStatus.InProgress || task.Status == WorkTaskStatus.Completed)
            {
                return null;
            }
            if (task.Status == WorkTaskStatus.Blocked)
            {
                _tasks.Remove(task);
                return task;
            }
            if (task.Employees.Count > 0)
            {
                return null;
            }

            if (_tasks.Remove(task))
            {
                return task;
            }
            return null;
        }
        public static WorkTask? AddDepartment(WorkTask task, string Department)
        {
            if (!_tasks.Contains(task))
            {
                return null;
            }
            if (_tasks.Find(x => x == task).Departments.Contains(Department))
            {
                return null;
            }
            _tasks.Find(x => x == task).Departments.Add(Department);
            return _tasks.Find(x => x == task);
        }
        public static WorkTask? RemoveDepartment(WorkTask task, string Department)
        {
            if (!_tasks.Contains(task))
            {
                return null;
            }
            if (_tasks.Find(x => x == task).Departments.Contains(Department))
            {
                _tasks.Find(x => x == task).Departments.Remove(Department);
                return _tasks.Find(x => x == task);
            }
            return null;
        }
        public static WorkTask? AddEmployee(WorkTask task, string Employee)
        {
            if (!_tasks.Contains(task))
            {
                return null;
            }
            if (_tasks.Find(x => x == task).Employees.Contains(Employee))
            {
                return null;
            }
            _tasks.Find(x => x == task).Employees.Add(Employee);
            return _tasks.Find(x => x == task);
        }
        public static WorkTask? RemoveEmployee(WorkTask task, string Employee)
        {
            if (!_tasks.Contains(task))
            {
                return null;
            }
            if (_tasks.Find(x => x == task).Employees.Contains(Employee))
            {
                _tasks.Find(x => x == task).Employees.Remove(Employee);
                return _tasks.Find(x => x == task);
            }
            return null;
        }
        #endregion

        #region CSV/File handling
        public static void WriteTasksCsv(string Path)
        {
            var tasks = Tasks.Select(x => x.ToString()).ToList();
            if (tasks.Count > 0)
            {
                File.WriteAllLines(Path, tasks);
            }
        }
        public static void ReadTasksCsv(string Path)
        {
            var file = File.ReadAllLines(Path);
            foreach (var line in file)
            {
                var ln = line.Split(',');
                var task = new WorkTask(
                Convert.ToInt32(ln[0]),
                ln[1],
                ln[2].Split("\\@").ToHashSet(),
                Enum.Parse<WorkTaskStatus>(ln[3]),
                DateTime.Parse(ln[4]),
                ln[5].Split("\\@").ToHashSet(),
                ln[6]
                    );
                _tasks.Add(task);
            }
        }
        
        public static void ClearTasks()
        {
            _tasks.Clear();
        }
        #endregion

        #region Filtering
        public static List<WorkTask> Filter(Predicate<WorkTask> predicate)
        {
            return _tasks.FindAll(predicate);
        }
        #endregion
    }
}