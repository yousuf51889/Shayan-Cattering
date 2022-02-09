
namespace Cattering
{
    partial class Customer_Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Balance));
            this.Ordertxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxdiscount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtadvancebox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cusname = new System.Windows.Forms.Label();
            this.cusadd = new System.Windows.Forms.Label();
            this.cusnum = new System.Windows.Forms.Label();
            this.invvalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.totalbalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updbalance = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.balanceinvgrid = new System.Windows.Forms.DataGridView();
            this.payrecdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpaymode = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpaystatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.balanceinvgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Ordertxtbox
            // 
            this.Ordertxtbox.Location = new System.Drawing.Point(87, 10);
            this.Ordertxtbox.Name = "Ordertxtbox";
            this.Ordertxtbox.ReadOnly = true;
            this.Ordertxtbox.Size = new System.Drawing.Size(154, 20);
            this.Ordertxtbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order No :";
            // 
            // txtboxdiscount
            // 
            this.txtboxdiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxdiscount.Location = new System.Drawing.Point(13, 227);
            this.txtboxdiscount.Name = "txtboxdiscount";
            this.txtboxdiscount.Size = new System.Drawing.Size(114, 26);
            this.txtboxdiscount.TabIndex = 28;
            this.txtboxdiscount.Text = "0";
            this.txtboxdiscount.TextChanged += new System.EventHandler(this.txtboxdiscount_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Discount";
            // 
            // txtadvancebox
            // 
            this.txtadvancebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvancebox.Location = new System.Drawing.Point(14, 179);
            this.txtadvancebox.Name = "txtadvancebox";
            this.txtadvancebox.Size = new System.Drawing.Size(113, 26);
            this.txtadvancebox.TabIndex = 26;
            this.txtadvancebox.Text = "0";
            this.txtadvancebox.TextChanged += new System.EventHandler(this.txtadvancebox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Paid";
            // 
            // cusname
            // 
            this.cusname.AutoSize = true;
            this.cusname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusname.Location = new System.Drawing.Point(247, 35);
            this.cusname.Name = "cusname";
            this.cusname.Size = new System.Drawing.Size(105, 16);
            this.cusname.TabIndex = 29;
            this.cusname.Text = "Customer Name";
            // 
            // cusadd
            // 
            this.cusadd.AutoSize = true;
            this.cusadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusadd.Location = new System.Drawing.Point(247, 60);
            this.cusadd.Name = "cusadd";
            this.cusadd.Size = new System.Drawing.Size(119, 16);
            this.cusadd.TabIndex = 30;
            this.cusadd.Text = "Customer Address";
            // 
            // cusnum
            // 
            this.cusnum.AutoSize = true;
            this.cusnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusnum.Location = new System.Drawing.Point(247, 9);
            this.cusnum.Name = "cusnum";
            this.cusnum.Size = new System.Drawing.Size(107, 16);
            this.cusnum.TabIndex = 31;
            this.cusnum.Text = "Customer Phone";
            // 
            // invvalue
            // 
            this.invvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invvalue.Location = new System.Drawing.Point(13, 84);
            this.invvalue.Name = "invvalue";
            this.invvalue.ReadOnly = true;
            this.invvalue.Size = new System.Drawing.Size(114, 26);
            this.invvalue.TabIndex = 32;
            this.invvalue.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Invoice Value";
            // 
            // totalbalance
            // 
            this.totalbalance.AutoSize = true;
            this.totalbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbalance.Location = new System.Drawing.Point(684, 35);
            this.totalbalance.Name = "totalbalance";
            this.totalbalance.Size = new System.Drawing.Size(174, 16);
            this.totalbalance.TabIndex = 34;
            this.totalbalance.Text = "Customer Total Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Total Balance";
            // 
            // updbalance
            // 
            this.updbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updbalance.Location = new System.Drawing.Point(740, 332);
            this.updbalance.Name = "updbalance";
            this.updbalance.Size = new System.Drawing.Size(115, 27);
            this.updbalance.TabIndex = 36;
            this.updbalance.Text = "Update Balance";
            this.updbalance.UseVisualStyleBackColor = true;
            this.updbalance.Click += new System.EventHandler(this.updbalance_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Balance";
            // 
            // balance
            // 
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(13, 132);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(114, 26);
            this.balance.TabIndex = 37;
            this.balance.Text = "0";
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(591, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(78, 30);
            this.Refresh.TabIndex = 39;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // balanceinvgrid
            // 
            this.balanceinvgrid.AllowUserToAddRows = false;
            this.balanceinvgrid.AllowUserToDeleteRows = false;
            this.balanceinvgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.balanceinvgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.balanceinvgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceinvgrid.Location = new System.Drawing.Point(133, 84);
            this.balanceinvgrid.Name = "balanceinvgrid";
            this.balanceinvgrid.ReadOnly = true;
            this.balanceinvgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.balanceinvgrid.Size = new System.Drawing.Size(725, 241);
            this.balanceinvgrid.TabIndex = 40;
            // 
            // payrecdate
            // 
            this.payrecdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.payrecdate.Location = new System.Drawing.Point(87, 36);
            this.payrecdate.Name = "payrecdate";
            this.payrecdate.Size = new System.Drawing.Size(154, 20);
            this.payrecdate.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "Pay Mode";
            // 
            // txtpaymode
            // 
            this.txtpaymode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaymode.FormattingEnabled = true;
            this.txtpaymode.Items.AddRange(new object[] {
            "",
            "Cash",
            "Online in Bank",
            "Cheque"});
            this.txtpaymode.Location = new System.Drawing.Point(16, 276);
            this.txtpaymode.Name = "txtpaymode";
            this.txtpaymode.Size = new System.Drawing.Size(111, 28);
            this.txtpaymode.TabIndex = 43;
            this.txtpaymode.SelectedIndexChanged += new System.EventHandler(this.txtpaymode_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 44;
            this.label7.Text = "Submit Status";
            // 
            // txtpaystatus
            // 
            this.txtpaystatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaystatus.FormattingEnabled = true;
            this.txtpaystatus.Location = new System.Drawing.Point(17, 331);
            this.txtpaystatus.Name = "txtpaystatus";
            this.txtpaystatus.Size = new System.Drawing.Size(414, 28);
            this.txtpaystatus.TabIndex = 45;
            // 
            // Customer_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 371);
            this.Controls.Add(this.txtpaystatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpaymode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.payrecdate);
            this.Controls.Add(this.balanceinvgrid);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.updbalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalbalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invvalue);
            this.Controls.Add(this.cusnum);
            this.Controls.Add(this.cusadd);
            this.Controls.Add(this.cusname);
            this.Controls.Add(this.txtboxdiscount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtadvancebox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ordertxtbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer_Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Balance";
            this.Load += new System.EventHandler(this.Customer_Balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balanceinvgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ordertxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxdiscount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtadvancebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cusname;
        private System.Windows.Forms.Label cusadd;
        private System.Windows.Forms.Label cusnum;
        private System.Windows.Forms.TextBox invvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalbalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button updbalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.DataGridView balanceinvgrid;
        private System.Windows.Forms.DateTimePicker payrecdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtpaymode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtpaystatus;
    }
}