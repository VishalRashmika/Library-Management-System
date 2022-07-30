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
    public partial class issuebook : Form
    {
        public issuebook()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void issuebook_Load(object sender, EventArgs e)
        {
            Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True con = new Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
            //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\PHOENIX4902N; database= library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select bname from new_book", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBoxbookname.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }
        int count;
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearchenrollno.Text != "")
            {
                string eid = txtsearchenrollno.Text;
                Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True con = new Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\PHOENIX4902N; database= library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewStudent where enroll = '" + eid + "' ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);


                //------------------------------------------------------------------//
                cmd.CommandText = "select count (std_enroll) from IRBook where std_enroll = '" + eid + "' and book_return_date is null ";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
                //------------------------------------------------------------------//

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtsdtname.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtdepartment.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtsdtsemester.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtsdtcontact.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtsdtemail.Text = ds.Tables[0].Rows[0][5].ToString();

                }
                else 
                {
                    txtsdtname.Clear();
                    txtdepartment.Clear();
                    txtsdtsemester.Clear();
                    txtsdtcontact.Clear();
                    txtsdtemail.Clear();
                    MessageBox.Show("INAVLID ENROLLMENT NUMBER", "WARINING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnissuebk_Click(object sender, EventArgs e)
        {
            if (txtsdtname.Text != "")
            {
                if (comboBoxbookname.SelectedIndex != -1 && count <= 2)
                {
                    string enroll = txtsearchenrollno.Text;
                    string sname = txtsdtname.Text;
                    string sdep = txtdepartment.Text;
                    string sem = txtsdtsemester.Text;
                    Int64 contact = Int64.Parse(txtsdtcontact.Text);
                    string email = txtsdtemail.Text;
                    string bookname = comboBoxbookname.Text;
                    string bookissuedate = DTPbookissuedate.Text;


                    string eid = txtsearchenrollno.Text;
                    Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True con = new Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                    //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\PHOENIX4902N; database= library;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = cmd.CommandText = "insert into IRBook (std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date)values('" + enroll + "','" + sname + "','" + sdep + "','" + sem + "'," + contact + ",'" + email + "','" + bookname + "','" + bookissuedate + "')";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("BOOK ISSUED", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("SELECT BOOK OR MAXIMUM OF BOOKS HAS BENN ISSUED", "NO BOOK SELECTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ENTER A VALID ENROLLMENT NUMBER", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
            }
        }

        private void txtsearchenrollno_TextChanged(object sender, EventArgs e)
        {
            if (txtsearchenrollno.Text == "")
            {
                txtsdtname.Clear();
                txtdepartment.Clear(); 
                txtsdtsemester .Clear();
                txtsdtcontact.Clear();
                txtsdtemail.Clear();
                
 
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsearchenrollno.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure yo want to exit ? ", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();

            }
        }
    }
}
