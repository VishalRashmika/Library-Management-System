using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookdetails bd = new bookdetails();
            bd.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure yo want to exit ? ", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
 
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addabook addbookfrm = new Addabook();
            addbookfrm.Show();
            
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewabook vab = new viewabook();
            vab.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstudent addsdt = new addstudent();
            addsdt.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewstudent vs = new viewstudent();
            vs.Show();
        }

        private void issueBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            issuebook ib = new issuebook();
            ib.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
