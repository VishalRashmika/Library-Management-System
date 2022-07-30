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
    public partial class viewabook : Form
    {
        public viewabook()
        {
            InitializeComponent();
        }

        private void viewabook_Load(object sender, EventArgs e)
        {
            Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True.Visible = false;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
            // con.ConnectionString = "data source = DESKTOP-3H8MJCB\\MSSQLSERVERMS; database= library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from new_book";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource=ds.Tables[0];
        }
        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True.Visible = true;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
            //con.ConnectionString = "data source = DESKTOP-3H8MJCB\\MSSQLSERVERMS; database= library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from new_book where bid="+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtvbookname.Text = ds.Tables[0].Rows[0][1].ToString();
            txtvbauthorname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtvbpublication.Text = ds.Tables[0].Rows[0][3].ToString();
            //txtpdate.Text = ds.Tables[0].Rows[0][4].ToString();
            txtvbprice.Text = ds.Tables[0].Rows[0][5].ToString();
            txtvbquantity.Text = ds.Tables[0].Rows[0][6].ToString();



        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True.Visible = false;
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True.Visible = false;
        }

        private void txtsearchabook_TextChanged(object sender, EventArgs e)
        {
            if (txtvbookname.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                // con.ConnectionString = "data source = DESKTOP-3H8MJCB\\MSSQLSERVERMS; database= library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from new_book where bname like '"+txtvbookname.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else 
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                // con.ConnectionString = "data source = DESKTOP-3H8MJCB\\MSSQLSERVERMS; database= library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from new_book";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsearchabook.Clear();
            Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Updated.Confirm?", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string bname = txtvbookname.Text;
                string bauthor = txtvbauthorname.Text;
                string publication = txtvbpublication.Text;
                string pdate = txtpdate.Text;
                Int64 price = Int64.Parse(txtvbprice.Text);
                Int64 quantity = Int64.Parse(txtvbquantity.Text);

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                // con.ConnectionString = "data source = DESKTOP-3H8MJCB\\MSSQLSERVERMS; database= library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update new_book set bname = '" + bname + "',bauthor ='" + bauthor + "',bpubl='" + publication + "',bpdate='" + txtpdate + "',bprice=" + price + ",bquan=" + quantity + " where bid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be DELETED.Confirm?", "CONFIRM", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
                // con.ConnectionString = "data source = DESKTOP-3H8MJCB\\MSSQLSERVERMS; database= library;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from new_book where bid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
    }
}
