
namespace MultiFaceRec
{
    partial class StorageForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Reset = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Remove = new Guna.UI2.WinForms.Guna2Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bt_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Add = new Guna.UI2.WinForms.Guna2Button();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_EID = new System.Windows.Forms.Label();
            this.tb_PID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.piDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quanity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet = new MultiFaceRec.hotelManagementDataSet();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.storageTableAdapter = new MultiFaceRec.hotelManagementDataSetTableAdapters.StorageTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Reset);
            this.groupBox1.Controls.Add(this.bt_Remove);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.bt_Edit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bt_Add);
            this.groupBox1.Controls.Add(this.tb_Price);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Controls.Add(this.lb_EID);
            this.groupBox1.Controls.Add(this.tb_PID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(26, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Info";
            // 
            // bt_Reset
            // 
            this.bt_Reset.BorderRadius = 15;
            this.bt_Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Reset.FillColor = System.Drawing.Color.Lime;
            this.bt_Reset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Reset.ForeColor = System.Drawing.Color.White;
            this.bt_Reset.Location = new System.Drawing.Point(23, 345);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(361, 41);
            this.bt_Reset.TabIndex = 145;
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
            this.bt_Remove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(203)))), ((int)(((byte)(80)))));
            this.bt_Remove.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Remove.ForeColor = System.Drawing.Color.White;
            this.bt_Remove.Location = new System.Drawing.Point(283, 272);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(128, 41);
            this.bt_Remove.TabIndex = 144;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(117, 192);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(117, 31);
            this.numericUpDown1.TabIndex = 121;
            // 
            // bt_Edit
            // 
            this.bt_Edit.BorderRadius = 15;
            this.bt_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.bt_Edit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Edit.ForeColor = System.Drawing.Color.White;
            this.bt_Edit.Location = new System.Drawing.Point(149, 272);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(128, 41);
            this.bt_Edit.TabIndex = 143;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 120;
            this.label3.Text = "Price:";
            // 
            // bt_Add
            // 
            this.bt_Add.BorderRadius = 15;
            this.bt_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.bt_Add.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.bt_Add.ForeColor = System.Drawing.Color.White;
            this.bt_Add.Location = new System.Drawing.Point(6, 272);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(128, 41);
            this.bt_Add.TabIndex = 142;
            this.bt_Add.Text = "Add";
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(117, 150);
            this.tb_Price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(200, 27);
            this.tb_Price.TabIndex = 119;
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Price_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 116;
            this.label1.Text = "Name:";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(117, 105);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(200, 27);
            this.tb_Name.TabIndex = 115;
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Name_TextChanged);
            // 
            // lb_EID
            // 
            this.lb_EID.AutoSize = true;
            this.lb_EID.BackColor = System.Drawing.Color.Transparent;
            this.lb_EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EID.ForeColor = System.Drawing.Color.Black;
            this.lb_EID.Location = new System.Drawing.Point(34, 59);
            this.lb_EID.Name = "lb_EID";
            this.lb_EID.Size = new System.Drawing.Size(46, 20);
            this.lb_EID.TabIndex = 114;
            this.lb_EID.Text = "PID:";
            // 
            // tb_PID
            // 
            this.tb_PID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PID.Location = new System.Drawing.Point(117, 59);
            this.tb_PID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_PID.Name = "tb_PID";
            this.tb_PID.Size = new System.Drawing.Size(200, 27);
            this.tb_PID.TabIndex = 113;
            this.tb_PID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_PID_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.piDDataGridViewTextBoxColumn,
            this.pNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.Quanity});
            this.dataGridView1.DataSource = this.storageBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(531, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 60;
            this.dataGridView1.Size = new System.Drawing.Size(623, 252);
            this.dataGridView1.TabIndex = 75;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // piDDataGridViewTextBoxColumn
            // 
            this.piDDataGridViewTextBoxColumn.DataPropertyName = "PiD";
            this.piDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.piDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.piDDataGridViewTextBoxColumn.Name = "piDDataGridViewTextBoxColumn";
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "PName";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Quanity
            // 
            this.Quanity.DataPropertyName = "Quanity";
            this.Quanity.HeaderText = "Quanity";
            this.Quanity.MinimumWidth = 6;
            this.Quanity.Name = "Quanity";
            // 
            // storageBindingSource
            // 
            this.storageBindingSource.DataMember = "Storage";
            this.storageBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "HotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Refresh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Refresh.Location = new System.Drawing.Point(976, 391);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(167, 48);
            this.bt_Refresh.TabIndex = 4;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // storageTableAdapter
            // 
            this.storageTableAdapter.ClearBeforeFill = true;
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiFaceRec.Properties.Resources._48bc45ff496120273edb97a4089d2115;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 560);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_EID;
        private System.Windows.Forms.TextBox tb_PID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_Refresh;
        private hotelManagementDataSet hotelManagementDataSet;
        private System.Windows.Forms.BindingSource storageBindingSource;
        private hotelManagementDataSetTableAdapters.StorageTableAdapter storageTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn piDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quanity;
        private Guna.UI2.WinForms.Guna2Button bt_Remove;
        private Guna.UI2.WinForms.Guna2Button bt_Edit;
        private Guna.UI2.WinForms.Guna2Button bt_Add;
        private Guna.UI2.WinForms.Guna2Button bt_Reset;
    }
}