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
    public partial class EmploymentForm : Form
    {
        public List<string> Employees { get; set; } = new List<string>();
        public List<int> Times { get; set; } = new List<int>();
        public EmploymentForm()
        {
            InitializeComponent();
        }

        private void EmploymentForm_Shown(object sender, EventArgs e)
        {
            //if (Employees.Count != Times.Count)
                //return;

            for (int i = 0; i < Employees.Count; ++i)
                dataGridView.Rows.Add(Employees[i], Times[i]);
        }
    }
}
