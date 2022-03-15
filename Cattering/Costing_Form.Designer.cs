
namespace Cattering
{
    partial class Costing_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Costing_Form));
            this.costingorderid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ordercostinggrid = new System.Windows.Forms.DataGridView();
            this.ordercostgrid = new System.Windows.Forms.DataGridView();
            this.costorderitem = new System.Windows.Forms.TextBox();
            this.costitemcost = new System.Windows.Forms.TextBox();
            this.costitemrates = new System.Windows.Forms.TextBox();
            this.costitemamount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ordercostingdorderitem = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.TCost = new System.Windows.Forms.Label();
            this.costprint = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ordercostinggrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordercostgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // costingorderid
            // 
            this.costingorderid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costingorderid.Location = new System.Drawing.Point(95, 24);
            this.costingorderid.Name = "costingorderid";
            this.costingorderid.ReadOnly = true;
            this.costingorderid.Size = new System.Drawing.Size(172, 22);
            this.costingorderid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order No :";
            // 
            // ordercostinggrid
            // 
            this.ordercostinggrid.AllowUserToAddRows = false;
            this.ordercostinggrid.AllowUserToDeleteRows = false;
            this.ordercostinggrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordercostinggrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordercostinggrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ordercostinggrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordercostinggrid.Location = new System.Drawing.Point(12, 67);
            this.ordercostinggrid.Name = "ordercostinggrid";
            this.ordercostinggrid.ReadOnly = true;
            this.ordercostinggrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordercostinggrid.Size = new System.Drawing.Size(1102, 145);
            this.ordercostinggrid.TabIndex = 2;
            this.ordercostinggrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordercostinggrid_CellClick);
            // 
            // ordercostgrid
            // 
            this.ordercostgrid.AllowUserToAddRows = false;
            this.ordercostgrid.AllowUserToDeleteRows = false;
            this.ordercostgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordercostgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordercostgrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.ordercostgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordercostgrid.Location = new System.Drawing.Point(12, 306);
            this.ordercostgrid.Name = "ordercostgrid";
            this.ordercostgrid.ReadOnly = true;
            this.ordercostgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordercostgrid.Size = new System.Drawing.Size(877, 150);
            this.ordercostgrid.TabIndex = 3;
            // 
            // costorderitem
            // 
            this.costorderitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costorderitem.Location = new System.Drawing.Point(12, 270);
            this.costorderitem.Name = "costorderitem";
            this.costorderitem.Size = new System.Drawing.Size(349, 22);
            this.costorderitem.TabIndex = 4;
            // 
            // costitemcost
            // 
            this.costitemcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costitemcost.Location = new System.Drawing.Point(367, 270);
            this.costitemcost.Name = "costitemcost";
            this.costitemcost.Size = new System.Drawing.Size(143, 22);
            this.costitemcost.TabIndex = 5;
            this.costitemcost.TextChanged += new System.EventHandler(this.costitemcost_TextChanged);
            // 
            // costitemrates
            // 
            this.costitemrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costitemrates.Location = new System.Drawing.Point(516, 270);
            this.costitemrates.Name = "costitemrates";
            this.costitemrates.Size = new System.Drawing.Size(143, 22);
            this.costitemrates.TabIndex = 6;
            this.costitemrates.TextChanged += new System.EventHandler(this.costitemrates_TextChanged);
            // 
            // costitemamount
            // 
            this.costitemamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costitemamount.Location = new System.Drawing.Point(665, 270);
            this.costitemamount.Name = "costitemamount";
            this.costitemamount.Size = new System.Drawing.Size(143, 22);
            this.costitemamount.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Used in Order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Rates";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(665, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Costing for :";
            // 
            // ordercostingdorderitem
            // 
            this.ordercostingdorderitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordercostingdorderitem.Location = new System.Drawing.Point(95, 223);
            this.ordercostingdorderitem.Name = "ordercostingdorderitem";
            this.ordercostingdorderitem.ReadOnly = true;
            this.ordercostingdorderitem.Size = new System.Drawing.Size(266, 22);
            this.ordercostingdorderitem.TabIndex = 9;
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(814, 269);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 10;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // TCost
            // 
            this.TCost.AutoSize = true;
            this.TCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCost.Location = new System.Drawing.Point(273, 26);
            this.TCost.Name = "TCost";
            this.TCost.Size = new System.Drawing.Size(91, 20);
            this.TCost.TabIndex = 11;
            this.TCost.Text = "Total Cost";
            // 
            // costprint
            // 
            this.costprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costprint.Location = new System.Drawing.Point(895, 306);
            this.costprint.Name = "costprint";
            this.costprint.Size = new System.Drawing.Size(120, 61);
            this.costprint.TabIndex = 12;
            this.costprint.Text = "Print Cost Sheet";
            this.costprint.UseVisualStyleBackColor = true;
            this.costprint.Click += new System.EventHandler(this.costprint_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cattering.Properties.Resources.WhatsApp_Image_2022_03_05_at_4_32_07_PM;
            this.pictureBox1.Location = new System.Drawing.Point(547, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Costing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1118, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.costprint);
            this.Controls.Add(this.TCost);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.ordercostingdorderitem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costitemamount);
            this.Controls.Add(this.costitemrates);
            this.Controls.Add(this.costitemcost);
            this.Controls.Add(this.costorderitem);
            this.Controls.Add(this.ordercostgrid);
            this.Controls.Add(this.ordercostinggrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costingorderid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Costing_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costing_Form";
            this.Load += new System.EventHandler(this.Costing_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordercostinggrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordercostgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox costingorderid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ordercostinggrid;
        private System.Windows.Forms.DataGridView ordercostgrid;
        private System.Windows.Forms.TextBox costorderitem;
        private System.Windows.Forms.TextBox costitemcost;
        private System.Windows.Forms.TextBox costitemrates;
        private System.Windows.Forms.TextBox costitemamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ordercostingdorderitem;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label TCost;
        private System.Windows.Forms.Button costprint;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}