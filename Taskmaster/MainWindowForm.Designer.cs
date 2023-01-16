namespace Taskmaster
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label10;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbDepartmentFilter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.flpTasksHome = new System.Windows.Forms.FlowLayoutPanel();
            this.tpAdmin = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConfirmTask = new System.Windows.Forms.Button();
            this.tbCreateTaskDescription = new System.Windows.Forms.TextBox();
            this.dtpCreateTaskDate = new System.Windows.Forms.DateTimePicker();
            this.cbCreateTaskStatus = new System.Windows.Forms.ComboBox();
            this.cbCreateTaskDepartment = new System.Windows.Forms.ComboBox();
            this.tbCreateTaskTitle = new System.Windows.Forms.TextBox();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.btnExportUsers = new System.Windows.Forms.Button();
            this.btnClearUsers = new System.Windows.Forms.Button();
            this.btnLoadUsers = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.flpAdminTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.AdminSearchPanel = new System.Windows.Forms.Panel();
            this.tbAdminSearch = new System.Windows.Forms.TextBox();
            this.cbAdminStatus = new System.Windows.Forms.ComboBox();
            this.cbAdminDepartment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpAdminTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpAdminFrom = new System.Windows.Forms.DateTimePicker();
            this.btnCreateTaskClose = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.tpAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AdminSearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Search:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 15);
            label2.TabIndex = 7;
            label2.Text = "Department:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(38, 81);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(35, 15);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(45, 15);
            label6.TabIndex = 1;
            label6.Text = "Search:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(38, 81);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(42, 15);
            label7.TabIndex = 11;
            label7.Text = "Status:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(7, 54);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(73, 15);
            label10.TabIndex = 7;
            label10.Text = "Department:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpHome);
            this.tabControl1.Controls.Add(this.tpAdmin);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 575);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tpHome
            // 
            this.tpHome.Controls.Add(this.searchPanel);
            this.tpHome.Controls.Add(this.flpTasksHome);
            this.tpHome.Location = new System.Drawing.Point(4, 24);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tpHome.Size = new System.Drawing.Size(792, 547);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(label1);
            this.searchPanel.Controls.Add(label5);
            this.searchPanel.Controls.Add(this.tbSearch);
            this.searchPanel.Controls.Add(this.cbStatus);
            this.searchPanel.Controls.Add(this.cbDepartmentFilter);
            this.searchPanel.Controls.Add(this.label4);
            this.searchPanel.Controls.Add(this.dtpTo);
            this.searchPanel.Controls.Add(this.label3);
            this.searchPanel.Controls.Add(this.dtpFrom);
            this.searchPanel.Controls.Add(label2);
            this.searchPanel.Location = new System.Drawing.Point(343, 10);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(428, 176);
            this.searchPanel.TabIndex = 12;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(86, 7);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(326, 23);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.FilterUser);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(86, 73);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 23);
            this.cbStatus.TabIndex = 10;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.FilterUser);
            this.cbStatus.TextUpdate += new System.EventHandler(this.FilterUser);
            // 
            // cbDepartmentFilter
            // 
            this.cbDepartmentFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDepartmentFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDepartmentFilter.FormattingEnabled = true;
            this.cbDepartmentFilter.Location = new System.Drawing.Point(86, 46);
            this.cbDepartmentFilter.Name = "cbDepartmentFilter";
            this.cbDepartmentFilter.Size = new System.Drawing.Size(121, 23);
            this.cbDepartmentFilter.TabIndex = 4;
            this.cbDepartmentFilter.SelectedIndexChanged += new System.EventHandler(this.FilterUser);
            this.cbDepartmentFilter.TextUpdate += new System.EventHandler(this.FilterUser);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "To:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(86, 144);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 23);
            this.dtpTo.TabIndex = 5;
            this.dtpTo.ValueChanged += new System.EventHandler(this.FilterUser);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "From:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(86, 115);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 23);
            this.dtpFrom.TabIndex = 6;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.FilterUser);
            // 
            // flpTasksHome
            // 
            this.flpTasksHome.AutoScroll = true;
            this.flpTasksHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpTasksHome.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpTasksHome.Location = new System.Drawing.Point(0, 10);
            this.flpTasksHome.Name = "flpTasksHome";
            this.flpTasksHome.Size = new System.Drawing.Size(320, 527);
            this.flpTasksHome.TabIndex = 3;
            this.flpTasksHome.WrapContents = false;
            // 
            // tpAdmin
            // 
            this.tpAdmin.Controls.Add(this.panel1);
            this.tpAdmin.Controls.Add(this.btnNewUser);
            this.tpAdmin.Controls.Add(this.btnNewTask);
            this.tpAdmin.Controls.Add(this.btnExportUsers);
            this.tpAdmin.Controls.Add(this.btnClearUsers);
            this.tpAdmin.Controls.Add(this.btnLoadUsers);
            this.tpAdmin.Controls.Add(this.btnReload);
            this.tpAdmin.Controls.Add(this.btnClearData);
            this.tpAdmin.Controls.Add(this.btnExportData);
            this.tpAdmin.Controls.Add(this.btnLoadData);
            this.tpAdmin.Controls.Add(this.flpAdminTasks);
            this.tpAdmin.Controls.Add(this.AdminSearchPanel);
            this.tpAdmin.Location = new System.Drawing.Point(4, 24);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdmin.Size = new System.Drawing.Size(792, 547);
            this.tpAdmin.TabIndex = 1;
            this.tpAdmin.Text = "Admin";
            this.tpAdmin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreateTaskClose);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnConfirmTask);
            this.panel1.Controls.Add(this.tbCreateTaskDescription);
            this.panel1.Controls.Add(this.dtpCreateTaskDate);
            this.panel1.Controls.Add(this.cbCreateTaskStatus);
            this.panel1.Controls.Add(this.cbCreateTaskDepartment);
            this.panel1.Controls.Add(this.tbCreateTaskTitle);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 248);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Description:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Deadline:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Department:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Title:";
            // 
            // btnConfirmTask
            // 
            this.btnConfirmTask.Location = new System.Drawing.Point(220, 209);
            this.btnConfirmTask.Name = "btnConfirmTask";
            this.btnConfirmTask.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmTask.TabIndex = 5;
            this.btnConfirmTask.Text = "Confirm";
            this.btnConfirmTask.UseVisualStyleBackColor = true;
            this.btnConfirmTask.Click += new System.EventHandler(this.btnConfirmTask_Click);
            // 
            // tbCreateTaskDescription
            // 
            this.tbCreateTaskDescription.Location = new System.Drawing.Point(116, 120);
            this.tbCreateTaskDescription.Multiline = true;
            this.tbCreateTaskDescription.Name = "tbCreateTaskDescription";
            this.tbCreateTaskDescription.Size = new System.Drawing.Size(179, 71);
            this.tbCreateTaskDescription.TabIndex = 4;
            // 
            // dtpCreateTaskDate
            // 
            this.dtpCreateTaskDate.Location = new System.Drawing.Point(116, 91);
            this.dtpCreateTaskDate.Name = "dtpCreateTaskDate";
            this.dtpCreateTaskDate.Size = new System.Drawing.Size(200, 23);
            this.dtpCreateTaskDate.TabIndex = 3;
            // 
            // cbCreateTaskStatus
            // 
            this.cbCreateTaskStatus.FormattingEnabled = true;
            this.cbCreateTaskStatus.Location = new System.Drawing.Point(116, 62);
            this.cbCreateTaskStatus.Name = "cbCreateTaskStatus";
            this.cbCreateTaskStatus.Size = new System.Drawing.Size(121, 23);
            this.cbCreateTaskStatus.TabIndex = 2;
            // 
            // cbCreateTaskDepartment
            // 
            this.cbCreateTaskDepartment.FormattingEnabled = true;
            this.cbCreateTaskDepartment.Location = new System.Drawing.Point(116, 30);
            this.cbCreateTaskDepartment.Name = "cbCreateTaskDepartment";
            this.cbCreateTaskDepartment.Size = new System.Drawing.Size(121, 23);
            this.cbCreateTaskDepartment.TabIndex = 1;
            // 
            // tbCreateTaskTitle
            // 
            this.tbCreateTaskTitle.Location = new System.Drawing.Point(116, 3);
            this.tbCreateTaskTitle.Name = "tbCreateTaskTitle";
            this.tbCreateTaskTitle.Size = new System.Drawing.Size(100, 23);
            this.tbCreateTaskTitle.TabIndex = 0;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(350, 333);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnNewUser.TabIndex = 24;
            this.btnNewUser.Text = "Create User";
            this.btnNewUser.UseVisualStyleBackColor = true;
            // 
            // btnNewTask
            // 
            this.btnNewTask.Location = new System.Drawing.Point(350, 258);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(75, 23);
            this.btnNewTask.TabIndex = 23;
            this.btnNewTask.Text = "New Task";
            this.btnNewTask.UseVisualStyleBackColor = true;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // btnExportUsers
            // 
            this.btnExportUsers.AutoSize = true;
            this.btnExportUsers.Location = new System.Drawing.Point(510, 304);
            this.btnExportUsers.Name = "btnExportUsers";
            this.btnExportUsers.Size = new System.Drawing.Size(82, 25);
            this.btnExportUsers.TabIndex = 22;
            this.btnExportUsers.Text = "Export Users";
            this.btnExportUsers.UseVisualStyleBackColor = true;
            this.btnExportUsers.Click += new System.EventHandler(this.btnExportUsers_Click);
            // 
            // btnClearUsers
            // 
            this.btnClearUsers.Location = new System.Drawing.Point(429, 304);
            this.btnClearUsers.Name = "btnClearUsers";
            this.btnClearUsers.Size = new System.Drawing.Size(75, 23);
            this.btnClearUsers.TabIndex = 21;
            this.btnClearUsers.Text = "Clear Users";
            this.btnClearUsers.UseVisualStyleBackColor = true;
            this.btnClearUsers.Click += new System.EventHandler(this.btnClearUsers_Click);
            // 
            // btnLoadUsers
            // 
            this.btnLoadUsers.Location = new System.Drawing.Point(350, 304);
            this.btnLoadUsers.Name = "btnLoadUsers";
            this.btnLoadUsers.Size = new System.Drawing.Size(75, 23);
            this.btnLoadUsers.TabIndex = 20;
            this.btnLoadUsers.Text = "Load Users";
            this.btnLoadUsers.UseVisualStyleBackColor = true;
            this.btnLoadUsers.Click += new System.EventHandler(this.btnLoadUsers_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(696, 258);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 19;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(429, 229);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(75, 23);
            this.btnClearData.TabIndex = 18;
            this.btnClearData.Text = "Clear Tasks";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnExportData
            // 
            this.btnExportData.AutoSize = true;
            this.btnExportData.Location = new System.Drawing.Point(510, 229);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(81, 25);
            this.btnExportData.TabIndex = 17;
            this.btnExportData.Text = "Export Tasks";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(350, 229);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(75, 23);
            this.btnLoadData.TabIndex = 16;
            this.btnLoadData.Text = "Load Tasks";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // flpAdminTasks
            // 
            this.flpAdminTasks.AutoScroll = true;
            this.flpAdminTasks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAdminTasks.Location = new System.Drawing.Point(8, 21);
            this.flpAdminTasks.Name = "flpAdminTasks";
            this.flpAdminTasks.Size = new System.Drawing.Size(320, 527);
            this.flpAdminTasks.TabIndex = 15;
            this.flpAdminTasks.WrapContents = false;
            // 
            // AdminSearchPanel
            // 
            this.AdminSearchPanel.Controls.Add(label6);
            this.AdminSearchPanel.Controls.Add(label7);
            this.AdminSearchPanel.Controls.Add(this.tbAdminSearch);
            this.AdminSearchPanel.Controls.Add(this.cbAdminStatus);
            this.AdminSearchPanel.Controls.Add(this.cbAdminDepartment);
            this.AdminSearchPanel.Controls.Add(this.label8);
            this.AdminSearchPanel.Controls.Add(this.dtpAdminTo);
            this.AdminSearchPanel.Controls.Add(this.label9);
            this.AdminSearchPanel.Controls.Add(this.dtpAdminFrom);
            this.AdminSearchPanel.Controls.Add(label10);
            this.AdminSearchPanel.Location = new System.Drawing.Point(343, 21);
            this.AdminSearchPanel.Name = "AdminSearchPanel";
            this.AdminSearchPanel.Size = new System.Drawing.Size(428, 176);
            this.AdminSearchPanel.TabIndex = 13;
            // 
            // tbAdminSearch
            // 
            this.tbAdminSearch.Location = new System.Drawing.Point(86, 7);
            this.tbAdminSearch.Name = "tbAdminSearch";
            this.tbAdminSearch.Size = new System.Drawing.Size(326, 23);
            this.tbAdminSearch.TabIndex = 2;
            this.tbAdminSearch.TextChanged += new System.EventHandler(this.FilterAdmin);
            // 
            // cbAdminStatus
            // 
            this.cbAdminStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAdminStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbAdminStatus.FormattingEnabled = true;
            this.cbAdminStatus.Location = new System.Drawing.Point(86, 73);
            this.cbAdminStatus.Name = "cbAdminStatus";
            this.cbAdminStatus.Size = new System.Drawing.Size(121, 23);
            this.cbAdminStatus.TabIndex = 10;
            this.cbAdminStatus.SelectedIndexChanged += new System.EventHandler(this.FilterUser);
            this.cbAdminStatus.TextUpdate += new System.EventHandler(this.FilterAdmin);
            // 
            // cbAdminDepartment
            // 
            this.cbAdminDepartment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbAdminDepartment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbAdminDepartment.FormattingEnabled = true;
            this.cbAdminDepartment.Location = new System.Drawing.Point(86, 46);
            this.cbAdminDepartment.Name = "cbAdminDepartment";
            this.cbAdminDepartment.Size = new System.Drawing.Size(121, 23);
            this.cbAdminDepartment.TabIndex = 4;
            this.cbAdminDepartment.SelectedIndexChanged += new System.EventHandler(this.FilterAdmin);
            this.cbAdminDepartment.TextUpdate += new System.EventHandler(this.FilterAdmin);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "To:";
            // 
            // dtpAdminTo
            // 
            this.dtpAdminTo.Location = new System.Drawing.Point(86, 144);
            this.dtpAdminTo.Name = "dtpAdminTo";
            this.dtpAdminTo.Size = new System.Drawing.Size(200, 23);
            this.dtpAdminTo.TabIndex = 5;
            this.dtpAdminTo.ValueChanged += new System.EventHandler(this.FilterAdmin);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "From:";
            // 
            // dtpAdminFrom
            // 
            this.dtpAdminFrom.Location = new System.Drawing.Point(86, 115);
            this.dtpAdminFrom.Name = "dtpAdminFrom";
            this.dtpAdminFrom.Size = new System.Drawing.Size(200, 23);
            this.dtpAdminFrom.TabIndex = 6;
            this.dtpAdminFrom.ValueChanged += new System.EventHandler(this.FilterAdmin);
            // 
            // btnCreateTaskClose
            // 
            this.btnCreateTaskClose.Location = new System.Drawing.Point(139, 209);
            this.btnCreateTaskClose.Name = "btnCreateTaskClose";
            this.btnCreateTaskClose.Size = new System.Drawing.Size(75, 23);
            this.btnCreateTaskClose.TabIndex = 10;
            this.btnCreateTaskClose.Text = "Close";
            this.btnCreateTaskClose.UseVisualStyleBackColor = true;
            this.btnCreateTaskClose.Click += new System.EventHandler(this.btnCreateTaskClose_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindowForm";
            this.Text = "MainWindowForm";
            this.tabControl1.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.tpAdmin.ResumeLayout(false);
            this.tpAdmin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AdminSearchPanel.ResumeLayout(false);
            this.AdminSearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpHome;
        private TextBox tbSearch;
        private Label label1;
        private FlowLayoutPanel flpTasksHome;
        private ComboBox cbDepartmentFilter;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label label4;
        private Label label3;
        private ComboBox cbStatus;
        private TabPage tpAdmin;
        private Panel searchPanel;
        private Panel AdminSearchPanel;
        private TextBox tbAdminSearch;
        private ComboBox cbAdminStatus;
        private ComboBox cbAdminDepartment;
        private Label label8;
        private DateTimePicker dtpAdminTo;
        private Label label9;
        private DateTimePicker dtpAdminFrom;
        private FlowLayoutPanel flpAdminTasks;
        private Button btnLoadData;
        private Button btnExportData;
        private Button btnClearData;
        private Button btnReload;
        private Button btnExportUsers;
        private Button btnClearUsers;
        private Button btnLoadUsers;
        private Button btnNewUser;
        private Button btnNewTask;
        private Panel panel1;
        private DateTimePicker dtpCreateTaskDate;
        private ComboBox cbCreateTaskStatus;
        private ComboBox cbCreateTaskDepartment;
        private TextBox tbCreateTaskTitle;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btnConfirmTask;
        private TextBox tbCreateTaskDescription;
        private Button btnCreateTaskClose;
    }
}