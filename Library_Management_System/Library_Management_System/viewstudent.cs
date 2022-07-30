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
    public partial class viewstudent : Form
    {
        public viewstudent()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void viewstudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                                                  //Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True
            //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\PHOENIX4902N; database=library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = " select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource=ds.Tables[0];
        }

        private void txtenrollnum_TextChanged(object sender, EventArgs e)
        {
            if (txtenrollnum.Text != "")
            {
                panel2.Visible = false;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\PHOENIX4902N; database=library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from NewStudent where enroll like '"+txtenrollnum.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\PHOENIX4902N; database=library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = " select * from NewStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
 
            }
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
 
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
            //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\PHOENIX4902N; database=library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = " select * from NewStudent where stuid  = "+bid+" ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][6].ToString());

            txtsname.Text = ds.Tables[0].Rows[0][0].ToString();
            txtsnumber.Text=ds.Tables[0].Rows[0][1].ToString();
            txtdepartment.Text=ds.Tables[0].Rows[0][2].ToString();
            txtssemester.Text=ds.Tables[0].Rows[0][3].ToString();
            txtscontact.Text=ds.Tables[0].Rows[0][4].ToString();
            txtemail.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string sname = txtsname.Text;
            string enroll = txtsnumber.Text;
            string dep = txtdepartment.Text;
            string sem = txtssemester.Text;
            Int64 contact = Int64.Parse(txtscontact.Text);
            string email = txtemail.Text;

            if (MessageBox.Show("DATA WILL BE UPDATED", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK) ;
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\PHOENIX4902N; database=library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NewStudent set sname='" + sname + "', enroll='" + enroll + "',dep='" + dep + "', sem='" + sem + "', contact=" + contact + ",email='" + email + "' where stuid = " + rowid + "   ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                viewstudent_Load(this,null);
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            viewstudent_Load(this, null);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("DATA WILL BE DELETED", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\PHOENIX4902N; database=library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent where stuid=" + rowid + " ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                viewstudent_Load(this, null);

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("UNSAVED DATA WILL BE LOST", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                this.Close();
 
            }
            
        }
    }
}
