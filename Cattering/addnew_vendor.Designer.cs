
namespace Cattering
{
    partial class addnew_vendor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addnew_vendor));
            this.label15 = new System.Windows.Forms.Label();
            this.addvendor = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addmobnum = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addnewvendorbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addvendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(12, -4);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 18);
            this.label15.TabIndex = 88;
            this.label15.Text = "Add New Vendor";
            // 
            // addvendor
            // 
            this.addvendor.Controls.Add(this.textBox1);
            this.addvendor.Controls.Add(this.addmobnum);
            this.addvendor.Controls.Add(this.textBox2);
            this.addvendor.Controls.Add(this.label15);
            this.addvendor.Controls.Add(this.addnewvendorbutton);
            this.addvendor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addvendor.Location = new System.Drawing.Point(6, 6);
            this.addvendor.Name = "addvendor";
            this.addvendor.Size = new System.Drawing.Size(578, 51);
            this.addvendor.TabIndex = 112;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 23);
            this.textBox1.TabIndex = 87;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addmobnum
            // 
            this.addmobnum.Location = new System.Drawing.Point(473, 20);
            this.addmobnum.Name = "addmobnum";
            this.addmobnum.Size = new System.Drawing.Size(98, 23);
            this.addmobnum.TabIndex = 108;
            this.addmobnum.Text = "Update Details";
            this.addmobnum.UseVisualStyleBackColor = true;
            this.addmobnum.Click += new System.EventHandler(this.addmobnum_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(286, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 23);
            this.textBox2.TabIndex = 107;
            this.textBox2.Text = "0";
            // 
            // addnewvendorbutton
            // 
            this.addnewvendorbutton.Location = new System.Drawing.Point(384, 20);
            this.addnewvendorbutton.Name = "addnewvendorbutton";
            this.addnewvendorbutton.Size = new System.Drawing.Size(84, 23);
            this.addnewvendorbutton.TabIndex = 89;
            this.addnewvendorbutton.Text = "Add Vendor";
            this.addnewvendorbutton.UseVisualStyleBackColor = true;
            this.addnewvendorbutton.Click += new System.EventHandler(this.addnewvendorbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(578, 183);
            this.dataGridView1.TabIndex = 113;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // addnew_vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(593, 253);
            this.Controls.Add(this.addvendor);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addnew_vendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addnew_vendor";
            this.addvendor.ResumeLayout(false);
            this.addvendor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel addvendor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addmobnum;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addnewvendorbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}