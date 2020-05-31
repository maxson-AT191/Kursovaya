namespace Department
{
    partial class GroupForm
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
            this.buttonClean = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelSpeciality = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxSpeciality = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonReplace = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SpecialtyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer.Panel1.Controls.Add(this.buttonClean);
            this.splitContainer.Panel1.Controls.Add(this.labelYear);
            this.splitContainer.Panel1.Controls.Add(this.labelSpeciality);
            this.splitContainer.Panel1.Controls.Add(this.textBoxYear);
            this.splitContainer.Panel1.Controls.Add(this.textBoxSpeciality);
            this.splitContainer.Panel1.Controls.Add(this.buttonCancel);
            this.splitContainer.Panel1.Controls.Add(this.buttonOK);
            this.splitContainer.Panel1.Controls.Add(this.buttonRemove);
            this.splitContainer.Panel1.Controls.Add(this.buttonReplace);
            this.splitContainer.Panel1.Controls.Add(this.buttonAdd);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer.Size = new System.Drawing.Size(800, 450);
            this.splitContainer.SplitterDistance = 266;
            this.splitContainer.TabIndex = 0;
            // 
            // buttonClean
            // 
            this.buttonClean.Enabled = false;
            this.buttonClean.Location = new System.Drawing.Point(177, 284);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 3;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYear.Location = new System.Drawing.Point(12, 167);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(37, 16);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year";
            // 
            // labelSpeciality
            // 
            this.labelSpeciality.AutoSize = true;
            this.labelSpeciality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeciality.Location = new System.Drawing.Point(12, 90);
            this.labelSpeciality.Name = "labelSpeciality";
            this.labelSpeciality.Size = new System.Drawing.Size(67, 16);
            this.labelSpeciality.TabIndex = 2;
            this.labelSpeciality.Text = "Speciality";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(3, 183);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 20);
            this.textBoxYear.TabIndex = 1;
            // 
            // textBoxSpeciality
            // 
            this.textBoxSpeciality.Location = new System.Drawing.Point(3, 106);
            this.textBoxSpeciality.Name = "textBoxSpeciality";
            this.textBoxSpeciality.Size = new System.Drawing.Size(260, 20);
            this.textBoxSpeciality.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(122, 415);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(28, 415);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(177, 254);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Enabled = false;
            this.buttonReplace.Location = new System.Drawing.Point(96, 254);
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Size = new System.Drawing.Size(75, 23);
            this.buttonReplace.TabIndex = 0;
            this.buttonReplace.Text = "Replace";
            this.buttonReplace.UseVisualStyleBackColor = true;
            this.buttonReplace.Click += new System.EventHandler(this.buttonReplace_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(15, 254);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SpecialtyColumn,
            this.YearColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(530, 450);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // SpecialtyColumn
            // 
            this.SpecialtyColumn.HeaderText = "Specialty";
            this.SpecialtyColumn.Name = "SpecialtyColumn";
            // 
            // YearColumn
            // 
            this.YearColumn.HeaderText = "Year";
            this.YearColumn.Name = "YearColumn";
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.Shown += new System.EventHandler(this.GroupForm_Shown);
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
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelSpeciality;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxSpeciality;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonReplace;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpecialtyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearColumn;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClean;
    }
}