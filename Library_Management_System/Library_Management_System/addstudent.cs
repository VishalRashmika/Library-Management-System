using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class addstudent : Form
    {
        public addstudent()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to cancel,your unsaved data will be lost ", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsdtname.Clear();
            txtenrollnum.Clear();
            txtdepartment.Clear();
            txtsdtsemester.Clear();
            txtsdtcontact.Clear();
            txtemail.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtsdtname.Text != "" && txtenrollnum.Text != "" && txtdepartment.Text != "" && txtsdtsemester.Text != "" && txtsdtcontact.Text != "" && txtemail.Text != "")
            {
                string name = txtsdtname.Text;
                string enrollnum = txtenrollnum.Text;
                string dep = txtdepartment.Text;
                string semester = txtsdtsemester.Text;
                Int64 contact = Int64.Parse(txtsdtcontact.Text);
                string email = txtemail.Text;

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\PHOENIX4902N; database = library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewStudent (sname,enroll,dep,sem,contact,email) values ('" + name + "','" + enrollnum + "','" + dep + "','" + semester + "'," + contact + ",'" + email + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("DATA SAVED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("EMPTY FIELDS ARE NOT ALLOWED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addstudent_Load(object sender, EventArgs e)
        {

        }
    }
}
