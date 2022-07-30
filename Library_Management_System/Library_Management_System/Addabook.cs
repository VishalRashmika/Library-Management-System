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
    public partial class Addabook : Form
    {
        public Addabook()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbookname.Text != "" && txtbkauthorname.Text != "" && txtbookpublication.Text != "" && txtbookprice.Text != "" && txtbookquantity.Text != "")
            {
                string bname = txtbookname.Text;
                string bauthor = txtbkauthorname.Text;
                string publication = txtbookpublication.Text;
                string pdate = DTPpurchaseddate.Text;
                Int64 price = Int64.Parse(txtbookprice.Text);
                Int64 quan = Int64.Parse(txtbookquantity.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                // con.ConnectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;


                con.Open();
                cmd.CommandText = "insert into new_book (bname,bauthor,bpubl,bpdate,bprice,bquan) values ('" + bname + "','" + bauthor + "','" + publication + "','" + pdate + "'," + price + "," + quan + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("data saved successfully","SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtbookname.Clear();
                txtbkauthorname.Clear();
                txtbookpublication.Clear();
                txtbookprice.Clear();
                txtbookquantity.Clear();

            }
            else
            {
                MessageBox.Show("Empty FIELDS are not allowed","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to cancel,your unsaved data will be lost ", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            this.Close();
        }

        private void Addabook_Load(object sender, EventArgs e)
        {

        }
    }
}
