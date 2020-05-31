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
    public partial class GroupForm : Form
    {
        public List<GroupDTO> DbGroups { get; set; } = new List<GroupDTO>();
        private int indexRow = -1;
        public GroupForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (DbGroups == null)
                DbGroups = new List<GroupDTO>();

            GroupDTO group = new GroupDTO
            {
                Specialty = textBoxSpeciality.Text,
                Year = Int32.Parse(textBoxYear.Text)
            };

            if (group == null)
                return;

            DbGroups.Add(group);
            dataGridView.Rows.Add(group.Specialty, group.Year);
            buttonClean.Enabled = true;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;

            DataGridViewRow row = dataGridView.Rows[indexRow];

            if (row.Cells[0].Value == null)
                return;

            textBoxSpeciality.Text = row.Cells[0].Value.ToString();
            textBoxYear.Text = row.Cells[1].Value.ToString();

            buttonReplace.Enabled = true;
            buttonRemove.Enabled = true;
            buttonClean.Enabled = true;
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            DbGroups[indexRow] = new GroupDTO
            {
                Specialty = textBoxSpeciality.Text,
                Year = Int32.Parse(textBoxYear.Text)
            };

            DataGridViewRow row = dataGridView.Rows[indexRow];
            row.Cells[0].Value = DbGroups[indexRow].Specialty;
            row.Cells[1].Value = DbGroups[indexRow].Year;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            DbGroups.RemoveAt(indexRow);

            dataGridView.Rows.Clear();

            foreach (var it in DbGroups)
                dataGridView.Rows.Add(it.Specialty, it.Year);

            indexRow = -1;
            buttonRemove.Enabled = false;
            buttonReplace.Enabled = false;
            buttonClean.Enabled = false;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            DbGroups = null;
            indexRow = -1;
            dataGridView.Rows.Clear();
            buttonClean.Enabled = false;
            buttonRemove.Enabled = false;
            buttonReplace.Enabled = false;
        }

        private void GroupForm_Shown(object sender, EventArgs e)
        {
            if (DbGroups == null)
                return;

            foreach (var it in DbGroups)
                dataGridView.Rows.Add(it.Specialty, it.Year);

            buttonClean.Enabled = true;
        }
    }
}
