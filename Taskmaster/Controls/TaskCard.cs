using Taskmaster.Models;
using Taskmaster.StateManagement;

namespace Taskmaster.Components
{
    public partial class TaskCard : UserControl
    {
        WorkTask _task;
        public WorkTask StoredTask
        {
            get
            {
                return _task;
            }
        }
        public WorkTask UpdateUsingObject
        {
            set
            {
                _task = value;
                DepartmentsLayoutPanel.Controls.Clear();
                lbBy.Items.Clear();
                foreach (string department in State.Departments)
                {
                    if (value.Departments.Contains(department))
                    {
                        DepartmentsLayoutPanel.Controls.Add(new Label { Text = department });
                    }
                }
                foreach (string author in value.Employees)
                {
                    lbBy.Items.Add(author);
                }
                lblDeadline.Text = value.Deadline.ToString();
                lblDescription.Text = value.Description;
                lblStatus.Text = value.Status.ToString();
                lblTask.Text = value.Name;
            }
        }

        // remember to give some values using the UpdateUsingObject property
        public TaskCard()
        {
            InitializeComponent();
        }
    }
}
