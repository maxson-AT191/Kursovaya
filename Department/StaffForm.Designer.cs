namespace Department
{
    partial class StaffForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonReplaceLecturer = new System.Windows.Forms.Button();
            this.buttonReplaceAssistant = new System.Windows.Forms.Button();
            this.buttonAddAssistant = new System.Windows.Forms.Button();
            this.buttonAddLecturer = new System.Windows.Forms.Button();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.splitContainerTable = new System.Windows.Forms.SplitContainer();
            this.dataGridViewLecturers = new System.Windows.Forms.DataGridView();
            this.LecturersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewAssistants = new System.Windows.Forms.DataGridView();
            this.AssistantsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTable)).BeginInit();
            this.splitContainerTable.Panel1.SuspendLayout();
            this.splitContainerTable.Panel2.SuspendLayout();
            this.splitContainerTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssistants)).BeginInit();
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
            this.splitContainer.Panel1.Controls.Add(this.buttonCancel);
            this.splitContainer.Panel1.Controls.Add(this.buttonOK);
            this.splitContainer.Panel1.Controls.Add(this.buttonClean);
            this.splitContainer.Panel1.Controls.Add(this.buttonRemove);
            this.splitContainer.Panel1.Controls.Add(this.buttonReplaceLecturer);
            this.splitContainer.Panel1.Controls.Add(this.buttonReplaceAssistant);
            this.splitContainer.Panel1.Controls.Add(this.buttonAddAssistant);
            this.splitContainer.Panel1.Controls.Add(this.buttonAddLecturer);
            this.splitContainer.Panel1.Controls.Add(this.labelFIO);
            this.splitContainer.Panel1.Controls.Add(this.textBoxFIO);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerTable);
            this.splitContainer.Size = new System.Drawing.Size(851, 450);
            this.splitContainer.SplitterDistance = 325;
            this.splitContainer.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(107, 415);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(26, 415);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(157, 279);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(115, 23);
            this.buttonClean.TabIndex = 5;
            this.buttonClean.Text = "Clean All";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Enabled = false;
            this.buttonRemove.Location = new System.Drawing.Point(26, 279);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(115, 23);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove selected";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonReplaceLecturer
            // 
            this.buttonReplaceLecturer.Enabled = false;
            this.buttonReplaceLecturer.Location = new System.Drawing.Point(26, 237);
            this.buttonReplaceLecturer.Name = "buttonReplaceLecturer";
            this.buttonReplaceLecturer.Size = new System.Drawing.Size(115, 23);
            this.buttonReplaceLecturer.TabIndex = 4;
            this.buttonReplaceLecturer.Text = "Replace as Lecturer";
            this.buttonReplaceLecturer.UseVisualStyleBackColor = true;
            this.buttonReplaceLecturer.Click += new System.EventHandler(this.buttonReplaceLecturer_Click);
            // 
            // buttonReplaceAssistant
            // 
            this.buttonReplaceAssistant.Enabled = false;
            this.buttonReplaceAssistant.Location = new System.Drawing.Point(157, 237);
            this.buttonReplaceAssistant.Name = "buttonReplaceAssistant";
            this.buttonReplaceAssistant.Size = new System.Drawing.Size(114, 23);
            this.buttonReplaceAssistant.TabIndex = 3;
            this.buttonReplaceAssistant.Text = "Replace as Assistant";
            this.buttonReplaceAssistant.UseVisualStyleBackColor = true;
            this.buttonReplaceAssistant.Click += new System.EventHandler(this.buttonReplaceAssistant_Click);
            // 
            // buttonAddAssistant
            // 
            this.buttonAddAssistant.Location = new System.Drawing.Point(157, 195);
            this.buttonAddAssistant.Name = "buttonAddAssistant";
            this.buttonAddAssistant.Size = new System.Drawing.Size(114, 23);
            this.buttonAddAssistant.TabIndex = 3;
            this.buttonAddAssistant.Text = "Add as Assistant";
            this.buttonAddAssistant.UseVisualStyleBackColor = true;
            this.buttonAddAssistant.Click += new System.EventHandler(this.buttonAddAssistant_Click);
            // 
            // buttonAddLecturer
            // 
            this.buttonAddLecturer.Location = new System.Drawing.Point(26, 195);
            this.buttonAddLecturer.Name = "buttonAddLecturer";
            this.buttonAddLecturer.Size = new System.Drawing.Size(115, 23);
            this.buttonAddLecturer.TabIndex = 2;
            this.buttonAddLecturer.Text = "Add as Lecturer";
            this.buttonAddLecturer.UseVisualStyleBackColor = true;
            this.buttonAddLecturer.Click += new System.EventHandler(this.buttonAddLecturer_Click);
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFIO.Location = new System.Drawing.Point(23, 126);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(29, 16);
            this.labelFIO.TabIndex = 1;
            this.labelFIO.Text = "FIO";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(26, 145);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(288, 20);
            this.textBoxFIO.TabIndex = 0;
            // 
            // splitContainerTable
            // 
            this.splitContainerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTable.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTable.Name = "splitContainerTable";
            // 
            // splitContainerTable.Panel1
            // 
            this.splitContainerTable.Panel1.Controls.Add(this.dataGridViewLecturers);
            // 
            // splitContainerTable.Panel2
            // 
            this.splitContainerTable.Panel2.Controls.Add(this.dataGridViewAssistants);
            this.splitContainerTable.Size = new System.Drawing.Size(522, 450);
            this.splitContainerTable.SplitterDistance = 256;
            this.splitContainerTable.TabIndex = 0;
            // 
            // dataGridViewLecturers
            // 
            this.dataGridViewLecturers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LecturersColumn});
            this.dataGridViewLecturers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLecturers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewLecturers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLecturers.Name = "dataGridViewLecturers";
            this.dataGridViewLecturers.Size = new System.Drawing.Size(256, 450);
            this.dataGridViewLecturers.TabIndex = 0;
            this.dataGridViewLecturers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLecturers_CellClick);
            // 
            // LecturersColumn
            // 
            this.LecturersColumn.HeaderText = "Lecturers";
            this.LecturersColumn.Name = "LecturersColumn";
            // 
            // dataGridViewAssistants
            // 
            this.dataGridViewAssistants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAssistants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssistants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssistantsColumn});
            this.dataGridViewAssistants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAssistants.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewAssistants.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewAssistants.Name = "dataGridViewAssistants";
            this.dataGridViewAssistants.Size = new System.Drawing.Size(262, 450);
            this.dataGridViewAssistants.TabIndex = 0;
            this.dataGridViewAssistants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAssistants_CellClick);
            // 
            // AssistantsColumn
            // 
            this.AssistantsColumn.HeaderText = "Assistants";
            this.AssistantsColumn.Name = "AssistantsColumn";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Shown += new System.EventHandler(this.StaffForm_Shown);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerTable.Panel1.ResumeLayout(false);
            this.splitContainerTable.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTable)).EndInit();
            this.splitContainerTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssistants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonReplaceLecturer;
        private System.Windows.Forms.Button buttonReplaceAssistant;
        private System.Windows.Forms.Button buttonAddAssistant;
        private System.Windows.Forms.Button buttonAddLecturer;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.SplitContainer splitContainerTable;
        private System.Windows.Forms.DataGridView dataGridViewLecturers;
        private System.Windows.Forms.DataGridViewTextBoxColumn LecturersColumn;
        private System.Windows.Forms.DataGridView dataGridViewAssistants;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssistantsColumn;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}