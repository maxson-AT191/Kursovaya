using Department_BL.Models_DTO;
using Department_Db;
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
    public partial class Main : Form
    {
        public DepartmentsDbDTO Db { get; set; } = new DepartmentsDbDTO();//динамическим массив структур 2 задание 
        public DepartmentDTO Selected { get; set; } = new DepartmentDTO();

        private string fullPath;
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Text files(*.json)|*.json|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            fullPath = openFileDialog.FileName;

            DepartmentsDb tmp = ProvideServices.ReadJSON<DepartmentsDb>(fullPath);
            Db = new DepartmentsDbDTO(tmp);

            foreach (var it in Db.Departments)
            {
                ToolStripMenuItem dbItem = new ToolStripMenuItem(it.Name);
                dbItem.Checked = true;
                dbItem.CheckState = CheckState.Unchecked;
                dbItem.Click += DbItem_Click;
                selectToolStripMenuItem.DropDownItems.Add(dbItem);
            }

            saveToolStripMenuItem.Enabled = true;
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void DbItem_Click(object sender, EventArgs e)
        {
            Selected = null;

            foreach (ToolStripMenuItem it in selectToolStripMenuItem.DropDownItems)
                it.CheckState = CheckState.Unchecked;
            ((ToolStripMenuItem)sender).CheckState = CheckState.Checked;

            List<DepartmentDTO> tmp = (from d in Db.Departments
                                     where d.Name == ((ToolStripMenuItem)sender).Text
                                     select d).ToList();
            Selected = tmp[0];

            Password password = new Password();
            if (password.ShowDialog(this) != DialogResult.OK)
            {
                Selected = null;
                ((ToolStripMenuItem)sender).CheckState = CheckState.Unchecked;
                return;
            }

            if(password.textBoxPassword.Text != Selected.Password)
            {
                Selected = null;
                ((ToolStripMenuItem)sender).CheckState = CheckState.Unchecked;
                return;
            }

                dataGridViewCources.Rows.Clear();
            int index = 0;
            foreach (var it in Selected.Courses)
            {
                dataGridViewCources.Rows.Add();
                dataGridViewCources.Rows[index].Cells[0].Value = it.Name;
                dataGridViewCources.Rows[index].Cells[1].Value = it.Code;
                dataGridViewCources.Rows[index].Cells[2].Value = it.Info.LectureHours;
                dataGridViewCources.Rows[index].Cells[3].Value = it.Info.PracticeHours;
                dataGridViewCources.Rows[index].Cells[4].Value = it.Info.LaboratoryHours;

                foreach(var item in it.Info.Groups)
                    ((DataGridViewComboBoxCell)dataGridViewCources.Rows[index].Cells[5]).Items.Add(item.ToString());

                foreach(var item in it.Staff.Lecturers)
                    ((DataGridViewComboBoxCell)dataGridViewCources.Rows[index].Cells[6]).Items.Add(item);

                foreach (var item in it.Staff.Assistants)
                    ((DataGridViewComboBoxCell)dataGridViewCources.Rows[index].Cells[7]).Items.Add(item);

                ++index;
            }

            foreach(var it in Selected.Courses)
                foreach (var item in it.Staff.Assistants)
                    if (!Selected.Staff.ContainsStaff(item))
                        Selected.Staff.AddAssistant(item);

            foreach (var it in Selected.Courses)
                foreach (var item in it.Staff.Lecturers)
                    if (!Selected.Staff.ContainsStaff(item))
                        Selected.Staff.AddLecturer(item);

            removeToolStripMenuItem.Enabled = true;
            changeToolStripMenuItem.Enabled = true;
            courcesWithoutStaffToolStripMenuItem.Enabled = true;
            showLowLecturesCoursesToolStripMenuItem.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentsDb db = Db.ToDLA();
            ProvideServices.WriteJSON<DepartmentsDb>(fullPath, ref db);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            fullPath = saveFileDialog.FileName;

            DepartmentsDb db = Db.ToDLA();
            ProvideServices.WriteJSON<DepartmentsDb>(fullPath, ref db);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentDTO department = new DepartmentDTO();//обьект создается вызовом форм 

            CourseForm courseForm = new CourseForm();
            if (courseForm.ShowDialog(this) != DialogResult.OK)
                return;

            department.Courses = courseForm.CourcesDb;

            Registration registration = new Registration();
            if(registration.ShowDialog(this) == DialogResult.OK)
            {
                department.Name = registration.textBoxName.Text;
                department.Head = registration.textBoxHead.Text;
                department.Password = registration.textBoxPassword.Text;
            }

            foreach(var it in department.Courses)
            {
                foreach (var item in it.Staff.Lecturers)
                    if (!Selected.Staff.ContainsStaff(item))
                        Selected.Staff.AddLecturer(item);

                foreach (var item in it.Staff.Assistants)
                    if (!Selected.Staff.ContainsStaff(item))
                        Selected.Staff.AddAssistant(item);
            }

            Db.Departments.Add(department);
            ToolStripMenuItem dbItem = new ToolStripMenuItem(department.Name);
            dbItem.Checked = true;
            dbItem.CheckState = CheckState.Unchecked;
            dbItem.Click += DbItem_Click;
            selectToolStripMenuItem.DropDownItems.Add(dbItem);
            saveAsToolStripMenuItem.Enabled = true;
        }

        private void courcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.CourcesDb = Selected.Courses;

            if (courseForm.ShowDialog(this) != DialogResult.OK)
                return;

            dataGridViewCources.Rows.Clear();
            int index = 0;
            foreach (var it in Selected.Courses)
            {
                dataGridViewCources.Rows.Add();
                dataGridViewCources.Rows[index].Cells[0].Value = it.Name;
                dataGridViewCources.Rows[index].Cells[1].Value = it.Code;
                dataGridViewCources.Rows[index].Cells[2].Value = it.Info.LectureHours;
                dataGridViewCources.Rows[index].Cells[3].Value = it.Info.PracticeHours;
                dataGridViewCources.Rows[index].Cells[4].Value = it.Info.LaboratoryHours;

                foreach (var item in it.Info.Groups)
                    ((DataGridViewComboBoxCell)dataGridViewCources.Rows[index].Cells[5]).Items.Add(item.ToString());

                foreach (var item in it.Staff.Lecturers)
                    ((DataGridViewComboBoxCell)dataGridViewCources.Rows[index].Cells[6]).Items.Add(item);

                foreach (var item in it.Staff.Assistants)
                    ((DataGridViewComboBoxCell)dataGridViewCources.Rows[index].Cells[7]).Items.Add(item);

                ++index;
            }
        }

        private void headToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm changeForm = new ChangeForm();

            if (changeForm.ShowDialog(this) != DialogResult.OK)
                return;

            if (changeForm.textBoxOldHead.Text == Selected.Head)
                Selected.Head = changeForm.textBoxNewHead.Text;

            if (changeForm.textBoxOldPassword.Text == Selected.Password)
                Selected.Password = changeForm.textBoxNewPassword.Text;
        }

        private void courcesWithoutStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<CourseDTO> noStaff = new List<CourseDTO>();

            noStaff = (from c in Selected.Courses
                      where c.Staff.Assistants.Count == 0 && c.Staff.Lecturers.Count == 0
                      select c).ToList();

            CoursesTable table = new CoursesTable();
            table.CourcesDb = noStaff;
            table.ShowDialog();
        }

        private void staffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> employees = new List<string>();
            foreach (var it in Selected.Staff.Assistants)
                employees.Add(it);

            foreach (var it in Selected.Staff.Lecturers)
                employees.Add(it);

            int[] times = new int[employees.Count];
            for(int i = 0; i < times.Length; ++i)
                foreach(var it in Selected.Courses)
                    if(it.Staff.ContainsStaff(employees[i]))
                        times[i] += (it.Info.LectureHours + it.Info.PracticeHours + it.Info.LaboratoryHours);

            EmploymentForm form = new EmploymentForm();
            form.Times = times.ToList();
            form.Employees = employees;
            form.ShowDialog();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Password password = new Password();

            if (password.ShowDialog() != DialogResult.OK)
                return;

            if (Selected.Password != password.textBoxPassword.Text)
                return;

            Db.Departments.Remove(Selected);
            dataGridViewCources.Rows.Clear();

            selectToolStripMenuItem.DropDownItems.Clear();
            ToolStripMenuItem addItem = new ToolStripMenuItem("Add...");
            addItem.Click += addToolStripMenuItem_Click;
            selectToolStripMenuItem.DropDownItems.Add(addItem);

            if (Db.Departments.Count == 0)
                return;

            foreach (var it in Db.Departments)
            {
                ToolStripMenuItem dbItem = new ToolStripMenuItem(it.Name);
                dbItem.Checked = true;
                dbItem.CheckState = CheckState.Unchecked;
                dbItem.Click += DbItem_Click;
                selectToolStripMenuItem.DropDownItems.Add(dbItem);
            }

            staffInformationToolStripMenuItem.Enabled = false;
            courcesWithoutStaffToolStripMenuItem.Enabled = false;
            headToolStripMenuItem.Enabled = false;
            showLowLecturesCoursesToolStripMenuItem.Enabled = false;
        }

        private void showLowLecturesCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<CourseDTO> list = new List<CourseDTO>();

            foreach (var it in Selected.Courses)
                if (it.Info.LectureHours > it.Info.PracticeHours + it.Info.LaboratoryHours)
                    list.Add(it);

            CoursesTable table = new CoursesTable();
            table.CourcesDb = list;
            table.ShowDialog();
        }
    }
}
