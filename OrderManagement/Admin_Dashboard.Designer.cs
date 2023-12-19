namespace OrderManagement
{
    partial class Admin_Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catergoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblloginuser = new System.Windows.Forms.Label();
            this.pblogout = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Turquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.catergoryToolStripMenuItem,
            this.prodcutToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // catergoryToolStripMenuItem
            // 
            this.catergoryToolStripMenuItem.Name = "catergoryToolStripMenuItem";
            this.catergoryToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
            this.catergoryToolStripMenuItem.Text = "Category";
            this.catergoryToolStripMenuItem.Click += new System.EventHandler(this.catergoryToolStripMenuItem_Click);
            // 
            // prodcutToolStripMenuItem
            // 
            this.prodcutToolStripMenuItem.Name = "prodcutToolStripMenuItem";
            this.prodcutToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.prodcutToolStripMenuItem.Text = "Product";
            this.prodcutToolStripMenuItem.Click += new System.EventHandler(this.prodcutToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(575, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adminstrator:";
            // 
            // lblloginuser
            // 
            this.lblloginuser.AutoSize = true;
            this.lblloginuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginuser.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblloginuser.Location = new System.Drawing.Point(692, 422);
            this.lblloginuser.Name = "lblloginuser";
            this.lblloginuser.Size = new System.Drawing.Size(0, 19);
            this.lblloginuser.TabIndex = 6;
            // 
            // pblogout
            // 
            this.pblogout.BackColor = System.Drawing.Color.OrangeRed;
            this.pblogout.Image = global::OrderManagement.Properties.Resources.png_transparent_computer_icons_error_computer_text_trademark_computer_thumbnail2;
            this.pblogout.Location = new System.Drawing.Point(769, 1);
            this.pblogout.Name = "pblogout";
            this.pblogout.Size = new System.Drawing.Size(26, 28);
            this.pblogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogout.TabIndex = 4;
            this.pblogout.TabStop = false;
            this.pblogout.Click += new System.EventHandler(this.pblogout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OrderManagement.Properties.Resources.giphy;
            this.pictureBox2.Location = new System.Drawing.Point(265, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(264, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OrderManagement.Properties.Resources.pngtree_fast_food_logo_png_image_5763171;
            this.pictureBox1.Location = new System.Drawing.Point(286, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // Admin_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblloginuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pblogout);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_Dashboard";
            this.Text = "                                                                                 " +
    "                       ADMIN DASHBOARD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catergoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pblogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblloginuser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
    }
}