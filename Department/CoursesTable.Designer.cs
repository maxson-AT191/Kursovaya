namespace Department
{
    partial class CoursesTable
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PracticeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaboratoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LecturerColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AssistantColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.CodeColumn,
            this.LectureColumn,
            this.PracticeColumn,
            this.LaboratoryColumn,
            this.GroupColumn,
            this.LecturerColumn,
            this.AssistantColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Course name";
            this.NameColumn.Name = "NameColumn";
            // 
            // CodeColumn
            // 
            this.CodeColumn.HeaderText = "Course code";
            this.CodeColumn.Name = "CodeColumn";
            // 
            // LectureColumn
            // 
            this.LectureColumn.HeaderText = "Lectures";
            this.LectureColumn.Name = "LectureColumn";
            // 
            // PracticeColumn
            // 
            this.PracticeColumn.HeaderText = "Practices";
            this.PracticeColumn.Name = "PracticeColumn";
            // 
            // LaboratoryColumn
            // 
            this.LaboratoryColumn.HeaderText = "Laboratories";
            this.LaboratoryColumn.Name = "LaboratoryColumn";
            this.LaboratoryColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LaboratoryColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GroupColumn
            // 
            this.GroupColumn.HeaderText = "Groups";
            this.GroupColumn.Name = "GroupColumn";
            // 
            // LecturerColumn
            // 
            this.LecturerColumn.HeaderText = "Lecturers";
            this.LecturerColumn.Name = "LecturerColumn";
            // 
            // AssistantColumn
            // 
            this.AssistantColumn.HeaderText = "Assistants";
            this.AssistantColumn.Name = "AssistantColumn";
            // 
            // CoursesTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CoursesTable";
            this.Text = "CoursesTable";
            this.Shown += new System.EventHandler(this.CoursesTable_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PracticeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaboratoryColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GroupColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn LecturerColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AssistantColumn;
    }
}