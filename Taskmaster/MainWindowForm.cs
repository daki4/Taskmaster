using System.Diagnostics;
using Taskmaster.Components;
using Taskmaster.Models;
using Taskmaster.StateManagement;
using WK.Libraries.HotkeyListenerNS;
using FileHelpers;
namespace Taskmaster
{
    public partial class MainWindowForm : Form
    {
        static readonly FileHelperEngine TaskEngine = new FileHelperEngine(typeof(WorkTask));
        static readonly FileHelperEngine EmployeeEngine = new FileHelperEngine(typeof(Employee));
        HotkeyListener hotkeyListener = new();
        User? _user;

        public void ShowAppropriatePages()
        {
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
            foreach (var status in Enum.GetValues(typeof(WorkTaskStatus)))
            {
                cbStatus.Items.Add(status.ToString());
                cbStatus.AutoCompleteCustomSource.Add(status.ToString());
                cbAdminStatus.Items.Add(status.ToString());
                cbAdminStatus.AutoCompleteCustomSource.Add(status.ToString());
            }
            foreach (var department in State.Departments)
            {
                cbDepartmentFilter.Items.Add(department);
                cbDepartmentFilter.AutoCompleteCustomSource.Add(department);
                cbAdminDepartment.Items.Add(department);
                cbAdminDepartment.AutoCompleteCustomSource.Add(department);
            }
            foreach (WorkTask task in State.CompanyContainer.Tasks)
            {
                flpTasksHome.Controls.Add(new TaskCard() { UpdateUsingObject = task });

                // admin tasks and injection
                var taskControl = new TaskCard { UpdateUsingObject = task };
                //taskControl.Click += AdminTaskControl_Click;
                flpAdminTasks.Controls.Add(taskControl);
            }
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
                    var taskControl = new TaskCard { UpdateUsingObject = task };
                    taskControl.Click += AdminTaskControl_Click;
                    flpAdminTasks.Controls.Add(taskControl);
                }
            }
        }

        private void AdminTaskControl_Click(object? sender, EventArgs e)
        {
            Debug.WriteLine("trigger");
            var x = (TaskCard)sender;
            x.Hide();
            
            //var x = (TaskCard)sender;x.TaskLayoutPanel.Hide();
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
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {

        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            State.CompanyContainer.Tasks.Clear();
        }
    }
}
