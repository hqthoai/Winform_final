
namespace MultiFaceRec
{
    partial class MainForm
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
            this.bt_Checkin = new System.Windows.Forms.Button();
            this.bt_Checkout = new System.Windows.Forms.Button();
            this.bt_ManageShift = new System.Windows.Forms.Button();
            this.lb_LogOut = new System.Windows.Forms.Label();
            this.lb_Edit = new System.Windows.Forms.Label();
            this.lb_FnameLname = new System.Windows.Forms.Label();
            this.lb_Welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Room = new System.Windows.Forms.Button();
            this.bt_Shift = new System.Windows.Forms.Button();
            this.bt_Bill = new System.Windows.Forms.Button();
            this.bt_HumanResource = new System.Windows.Forms.Button();
            this.bt_Salary = new System.Windows.Forms.Button();
            this.bt_Stored = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Checkin
            // 
            this.bt_Checkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bt_Checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Checkin.Location = new System.Drawing.Point(128, 260);
            this.bt_Checkin.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Checkin.Name = "bt_Checkin";
            this.bt_Checkin.Size = new System.Drawing.Size(202, 54);
            this.bt_Checkin.TabIndex = 1;
            this.bt_Checkin.Text = "CHECK IN";
            this.bt_Checkin.UseVisualStyleBackColor = false;
            this.bt_Checkin.Click += new System.EventHandler(this.bt_Checkin_Click);
            // 
            // bt_Checkout
            // 
            this.bt_Checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bt_Checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Checkout.Location = new System.Drawing.Point(321, 260);
            this.bt_Checkout.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Checkout.Name = "bt_Checkout";
            this.bt_Checkout.Size = new System.Drawing.Size(190, 54);
            this.bt_Checkout.TabIndex = 2;
            this.bt_Checkout.Text = "CHECK OUT";
            this.bt_Checkout.UseVisualStyleBackColor = false;
            // 
            // bt_ManageShift
            // 
            this.bt_ManageShift.BackColor = System.Drawing.Color.SandyBrown;
            this.bt_ManageShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ManageShift.Location = new System.Drawing.Point(619, 431);
            this.bt_ManageShift.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ManageShift.Name = "bt_ManageShift";
            this.bt_ManageShift.Size = new System.Drawing.Size(155, 54);
            this.bt_ManageShift.TabIndex = 3;
            this.bt_ManageShift.Text = "MANAGE SHIFT";
            this.bt_ManageShift.UseVisualStyleBackColor = false;
            this.bt_ManageShift.Click += new System.EventHandler(this.bt_Shift_Click_1);
            // 
            // lb_LogOut
            // 
            this.lb_LogOut.AutoSize = true;
            this.lb_LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LogOut.ForeColor = System.Drawing.Color.Blue;
            this.lb_LogOut.Location = new System.Drawing.Point(194, 181);
            this.lb_LogOut.Name = "lb_LogOut";
            this.lb_LogOut.Size = new System.Drawing.Size(59, 17);
            this.lb_LogOut.TabIndex = 21;
            this.lb_LogOut.Text = "Log Out";
            this.lb_LogOut.Click += new System.EventHandler(this.lb_LogOut_Click);
            // 
            // lb_Edit
            // 
            this.lb_Edit.AutoSize = true;
            this.lb_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Edit.ForeColor = System.Drawing.Color.Blue;
            this.lb_Edit.Location = new System.Drawing.Point(96, 181);
            this.lb_Edit.Name = "lb_Edit";
            this.lb_Edit.Size = new System.Drawing.Size(81, 17);
            this.lb_Edit.TabIndex = 19;
            this.lb_Edit.Text = "Edit My Info";
            this.lb_Edit.Click += new System.EventHandler(this.lb_Edit_Click);
            // 
            // lb_FnameLname
            // 
            this.lb_FnameLname.AutoSize = true;
            this.lb_FnameLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FnameLname.Location = new System.Drawing.Point(95, 146);
            this.lb_FnameLname.Name = "lb_FnameLname";
            this.lb_FnameLname.Size = new System.Drawing.Size(235, 20);
            this.lb_FnameLname.TabIndex = 23;
            this.lb_FnameLname.Text = "First Name and Last Name";
            // 
            // lb_Welcome
            // 
            this.lb_Welcome.AutoSize = true;
            this.lb_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Welcome.Location = new System.Drawing.Point(95, 107);
            this.lb_Welcome.Name = "lb_Welcome";
            this.lb_Welcome.Size = new System.Drawing.Size(86, 20);
            this.lb_Welcome.TabIndex = 22;
            this.lb_Welcome.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(92, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 52);
            this.label2.TabIndex = 20;
            this.label2.Text = "RIVERSIDE HOTEL";
            // 
            // bt_Room
            // 
            this.bt_Room.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bt_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Room.Location = new System.Drawing.Point(467, 431);
            this.bt_Room.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Room.Name = "bt_Room";
            this.bt_Room.Size = new System.Drawing.Size(155, 54);
            this.bt_Room.TabIndex = 25;
            this.bt_Room.Text = "ROOM";
            this.bt_Room.UseVisualStyleBackColor = false;
            this.bt_Room.Click += new System.EventHandler(this.bt_Room_Click);
            // 
            // bt_Shift
            // 
            this.bt_Shift.BackColor = System.Drawing.Color.NavajoWhite;
            this.bt_Shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Shift.Location = new System.Drawing.Point(496, 260);
            this.bt_Shift.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Shift.Name = "bt_Shift";
            this.bt_Shift.Size = new System.Drawing.Size(179, 54);
            this.bt_Shift.TabIndex = 26;
            this.bt_Shift.Text = "SHIFT";
            this.bt_Shift.UseVisualStyleBackColor = false;
            this.bt_Shift.Click += new System.EventHandler(this.bt_Shift_Click);
            // 
            // bt_Bill
            // 
            this.bt_Bill.BackColor = System.Drawing.Color.Gold;
            this.bt_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Bill.Location = new System.Drawing.Point(772, 431);
            this.bt_Bill.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Bill.Name = "bt_Bill";
            this.bt_Bill.Size = new System.Drawing.Size(155, 54);
            this.bt_Bill.TabIndex = 27;
            this.bt_Bill.Text = "BILL";
            this.bt_Bill.UseVisualStyleBackColor = false;
            // 
            // bt_HumanResource
            // 
            this.bt_HumanResource.BackColor = System.Drawing.Color.LawnGreen;
            this.bt_HumanResource.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_HumanResource.Location = new System.Drawing.Point(730, 576);
            this.bt_HumanResource.Margin = new System.Windows.Forms.Padding(4);
            this.bt_HumanResource.Name = "bt_HumanResource";
            this.bt_HumanResource.Size = new System.Drawing.Size(155, 54);
            this.bt_HumanResource.TabIndex = 28;
            this.bt_HumanResource.Text = "HUMAN RESOURCE";
            this.bt_HumanResource.UseVisualStyleBackColor = false;
            this.bt_HumanResource.Click += new System.EventHandler(this.bt_HumanResource_Click);
            // 
            // bt_Salary
            // 
            this.bt_Salary.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Salary.Location = new System.Drawing.Point(877, 576);
            this.bt_Salary.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Salary.Name = "bt_Salary";
            this.bt_Salary.Size = new System.Drawing.Size(155, 54);
            this.bt_Salary.TabIndex = 29;
            this.bt_Salary.Text = "SALARY";
            this.bt_Salary.UseVisualStyleBackColor = false;
            // 
            // bt_Stored
            // 
            this.bt_Stored.BackColor = System.Drawing.Color.Green;
            this.bt_Stored.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Stored.Location = new System.Drawing.Point(1029, 576);
            this.bt_Stored.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Stored.Name = "bt_Stored";
            this.bt_Stored.Size = new System.Drawing.Size(155, 54);
            this.bt_Stored.TabIndex = 30;
            this.bt_Stored.Text = "STORED";
            this.bt_Stored.UseVisualStyleBackColor = false;
            this.bt_Stored.Click += new System.EventHandler(this.bt_Stored_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(365, 107);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(105, 107);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 24;
            this.pictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::MultiFaceRec.Properties.Resources._3881977f990886521e929f16e5d765e9;
            this.ClientSize = new System.Drawing.Size(1197, 841);
            this.Controls.Add(this.bt_Stored);
            this.Controls.Add(this.bt_Salary);
            this.Controls.Add(this.bt_HumanResource);
            this.Controls.Add(this.bt_Bill);
            this.Controls.Add(this.bt_Shift);
            this.Controls.Add(this.bt_Room);
            this.Controls.Add(this.lb_LogOut);
            this.Controls.Add(this.lb_Edit);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lb_FnameLname);
            this.Controls.Add(this.lb_Welcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_ManageShift);
            this.Controls.Add(this.bt_Checkout);
            this.Controls.Add(this.bt_Checkin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button bt_Checkin;
        private System.Windows.Forms.Button bt_Checkout;
        private System.Windows.Forms.Button bt_ManageShift;
        private System.Windows.Forms.Label lb_LogOut;
        private System.Windows.Forms.Label lb_Edit;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lb_FnameLname;
        private System.Windows.Forms.Label lb_Welcome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Room;
        private System.Windows.Forms.Button bt_Shift;
        private System.Windows.Forms.Button bt_Bill;
        private System.Windows.Forms.Button bt_HumanResource;
        private System.Windows.Forms.Button bt_Salary;
        private System.Windows.Forms.Button bt_Stored;

        #endregion
    }
}