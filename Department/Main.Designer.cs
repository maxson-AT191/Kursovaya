namespace Department
{
    partial class Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courcesWithoutStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewCources = new System.Windows.Forms.DataGridView();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lectures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Practice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laboratory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groups = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Lecturers = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Assistants = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.showLowLecturesCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCources)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(883, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem.Text = "Add...";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courcesWithoutStaffToolStripMenuItem,
            this.staffInformationToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.showLowLecturesCoursesToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // courcesWithoutStaffToolStripMenuItem
            // 
            this.courcesWithoutStaffToolStripMenuItem.Enabled = false;
            this.courcesWithoutStaffToolStripMenuItem.Name = "courcesWithoutStaffToolStripMenuItem";
            this.courcesWithoutStaffToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.courcesWithoutStaffToolStripMenuItem.Text = "Cources without staff";
            this.courcesWithoutStaffToolStripMenuItem.Click += new System.EventHandler(this.courcesWithoutStaffToolStripMenuItem_Click);
            // 
            // staffInformationToolStripMenuItem
            // 
            this.staffInformationToolStripMenuItem.Name = "staffInformationToolStripMenuItem";
            this.staffInformationToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.staffInformationToolStripMenuItem.Text = "Staff information";
            this.staffInformationToolStripMenuItem.Click += new System.EventHandler(this.staffInformationToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Enabled = false;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.removeToolStripMenuItem.Text = "Remove department";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courcesToolStripMenuItem,
            this.headToolStripMenuItem});
            this.changeToolStripMenuItem.Enabled = false;
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.changeToolStripMenuItem.Text = "Change";
            // 
            // courcesToolStripMenuItem
            // 
            this.courcesToolStripMenuItem.Name = "courcesToolStripMenuItem";
            this.courcesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.courcesToolStripMenuItem.Text = "Cources";
            this.courcesToolStripMenuItem.Click += new System.EventHandler(this.courcesToolStripMenuItem_Click);
            // 
            // headToolStripMenuItem
            // 
            this.headToolStripMenuItem.Name = "headToolStripMenuItem";
            this.headToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.headToolStripMenuItem.Text = "Head and password";
            this.headToolStripMenuItem.Click += new System.EventHandler(this.headToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridViewCources
            // 
            this.dataGridViewCources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseName,
            this.CourseCode,
            this.Lectures,
            this.Practice,
            this.Laboratory,
            this.Groups,
            this.Lecturers,
            this.Assistants});
            this.dataGridViewCources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCources.Location = new System.Drawing.Point(0, 24);
            this.dataGridViewCources.Name = "dataGridViewCources";
            this.dataGridViewCources.RowHeadersWidth = 80;
            this.dataGridViewCources.Size = new System.Drawing.Size(883, 471);
            this.dataGridViewCources.TabIndex = 1;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            // 
            // CourseCode
            // 
            this.CourseCode.HeaderText = "Course Code";
            this.CourseCode.Name = "CourseCode";
            // 
            // Lectures
            // 
            this.Lectures.HeaderText = "Lectures";
            this.Lectures.Name = "Lectures";
            // 
            // Practice
            // 
            this.Practice.HeaderText = "Practices";
            this.Practice.Name = "Practice";
            // 
            // Laboratory
            // 
            this.Laboratory.HeaderText = "Laboratories";
            this.Laboratory.Name = "Laboratory";
            // 
            // Groups
            // 
            this.Groups.HeaderText = "Groups";
            this.Groups.Name = "Groups";
            // 
            // Lecturers
            // 
            this.Lecturers.HeaderText = "Lecturers";
            this.Lecturers.Name = "Lecturers";
            // 
            // Assistants
            // 
            this.Assistants.HeaderText = "Assistants";
            this.Assistants.Name = "Assistants";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // showLowLecturesCoursesToolStripMenuItem
            // 
            this.showLowLecturesCoursesToolStripMenuItem.Enabled = false;
            this.showLowLecturesCoursesToolStripMenuItem.Name = "showLowLecturesCoursesToolStripMenuItem";
            this.showLowLecturesCoursesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.showLowLecturesCoursesToolStripMenuItem.Text = "Show low lectures courses";
            this.showLowLecturesCoursesToolStripMenuItem.Click += new System.EventHandler(this.showLowLecturesCoursesToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 495);
            this.Controls.Add(this.dataGridViewCources);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main";
            this.Text = "Department Manager";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewCources;
        private System.Windows.Forms.ToolStripMenuItem courcesWithoutStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lectures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Practice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laboratory;
        private System.Windows.Forms.DataGridViewComboBoxColumn Groups;
        private System.Windows.Forms.DataGridViewComboBoxColumn Lecturers;
        private System.Windows.Forms.DataGridViewComboBoxColumn Assistants;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLowLecturesCoursesToolStripMenuItem;
    }
}

