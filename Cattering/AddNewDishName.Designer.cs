
namespace Cattering
{
    partial class AddNewDishName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewDishName));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dishname = new System.Windows.Forms.TextBox();
            this.perkgrates = new System.Windows.Forms.TextBox();
            this.perpersonrates = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dishnamesgrid = new System.Windows.Forms.DataGridView();
            this.editdishnamebtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfoodcat = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dishnamesgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Dish Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dish Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Per KG Rates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Per Person Rates";
            // 
            // dishname
            // 
            this.dishname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dishname.Location = new System.Drawing.Point(12, 82);
            this.dishname.Name = "dishname";
            this.dishname.Size = new System.Drawing.Size(449, 26);
            this.dishname.TabIndex = 2;
            this.dishname.TextChanged += new System.EventHandler(this.dishname_TextChanged);
            // 
            // perkgrates
            // 
            this.perkgrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perkgrates.Location = new System.Drawing.Point(12, 137);
            this.perkgrates.Name = "perkgrates";
            this.perkgrates.Size = new System.Drawing.Size(104, 26);
            this.perkgrates.TabIndex = 2;
            // 
            // perpersonrates
            // 
            this.perpersonrates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perpersonrates.Location = new System.Drawing.Point(136, 137);
            this.perpersonrates.Name = "perpersonrates";
            this.perpersonrates.Size = new System.Drawing.Size(136, 26);
            this.perpersonrates.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(556, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dishnamesgrid
            // 
            this.dishnamesgrid.AllowUserToAddRows = false;
            this.dishnamesgrid.AllowUserToDeleteRows = false;
            this.dishnamesgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dishnamesgrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dishnamesgrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dishnamesgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishnamesgrid.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dishnamesgrid.Location = new System.Drawing.Point(0, 234);
            this.dishnamesgrid.Name = "dishnamesgrid";
            this.dishnamesgrid.ReadOnly = true;
            this.dishnamesgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dishnamesgrid.Size = new System.Drawing.Size(677, 335);
            this.dishnamesgrid.TabIndex = 4;
            this.dishnamesgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dishnamesgrid_CellClick);
            this.dishnamesgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dishnamesgrid_CellContentClick);
            // 
            // editdishnamebtn
            // 
            this.editdishnamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editdishnamebtn.Location = new System.Drawing.Point(556, 152);
            this.editdishnamebtn.Name = "editdishnamebtn";
            this.editdishnamebtn.Size = new System.Drawing.Size(109, 36);
            this.editdishnamebtn.TabIndex = 5;
            this.editdishnamebtn.Text = "Edit";
            this.editdishnamebtn.UseVisualStyleBackColor = true;
            this.editdishnamebtn.Click += new System.EventHandler(this.editdishnamebtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.Location = new System.Drawing.Point(556, 44);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(109, 35);
            this.resetbtn.TabIndex = 6;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cattering.Properties.Resources.SC_Logo_SW;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Catagory (List)";
            // 
            // txtfoodcat
            // 
            this.txtfoodcat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfoodcat.FormattingEnabled = true;
            this.txtfoodcat.Items.AddRange(new object[] {
            "Fast Food / Burgers - Sandwitches",
            "Bar B.Q / Rolls",
            "Biryani / Palao",
            "Drinks / Juices",
            "Roti / Bread",
            "Bakery Items",
            "Fried Items",
            "Curry Items",
            "Desert Items / Sweet Dishes",
            "Chineese Items"});
            this.txtfoodcat.Location = new System.Drawing.Point(139, 174);
            this.txtfoodcat.Name = "txtfoodcat";
            this.txtfoodcat.Size = new System.Drawing.Size(326, 27);
            this.txtfoodcat.TabIndex = 8;
            // 
            // AddNewDishName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(689, 573);
            this.Controls.Add(this.txtfoodcat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.editdishnamebtn);
            this.Controls.Add(this.dishnamesgrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.perpersonrates);
            this.Controls.Add(this.perkgrates);
            this.Controls.Add(this.dishname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNewDishName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add NewDish Name";
            this.Activated += new System.EventHandler(this.AddNewDishName_Activated);
            this.Load += new System.EventHandler(this.AddNewDishName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dishnamesgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dishname;
        private System.Windows.Forms.TextBox perkgrates;
        private System.Windows.Forms.TextBox perpersonrates;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dishnamesgrid;
        private System.Windows.Forms.Button editdishnamebtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtfoodcat;
    }
}