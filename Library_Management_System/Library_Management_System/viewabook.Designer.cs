namespace Library_Management_System
{
    partial class viewabook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewabook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearchabook = new System.Windows.Forms.TextBox();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.txtpdate = new System.Windows.Forms.DateTimePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtvbpublication = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtvbauthorname = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtvbquantity = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtvbookname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtvbprice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 132);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, -24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(790, 284);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Name";
            // 
            // txtsearchabook
            // 
            this.txtsearchabook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchabook.Location = new System.Drawing.Point(286, 154);
            this.txtsearchabook.Margin = new System.Windows.Forms.Padding(2);
            this.txtsearchabook.Name = "txtsearchabook";
            this.txtsearchabook.Size = new System.Drawing.Size(240, 30);
            this.txtsearchabook.TabIndex = 3;
            this.txtsearchabook.TextChanged += new System.EventHandler(this.txtsearchabook_TextChanged);
            // 
            // btnrefresh
            // 
            this.btnrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Location = new System.Drawing.Point(544, 144);
            this.btnrefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(108, 54);
            this.btnrefresh.TabIndex = 4;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.btncancel);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.b);
            this.panel2.Controls.Add(this.txtpdate);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.txtvbpublication);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.txtvbauthorname);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txtvbquantity);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtvbookname);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtvbprice);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(9, 494);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(790, 353);
            this.panel2.TabIndex = 5;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(509, 267);
            this.btncancel.Margin = new System.Windows.Forms.Padding(2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(110, 41);
            this.btncancel.TabIndex = 27;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(365, 267);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 41);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(219, 267);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(110, 41);
            this.btnupdate.TabIndex = 25;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(417, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 22);
            this.label8.TabIndex = 24;
            this.label8.Text = "Book Quantity";
            this.label8.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Book Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Book Purchased Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Book Publication";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Book Author Name";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(10, 45);
            this.b.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(103, 22);
            this.b.TabIndex = 19;
            this.b.Text = "Book Name";
            // 
            // txtpdate
            // 
            this.txtpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpdate.Location = new System.Drawing.Point(610, 46);
            this.txtpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtpdate.Name = "txtpdate";
            this.txtpdate.Size = new System.Drawing.Size(180, 20);
            this.txtpdate.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(160, 226);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 1);
            this.panel7.TabIndex = 17;
            // 
            // txtvbpublication
            // 
            this.txtvbpublication.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtvbpublication.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvbpublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvbpublication.Location = new System.Drawing.Point(163, 202);
            this.txtvbpublication.Margin = new System.Windows.Forms.Padding(2);
            this.txtvbpublication.Name = "txtvbpublication";
            this.txtvbpublication.Size = new System.Drawing.Size(250, 25);
            this.txtvbpublication.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(171, 141);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 1);
            this.panel6.TabIndex = 15;
            // 
            // txtvbauthorname
            // 
            this.txtvbauthorname.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtvbauthorname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvbauthorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvbauthorname.Location = new System.Drawing.Point(174, 116);
            this.txtvbauthorname.Margin = new System.Windows.Forms.Padding(2);
            this.txtvbauthorname.Name = "txtvbauthorname";
            this.txtvbauthorname.Size = new System.Drawing.Size(250, 25);
            this.txtvbauthorname.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(542, 223);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 1);
            this.panel5.TabIndex = 13;
            // 
            // txtvbquantity
            // 
            this.txtvbquantity.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtvbquantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvbquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvbquantity.Location = new System.Drawing.Point(544, 199);
            this.txtvbquantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtvbquantity.Name = "txtvbquantity";
            this.txtvbquantity.Size = new System.Drawing.Size(242, 25);
            this.txtvbquantity.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(160, 69);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 1);
            this.panel4.TabIndex = 11;
            // 
            // txtvbookname
            // 
            this.txtvbookname.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtvbookname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvbookname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvbookname.Location = new System.Drawing.Point(163, 45);
            this.txtvbookname.Margin = new System.Windows.Forms.Padding(2);
            this.txtvbookname.Name = "txtvbookname";
            this.txtvbookname.Size = new System.Drawing.Size(250, 25);
            this.txtvbookname.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(532, 141);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 1);
            this.panel3.TabIndex = 9;
            // 
            // txtvbprice
            // 
            this.txtvbprice.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtvbprice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtvbprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvbprice.Location = new System.Drawing.Point(535, 117);
            this.txtvbprice.Margin = new System.Windows.Forms.Padding(2);
            this.txtvbprice.Name = "txtvbprice";
            this.txtvbprice.Size = new System.Drawing.Size(242, 25);
            this.txtvbprice.TabIndex = 8;
            // 
            // viewabook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(819, 494);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.txtsearchabook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "viewabook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewabook";
            this.Load += new System.EventHandler(this.viewabook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearchabook;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.DateTimePicker txtpdate;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtvbpublication;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtvbauthorname;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtvbquantity;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtvbookname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtvbprice;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
    }
}