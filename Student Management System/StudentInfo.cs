using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class StudentInfo : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gustavo.Kemenyfy\Documents\STUDENTINFO.mdf;Integrated Security=True;Connect Timeout=30");

        public StudentInfo()
        {
            InitializeComponent();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO STUDENT_INFO(STUDENT_ID,STUDENT_NAME,ADDRESS,CLASS) 
                                        VALUES(@id, @name, @address, @class)",connection);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);
            cmd.Parameters.AddWithValue("@class", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Added Successfully");
            connection.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE STUDENT_INFO SET STUDENT_NAME=@name, ADDRESS=@address, CLASS=@class WHERE STUDENT_ID=@id", connection);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);
            cmd.Parameters.AddWithValue("@class", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Updated Successfully");
            connection.Close();
        }
    }
}
