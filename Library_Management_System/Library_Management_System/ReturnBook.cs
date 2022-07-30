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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
            //con.ConnectionString = "data source =DESKTOP-3H8MJCB\\PHOENIX4902N; database= library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM IRBook WHERE std_enroll = '" + txtsearchenrollno.Text + "' AND book_return_date IS NULL";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];

            }
            else
            {
                MessageBox.Show("INAVALID ID OR NO BOOK ISSUED","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True.Visible = false;
            txtsearchenrollno.Clear();
        }
        string bname;
        string bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

            }
            txtbkname.Text = bname;
            txtissuedate.Text = bdate;
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True");
            //con.ConnectionString = "data source =DESKTOP-3H8MJCB\\PHOENIX4902N; database= library;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRBook set book_return_date = '"+dateTimePickerreturndate.Text+"' where std_enroll = '"+txtsearchenrollno.Text+"'and id ="+rowid+" ";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("RETURNED SUCCESSFULL","SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ReturnBook_Load(this, null);
        }

        private void txtsearchenrollno_TextChanged(object sender, EventArgs e)
        {
            if (txtsearchenrollno.Text == "")
            {
                Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsearchenrollno.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\C#\Library Management System\Library_Management_System\Library_Management_System\library.mdf;Integrated Security=True.Visible = false;
        }
    }
}
