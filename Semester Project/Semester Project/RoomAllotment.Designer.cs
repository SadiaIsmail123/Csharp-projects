namespace Semester_Project
{
    partial class frmroomallotment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtallocid = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtdeptid = new System.Windows.Forms.TextBox();
            this.cbrollno = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbroomno = new System.Windows.Forms.ComboBox();
            this.dgv6 = new System.Windows.Forms.DataGridView();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "AllotID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alloc Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "RollNo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "RoomNo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dept Id";
            // 
            // txtallocid
            // 
            this.txtallocid.Location = new System.Drawing.Point(188, 49);
            this.txtallocid.Name = "txtallocid";
            this.txtallocid.Size = new System.Drawing.Size(199, 26);
            this.txtallocid.TabIndex = 10;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(206, 355);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(199, 26);
            this.txtaddress.TabIndex = 13;
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(206, 412);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(199, 26);
            this.txtcontact.TabIndex = 14;
            // 
            // txtdeptid
            // 
            this.txtdeptid.Location = new System.Drawing.Point(227, 290);
            this.txtdeptid.Name = "txtdeptid";
            this.txtdeptid.Size = new System.Drawing.Size(199, 26);
            this.txtdeptid.TabIndex = 16;
            // 
            // cbrollno
            // 
            this.cbrollno.FormattingEnabled = true;
            this.cbrollno.Location = new System.Drawing.Point(206, 163);
            this.cbrollno.Name = "cbrollno";
            this.cbrollno.Size = new System.Drawing.Size(219, 28);
            this.cbrollno.TabIndex = 19;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(605, 109);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(282, 45);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(605, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 45);
            this.button2.TabIndex = 21;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbroomno
            // 
            this.cbroomno.FormattingEnabled = true;
            this.cbroomno.Location = new System.Drawing.Point(202, 222);
            this.cbroomno.Name = "cbroomno";
            this.cbroomno.Size = new System.Drawing.Size(203, 28);
            this.cbroomno.TabIndex = 22;
            // 
            // dgv6
            // 
            this.dgv6.AllowUserToAddRows = false;
            this.dgv6.AllowUserToDeleteRows = false;
            this.dgv6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv6.Location = new System.Drawing.Point(28, 456);
            this.dgv6.Name = "dgv6";
            this.dgv6.ReadOnly = true;
            this.dgv6.RowHeadersWidth = 62;
            this.dgv6.RowTemplate.Height = 28;
            this.dgv6.Size = new System.Drawing.Size(1066, 155);
            this.dgv6.TabIndex = 23;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(205, 104);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(253, 26);
            this.dtp1.TabIndex = 24;
            // 
            // frmroomallotment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 650);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.dgv6);
            this.Controls.Add(this.cbroomno);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbrollno);
            this.Controls.Add(this.txtdeptid);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtallocid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmroomallotment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomAllotment";
            this.Load += new System.EventHandler(this.RoomAllotment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtallocid;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.TextBox txtdeptid;
        private System.Windows.Forms.ComboBox cbrollno;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbroomno;
        private System.Windows.Forms.DataGridView dgv6;
        private System.Windows.Forms.DateTimePicker dtp1;
    }
}