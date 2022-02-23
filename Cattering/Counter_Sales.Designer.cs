
namespace Cattering
{
    partial class Counter_Sales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Counter_Sales));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dish_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.digh_ratesPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dish_ratespkg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item = new System.Windows.Forms.TextBox();
            this.rates = new System.Windows.Forms.TextBox();
            this.unittype = new System.Windows.Forms.ComboBox();
            this.qty = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gtotal1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GST = new System.Windows.Forms.TextBox();
            this.Discount = new System.Windows.Forms.TextBox();
            this.Grand_Total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cashrec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chnageam = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.delitem = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.insertorder = new System.Windows.Forms.Button();
            this.Token_no = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.ch2 = new System.Windows.Forms.CheckBox();
            this.ch3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cattering.Properties.Resources.SC_Logo_SW;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Counter Sales Form - SHAYAN CATTERERS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dish_name,
            this.digh_ratesPP,
            this.dish_ratespkg});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(157, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(913, 344);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dish_name
            // 
            this.dish_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dish_name.DataPropertyName = "dish_name";
            this.dish_name.FillWeight = 236.8069F;
            this.dish_name.HeaderText = "Item_Name";
            this.dish_name.Name = "dish_name";
            this.dish_name.ReadOnly = true;
            // 
            // digh_ratesPP
            // 
            this.digh_ratesPP.DataPropertyName = "digh_ratesPP";
            this.digh_ratesPP.FillWeight = 32.73622F;
            this.digh_ratesPP.HeaderText = "PP";
            this.digh_ratesPP.Name = "digh_ratesPP";
            this.digh_ratesPP.ReadOnly = true;
            // 
            // dish_ratespkg
            // 
            this.dish_ratespkg.DataPropertyName = "dish_ratespkg";
            this.dish_ratespkg.FillWeight = 30.45685F;
            this.dish_ratespkg.HeaderText = "P_Kg";
            this.dish_ratespkg.Name = "dish_ratespkg";
            this.dish_ratespkg.ReadOnly = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(387, 453);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 399);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item_Name";
            this.columnHeader1.Width = 425;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rates";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qty";
            this.columnHeader3.Width = 40;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 70;
            // 
            // item
            // 
            this.item.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item.Location = new System.Drawing.Point(157, 420);
            this.item.Name = "item";
            this.item.ReadOnly = true;
            this.item.Size = new System.Drawing.Size(464, 27);
            this.item.TabIndex = 6;
            // 
            // rates
            // 
            this.rates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rates.Location = new System.Drawing.Point(627, 420);
            this.rates.Name = "rates";
            this.rates.ReadOnly = true;
            this.rates.Size = new System.Drawing.Size(68, 27);
            this.rates.TabIndex = 7;
            this.rates.TextChanged += new System.EventHandler(this.rates_TextChanged);
            // 
            // unittype
            // 
            this.unittype.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unittype.FormattingEnabled = true;
            this.unittype.Items.AddRange(new object[] {
            "Per Person",
            "Per KG"});
            this.unittype.Location = new System.Drawing.Point(951, 3);
            this.unittype.Name = "unittype";
            this.unittype.Size = new System.Drawing.Size(120, 27);
            this.unittype.TabIndex = 1;
            // 
            // qty
            // 
            this.qty.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Location = new System.Drawing.Point(739, 420);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(45, 27);
            this.qty.TabIndex = 9;
            this.qty.Text = "0";
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            this.qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.qty_KeyPress);
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(828, 420);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(73, 27);
            this.total.TabIndex = 11;
            this.total.Text = "0";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnplus
            // 
            this.btnplus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(787, 414);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(39, 37);
            this.btnplus.TabIndex = 10;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnminus
            // 
            this.btnminus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.Location = new System.Drawing.Point(697, 414);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(39, 37);
            this.btnminus.TabIndex = 8;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = true;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(907, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gtotal1
            // 
            this.gtotal1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtotal1.Location = new System.Drawing.Point(307, 453);
            this.gtotal1.Name = "gtotal1";
            this.gtotal1.ReadOnly = true;
            this.gtotal1.Size = new System.Drawing.Size(74, 26);
            this.gtotal1.TabIndex = 14;
            this.gtotal1.Text = "0";
            this.gtotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gtotal1.TextChanged += new System.EventHandler(this.gtotal1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total (Exc. GST) = ";
            // 
            // GST
            // 
            this.GST.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GST.Location = new System.Drawing.Point(307, 480);
            this.GST.Name = "GST";
            this.GST.ReadOnly = true;
            this.GST.Size = new System.Drawing.Size(74, 26);
            this.GST.TabIndex = 15;
            this.GST.Text = "0";
            this.GST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Discount
            // 
            this.Discount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(307, 507);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(74, 26);
            this.Discount.TabIndex = 16;
            this.Discount.Text = "0";
            this.Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Discount.TextChanged += new System.EventHandler(this.Discount_TextChanged);
            this.Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Discount_KeyPress);
            // 
            // Grand_Total
            // 
            this.Grand_Total.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grand_Total.Location = new System.Drawing.Point(307, 535);
            this.Grand_Total.Name = "Grand_Total";
            this.Grand_Total.ReadOnly = true;
            this.Grand_Total.Size = new System.Drawing.Size(74, 26);
            this.Grand_Total.TabIndex = 17;
            this.Grand_Total.Text = "0";
            this.Grand_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "G.S.T Tax = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 511);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Discount = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Grand Total Amount = ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(307, 562);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(74, 26);
            this.textBox1.TabIndex = 52;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cashrec
            // 
            this.cashrec.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashrec.Location = new System.Drawing.Point(307, 562);
            this.cashrec.Name = "cashrec";
            this.cashrec.Size = new System.Drawing.Size(74, 26);
            this.cashrec.TabIndex = 18;
            this.cashrec.Text = "0";
            this.cashrec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cashrec.TextChanged += new System.EventHandler(this.cashrec_TextChanged);
            this.cashrec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cashrec_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 539);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Grand Total Amount = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 566);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cash Received = ";
            // 
            // chnageam
            // 
            this.chnageam.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chnageam.Location = new System.Drawing.Point(307, 589);
            this.chnageam.Name = "chnageam";
            this.chnageam.ReadOnly = true;
            this.chnageam.Size = new System.Drawing.Size(74, 26);
            this.chnageam.TabIndex = 19;
            this.chnageam.Text = "0";
            this.chnageam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 592);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Change Amount = ";
            // 
            // delitem
            // 
            this.delitem.Location = new System.Drawing.Point(986, 420);
            this.delitem.Name = "delitem";
            this.delitem.Size = new System.Drawing.Size(80, 28);
            this.delitem.TabIndex = 13;
            this.delitem.Text = "Del_Item";
            this.delitem.UseVisualStyleBackColor = true;
            this.delitem.Click += new System.EventHandler(this.delitem_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnreset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnreset.Location = new System.Drawing.Point(870, 4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 26);
            this.btnreset.TabIndex = 0;
            this.btnreset.Text = "New Sales";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // insertorder
            // 
            this.insertorder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.insertorder.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertorder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.insertorder.Location = new System.Drawing.Point(993, 452);
            this.insertorder.Name = "insertorder";
            this.insertorder.Size = new System.Drawing.Size(75, 61);
            this.insertorder.TabIndex = 20;
            this.insertorder.Text = "Insert Order";
            this.insertorder.UseVisualStyleBackColor = false;
            this.insertorder.Click += new System.EventHandler(this.insertorder_Click);
            // 
            // Token_no
            // 
            this.Token_no.AutoSize = true;
            this.Token_no.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Token_no.Location = new System.Drawing.Point(137, 32);
            this.Token_no.Name = "Token_no";
            this.Token_no.Size = new System.Drawing.Size(0, 29);
            this.Token_no.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(5, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add New Dish";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 29);
            this.label9.TabIndex = 31;
            this.label9.Text = "Catagories";
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch1.Location = new System.Drawing.Point(8, 145);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(96, 27);
            this.ch1.TabIndex = 3;
            this.ch1.Text = "All Items";
            this.ch1.UseVisualStyleBackColor = true;
            this.ch1.Click += new System.EventHandler(this.ch1_Click);
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch2.Location = new System.Drawing.Point(8, 178);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(103, 27);
            this.ch2.TabIndex = 4;
            this.ch2.Text = "Fast Food";
            this.ch2.UseVisualStyleBackColor = true;
            this.ch2.Click += new System.EventHandler(this.ch2_Click);
            // 
            // ch3
            // 
            this.ch3.AutoSize = true;
            this.ch3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch3.Location = new System.Drawing.Point(9, 210);
            this.ch3.Name = "ch3";
            this.ch3.Size = new System.Drawing.Size(139, 27);
            this.ch3.TabIndex = 5;
            this.ch3.Text = "Biryani / Palao";
            this.ch3.UseVisualStyleBackColor = true;
            this.ch3.Click += new System.EventHandler(this.ch3_Click);
            // 
            // Counter_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 928);
            this.Controls.Add(this.ch3);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Token_no);
            this.Controls.Add(this.insertorder);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.delitem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chnageam);
            this.Controls.Add(this.cashrec);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Grand_Total);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.GST);
            this.Controls.Add(this.gtotal1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.total);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.unittype);
            this.Controls.Add(this.rates);
            this.Controls.Add(this.item);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Counter_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter Sale - POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Counter_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox item;
        private System.Windows.Forms.TextBox rates;
        private System.Windows.Forms.ComboBox unittype;
        private System.Windows.Forms.TextBox qty;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dish_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn digh_ratesPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dish_ratespkg;
        private System.Windows.Forms.TextBox gtotal1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GST;
        private System.Windows.Forms.TextBox Discount;
        private System.Windows.Forms.TextBox Grand_Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cashrec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox chnageam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button delitem;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button insertorder;
        private System.Windows.Forms.Label Token_no;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.CheckBox ch2;
        private System.Windows.Forms.CheckBox ch3;
    }
}