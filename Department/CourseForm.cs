using Department_BL.Models_DTO;
using Department_Db.Models;
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
    public partial class CourseForm : Form
    {
        public List<CourseDTO> CourcesDb { get; set; } = new List<CourseDTO>();
        private int rowIndex = -1;
        private CourseDTO Selected = new CourseDTO();
        public CourseForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (CourcesDb == null)
                CourcesDb = new List<CourseDTO>();

            CourseDTO course = new CourseDTO
            {
                Name = textBoxName.Text,
                Code = textBoxCode.Text
            };

            CourseInfoDTO info = new CourseInfoDTO
            {
                LaboratoryHours = Int32.Parse(textBoxLaboratories.Text),
                LectureHours = Int32.Parse(textBoxLectures.Text),
                PracticeHours = Int32.Parse(textBoxPractices.Text)
            };

            StaffForm staffForm = new StaffForm();
            if (staffForm.ShowDialog(this) == DialogResult.OK)
                course.Staff = staffForm.StaffDb;

            GroupForm groupForm = new GroupForm();
            if (groupForm.ShowDialog(this) == DialogResult.OK)
                info.Groups = groupForm.DbGroups;

            course.Info = info;
            CourcesDb.Add(course);

            dataGridView.Rows.Add();
            DataGridViewRow row = dataGridView.Rows[CourcesDb.Count - 1];
            row.Cells[0].Value = course.Name;
            row.Cells[1].Value = course.Code;
            row.Cells[2].Value = course.Info.LectureHours;
            row.Cells[3].Value = course.Info.PracticeHours;
            row.Cells[4].Value = course.Info.LaboratoryHours;

            foreach (var it in course.Info.Groups)
                ((DataGridViewComboBoxCell)row.Cells[5]).Items.Add(it);

            buttonClean.Enabled = true;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            Selected = CourcesDb[rowIndex];
            DataGridViewRow row = dataGridView.Rows[rowIndex];

            if (row.Cells[0].Value == null)
                return;

            textBoxName.Text = Selected.Name;
            textBoxCode.Text = Selected.Code;
            textBoxLectures.Text = Selected.Info.LectureHours.ToString();
            textBoxPractices.Text = Selected.Info.PracticeHours.ToString();
            textBoxLaboratories.Text = Selected.Info.LaboratoryHours.ToString();

            buttonRemove.Enabled = true;
            buttonReplace.Enabled = true;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
                return;

            Selected.Name = textBoxName.Text;
            Selected.Code = textBoxCode.Text;
            Selected.Info.LectureHours = Int32.Parse(textBoxLectures.Text);
            Selected.Info.PracticeHours = Int32.Parse(textBoxPractices.Text);
            Selected.Info.LaboratoryHours = Int32.Parse(textBoxLaboratories.Text);

            StaffForm staffForm = new StaffForm();
            staffForm.StaffDb = Selected.Staff;
            if (staffForm.ShowDialog(this) == DialogResult.OK)
                Selected.Staff = staffForm.StaffDb;

            GroupForm groupForm = new GroupForm();
            groupForm.DbGroups = Selected.Info.Groups;
            if (groupForm.ShowDialog(this) == DialogResult.OK)
                Selected.Info.Groups = groupForm.DbGroups;

            dataGridView.Rows.Clear();

            int index = 0;
            foreach (var it in CourcesDb)
            {
                dataGridView.Rows.Add();
                DataGridViewRow row = dataGridView.Rows[index];

                row.Cells[0].Value = it.Name;
                row.Cells[1].Value = it.Code;
                row.Cells[2].Value = it.Info.LectureHours;
                row.Cells[3].Value = it.Info.PracticeHours;
                row.Cells[4].Value = it.Info.LaboratoryHours;

                foreach (var item in it.Info.Groups)
                    ((DataGridViewComboBoxCell)row.Cells[5]).Items.Add(item);

                ++index;
            }
        }

        private void CourseForm_Shown(object sender, EventArgs e)
        {
            if (CourcesDb == null)
                return;

            int index = 0;
            foreach(var it in CourcesDb)
            {
                dataGridView.Rows.Add();
                DataGridViewRow row = dataGridView.Rows[index];

                row.Cells[0].Value = it.Name;
                row.Cells[1].Value = it.Code;
                row.Cells[2].Value = it.Info.LectureHours;
                row.Cells[3].Value = it.Info.PracticeHours;
                row.Cells[4].Value = it.Info.LaboratoryHours;

                foreach (var item in it.Info.Groups)
                    ((DataGridViewComboBoxCell)row.Cells[5]).Items.Add(item);

                ++index;
            }

            buttonClean.Enabled = true;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (rowIndex == -1)
                return;

            CourcesDb = (from c in CourcesDb
                         where c != Selected
                         select c).ToList();

            dataGridView.Rows.Clear();

            int index = 0;
            foreach (var it in CourcesDb)
            {
                dataGridView.Rows.Add();
                DataGridViewRow row = dataGridView.Rows[index];

                row.Cells[0].Value = it.Name;
                row.Cells[1].Value = it.Code;
                row.Cells[2].Value = it.Info.LectureHours;
                row.Cells[3].Value = it.Info.PracticeHours;
                row.Cells[4].Value = it.Info.LaboratoryHours;

                foreach (var item in it.Info.Groups)
                    ((DataGridViewComboBoxCell)row.Cells[5]).Items.Add(item);

                ++index;
            }

            rowIndex = -1;
            buttonRemove.Enabled = false;
            buttonReplace.Enabled = false;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            CourcesDb = null;
            dataGridView.Rows.Clear();
            Selected = null;
            rowIndex = -1;
            buttonReplace.Enabled = false;
            buttonRemove.Enabled = false;
            buttonClean.Enabled = false;
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
