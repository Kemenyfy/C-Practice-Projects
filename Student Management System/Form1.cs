using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HoneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo();
            student.Show();
        }

        private void LogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
