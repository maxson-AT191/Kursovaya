namespace Department
{
    partial class CourseForm
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelLaboratory = new System.Windows.Forms.Label();
            this.labelPractice = new System.Windows.Forms.Label();
            this.labelLectures = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxLaboratories = new System.Windows.Forms.TextBox();
            this.textBoxPractices = new System.Windows.Forms.TextBox();
            this.textBoxLectures = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.CourseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LectureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PracticeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaboratoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.buttonReplace);
            this.splitContainer.Panel1.Controls.Add(this.buttonCancel);
            this.splitContainer.Panel1.Controls.Add(this.buttonOK);
            this.splitContainer.Panel1.Controls.Add(this.buttonClean);
            this.splitContainer.Panel1.Controls.Add(this.buttonRemove);
            this.splitContainer.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainer.Panel1.Controls.Add(this.labelLaboratory);
            this.splitContainer.Panel1.Controls.Add(this.labelPractice);
            this.splitContainer.Panel1.Controls.Add(this.labelLectures);
            this.splitContainer.Panel1.Controls.Add(this.labelCode);
            this.splitContainer.Panel1.Controls.Add(this.labelName);
            this.splitContainer.Panel1.Controls.Add(this.textBoxLaboratories);
            this.splitContainer.Panel1.Controls.Add(this.textBoxPractices);
            this.splitContainer.Panel1.Controls.Add(this.textBoxLectures);
            this.splitContainer.Panel1.Controls.Add(this.textBoxCode);
            this.splitContainer.Panel1.Controls.Add(this.textBoxName);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer.Size = new System.Drawing.Size(971, 450);
            this.splitContainer.SplitterDistance = 323;
            this.splitContainer.TabIndex = 0;
            // 
            // buttonReplace
            // 
            this.buttonReplace.Enabled = false;
            this.buttonReplace.Location = new System.Drawing.Point(113, 300);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 3;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(113, 386);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(32, 386);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(194, 270);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 2;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(113, 270);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(32, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelLaboratory
            // 
            this.labelLaboratory.AutoSize = true;
            this.labelLaboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaboratory.Location = new System.Drawing.Point(12, 193);
            this.labelLaboratory.Name = "labelLaboratory";
            this.labelLaboratory.Size = new System.Drawing.Size(84, 16);
            this.labelLaboratory.TabIndex = 1;
            this.labelLaboratory.Text = "Laboratories";
            // 
            // labelPractice
            // 
            this.labelPractice.AutoSize = true;
            this.labelPractice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPractice.Location = new System.Drawing.Point(13, 167);
            this.labelPractice.Name = "labelPractice";
            this.labelPractice.Size = new System.Drawing.Size(64, 16);
            this.labelPractice.TabIndex = 1;
            this.labelPractice.Text = "Practices";
            // 
            // labelLectures
            // 
            this.labelLectures.AutoSize = true;
            this.labelLectures.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLectures.Location = new System.Drawing.Point(12, 141);
            this.labelLectures.Name = "labelLectures";
            this.labelLectures.Size = new System.Drawing.Size(59, 16);
            this.labelLectures.TabIndex = 1;
            this.labelLectures.Text = "Lectures";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(12, 115);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(41, 16);
            this.labelCode.TabIndex = 1;
            this.labelCode.Text = "Code";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(13, 89);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxLaboratories
            // 
            this.textBoxLaboratories.Location = new System.Drawing.Point(113, 193);
            this.textBoxLaboratories.Name = "textBoxLaboratories";
            this.textBoxLaboratories.Size = new System.Drawing.Size(207, 20);
            this.textBoxLaboratories.TabIndex = 0;
            // 
            // textBoxPractices
            // 
            this.textBoxPractices.Location = new System.Drawing.Point(113, 167);
            this.textBoxPractices.Name = "textBoxPractices";
            this.textBoxPractices.Size = new System.Drawing.Size(207, 20);
            this.textBoxPractices.TabIndex = 0;
            // 
            // textBoxLectures
            // 
            this.textBoxLectures.Location = new System.Drawing.Point(113, 141);
            this.textBoxLectures.Name = "textBoxLectures";
            this.textBoxLectures.Size = new System.Drawing.Size(207, 20);
            this.textBoxLectures.TabIndex = 0;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(113, 115);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(207, 20);
            this.textBoxCode.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(113, 89);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(207, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseColumn,
            this.CodeColumn,
            this.LectureColumn,
            this.PracticeColumn,
            this.LaboratoryColumn,
            this.GroupColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(644, 450);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // CourseColumn
            // 
            this.CourseColumn.HeaderText = "Course Name";
            this.CourseColumn.Name = "CourseColumn";
            // 
            // CodeColumn
            // 
            this.CodeColumn.HeaderText = "Course code";
            this.CodeColumn.Name = "CodeColumn";
            // 
            // LectureColumn
            // 
            this.LectureColumn.HeaderText = "LectureHours";
            this.LectureColumn.Name = "LectureColumn";
            // 
            // PracticeColumn
            // 
            this.PracticeColumn.HeaderText = "PracticeHours";
            this.PracticeColumn.Name = "PracticeColumn";
            // 
            // LaboratoryColumn
            // 
            this.LaboratoryColumn.HeaderText = "LaboratoryHours";
            this.LaboratoryColumn.Name = "LaboratoryColumn";
            // 
            // GroupColumn
            // 
            this.GroupColumn.HeaderText = "Groups";
            this.GroupColumn.Name = "GroupColumn";
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.Shown += new System.EventHandler(this.CourseForm_Shown);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelLaboratory;
        private System.Windows.Forms.Label labelPractice;
        private System.Windows.Forms.Label labelLectures;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxLaboratories;
        private System.Windows.Forms.TextBox textBoxPractices;
        private System.Windows.Forms.TextBox textBoxLectures;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LectureColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PracticeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaboratoryColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GroupColumn;
    }
}