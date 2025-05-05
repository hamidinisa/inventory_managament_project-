namespace inventory_managament_project
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_customers = new System.Windows.Forms.Button();
            this.button_addproduct = new System.Windows.Forms.Button();
            this.button_addcatogaries = new System.Windows.Forms.Button();
            this.button_addusers = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.button_customers);
            this.panel1.Controls.Add(this.button_addproduct);
            this.panel1.Controls.Add(this.button_addcatogaries);
            this.panel1.Controls.Add(this.button_addusers);
            this.panel1.Controls.Add(this.button_dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 450);
            this.panel1.TabIndex = 0;
            // 
            // button_customers
            // 
            this.button_customers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_customers.Location = new System.Drawing.Point(0, 356);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(200, 47);
            this.button_customers.TabIndex = 4;
            this.button_customers.Text = "Customers";
            this.button_customers.UseVisualStyleBackColor = false;
            // 
            // button_addproduct
            // 
            this.button_addproduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_addproduct.Location = new System.Drawing.Point(0, 304);
            this.button_addproduct.Name = "button_addproduct";
            this.button_addproduct.Size = new System.Drawing.Size(200, 55);
            this.button_addproduct.TabIndex = 3;
            this.button_addproduct.Text = "Add Products";
            this.button_addproduct.UseVisualStyleBackColor = false;
            // 
            // button_addcatogaries
            // 
            this.button_addcatogaries.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_addcatogaries.Location = new System.Drawing.Point(0, 245);
            this.button_addcatogaries.Name = "button_addcatogaries";
            this.button_addcatogaries.Size = new System.Drawing.Size(200, 61);
            this.button_addcatogaries.TabIndex = 2;
            this.button_addcatogaries.Text = "Add Catogories";
            this.button_addcatogaries.UseVisualStyleBackColor = false;
            // 
            // button_addusers
            // 
            this.button_addusers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_addusers.Location = new System.Drawing.Point(0, 191);
            this.button_addusers.Name = "button_addusers";
            this.button_addusers.Size = new System.Drawing.Size(200, 57);
            this.button_addusers.TabIndex = 1;
            this.button_addusers.Text = "Add Users";
            this.button_addusers.UseVisualStyleBackColor = false;
            this.button_addusers.Click += new System.EventHandler(this.button_addusers_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_dashboard.Location = new System.Drawing.Point(0, 139);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(200, 56);
            this.button_dashboard.TabIndex = 0;
            this.button_dashboard.Text = "Dasboard";
            this.button_dashboard.UseVisualStyleBackColor = false;
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(194, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(606, 450);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.IndianRed;
            this.button_logout.Location = new System.Drawing.Point(0, 415);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(200, 23);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory_managament_project.Properties.Resources.imagesuserprofile__1_;
            this.pictureBox1.Location = new System.Drawing.Point(42, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "admins form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.Button button_addproduct;
        private System.Windows.Forms.Button button_addcatogaries;
        private System.Windows.Forms.Button button_addusers;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label1;
    }
}