using Department_BL.Models_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Department
{
    public partial class StaffForm : Form
    {
        public StaffDTO StaffDb { get; set; } = new StaffDTO();
        private int indexerLecturers;
        private int indexerAssistants;
        private bool isLastLecturer;
        public StaffForm()
        {
            InitializeComponent();
        }

        private void buttonAddLecturer_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (StaffDb.Lecturers != null)
                check = StaffDb.Lecturers.Count;

            StaffDb.AddLecturer(textBoxFIO.Text);
            if (check != StaffDb.Lecturers.Count)
                dataGridViewLecturers.Rows.Add(StaffDb.Lecturers.Last());
        }

        private void buttonAddAssistant_Click(object sender, EventArgs e)
        {
            int check = 0;
            if(StaffDb.Assistants != null)
                check = StaffDb.Assistants.Count;

            StaffDb.AddAssistant(textBoxFIO.Text);

            if (check != StaffDb.Assistants.Count)
                dataGridViewAssistants.Rows.Add(StaffDb.Assistants.Last());
        }

        private void dataGridViewLecturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexerLecturers = e.RowIndex;
            DataGridViewRow row = dataGridViewLecturers.Rows[indexerLecturers];
            if (row.Cells[0].Value == null)
                return;

            textBoxFIO.Text = row.Cells[0].Value.ToString();

            buttonReplaceLecturer.Enabled = true;
            buttonReplaceAssistant.Enabled = true;
            buttonRemove.Enabled = true;
            isLastLecturer = true;
        }

        private void dataGridViewAssistants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexerAssistants = e.RowIndex;
            DataGridViewRow row = dataGridViewAssistants.Rows[indexerAssistants];
            if (row.Cells[0].Value == null)
                return;

            textBoxFIO.Text = row.Cells[0].Value.ToString();

            buttonReplaceAssistant.Enabled = true;
            buttonReplaceLecturer.Enabled = true;
            buttonRemove.Enabled = true;
            isLastLecturer = false;
        }

        private void buttonReplaceLecturer_Click(object sender, EventArgs e)
        {
            if (isLastLecturer)
            {
                if (indexerLecturers == -1)
                    return;

                StaffDb.Lecturers[indexerLecturers] = textBoxFIO.Text;
                DataGridViewRow row = dataGridViewLecturers.Rows[indexerLecturers];
                if (row.Cells[0].Value == null)
                    return;

                row.Cells[0].Value = StaffDb.Lecturers[indexerLecturers];
            }
            else
            {
                if (StaffDb.Lecturers.Contains(textBoxFIO.Text))
                    return;

                StaffDb.Assistants.RemoveAt(indexerAssistants);
                dataGridViewAssistants.Rows.Clear();
                if (StaffDb.Assistants != null)
                    foreach (var it in StaffDb.Assistants)
                        dataGridViewAssistants.Rows.Add(it);


                StaffDb.AddLecturer(textBoxFIO.Text);
                dataGridViewLecturers.Rows.Add(StaffDb.Lecturers.Last());
            }
        }

        private void buttonReplaceAssistant_Click(object sender, EventArgs e)
        {
            if (!isLastLecturer)
            {
                if (indexerAssistants == -1)
                    return;

                StaffDb.Assistants[indexerAssistants] = textBoxFIO.Text;
                DataGridViewRow row = dataGridViewAssistants.Rows[indexerAssistants];
                if (row.Cells[0].Value == null)
                    return;

                row.Cells[0].Value = StaffDb.Assistants[indexerAssistants];
            }
            else
            {
                if (StaffDb.Assistants.Contains(textBoxFIO.Text))
                    return;

                StaffDb.Lecturers.RemoveAt(indexerLecturers);
                dataGridViewLecturers.Rows.Clear();
                if (StaffDb.Lecturers != null)
                    foreach (var it in StaffDb.Lecturers)
                        dataGridViewLecturers.Rows.Add(it);


                StaffDb.AddAssistant(textBoxFIO.Text);
                dataGridViewAssistants.Rows.Add(StaffDb.Assistants.Last());
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(isLastLecturer)
            {
                if (indexerLecturers == -1)
                    return;

                StaffDb.Lecturers.RemoveAt(indexerLecturers);
                dataGridViewLecturers.Rows.RemoveAt(indexerLecturers);
            }
            else
            {
                if (indexerAssistants == -1)
                    return;

                StaffDb.Assistants.RemoveAt(indexerAssistants);
                dataGridViewLecturers.Rows.RemoveAt(indexerAssistants);
            }

            buttonRemove.Enabled = false;
            buttonReplaceAssistant.Enabled = false;
            buttonReplaceLecturer.Enabled = false;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            StaffDb = new StaffDTO();
            dataGridViewAssistants.Rows.Clear();
            dataGridViewLecturers.Rows.Clear();

            buttonReplaceLecturer.Enabled = false;
            buttonReplaceAssistant.Enabled = false;
            buttonClean.Enabled = false;
            buttonRemove.Enabled = false;
        }

        private void StaffForm_Shown(object sender, EventArgs e)
        {
            if (StaffDb == null)
                return;

            if(StaffDb.Assistants != null)
                foreach (var it in StaffDb.Assistants)
                    dataGridViewAssistants.Rows.Add(it);

            if(StaffDb.Lecturers != null)
                foreach (var it in StaffDb.Lecturers)
                    dataGridViewLecturers.Rows.Add(it);

            buttonClean.Enabled = true;
        }
    }
}
