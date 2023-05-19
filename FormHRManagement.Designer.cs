namespace MultiFaceRec
{
    partial class FormHRManagement
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.tb_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hotelManagementDataSet = new MultiFaceRec.hotelManagementDataSet();
            this.hotelManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new MultiFaceRec.hotelManagementDataSetTableAdapters.BookingTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new MultiFaceRec.hotelManagementDataSetTableAdapters.EmployeeTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_Labourer = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Receptionist = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Manager = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Reset = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Remove = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Add = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dt_Birthday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_UserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_RoleID = new System.Windows.Forms.Label();
            this.lb_Picture = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.lb_Birthday = new System.Windows.Forms.Label();
            this.lb_LastName = new System.Windows.Forms.Label();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.lb_EID = new System.Windows.Forms.Label();
            this.tb_Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.tb_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_Phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_Upload = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_LastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_FirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_EID = new Guna.UI2.WinForms.Guna2TextBox();
            this.pb_PictureImage = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(27, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 25);
            this.label3.TabIndex = 174;
            this.label3.Text = "Employee Information";
            // 
            // btn_Search
            // 
            this.btn_Search.BorderRadius = 15;
            this.btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Search.FillColor = System.Drawing.Color.Salmon;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1218, 50);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(157, 41);
            this.btn_Search.TabIndex = 168;
            this.btn_Search.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.BorderRadius = 10;
            this.tb_Search.BorderThickness = 2;
            this.tb_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Search.DefaultText = "";
            this.tb_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_Search.ForeColor = System.Drawing.Color.Blue;
            this.tb_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Search.Location = new System.Drawing.Point(942, 52);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.PasswordChar = '\0';
            this.tb_Search.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Search.PlaceholderText = "Search";
            this.tb_Search.SelectedText = "";
            this.tb_Search.Size = new System.Drawing.Size(266, 39);
            this.tb_Search.TabIndex = 167;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(436, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 166;
            this.label1.Text = "UserName";
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "hotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelManagementDataSetBindingSource
            // 
            this.hotelManagementDataSetBindingSource.DataSource = this.hotelManagementDataSet;
            this.hotelManagementDataSetBindingSource.Position = 0;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.hotelManagementDataSetBindingSource;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.hotelManagementDataSetBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_Labourer);
            this.groupBox3.Controls.Add(this.bt_Receptionist);
            this.groupBox3.Controls.Add(this.bt_Manager);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(942, 589);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 143);
            this.groupBox3.TabIndex = 172;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Type";
            // 
            // bt_Labourer
            // 
            this.bt_Labourer.BorderRadius = 15;
            this.bt_Labourer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Labourer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Labourer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Labourer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Labourer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Labourer.ForeColor = System.Drawing.Color.White;
            this.bt_Labourer.Location = new System.Drawing.Point(239, 96);
            this.bt_Labourer.Name = "bt_Labourer";
            this.bt_Labourer.Size = new System.Drawing.Size(194, 41);
            this.bt_Labourer.TabIndex = 146;
            this.bt_Labourer.Text = "Labourer";
            this.bt_Labourer.Click += new System.EventHandler(this.bt_Labourer_Click);
            // 
            // bt_Receptionist
            // 
            this.bt_Receptionist.BorderRadius = 15;
            this.bt_Receptionist.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Receptionist.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Receptionist.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Receptionist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Receptionist.FillColor = System.Drawing.Color.Gold;
            this.bt_Receptionist.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Receptionist.ForeColor = System.Drawing.Color.White;
            this.bt_Receptionist.Location = new System.Drawing.Point(0, 96);
            this.bt_Receptionist.Name = "bt_Receptionist";
            this.bt_Receptionist.Size = new System.Drawing.Size(194, 41);
            this.bt_Receptionist.TabIndex = 145;
            this.bt_Receptionist.Text = "Receptionist";
            this.bt_Receptionist.Click += new System.EventHandler(this.bt_Receptionist_Click);
            // 
            // bt_Manager
            // 
            this.bt_Manager.BorderRadius = 15;
            this.bt_Manager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Manager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Manager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Manager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Manager.FillColor = System.Drawing.Color.OldLace;
            this.bt_Manager.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Manager.ForeColor = System.Drawing.Color.Blue;
            this.bt_Manager.Location = new System.Drawing.Point(6, 42);
            this.bt_Manager.Name = "bt_Manager";
            this.bt_Manager.Size = new System.Drawing.Size(427, 41);
            this.bt_Manager.TabIndex = 144;
            this.bt_Manager.Text = "Manager";
            this.bt_Manager.Click += new System.EventHandler(this.bt_Manager_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Exit);
            this.groupBox2.Controls.Add(this.bt_Reset);
            this.groupBox2.Controls.Add(this.bt_Remove);
            this.groupBox2.Controls.Add(this.bt_Edit);
            this.groupBox2.Controls.Add(this.bt_Add);
            this.groupBox2.Controls.Add(this.bt_Refresh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(427, 589);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 143);
            this.groupBox2.TabIndex = 171;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editing";
            // 
            // bt_Exit
            // 
            this.bt_Exit.BorderRadius = 15;
            this.bt_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Exit.FillColor = System.Drawing.Color.Orange;
            this.bt_Exit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Exit.ForeColor = System.Drawing.Color.White;
            this.bt_Exit.Location = new System.Drawing.Point(258, 32);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(200, 41);
            this.bt_Exit.TabIndex = 143;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.BorderRadius = 15;
            this.bt_Reset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Reset.ForeColor = System.Drawing.Color.White;
            this.bt_Reset.Location = new System.Drawing.Point(380, 85);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(101, 41);
            this.bt_Reset.TabIndex = 142;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BorderRadius = 15;
            this.bt_Remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Remove.FillColor = System.Drawing.Color.Lime;
            this.bt_Remove.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Remove.ForeColor = System.Drawing.Color.White;
            this.bt_Remove.Location = new System.Drawing.Point(230, 85);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(128, 41);
            this.bt_Remove.TabIndex = 141;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BorderRadius = 15;
            this.bt_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Edit.FillColor = System.Drawing.Color.LightGreen;
            this.bt_Edit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Edit.ForeColor = System.Drawing.Color.White;
            this.bt_Edit.Location = new System.Drawing.Point(112, 85);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(101, 41);
            this.bt_Edit.TabIndex = 140;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.BorderRadius = 15;
            this.bt_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Add.FillColor = System.Drawing.Color.Teal;
            this.bt_Add.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Add.ForeColor = System.Drawing.Color.White;
            this.bt_Add.Location = new System.Drawing.Point(6, 85);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(101, 41);
            this.bt_Add.TabIndex = 139;
            this.bt_Add.Text = "Add";
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BorderRadius = 15;
            this.bt_Refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Refresh.FillColor = System.Drawing.Color.Cyan;
            this.bt_Refresh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Refresh.ForeColor = System.Drawing.Color.White;
            this.bt_Refresh.Location = new System.Drawing.Point(25, 32);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(200, 41);
            this.bt_Refresh.TabIndex = 114;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(487, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(888, 388);
            this.dataGridView1.TabIndex = 175;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dt_Birthday
            // 
            this.dt_Birthday.CustomFormat = "dd/MM/yyyy";
            this.dt_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Birthday.Location = new System.Drawing.Point(179, 187);
            this.dt_Birthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Birthday.Name = "dt_Birthday";
            this.dt_Birthday.Size = new System.Drawing.Size(194, 22);
            this.dt_Birthday.TabIndex = 173;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(937, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 25);
            this.label9.TabIndex = 170;
            this.label9.Text = "Search Fname, Lname : ";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.ForeColor = System.Drawing.Color.Crimson;
            this.lb_Total.Location = new System.Drawing.Point(1292, 557);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(83, 29);
            this.lb_Total.TabIndex = 169;
            this.lb_Total.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(436, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 165;
            this.label2.Text = "Passs:";
            // 
            // tb_Password
            // 
            this.tb_Password.BorderRadius = 10;
            this.tb_Password.BorderThickness = 2;
            this.tb_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Password.DefaultText = "";
            this.tb_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_Password.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Password.Location = new System.Drawing.Point(576, 82);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '\0';
            this.tb_Password.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Password.PlaceholderText = "Password";
            this.tb_Password.SelectedText = "";
            this.tb_Password.Size = new System.Drawing.Size(198, 39);
            this.tb_Password.TabIndex = 164;
            // 
            // tb_UserName
            // 
            this.tb_UserName.BorderRadius = 10;
            this.tb_UserName.BorderThickness = 2;
            this.tb_UserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_UserName.DefaultText = "";
            this.tb_UserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_UserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_UserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_UserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_UserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_UserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_UserName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_UserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_UserName.Location = new System.Drawing.Point(576, 33);
            this.tb_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.PasswordChar = '\0';
            this.tb_UserName.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_UserName.PlaceholderText = "User Name";
            this.tb_UserName.SelectedText = "";
            this.tb_UserName.Size = new System.Drawing.Size(198, 39);
            this.tb_UserName.TabIndex = 163;
            this.tb_UserName.TextChanged += new System.EventHandler(this.tb_UserName_TextChanged);
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.Black;
            this.lb_Email.Location = new System.Drawing.Point(35, 347);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(68, 20);
            this.lb_Email.TabIndex = 162;
            this.lb_Email.Text = "Email :";
            // 
            // lb_RoleID
            // 
            this.lb_RoleID.AutoSize = true;
            this.lb_RoleID.BackColor = System.Drawing.Color.Transparent;
            this.lb_RoleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RoleID.ForeColor = System.Drawing.Color.Black;
            this.lb_RoleID.Location = new System.Drawing.Point(50, 453);
            this.lb_RoleID.Name = "lb_RoleID";
            this.lb_RoleID.Size = new System.Drawing.Size(53, 20);
            this.lb_RoleID.TabIndex = 161;
            this.lb_RoleID.Text = "Role:";
            // 
            // lb_Picture
            // 
            this.lb_Picture.AutoSize = true;
            this.lb_Picture.BackColor = System.Drawing.Color.Transparent;
            this.lb_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Picture.ForeColor = System.Drawing.Color.Black;
            this.lb_Picture.Location = new System.Drawing.Point(28, 513);
            this.lb_Picture.Name = "lb_Picture";
            this.lb_Picture.Size = new System.Drawing.Size(75, 20);
            this.lb_Picture.TabIndex = 160;
            this.lb_Picture.Text = "Picture:";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.BackColor = System.Drawing.Color.Transparent;
            this.lb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.ForeColor = System.Drawing.Color.Black;
            this.lb_Address.Location = new System.Drawing.Point(19, 398);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(84, 20);
            this.lb_Address.TabIndex = 159;
            this.lb_Address.Text = "Address:";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.ForeColor = System.Drawing.Color.Black;
            this.lb_Phone.Location = new System.Drawing.Point(29, 290);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(67, 20);
            this.lb_Phone.TabIndex = 158;
            this.lb_Phone.Text = "Phone:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Black;
            this.labelGender.Location = new System.Drawing.Point(20, 231);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(76, 20);
            this.labelGender.TabIndex = 157;
            this.labelGender.Text = "Gender:";
            // 
            // lb_Birthday
            // 
            this.lb_Birthday.AutoSize = true;
            this.lb_Birthday.BackColor = System.Drawing.Color.Transparent;
            this.lb_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Birthday.ForeColor = System.Drawing.Color.Black;
            this.lb_Birthday.Location = new System.Drawing.Point(8, 189);
            this.lb_Birthday.Name = "lb_Birthday";
            this.lb_Birthday.Size = new System.Drawing.Size(96, 20);
            this.lb_Birthday.TabIndex = 156;
            this.lb_Birthday.Text = "BirthDate:";
            // 
            // lb_LastName
            // 
            this.lb_LastName.AutoSize = true;
            this.lb_LastName.BackColor = System.Drawing.Color.Transparent;
            this.lb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LastName.ForeColor = System.Drawing.Color.Black;
            this.lb_LastName.Location = new System.Drawing.Point(5, 143);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(106, 20);
            this.lb_LastName.TabIndex = 155;
            this.lb_LastName.Text = "Last Name:";
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.lb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FirstName.ForeColor = System.Drawing.Color.Black;
            this.lb_FirstName.Location = new System.Drawing.Point(4, 104);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(108, 20);
            this.lb_FirstName.TabIndex = 154;
            this.lb_FirstName.Text = "First Name:";
            // 
            // lb_EID
            // 
            this.lb_EID.AutoSize = true;
            this.lb_EID.BackColor = System.Drawing.Color.Transparent;
            this.lb_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EID.ForeColor = System.Drawing.Color.Black;
            this.lb_EID.Location = new System.Drawing.Point(50, 52);
            this.lb_EID.Name = "lb_EID";
            this.lb_EID.Size = new System.Drawing.Size(46, 20);
            this.lb_EID.TabIndex = 153;
            this.lb_EID.Text = "EID:";
            // 
            // tb_Address
            // 
            this.tb_Address.BorderRadius = 10;
            this.tb_Address.BorderThickness = 2;
            this.tb_Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Address.DefaultText = "";
            this.tb_Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Address.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_Address.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Address.Location = new System.Drawing.Point(171, 389);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.PasswordChar = '\0';
            this.tb_Address.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Address.PlaceholderText = "Address";
            this.tb_Address.SelectedText = "";
            this.tb_Address.Size = new System.Drawing.Size(198, 39);
            this.tb_Address.TabIndex = 152;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.Checked = true;
            this.RadioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonMale.ForeColor = System.Drawing.Color.Blue;
            this.RadioButtonMale.Location = new System.Drawing.Point(5, 16);
            this.RadioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(66, 24);
            this.RadioButtonMale.TabIndex = 0;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioButtonFemale.ForeColor = System.Drawing.Color.Fuchsia;
            this.RadioButtonFemale.Location = new System.Drawing.Point(96, 16);
            this.RadioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(85, 24);
            this.RadioButtonFemale.TabIndex = 1;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // tb_Email
            // 
            this.tb_Email.BorderRadius = 10;
            this.tb_Email.BorderThickness = 2;
            this.tb_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Email.DefaultText = "";
            this.tb_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Email.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_Email.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Email.Location = new System.Drawing.Point(171, 340);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.PasswordChar = '\0';
            this.tb_Email.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Email.PlaceholderText = "Email";
            this.tb_Email.SelectedText = "";
            this.tb_Email.Size = new System.Drawing.Size(198, 39);
            this.tb_Email.TabIndex = 151;
            // 
            // tb_Phone
            // 
            this.tb_Phone.BorderRadius = 10;
            this.tb_Phone.BorderThickness = 2;
            this.tb_Phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Phone.DefaultText = "";
            this.tb_Phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_Phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_Phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_Phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Phone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_Phone.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_Phone.Location = new System.Drawing.Point(175, 280);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.PasswordChar = '\0';
            this.tb_Phone.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_Phone.PlaceholderText = "Phone Number";
            this.tb_Phone.SelectedText = "";
            this.tb_Phone.Size = new System.Drawing.Size(198, 39);
            this.tb_Phone.TabIndex = 150;
            this.tb_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Phone_KeyPress);
            // 
            // bt_Upload
            // 
            this.bt_Upload.BorderRadius = 15;
            this.bt_Upload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Upload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Upload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Upload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Upload.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Upload.ForeColor = System.Drawing.Color.White;
            this.bt_Upload.Location = new System.Drawing.Point(171, 621);
            this.bt_Upload.Name = "bt_Upload";
            this.bt_Upload.Size = new System.Drawing.Size(208, 41);
            this.bt_Upload.TabIndex = 149;
            this.bt_Upload.Text = "Upload";
            this.bt_Upload.Click += new System.EventHandler(this.bt_Upload_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(175, 449);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 146;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonMale);
            this.groupBox1.Controls.Add(this.RadioButtonFemale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(181, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(207, 60);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            // 
            // tb_LastName
            // 
            this.tb_LastName.BorderRadius = 10;
            this.tb_LastName.BorderThickness = 2;
            this.tb_LastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_LastName.DefaultText = "";
            this.tb_LastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_LastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_LastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_LastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_LastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_LastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LastName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_LastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_LastName.Location = new System.Drawing.Point(175, 134);
            this.tb_LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.PasswordChar = '\0';
            this.tb_LastName.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_LastName.PlaceholderText = "Last Name";
            this.tb_LastName.SelectedText = "";
            this.tb_LastName.Size = new System.Drawing.Size(198, 39);
            this.tb_LastName.TabIndex = 144;
            this.tb_LastName.TextChanged += new System.EventHandler(this.tb_LastName_TextChanged);
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.BorderRadius = 10;
            this.tb_FirstName.BorderThickness = 2;
            this.tb_FirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_FirstName.DefaultText = "";
            this.tb_FirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_FirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_FirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_FirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_FirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_FirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FirstName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_FirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_FirstName.Location = new System.Drawing.Point(175, 90);
            this.tb_FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.PasswordChar = '\0';
            this.tb_FirstName.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_FirstName.PlaceholderText = "First Name";
            this.tb_FirstName.SelectedText = "";
            this.tb_FirstName.Size = new System.Drawing.Size(198, 34);
            this.tb_FirstName.TabIndex = 143;
            this.tb_FirstName.TextChanged += new System.EventHandler(this.tb_FirstName_TextChanged);
            // 
            // tb_EID
            // 
            this.tb_EID.BorderColor = System.Drawing.Color.White;
            this.tb_EID.BorderRadius = 10;
            this.tb_EID.BorderThickness = 2;
            this.tb_EID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_EID.DefaultText = "";
            this.tb_EID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_EID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_EID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_EID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_EID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_EID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_EID.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_EID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_EID.Location = new System.Drawing.Point(175, 47);
            this.tb_EID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_EID.Name = "tb_EID";
            this.tb_EID.PasswordChar = '\0';
            this.tb_EID.PlaceholderForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tb_EID.PlaceholderText = "Employee ID";
            this.tb_EID.SelectedText = "";
            this.tb_EID.Size = new System.Drawing.Size(198, 34);
            this.tb_EID.TabIndex = 142;
            this.tb_EID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_EID_KeyPress);
            // 
            // pb_PictureImage
            // 
            this.pb_PictureImage.BackColor = System.Drawing.Color.IndianRed;
            this.pb_PictureImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pb_PictureImage.Location = new System.Drawing.Point(175, 498);
            this.pb_PictureImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_PictureImage.Name = "pb_PictureImage";
            this.pb_PictureImage.Size = new System.Drawing.Size(194, 100);
            this.pb_PictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_PictureImage.TabIndex = 148;
            this.pb_PictureImage.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(41, 290);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(8, 8);
            this.guna2CirclePictureBox1.TabIndex = 147;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FormHRManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1444, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dt_Birthday);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.lb_Email);
            this.Controls.Add(this.lb_RoleID);
            this.Controls.Add(this.lb_Picture);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.lb_Birthday);
            this.Controls.Add(this.lb_LastName);
            this.Controls.Add(this.lb_FirstName);
            this.Controls.Add(this.lb_EID);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.bt_Upload);
            this.Controls.Add(this.pb_PictureImage);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.tb_EID);
            this.Name = "FormHRManagement";
            this.Text = "FormHRManagement";
            this.Load += new System.EventHandler(this.FormHRManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btn_Search;
        private Guna.UI2.WinForms.Guna2TextBox tb_Search;
        private System.Windows.Forms.Label label1;
        private hotelManagementDataSet hotelManagementDataSet;
        private System.Windows.Forms.BindingSource hotelManagementDataSetBindingSource;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private hotelManagementDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private hotelManagementDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI2.WinForms.Guna2Button bt_Labourer;
        private Guna.UI2.WinForms.Guna2Button bt_Receptionist;
        private Guna.UI2.WinForms.Guna2Button bt_Manager;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button bt_Exit;
        private Guna.UI2.WinForms.Guna2Button bt_Reset;
        private Guna.UI2.WinForms.Guna2Button bt_Remove;
        private Guna.UI2.WinForms.Guna2Button bt_Edit;
        private Guna.UI2.WinForms.Guna2Button bt_Add;
        private Guna.UI2.WinForms.Guna2Button bt_Refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dt_Birthday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tb_Password;
        private Guna.UI2.WinForms.Guna2TextBox tb_UserName;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_RoleID;
        private System.Windows.Forms.Label lb_Picture;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label lb_Birthday;
        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.Label lb_EID;
        private Guna.UI2.WinForms.Guna2TextBox tb_Address;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private Guna.UI2.WinForms.Guna2TextBox tb_Email;
        private Guna.UI2.WinForms.Guna2TextBox tb_Phone;
        private Guna.UI2.WinForms.Guna2Button bt_Upload;
        private System.Windows.Forms.PictureBox pb_PictureImage;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox tb_LastName;
        private Guna.UI2.WinForms.Guna2TextBox tb_FirstName;
        private Guna.UI2.WinForms.Guna2TextBox tb_EID;
    }
}