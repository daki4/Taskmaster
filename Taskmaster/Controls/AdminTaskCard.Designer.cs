namespace Taskmaster.Components
{
    partial class AdminTaskCard
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
            this.TaskCard = new Taskmaster.Components.TaskCard();
            this.pControls = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRemoveEmployee = new System.Windows.Forms.ComboBox();
            this.cbAddEmployee = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelTask = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnDownStatus = new System.Windows.Forms.Button();
            this.btnUpStatus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRemoveDept = new System.Windows.Forms.ComboBox();
            this.cbAddDept = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPStatus = new System.Windows.Forms.Label();
            this.pControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskCard
            // 
            this.TaskCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaskCard.Location = new System.Drawing.Point(0, 0);
            this.TaskCard.Name = "TaskCard";
            this.TaskCard.Size = new System.Drawing.Size(296, 346);
            this.TaskCard.TabIndex = 0;
            this.TaskCard.Click += new System.EventHandler(this.AdminTaskCard_Click);
            // 
            // pControls
            // 
            this.pControls.Controls.Add(this.lblPStatus);
            this.pControls.Controls.Add(this.label5);
            this.pControls.Controls.Add(this.btnCancel);
            this.pControls.Controls.Add(this.label3);
            this.pControls.Controls.Add(this.label4);
            this.pControls.Controls.Add(this.cbRemoveEmployee);
            this.pControls.Controls.Add(this.cbAddEmployee);
            this.pControls.Controls.Add(this.btnDelete);
            this.pControls.Controls.Add(this.btnCancelTask);
            this.pControls.Controls.Add(this.btnBlock);
            this.pControls.Controls.Add(this.btnDownStatus);
            this.pControls.Controls.Add(this.btnUpStatus);
            this.pControls.Controls.Add(this.label2);
            this.pControls.Controls.Add(this.label1);
            this.pControls.Controls.Add(this.cbRemoveDept);
            this.pControls.Controls.Add(this.cbAddDept);
            this.pControls.Location = new System.Drawing.Point(0, 0);
            this.pControls.Name = "pControls";
            this.pControls.Size = new System.Drawing.Size(296, 346);
            this.pControls.TabIndex = 2;
            this.pControls.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(27, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(245, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Remove employee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Add employee:";
            // 
            // cbRemoveEmployee
            // 
            this.cbRemoveEmployee.FormattingEnabled = true;
            this.cbRemoveEmployee.Location = new System.Drawing.Point(151, 94);
            this.cbRemoveEmployee.Name = "cbRemoveEmployee";
            this.cbRemoveEmployee.Size = new System.Drawing.Size(121, 23);
            this.cbRemoveEmployee.TabIndex = 10;
            this.cbRemoveEmployee.SelectedIndexChanged += new System.EventHandler(this.cbRemoveEmployee_SelectedIndexChanged);
            // 
            // cbAddEmployee
            // 
            this.cbAddEmployee.FormattingEnabled = true;
            this.cbAddEmployee.Location = new System.Drawing.Point(151, 65);
            this.cbAddEmployee.Name = "cbAddEmployee";
            this.cbAddEmployee.Size = new System.Drawing.Size(121, 23);
            this.cbAddEmployee.TabIndex = 9;
            this.cbAddEmployee.SelectedIndexChanged += new System.EventHandler(this.cbAddEmployee_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(27, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelTask
            // 
            this.btnCancelTask.AutoSize = true;
            this.btnCancelTask.Location = new System.Drawing.Point(98, 178);
            this.btnCancelTask.Name = "btnCancelTask";
            this.btnCancelTask.Size = new System.Drawing.Size(78, 25);
            this.btnCancelTask.TabIndex = 7;
            this.btnCancelTask.Text = "Cancel Task";
            this.btnCancelTask.UseVisualStyleBackColor = true;
            this.btnCancelTask.Click += new System.EventHandler(this.btnCancelTask_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(182, 178);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 6;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnDownStatus
            // 
            this.btnDownStatus.AutoSize = true;
            this.btnDownStatus.Location = new System.Drawing.Point(94, 147);
            this.btnDownStatus.Name = "btnDownStatus";
            this.btnDownStatus.Size = new System.Drawing.Size(82, 25);
            this.btnDownStatus.TabIndex = 5;
            this.btnDownStatus.Text = "Down status";
            this.btnDownStatus.UseVisualStyleBackColor = true;
            this.btnDownStatus.Click += new System.EventHandler(this.btnDownStatus_Click);
            // 
            // btnUpStatus
            // 
            this.btnUpStatus.Location = new System.Drawing.Point(182, 149);
            this.btnUpStatus.Name = "btnUpStatus";
            this.btnUpStatus.Size = new System.Drawing.Size(75, 23);
            this.btnUpStatus.TabIndex = 4;
            this.btnUpStatus.Text = "Up status";
            this.btnUpStatus.UseVisualStyleBackColor = true;
            this.btnUpStatus.Click += new System.EventHandler(this.btnUpStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remove department:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add department:";
            // 
            // cbRemoveDept
            // 
            this.cbRemoveDept.FormattingEnabled = true;
            this.cbRemoveDept.Location = new System.Drawing.Point(151, 35);
            this.cbRemoveDept.Name = "cbRemoveDept";
            this.cbRemoveDept.Size = new System.Drawing.Size(121, 23);
            this.cbRemoveDept.TabIndex = 1;
            this.cbRemoveDept.SelectedIndexChanged += new System.EventHandler(this.cbRemoveDept_SelectedIndexChanged);
            // 
            // cbAddDept
            // 
            this.cbAddDept.FormattingEnabled = true;
            this.cbAddDept.Location = new System.Drawing.Point(151, 6);
            this.cbAddDept.Name = "cbAddDept";
            this.cbAddDept.Size = new System.Drawing.Size(121, 23);
            this.cbAddDept.TabIndex = 0;
            this.cbAddDept.SelectedIndexChanged += new System.EventHandler(this.cbAddDept_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(3, 310);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.AdminTaskCard_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status:";
            // 
            // lblPStatus
            // 
            this.lblPStatus.AutoSize = true;
            this.lblPStatus.Location = new System.Drawing.Point(91, 128);
            this.lblPStatus.Name = "lblPStatus";
            this.lblPStatus.Size = new System.Drawing.Size(42, 15);
            this.lblPStatus.TabIndex = 15;
            this.lblPStatus.Text = "Status:";
            // 
            // AdminTaskCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pControls);
            this.Controls.Add(this.TaskCard);
            this.Name = "AdminTaskCard";
            this.Size = new System.Drawing.Size(299, 349);
            this.pControls.ResumeLayout(false);
            this.pControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TaskCard TaskCard;
        private Panel pControls;
        private Label label2;
        private Label label1;
        private ComboBox cbRemoveDept;
        private ComboBox cbAddDept;
        private Button btnDownStatus;
        private Button btnUpStatus;
        private Button btnCancelTask;
        private Button btnBlock;
        private Button btnDelete;
        private Label label3;
        private Label label4;
        private ComboBox cbRemoveEmployee;
        private ComboBox cbAddEmployee;
        private Button btnCancel;
        private Button btnEdit;
        private Label label5;
        private Label lblPStatus;
    }
}
