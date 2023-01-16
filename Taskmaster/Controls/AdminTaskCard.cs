using Taskmaster.Models;
using Taskmaster.Models.DataHandling;

namespace Taskmaster.Components
{
    public partial class AdminTaskCard : UserControl
    {
        public WorkTask UpdateUsingObject
        {
            set
            {
                TaskCard.UpdateUsingObject = value;
                cbAddDept.Items.Clear();
                cbRemoveDept.Items.Clear();

                UpdateEmployees();

                lblPStatus.Text = value.Status.ToString();

                foreach (var dept in value.Departments)
                {
                    cbRemoveDept.Items.Add(dept);
                }

                foreach (var dept in StateManagement.State.Departments)
                {
                    if (!value.Departments.Contains(dept))
                    {
                        cbAddDept.Items.Add(dept);
                    }
                }

                btnDelete.Enabled = value.Status switch
                {
                    WorkTaskStatus.Open => true,
                    WorkTaskStatus.Blocked => true,
                    WorkTaskStatus.Cancelled => true,
                    _ => false
                };

                if (value.Employees.Count > 0)
                {
                    btnDelete.Enabled = false;
                }

                btnDownStatus.Enabled = value.Status switch
                {
                    WorkTaskStatus.Open => false,
                    WorkTaskStatus.Cancelled => false,
                    WorkTaskStatus.Blocked => false,
                    WorkTaskStatus.Completed => false,
                    _ => true
                };

                btnUpStatus.Enabled = value.Status switch
                {
                    WorkTaskStatus.Completed => false,
                    WorkTaskStatus.Blocked => false,
                    WorkTaskStatus.Cancelled => false,
                    _ => true
                };
            }
        }
        private void UpdateEmployees()
        {
            cbAddEmployee.Items.Clear();
            cbRemoveEmployee.Items.Clear();

            foreach (var employee in TaskCard.StoredTask.Employees)
            {
                cbRemoveEmployee.Items.Add(employee);
            }

            foreach (var employee in StateManagement.State.Employees)
            {
                var name = $"{employee.FirstName} {employee.LastName}";
                if (!TaskCard.StoredTask.Departments.Contains(name))
                {
                    cbAddEmployee.Items.Add(name);
                }
            }
        }
        private void AdminTaskCard_Click(object sender, EventArgs e)
        {
            TaskCard.Hide();
            pControls.Show();
            UpdateUsingObject = TaskCard.StoredTask;
        }

        // update the card after creation!
        public AdminTaskCard()
        {
            InitializeComponent();
        }
        private void btnDownStatus_Click(object sender, EventArgs e)
        {
            var ret = TaskHandler.DownStatus(TaskCard.StoredTask);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }
        private void btnUpStatus_Click(object sender, EventArgs e)
        {
            var ret = TaskHandler.UpStatus(TaskCard.StoredTask);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }
        private void btnBlock_Click(object sender, EventArgs e)
        {
            var ret = TaskHandler.Block(TaskCard.StoredTask);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }
        private void btnCancelTask_Click(object sender, EventArgs e)
        {
            var ret = TaskHandler.Cancel(TaskCard.StoredTask);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }
        private void cbRemoveDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ret = TaskHandler.RemoveDepartment(TaskCard.StoredTask, cbRemoveDept.Text);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }
        private void cbAddEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ret = TaskHandler.AddEmployee(TaskCard.StoredTask, cbAddEmployee.Text);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }
        private void cbRemoveEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ret = TaskHandler.RemoveEmployee(TaskCard.StoredTask, cbRemoveEmployee.Text);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }
        private void cbAddDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ret = TaskHandler.AddDepartment(TaskCard.StoredTask, cbAddDept.Text);
            _ = ret ?? throw new NullReferenceException();
            UpdateUsingObject = ret;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TaskCard.Show();
            pControls.Hide();
            UpdateUsingObject = TaskCard.StoredTask;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            TaskHandler.RemoveTask(TaskCard.StoredTask);
            RefreshEvent.RaiseRefreshEvent(this, new());
        }
    }
}
