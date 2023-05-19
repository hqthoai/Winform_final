namespace MultiFaceRec
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_Shift = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Checkout = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Stored = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Room = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Bill = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Salary = new Guna.UI2.WinForms.Guna2Button();
            this.lb_LogOut = new System.Windows.Forms.Label();
            this.lb_Edit = new System.Windows.Forms.Label();
            this.lb_FnameLname = new System.Windows.Forms.Label();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Checkin = new Guna.UI2.WinForms.Guna2Button();
            this.bt_ManageShift = new System.Windows.Forms.Button();
            this.bt_HumanResource = new System.Windows.Forms.Button();
            this.button_Main = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CirclePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bt_ManageShift);
            this.panel1.Controls.Add(this.bt_HumanResource);
            this.panel1.Controls.Add(this.button_Main);
            this.panel1.Controls.Add(this.panel_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 643);
            this.panel1.TabIndex = 4;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.pictureBox1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(169, 98);
            this.panel_main.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.bt_Shift);
            this.panel2.Controls.Add(this.bt_Checkout);
            this.panel2.Controls.Add(this.bt_Stored);
            this.panel2.Controls.Add(this.bt_Room);
            this.panel2.Controls.Add(this.bt_Bill);
            this.panel2.Controls.Add(this.bt_Salary);
            this.panel2.Controls.Add(this.CirclePictureBox);
            this.panel2.Controls.Add(this.lb_LogOut);
            this.panel2.Controls.Add(this.lb_Edit);
            this.panel2.Controls.Add(this.lb_FnameLname);
            this.panel2.Controls.Add(this.lb_Welcome);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bt_Checkin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 643);
            this.panel2.TabIndex = 5;
            // 
            // bt_Shift
            // 
            this.bt_Shift.BorderRadius = 20;
            this.bt_Shift.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Shift.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Shift.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Shift.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Shift.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bt_Shift.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Shift.ForeColor = System.Drawing.Color.White;
            this.bt_Shift.Location = new System.Drawing.Point(798, 261);
            this.bt_Shift.Name = "bt_Shift";
            this.bt_Shift.Size = new System.Drawing.Size(191, 60);
            this.bt_Shift.TabIndex = 55;
            this.bt_Shift.Text = "Shift";
            this.bt_Shift.Click += new System.EventHandler(this.bt_Shift_Click);
            // 
            // bt_Checkout
            // 
            this.bt_Checkout.BorderRadius = 20;
            this.bt_Checkout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Checkout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Checkout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Checkout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Checkout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(128)))), ((int)(((byte)(250)))));
            this.bt_Checkout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Checkout.ForeColor = System.Drawing.Color.White;
            this.bt_Checkout.Location = new System.Drawing.Point(519, 261);
            this.bt_Checkout.Name = "bt_Checkout";
            this.bt_Checkout.Size = new System.Drawing.Size(191, 60);
            this.bt_Checkout.TabIndex = 54;
            this.bt_Checkout.Text = "Check Out";
            this.bt_Checkout.Click += new System.EventHandler(this.bt_Checkout_Click);
            // 
            // bt_Stored
            // 
            this.bt_Stored.BorderRadius = 20;
            this.bt_Stored.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Stored.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Stored.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Stored.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Stored.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(155)))), ((int)(((byte)(177)))));
            this.bt_Stored.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Stored.ForeColor = System.Drawing.Color.White;
            this.bt_Stored.Location = new System.Drawing.Point(767, 515);
            this.bt_Stored.Name = "bt_Stored";
            this.bt_Stored.Size = new System.Drawing.Size(191, 60);
            this.bt_Stored.TabIndex = 53;
            this.bt_Stored.Text = "STORED";
            this.bt_Stored.Click += new System.EventHandler(this.bt_Stored_Click);
            // 
            // bt_Room
            // 
            this.bt_Room.BorderRadius = 20;
            this.bt_Room.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Room.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Room.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Room.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Room.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(155)))), ((int)(((byte)(177)))));
            this.bt_Room.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Room.ForeColor = System.Drawing.Color.White;
            this.bt_Room.Location = new System.Drawing.Point(350, 376);
            this.bt_Room.Name = "bt_Room";
            this.bt_Room.PressedColor = System.Drawing.Color.BlanchedAlmond;
            this.bt_Room.Size = new System.Drawing.Size(191, 60);
            this.bt_Room.TabIndex = 52;
            this.bt_Room.Text = "Room";
            this.bt_Room.Click += new System.EventHandler(this.bt_Room_Click);
            // 
            // bt_Bill
            // 
            this.bt_Bill.BorderRadius = 20;
            this.bt_Bill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Bill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Bill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Bill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Bill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(233)))), ((int)(((byte)(144)))));
            this.bt_Bill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Bill.ForeColor = System.Drawing.Color.White;
            this.bt_Bill.Location = new System.Drawing.Point(673, 376);
            this.bt_Bill.Name = "bt_Bill";
            this.bt_Bill.Size = new System.Drawing.Size(191, 60);
            this.bt_Bill.TabIndex = 49;
            this.bt_Bill.Text = "Bill";
            this.bt_Bill.Click += new System.EventHandler(this.bt_Bill_Click);
            // 
            // bt_Salary
            // 
            this.bt_Salary.BorderRadius = 20;
            this.bt_Salary.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Salary.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Salary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Salary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Salary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Salary.ForeColor = System.Drawing.Color.White;
            this.bt_Salary.Location = new System.Drawing.Point(462, 515);
            this.bt_Salary.Name = "bt_Salary";
            this.bt_Salary.Size = new System.Drawing.Size(191, 60);
            this.bt_Salary.TabIndex = 51;
            this.bt_Salary.Text = "SALARY";
            this.bt_Salary.Click += new System.EventHandler(this.bt_Salary_Click);
            // 
            // lb_LogOut
            // 
            this.lb_LogOut.AutoSize = true;
            this.lb_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.lb_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LogOut.ForeColor = System.Drawing.Color.Blue;
            this.lb_LogOut.Location = new System.Drawing.Point(843, 177);
            this.lb_LogOut.Name = "lb_LogOut";
            this.lb_LogOut.Size = new System.Drawing.Size(82, 25);
            this.lb_LogOut.TabIndex = 34;
            this.lb_LogOut.Text = "Log Out";
            this.lb_LogOut.Click += new System.EventHandler(this.lb_LogOut_Click);
            // 
            // lb_Edit
            // 
            this.lb_Edit.AutoSize = true;
            this.lb_Edit.BackColor = System.Drawing.Color.Transparent;
            this.lb_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Edit.ForeColor = System.Drawing.Color.Blue;
            this.lb_Edit.Location = new System.Drawing.Point(668, 177);
            this.lb_Edit.Name = "lb_Edit";
            this.lb_Edit.Size = new System.Drawing.Size(114, 25);
            this.lb_Edit.TabIndex = 32;
            this.lb_Edit.Text = "Edit My Info";
            this.lb_Edit.Click += new System.EventHandler(this.lb_Edit_Click);
            // 
            // lb_FnameLname
            // 
            this.lb_FnameLname.AutoSize = true;
            this.lb_FnameLname.BackColor = System.Drawing.Color.Transparent;
            this.lb_FnameLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FnameLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(155)))), ((int)(((byte)(177)))));
            this.lb_FnameLname.Location = new System.Drawing.Point(669, 134);
            this.lb_FnameLname.Name = "lb_FnameLname";
            this.lb_FnameLname.Size = new System.Drawing.Size(235, 20);
            this.lb_FnameLname.TabIndex = 36;
            this.lb_FnameLname.Text = "First Name and Last Name";
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.lb_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(155)))), ((int)(((byte)(177)))));
            this.lb_Welcome.Location = new System.Drawing.Point(669, 95);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(86, 20);
            this.lb_Welcome.TabIndex = 35;
            this.lb_Welcome.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(155)))), ((int)(((byte)(177)))));
            this.label2.Location = new System.Drawing.Point(254, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 51);
            this.label2.TabIndex = 33;
            this.label2.Text = "WINFORM HOTEL";
            // 
            // bt_Checkin
            // 
            this.bt_Checkin.BorderRadius = 20;
            this.bt_Checkin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Checkin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Checkin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Checkin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Checkin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(199)))), ((int)(((byte)(112)))));
            this.bt_Checkin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Checkin.ForeColor = System.Drawing.Color.White;
            this.bt_Checkin.Location = new System.Drawing.Point(263, 261);
            this.bt_Checkin.Name = "bt_Checkin";
            this.bt_Checkin.PressedColor = System.Drawing.Color.Aquamarine;
            this.bt_Checkin.Size = new System.Drawing.Size(191, 60);
            this.bt_Checkin.TabIndex = 0;
            this.bt_Checkin.Text = "Check In";
            this.bt_Checkin.Click += new System.EventHandler(this.bt_Checkin_Click);
            // 
            // bt_ManageShift
            // 
            this.bt_ManageShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.bt_ManageShift.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ManageShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ManageShift.ForeColor = System.Drawing.Color.Blue;
            this.bt_ManageShift.Image = ((System.Drawing.Image)(resources.GetObject("bt_ManageShift.Image")));
            this.bt_ManageShift.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_ManageShift.Location = new System.Drawing.Point(0, 442);
            this.bt_ManageShift.Name = "bt_ManageShift";
            this.bt_ManageShift.Size = new System.Drawing.Size(169, 138);
            this.bt_ManageShift.TabIndex = 57;
            this.bt_ManageShift.Text = "Manage Shift";
            this.bt_ManageShift.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_ManageShift.UseVisualStyleBackColor = false;
            this.bt_ManageShift.Click += new System.EventHandler(this.bt_ManageShift_Click);
            // 
            // bt_HumanResource
            // 
            this.bt_HumanResource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.bt_HumanResource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_HumanResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HumanResource.ForeColor = System.Drawing.Color.Blue;
            this.bt_HumanResource.Image = ((System.Drawing.Image)(resources.GetObject("bt_HumanResource.Image")));
            this.bt_HumanResource.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_HumanResource.Location = new System.Drawing.Point(0, 276);
            this.bt_HumanResource.Name = "bt_HumanResource";
            this.bt_HumanResource.Size = new System.Drawing.Size(169, 145);
            this.bt_HumanResource.TabIndex = 56;
            this.bt_HumanResource.Text = "Human Resource";
            this.bt_HumanResource.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_HumanResource.UseVisualStyleBackColor = false;
            this.bt_HumanResource.Click += new System.EventHandler(this.bt_HumanResource_Click);
            // 
            // button_Main
            // 
            this.button_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.button_Main.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Main.ForeColor = System.Drawing.Color.Blue;
            this.button_Main.Image = ((System.Drawing.Image)(resources.GetObject("button_Main.Image")));
            this.button_Main.Location = new System.Drawing.Point(0, 104);
            this.button_Main.Name = "button_Main";
            this.button_Main.Size = new System.Drawing.Size(169, 145);
            this.button_Main.TabIndex = 2;
            this.button_Main.Text = "Dashboard";
            this.button_Main.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Main.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MultiFaceRec.Properties.Resources._7;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CirclePictureBox
            // 
            this.CirclePictureBox.ImageRotate = 0F;
            this.CirclePictureBox.Location = new System.Drawing.Point(940, 82);
            this.CirclePictureBox.Name = "CirclePictureBox";
            this.CirclePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CirclePictureBox.Size = new System.Drawing.Size(165, 120);
            this.CirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CirclePictureBox.TabIndex = 38;
            this.CirclePictureBox.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CirclePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_ManageShift;
        private System.Windows.Forms.Button bt_HumanResource;
        private System.Windows.Forms.Button button_Main;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button bt_Shift;
        private Guna.UI2.WinForms.Guna2Button bt_Checkout;
        private Guna.UI2.WinForms.Guna2Button bt_Stored;
        private Guna.UI2.WinForms.Guna2Button bt_Room;
        private Guna.UI2.WinForms.Guna2Button bt_Bill;
        private Guna.UI2.WinForms.Guna2Button bt_Salary;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CirclePictureBox;
        private System.Windows.Forms.Label lb_LogOut;
        private System.Windows.Forms.Label lb_Edit;
        private System.Windows.Forms.Label lb_FnameLname;
        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button bt_Checkin;
    }
}