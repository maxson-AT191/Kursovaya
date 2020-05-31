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
    public partial class CoursesTable : Form
    {
        public List<CourseDTO> CourcesDb { get; set; } = new List<CourseDTO>();
        public CoursesTable()
        {
            InitializeComponent();
        }

        private void CoursesTable_Shown(object sender, EventArgs e)
        {
            if (CourcesDb == null)
                return;

            int index = 0;
            foreach (var it in CourcesDb)
            {
                dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[index];

                row.Cells[0].Value = it.Name;
                row.Cells[1].Value = it.Code;
                row.Cells[2].Value = it.Info.LectureHours;
                row.Cells[3].Value = it.Info.PracticeHours;
                row.Cells[4].Value = it.Info.LaboratoryHours;

                foreach (var item in it.Info.Groups)
                    ((DataGridViewComboBoxCell)row.Cells[5]).Items.Add(item);

                foreach(var item in it.Staff.Lecturers)
                    ((DataGridViewComboBoxCell)row.Cells[6]).Items.Add(item);

                foreach (var item in it.Staff.Assistants)
                    ((DataGridViewComboBoxCell)row.Cells[7]).Items.Add(item);

                ++index;
            }
        }
    }
}
