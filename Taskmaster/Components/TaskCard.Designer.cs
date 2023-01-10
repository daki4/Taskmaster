namespace Taskmaster.Components
{
    partial class TaskCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.TaskLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.DepartmentsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbBy = new System.Windows.Forms.ListBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.TaskLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 15);
            label2.TabIndex = 1;
            label2.Text = "Departments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 118);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 138);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Deadline";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 158);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(20, 15);
            label5.TabIndex = 4;
            label5.Text = "By";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 256);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Description";
            // 
            // TaskLayoutPanel
            // 
            this.TaskLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TaskLayoutPanel.ColumnCount = 2;
            this.TaskLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TaskLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TaskLayoutPanel.Controls.Add(label1, 0, 0);
            this.TaskLayoutPanel.Controls.Add(label2, 0, 1);
            this.TaskLayoutPanel.Controls.Add(label3, 0, 2);
            this.TaskLayoutPanel.Controls.Add(label4, 0, 3);
            this.TaskLayoutPanel.Controls.Add(label5, 0, 4);
            this.TaskLayoutPanel.Controls.Add(label6, 0, 5);
            this.TaskLayoutPanel.Controls.Add(this.lblTask, 1, 0);
            this.TaskLayoutPanel.Controls.Add(this.lblStatus, 1, 2);
            this.TaskLayoutPanel.Controls.Add(this.lblDeadline, 1, 3);
            this.TaskLayoutPanel.Controls.Add(this.lblDescription, 1, 5);
            this.TaskLayoutPanel.Controls.Add(this.DepartmentsLayoutPanel, 1, 1);
            this.TaskLayoutPanel.Controls.Add(this.lbBy, 1, 4);
            this.TaskLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TaskLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TaskLayoutPanel.Name = "TaskLayoutPanel";
            this.TaskLayoutPanel.RowCount = 6;
            this.TaskLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TaskLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TaskLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TaskLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TaskLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TaskLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TaskLayoutPanel.Size = new System.Drawing.Size(296, 346);
            this.TaskLayoutPanel.TabIndex = 0;
            // 
            // lblTask
            // 
            this.lblTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTask.Location = new System.Drawing.Point(84, 0);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(379, 20);
            this.lblTask.TabIndex = 6;
            this.lblTask.Text = "EmptyTask";
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(84, 118);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(379, 20);
            this.lblStatus.TabIndex = 7;
            // 
            // lblDeadline
            // 
            this.lblDeadline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeadline.Location = new System.Drawing.Point(84, 138);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(379, 20);
            this.lblDeadline.TabIndex = 8;
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(84, 256);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(379, 244);
            this.lblDescription.TabIndex = 10;
            // 
            // DepartmentsLayoutPanel
            // 
            this.DepartmentsLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DepartmentsLayoutPanel.ColumnCount = 2;
            this.DepartmentsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DepartmentsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DepartmentsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentsLayoutPanel.Location = new System.Drawing.Point(84, 23);
            this.DepartmentsLayoutPanel.Name = "DepartmentsLayoutPanel";
            this.DepartmentsLayoutPanel.RowCount = 2;
            this.DepartmentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DepartmentsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DepartmentsLayoutPanel.Size = new System.Drawing.Size(379, 92);
            this.DepartmentsLayoutPanel.TabIndex = 11;
            // 
            // lbBy
            // 
            this.lbBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBy.FormattingEnabled = true;
            this.lbBy.ItemHeight = 15;
            this.lbBy.Location = new System.Drawing.Point(84, 161);
            this.lbBy.Name = "lbBy";
            this.lbBy.Size = new System.Drawing.Size(379, 92);
            this.lbBy.TabIndex = 12;
            // 
            // TaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.TaskLayoutPanel);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(296, 346);
            this.TaskLayoutPanel.ResumeLayout(false);
            this.TaskLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblTask;
        private Label lblStatus;
        private Label lblDescription;
        private TableLayoutPanel DepartmentsLayoutPanel;
        private ListBox lbBy;
        private Label lblDeadline;
        public TableLayoutPanel TaskLayoutPanel;
    }
}
