
namespace MultiFaceRec
{
    partial class HRForm
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
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDataSet = new MultiFaceRec.EmployeeDataSet();
            this.std2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.lb_Total = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_Labourer = new System.Windows.Forms.Button();
            this.bt_Receptionist = new System.Windows.Forms.Button();
            this.bt_Manager = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.employeeTableAdapter = new MultiFaceRec.EmployeeDataSetTableAdapters.EmployeeTableAdapter();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_EID = new System.Windows.Forms.Label();
            this.tb_EID = new System.Windows.Forms.TextBox();
            this.lb_Email = new System.Windows.Forms.Label();
            this.lb_RoleID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.bt_UploadImage = new System.Windows.Forms.Button();
            this.pb_PictureImage = new System.Windows.Forms.PictureBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.dt_Birthday = new System.Windows.Forms.DateTimePicker();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.lb_Picture = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.lb_Birthday = new System.Windows.Forms.Label();
            this.lb_LastName = new System.Windows.Forms.Label();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.picDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.std2BindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.employeeDataSet;
            // 
            // employeeDataSet
            // 
            this.employeeDataSet.DataSetName = "EmployeeDataSet";
            this.employeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // std2BindingSource
            // 
            this.std2BindingSource.DataMember = "std2";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSearch.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(1118, 41);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(119, 45);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(13, -20);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(46, 20);
            this.labelID.TabIndex = 52;
            this.labelID.Text = "EID:";
            // 
            // tb_Search
            // 
            this.tb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Search.Location = new System.Drawing.Point(744, 50);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(308, 30);
            this.tb_Search.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(489, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 25);
            this.label9.TabIndex = 89;
            this.label9.Text = "Search Fname, Lname : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_Reset);
            this.groupBox2.Controls.Add(this.bt_Refresh);
            this.groupBox2.Controls.Add(this.bt_Remove);
            this.groupBox2.Controls.Add(this.bt_Add);
            this.groupBox2.Controls.Add(this.bt_Edit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(509, 578);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 143);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Editing";
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_Reset.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reset.ForeColor = System.Drawing.Color.Black;
            this.bt_Reset.Location = new System.Drawing.Point(369, 85);
            this.bt_Reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(93, 41);
            this.bt_Reset.TabIndex = 3;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.Blue;
            this.bt_Refresh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.ForeColor = System.Drawing.Color.Black;
            this.bt_Refresh.Location = new System.Drawing.Point(125, 24);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(227, 43);
            this.bt_Refresh.TabIndex = 4;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.Red;
            this.bt_Remove.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.ForeColor = System.Drawing.Color.Black;
            this.bt_Remove.Location = new System.Drawing.Point(244, 85);
            this.bt_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(108, 41);
            this.bt_Remove.TabIndex = 2;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.Lime;
            this.bt_Add.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.ForeColor = System.Drawing.Color.Black;
            this.bt_Add.Location = new System.Drawing.Point(32, 85);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(71, 41);
            this.bt_Add.TabIndex = 0;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.Aqua;
            this.bt_Edit.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Edit.ForeColor = System.Drawing.Color.Black;
            this.bt_Edit.Location = new System.Drawing.Point(125, 85);
            this.bt_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(77, 41);
            this.bt_Edit.TabIndex = 1;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Total.ForeColor = System.Drawing.Color.Crimson;
            this.lb_Total.Location = new System.Drawing.Point(1356, 527);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(83, 29);
            this.lb_Total.TabIndex = 82;
            this.lb_Total.Text = "Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_Labourer);
            this.groupBox3.Controls.Add(this.bt_Receptionist);
            this.groupBox3.Controls.Add(this.bt_Manager);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(1009, 578);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 143);
            this.groupBox3.TabIndex = 91;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Type";
            // 
            // bt_Labourer
            // 
            this.bt_Labourer.BackColor = System.Drawing.Color.MintCream;
            this.bt_Labourer.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Labourer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Labourer.Location = new System.Drawing.Point(298, 79);
            this.bt_Labourer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Labourer.Name = "bt_Labourer";
            this.bt_Labourer.Size = new System.Drawing.Size(126, 41);
            this.bt_Labourer.TabIndex = 2;
            this.bt_Labourer.Text = "Labourer";
            this.bt_Labourer.UseVisualStyleBackColor = false;
            this.bt_Labourer.Click += new System.EventHandler(this.bt_Labourer_Click);
            // 
            // bt_Receptionist
            // 
            this.bt_Receptionist.BackColor = System.Drawing.Color.MintCream;
            this.bt_Receptionist.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Receptionist.ForeColor = System.Drawing.Color.Blue;
            this.bt_Receptionist.Location = new System.Drawing.Point(143, 79);
            this.bt_Receptionist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Receptionist.Name = "bt_Receptionist";
            this.bt_Receptionist.Size = new System.Drawing.Size(144, 41);
            this.bt_Receptionist.TabIndex = 1;
            this.bt_Receptionist.Text = "Receptionist";
            this.bt_Receptionist.UseVisualStyleBackColor = false;
            this.bt_Receptionist.Click += new System.EventHandler(this.bt_Receptionist_Click);
            // 
            // bt_Manager
            // 
            this.bt_Manager.BackColor = System.Drawing.Color.MintCream;
            this.bt_Manager.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Manager.ForeColor = System.Drawing.Color.Red;
            this.bt_Manager.Location = new System.Drawing.Point(6, 79);
            this.bt_Manager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Manager.Name = "bt_Manager";
            this.bt_Manager.Size = new System.Drawing.Size(114, 41);
            this.bt_Manager.TabIndex = 0;
            this.bt_Manager.Text = "Manager";
            this.bt_Manager.UseVisualStyleBackColor = false;
            this.bt_Manager.Click += new System.EventHandler(this.bt_Manager_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_Password);
            this.groupBox4.Controls.Add(this.tb_UserName);
            this.groupBox4.Controls.Add(this.lb_UserName);
            this.groupBox4.Controls.Add(this.lb_Password);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Lime;
            this.groupBox4.Location = new System.Drawing.Point(8, 595);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 126);
            this.groupBox4.TabIndex = 93;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employee Account";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(170, 83);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(210, 22);
            this.tb_Password.TabIndex = 1;
            // 
            // tb_UserName
            // 
            this.tb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_UserName.Location = new System.Drawing.Point(170, 41);
            this.tb_UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(210, 22);
            this.tb_UserName.TabIndex = 0;
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserName.ForeColor = System.Drawing.Color.Black;
            this.lb_UserName.Location = new System.Drawing.Point(45, 43);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(106, 20);
            this.lb_UserName.TabIndex = 86;
            this.lb_UserName.Text = "User name:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.ForeColor = System.Drawing.Color.Black;
            this.lb_Password.Location = new System.Drawing.Point(46, 83);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(103, 20);
            this.lb_Password.TabIndex = 87;
            this.lb_Password.Text = "Password :";
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.lb_EID);
            this.groupBox5.Controls.Add(this.tb_EID);
            this.groupBox5.Controls.Add(this.lb_Email);
            this.groupBox5.Controls.Add(this.lb_RoleID);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.bt_UploadImage);
            this.groupBox5.Controls.Add(this.pb_PictureImage);
            this.groupBox5.Controls.Add(this.tb_Address);
            this.groupBox5.Controls.Add(this.tb_Phone);
            this.groupBox5.Controls.Add(this.dt_Birthday);
            this.groupBox5.Controls.Add(this.tb_Email);
            this.groupBox5.Controls.Add(this.tb_LastName);
            this.groupBox5.Controls.Add(this.tb_FirstName);
            this.groupBox5.Controls.Add(this.lb_Picture);
            this.groupBox5.Controls.Add(this.lb_Address);
            this.groupBox5.Controls.Add(this.lb_Phone);
            this.groupBox5.Controls.Add(this.labelGender);
            this.groupBox5.Controls.Add(this.lb_Birthday);
            this.groupBox5.Controls.Add(this.lb_LastName);
            this.groupBox5.Controls.Add(this.lb_FirstName);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox5.Location = new System.Drawing.Point(8, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(456, 584);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Employee Info";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 389);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // lb_EID
            // 
            this.lb_EID.AutoSize = true;
            this.lb_EID.BackColor = System.Drawing.Color.Transparent;
            this.lb_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EID.ForeColor = System.Drawing.Color.Black;
            this.lb_EID.Location = new System.Drawing.Point(94, 49);
            this.lb_EID.Name = "lb_EID";
            this.lb_EID.Size = new System.Drawing.Size(46, 20);
            this.lb_EID.TabIndex = 112;
            this.lb_EID.Text = "EID:";
            // 
            // tb_EID
            // 
            this.tb_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EID.Location = new System.Drawing.Point(170, 36);
            this.tb_EID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_EID.Name = "tb_EID";
            this.tb_EID.Size = new System.Drawing.Size(200, 22);
            this.tb_EID.TabIndex = 0;
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.BackColor = System.Drawing.Color.Transparent;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.ForeColor = System.Drawing.Color.Black;
            this.lb_Email.Location = new System.Drawing.Point(65, 283);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(68, 20);
            this.lb_Email.TabIndex = 110;
            this.lb_Email.Text = "Email :";
            // 
            // lb_RoleID
            // 
            this.lb_RoleID.AutoSize = true;
            this.lb_RoleID.BackColor = System.Drawing.Color.Transparent;
            this.lb_RoleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RoleID.ForeColor = System.Drawing.Color.Black;
            this.lb_RoleID.Location = new System.Drawing.Point(80, 389);
            this.lb_RoleID.Name = "lb_RoleID";
            this.lb_RoleID.Size = new System.Drawing.Size(53, 20);
            this.lb_RoleID.TabIndex = 109;
            this.lb_RoleID.Text = "Role:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonMale);
            this.groupBox1.Controls.Add(this.RadioButtonFemale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(165, 178);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(207, 60);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
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
            // bt_UploadImage
            // 
            this.bt_UploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_UploadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_UploadImage.ForeColor = System.Drawing.Color.White;
            this.bt_UploadImage.Location = new System.Drawing.Point(160, 543);
            this.bt_UploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_UploadImage.Name = "bt_UploadImage";
            this.bt_UploadImage.Size = new System.Drawing.Size(212, 41);
            this.bt_UploadImage.TabIndex = 8;
            this.bt_UploadImage.Text = "Upload ";
            this.bt_UploadImage.UseVisualStyleBackColor = false;
            this.bt_UploadImage.Click += new System.EventHandler(this.bt_UploadImage_Click_1);
            // 
            // pb_PictureImage
            // 
            this.pb_PictureImage.BackColor = System.Drawing.Color.IndianRed;
            this.pb_PictureImage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pb_PictureImage.Location = new System.Drawing.Point(164, 436);
            this.pb_PictureImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_PictureImage.Name = "pb_PictureImage";
            this.pb_PictureImage.Size = new System.Drawing.Size(208, 100);
            this.pb_PictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_PictureImage.TabIndex = 106;
            this.pb_PictureImage.TabStop = false;
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(164, 319);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Address.Multiline = true;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(208, 53);
            this.tb_Address.TabIndex = 6;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Phone.Location = new System.Drawing.Point(165, 248);
            this.tb_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(207, 22);
            this.tb_Phone.TabIndex = 4;
            // 
            // dt_Birthday
            // 
            this.dt_Birthday.CustomFormat = "dd/MM/yyyy";
            this.dt_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_Birthday.Location = new System.Drawing.Point(170, 142);
            this.dt_Birthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_Birthday.Name = "dt_Birthday";
            this.dt_Birthday.Size = new System.Drawing.Size(200, 22);
            this.dt_Birthday.TabIndex = 3;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(165, 283);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(207, 22);
            this.tb_Email.TabIndex = 5;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LastName.Location = new System.Drawing.Point(170, 107);
            this.tb_LastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(200, 22);
            this.tb_LastName.TabIndex = 2;
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FirstName.Location = new System.Drawing.Point(170, 70);
            this.tb_FirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(200, 22);
            this.tb_FirstName.TabIndex = 1;
            // 
            // lb_Picture
            // 
            this.lb_Picture.AutoSize = true;
            this.lb_Picture.BackColor = System.Drawing.Color.Transparent;
            this.lb_Picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Picture.ForeColor = System.Drawing.Color.Black;
            this.lb_Picture.Location = new System.Drawing.Point(58, 449);
            this.lb_Picture.Name = "lb_Picture";
            this.lb_Picture.Size = new System.Drawing.Size(75, 20);
            this.lb_Picture.TabIndex = 99;
            this.lb_Picture.Text = "Picture:";
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.BackColor = System.Drawing.Color.Transparent;
            this.lb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.ForeColor = System.Drawing.Color.Black;
            this.lb_Address.Location = new System.Drawing.Point(49, 334);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(84, 20);
            this.lb_Address.TabIndex = 98;
            this.lb_Address.Text = "Address:";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.BackColor = System.Drawing.Color.Transparent;
            this.lb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.ForeColor = System.Drawing.Color.Black;
            this.lb_Phone.Location = new System.Drawing.Point(66, 248);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(67, 20);
            this.lb_Phone.TabIndex = 97;
            this.lb_Phone.Text = "Phone:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.BackColor = System.Drawing.Color.Transparent;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.Black;
            this.labelGender.Location = new System.Drawing.Point(57, 194);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(76, 20);
            this.labelGender.TabIndex = 96;
            this.labelGender.Text = "Gender:";
            // 
            // lb_Birthday
            // 
            this.lb_Birthday.AutoSize = true;
            this.lb_Birthday.BackColor = System.Drawing.Color.Transparent;
            this.lb_Birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Birthday.ForeColor = System.Drawing.Color.Black;
            this.lb_Birthday.Location = new System.Drawing.Point(37, 146);
            this.lb_Birthday.Name = "lb_Birthday";
            this.lb_Birthday.Size = new System.Drawing.Size(96, 20);
            this.lb_Birthday.TabIndex = 95;
            this.lb_Birthday.Text = "BirthDate:";
            // 
            // lb_LastName
            // 
            this.lb_LastName.AutoSize = true;
            this.lb_LastName.BackColor = System.Drawing.Color.Transparent;
            this.lb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LastName.ForeColor = System.Drawing.Color.Black;
            this.lb_LastName.Location = new System.Drawing.Point(34, 111);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(106, 20);
            this.lb_LastName.TabIndex = 94;
            this.lb_LastName.Text = "Last Name:";
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.lb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FirstName.ForeColor = System.Drawing.Color.Black;
            this.lb_FirstName.Location = new System.Drawing.Point(33, 72);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(108, 20);
            this.lb_FirstName.TabIndex = 93;
            this.lb_FirstName.Text = "First Name:";
            // 
            // picDataGridViewImageColumn
            // 
            this.picDataGridViewImageColumn.DataPropertyName = "Pic";
            this.picDataGridViewImageColumn.HeaderText = "Pic";
            this.picDataGridViewImageColumn.MinimumWidth = 6;
            this.picDataGridViewImageColumn.Name = "picDataGridViewImageColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // gmailDataGridViewTextBoxColumn
            // 
            this.gmailDataGridViewTextBoxColumn.DataPropertyName = "gmail";
            this.gmailDataGridViewTextBoxColumn.HeaderText = "Gmail";
            this.gmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gmailDataGridViewTextBoxColumn.Name = "gmailDataGridViewTextBoxColumn";
            // 
            // roleIDDataGridViewTextBoxColumn
            // 
            this.roleIDDataGridViewTextBoxColumn.DataPropertyName = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.HeaderText = "RoleID";
            this.roleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleIDDataGridViewTextBoxColumn.Name = "roleIDDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "Bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.bdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "Lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "Fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // eIDDataGridViewTextBoxColumn
            // 
            this.eIDDataGridViewTextBoxColumn.DataPropertyName = "EID";
            this.eIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.eIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eIDDataGridViewTextBoxColumn.Name = "eIDDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eIDDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.roleIDDataGridViewTextBoxColumn,
            this.gmailDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.picDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(498, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(941, 388);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HRForm
            // 
            this.AcceptButton = this.bt_Edit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiFaceRec.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1491, 733);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelID);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HRForm";
            this.Text = "ManagementForm";
            this.Load += new System.EventHandler(this.HRForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.std2BindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_PictureImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource std2BindingSource;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_Labourer;
        private System.Windows.Forms.Button bt_Receptionist;
        private System.Windows.Forms.Button bt_Manager;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.Label lb_Password;
        private EmployeeDataSet employeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private EmployeeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_EID;
        private System.Windows.Forms.TextBox tb_EID;
        private System.Windows.Forms.Label lb_Email;
        private System.Windows.Forms.Label lb_RoleID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.Button bt_UploadImage;
        private System.Windows.Forms.PictureBox pb_PictureImage;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.DateTimePicker dt_Birthday;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.Label lb_Picture;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label lb_Birthday;
        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.DataGridViewImageColumn picDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}