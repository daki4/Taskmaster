using Taskmaster.Components;
using Taskmaster.Models;
using Taskmaster.Models.DataHandling;
using Taskmaster.StateManagement;
using WK.Libraries.HotkeyListenerNS;

namespace Taskmaster
{
    public partial class MainWindowForm : Form
    {
        public void ForceUdate()
        {
            _update();
        }
        HotkeyListener hotkeyListener = new();
        User? _user;

        public void ShowAppropriatePages()
        {
            RefreshEvent.RefreshNeeded += new EventHandler(_update);
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tpHome);
            if (_user == null)
            {
                tabControl1.TabPages.Add(tpAdmin);
            }
        }

        public MainWindowForm(User? user)
        {
            _user = user;
            InitializeComponent();
            ShowAppropriatePages();
            _update();
        }
        public List<WorkTask> DisplayTasks
        {
            set
            {
                flpTasksHome.Controls.Clear();
                foreach (var task in value)
                {
                    flpTasksHome.Controls.Add(new TaskCard() { UpdateUsingObject = task });
                }
            }
        }
        public List<WorkTask> DisplayTasksAdmin
        {
            set
            {
                flpAdminTasks.Controls.Clear();
                foreach (var task in value)
                {
                    // admin tasks and injection
                    var taskControl = new AdminTaskCard { UpdateUsingObject = task };
                    flpAdminTasks.Controls.Add(taskControl);
                }
            }
        }
        private void FilterUser(object sender, EventArgs e)
        {
            DisplayTasks = Filter.filter(tbSearch.Text, cbDepartmentFilter.Text, cbStatus.Text, dtpFrom.Value, dtpTo.Value) ?? new List<WorkTask>();
        }
        private void FilterAdmin(object sender, EventArgs e)
        {
            DisplayTasksAdmin = Filter.filter(tbAdminSearch.Text, cbAdminDepartment.Text, cbAdminStatus.Text, dtpAdminFrom.Value, dtpAdminTo.Value) ?? new List<WorkTask>();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            // update stuff here
            _update();
        }
        private void _update(object _, EventArgs __)
        {
            _update();
        }
        private void _update()
        {
            DisplayTasks = TaskHandler.Tasks;
            DisplayTasksAdmin = TaskHandler.Tasks;
            foreach (var status in Enum.GetValues(typeof(WorkTaskStatus)))
            {
                cbCreateTaskStatus.Items.Add(status.ToString());
                cbStatus.Items.Add(status.ToString());
                cbStatus.AutoCompleteCustomSource.Add(status.ToString());
                cbAdminStatus.Items.Add(status.ToString());
                cbAdminStatus.AutoCompleteCustomSource.Add(status.ToString());
            }
            foreach (var department in State.Departments)
            {
                cbCreateTaskDepartment.Items.Add(department);
                cbDepartmentFilter.Items.Add(department);
                cbDepartmentFilter.AutoCompleteCustomSource.Add(department);
                cbAdminDepartment.Items.Add(department);
                cbAdminDepartment.AutoCompleteCustomSource.Add(department);
            }
            //foreach (WorkTask task in TaskHandler.Filter(x => true))
            //{
            //    flpTasksHome.Controls.Add(new TaskCard() { UpdateUsingObject = task });

            //    // admin tasks and injection
            //    var taskControl = new TaskCard { UpdateUsingObject = task };
            //    flpAdminTasks.Controls.Add(taskControl);
            //}
        }
        private void btnLoadData_Click(object sender, EventArgs e)
        {
            var path = GetDailogFilePath();
            if (path != null)
            {
                TaskHandler.ReadTasksCsv(path);
            }
            _update();
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            var path = GetDailogFilePath();
            if (path != null)
            {
                TaskHandler.WriteTasksCsv(path);
            }
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            TaskHandler.ClearTasks();
            _update();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            _update();
        }

        private void btnConfirmTask_Click(object sender, EventArgs e)
        {
            TaskHandler.AddTask(
                new WorkTask(
                    tbCreateTaskTitle.Text,
                    cbCreateTaskDepartment.Text == "" ? new HashSet<string>() { cbCreateTaskDepartment.Text } : new HashSet<string>(),
                    Enum.TryParse<WorkTaskStatus>(cbCreateTaskStatus.Text, out var result) ? result : WorkTaskStatus.Open,
                    dtpCreateTaskDate.Value.Date,
                    new HashSet<string>(),
                    tbCreateTaskDescription.Text
                    ));
            _update();
            _clearCreateTaskPanel();
            panel1.Hide();
            flpAdminTasks.Show();
        }
        private void _clearCreateTaskPanel()
        {
            tbCreateTaskTitle.Text = "";
            cbCreateTaskDepartment.Text = "";
            dtpCreateTaskDate.Value = DateTime.Now;
            tbCreateTaskDescription.Text = "";
        }
        private static string? GetDailogFilePath()
        {
            using OpenFileDialog openFileDialog = new();
            //openFileDialog.InitialDirectory = ;
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
        private void btnLoadUsers_Click(object sender, EventArgs e)
        {
            //Get the path of specified file
            var path = GetDailogFilePath();
            if (path != null)
            {
                UserHandler.ReadCsv(path);
            }
        }

        private void btnNewTask_Click(object sender, EventArgs e)
        {
            panel1.Show();
            flpAdminTasks.Hide();
        }

        private void btnClearUsers_Click(object sender, EventArgs e)
        {
            UserHandler.ClearUsers();
        }

        private void btnExportUsers_Click(object sender, EventArgs e)
        {
            var path = GetDailogFilePath();
            if (path != null)
            {
                UserHandler.WriteCsv(path);
            }
        }

        private void btnCreateTaskClose_Click(object sender, EventArgs e)
        {
            _clearCreateTaskPanel();
            panel1.Hide();
            flpAdminTasks.Show();
        }
    }
}
