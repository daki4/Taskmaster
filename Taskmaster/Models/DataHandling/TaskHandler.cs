namespace Taskmaster.Models.DataHandling
{
    public static class TaskHandler
    {
        // the tasks
        public static readonly List<WorkTask> Tasks = new();
        
        //tasks functionality, abstracted away and put here
        public static WorkTask? UpStatus(WorkTask task)
        {
            if (task.Status >= WorkTaskStatus.Completed)
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
            if (task.Status == WorkTaskStatus.Open || task.Status >= WorkTaskStatus.Blocked)
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
