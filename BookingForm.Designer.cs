
namespace MultiFaceRec
{
    partial class BookingForm
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
            this.txb_pupli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_RoomID = new System.Windows.Forms.Label();
            this.txb_GuestName = new System.Windows.Forms.TextBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.dtp_Leave = new System.Windows.Forms.DateTimePicker();
            this.dtp_Arrival = new System.Windows.Forms.DateTimePicker();
            this.txb_Price = new System.Windows.Forms.TextBox();
            this.txb_Days = new System.Windows.Forms.TextBox();
            this.lblChiTietSoDem = new System.Windows.Forms.Label();
            this.lblChiTietThanhTien = new System.Windows.Forms.Label();
            this.lblChiTietNgayDi = new System.Windows.Forms.Label();
            this.lblChiTietGiaPhong = new System.Windows.Forms.Label();
            this.lblChiTietTenBooking = new System.Windows.Forms.Label();
            this.lblChiTietLoaiPhong = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.Cbb_Service = new System.Windows.Forms.ComboBox();
            this.datagridview1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.newData = new MultiFaceRec.NewData();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Remove = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_Sum = new System.Windows.Forms.Label();
            this.hotelManagementDataSet = new MultiFaceRec.hotelManagementDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new MultiFaceRec.hotelManagementDataSetTableAdapters.OrderTableAdapter();
            this.newDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter1 = new MultiFaceRec.NewDataTableAdapters.OrderTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txb_pupli
            // 
            this.txb_pupli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_pupli.Location = new System.Drawing.Point(413, 256);
            this.txb_pupli.Name = "txb_pupli";
            this.txb_pupli.Size = new System.Drawing.Size(169, 27);
            this.txb_pupli.TabIndex = 162;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(327, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 161;
            this.label2.Text = "Pupils: ";
            // 
            // bt_Book
            // 
            this.bt_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Book.ForeColor = System.Drawing.Color.White;
            this.bt_Book.Location = new System.Drawing.Point(248, 418);
            this.bt_Book.Name = "bt_Book";
            this.bt_Book.Size = new System.Drawing.Size(113, 49);
            this.bt_Book.TabIndex = 158;
            this.bt_Book.Text = "Book";
            this.bt_Book.UseVisualStyleBackColor = false;
            this.bt_Book.Click += new System.EventHandler(this.bt_Book_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(327, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 157;
            this.label1.Text = "Phone:";
            // 
            // txb_Phone
            // 
            this.txb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Phone.Location = new System.Drawing.Point(413, 112);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(169, 27);
            this.txb_Phone.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 155;
            this.label3.Text = "Arrival:";
            // 
            // lb_RoomID
            // 
            this.lb_RoomID.AutoSize = true;
            this.lb_RoomID.BackColor = System.Drawing.Color.Transparent;
            this.lb_RoomID.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RoomID.ForeColor = System.Drawing.Color.Black;
            this.lb_RoomID.Location = new System.Drawing.Point(255, 58);
            this.lb_RoomID.Name = "lb_RoomID";
            this.lb_RoomID.Size = new System.Drawing.Size(83, 23);
            this.lb_RoomID.TabIndex = 154;
            this.lb_RoomID.Text = "RoomID: ";
            // 
            // txb_GuestName
            // 
            this.txb_GuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_GuestName.Location = new System.Drawing.Point(129, 115);
            this.txb_GuestName.Name = "txb_GuestName";
            this.txb_GuestName.Size = new System.Drawing.Size(149, 27);
            this.txb_GuestName.TabIndex = 153;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.BackColor = System.Drawing.Color.Transparent;
            this.lb_total.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.Black;
            this.lb_total.Location = new System.Drawing.Point(112, 266);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(22, 27);
            this.lb_total.TabIndex = 152;
            this.lb_total.Text = "0";
            // 
            // dtp_Leave
            // 
            this.dtp_Leave.CustomFormat = "";
            this.dtp_Leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Leave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Leave.Location = new System.Drawing.Point(413, 166);
            this.dtp_Leave.Name = "dtp_Leave";
            this.dtp_Leave.Size = new System.Drawing.Size(169, 27);
            this.dtp_Leave.TabIndex = 151;
            this.dtp_Leave.ValueChanged += new System.EventHandler(this.dtp_Leave_ValueChanged_1);
            this.dtp_Leave.Leave += new System.EventHandler(this.dtp_Leave_Leave_1);
            // 
            // dtp_Arrival
            // 
            this.dtp_Arrival.CustomFormat = "";
            this.dtp_Arrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Arrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Arrival.Location = new System.Drawing.Point(129, 163);
            this.dtp_Arrival.Name = "dtp_Arrival";
            this.dtp_Arrival.Size = new System.Drawing.Size(149, 27);
            this.dtp_Arrival.TabIndex = 150;
            this.dtp_Arrival.ValueChanged += new System.EventHandler(this.dtp_Arrival_ValueChanged);
            // 
            // txb_Price
            // 
            this.txb_Price.Enabled = false;
            this.txb_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Price.Location = new System.Drawing.Point(129, 207);
            this.txb_Price.Name = "txb_Price";
            this.txb_Price.Size = new System.Drawing.Size(149, 27);
            this.txb_Price.TabIndex = 149;
            // 
            // txb_Days
            // 
            this.txb_Days.Enabled = false;
            this.txb_Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Days.Location = new System.Drawing.Point(413, 206);
            this.txb_Days.Name = "txb_Days";
            this.txb_Days.Size = new System.Drawing.Size(169, 27);
            this.txb_Days.TabIndex = 148;
            // 
            // lblChiTietSoDem
            // 
            this.lblChiTietSoDem.AutoSize = true;
            this.lblChiTietSoDem.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietSoDem.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietSoDem.ForeColor = System.Drawing.Color.Black;
            this.lblChiTietSoDem.Location = new System.Drawing.Point(327, 207);
            this.lblChiTietSoDem.Name = "lblChiTietSoDem";
            this.lblChiTietSoDem.Size = new System.Drawing.Size(62, 23);
            this.lblChiTietSoDem.TabIndex = 146;
            this.lblChiTietSoDem.Text = "Day(s)";
            // 
            // lblChiTietThanhTien
            // 
            this.lblChiTietThanhTien.AutoSize = true;
            this.lblChiTietThanhTien.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietThanhTien.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietThanhTien.ForeColor = System.Drawing.Color.Black;
            this.lblChiTietThanhTien.Location = new System.Drawing.Point(14, 264);
            this.lblChiTietThanhTien.Name = "lblChiTietThanhTien";
            this.lblChiTietThanhTien.Size = new System.Drawing.Size(54, 23);
            this.lblChiTietThanhTien.TabIndex = 147;
            this.lblChiTietThanhTien.Text = "Total:";
            // 
            // lblChiTietNgayDi
            // 
            this.lblChiTietNgayDi.AutoSize = true;
            this.lblChiTietNgayDi.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietNgayDi.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietNgayDi.ForeColor = System.Drawing.Color.Black;
            this.lblChiTietNgayDi.Location = new System.Drawing.Point(330, 166);
            this.lblChiTietNgayDi.Name = "lblChiTietNgayDi";
            this.lblChiTietNgayDi.Size = new System.Drawing.Size(58, 23);
            this.lblChiTietNgayDi.TabIndex = 145;
            this.lblChiTietNgayDi.Text = "Leave:";
            // 
            // lblChiTietGiaPhong
            // 
            this.lblChiTietGiaPhong.AutoSize = true;
            this.lblChiTietGiaPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietGiaPhong.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietGiaPhong.ForeColor = System.Drawing.Color.Black;
            this.lblChiTietGiaPhong.Location = new System.Drawing.Point(14, 214);
            this.lblChiTietGiaPhong.Name = "lblChiTietGiaPhong";
            this.lblChiTietGiaPhong.Size = new System.Drawing.Size(52, 23);
            this.lblChiTietGiaPhong.TabIndex = 144;
            this.lblChiTietGiaPhong.Text = "Price:";
            // 
            // lblChiTietTenBooking
            // 
            this.lblChiTietTenBooking.AutoSize = true;
            this.lblChiTietTenBooking.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietTenBooking.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietTenBooking.ForeColor = System.Drawing.Color.Black;
            this.lblChiTietTenBooking.Location = new System.Drawing.Point(14, 115);
            this.lblChiTietTenBooking.Name = "lblChiTietTenBooking";
            this.lblChiTietTenBooking.Size = new System.Drawing.Size(110, 23);
            this.lblChiTietTenBooking.TabIndex = 143;
            this.lblChiTietTenBooking.Text = "Guest Name:";
            // 
            // lblChiTietLoaiPhong
            // 
            this.lblChiTietLoaiPhong.AutoSize = true;
            this.lblChiTietLoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTietLoaiPhong.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTietLoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.lblChiTietLoaiPhong.Location = new System.Drawing.Point(14, 58);
            this.lblChiTietLoaiPhong.Name = "lblChiTietLoaiPhong";
            this.lblChiTietLoaiPhong.Size = new System.Drawing.Size(83, 23);
            this.lblChiTietLoaiPhong.TabIndex = 142;
            this.lblChiTietLoaiPhong.Text = "RoomID: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.txb_pupli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_Phone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_RoomID);
            this.groupBox1.Controls.Add(this.txb_GuestName);
            this.groupBox1.Controls.Add(this.lb_total);
            this.groupBox1.Controls.Add(this.dtp_Leave);
            this.groupBox1.Controls.Add(this.dtp_Arrival);
            this.groupBox1.Controls.Add(this.txb_Price);
            this.groupBox1.Controls.Add(this.txb_Days);
            this.groupBox1.Controls.Add(this.lblChiTietThanhTien);
            this.groupBox1.Controls.Add(this.lblChiTietSoDem);
            this.groupBox1.Controls.Add(this.lblChiTietNgayDi);
            this.groupBox1.Controls.Add(this.lblChiTietGiaPhong);
            this.groupBox1.Controls.Add(this.lblChiTietTenBooking);
            this.groupBox1.Controls.Add(this.lblChiTietLoaiPhong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(23, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 336);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking Info";
            // 
            // lblTenDichVu
            // 
            this.lblTenDichVu.AutoSize = true;
            this.lblTenDichVu.BackColor = System.Drawing.Color.Transparent;
            this.lblTenDichVu.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDichVu.ForeColor = System.Drawing.Color.Black;
            this.lblTenDichVu.Location = new System.Drawing.Point(30, 360);
            this.lblTenDichVu.Name = "lblTenDichVu";
            this.lblTenDichVu.Size = new System.Drawing.Size(58, 19);
            this.lblTenDichVu.TabIndex = 145;
            this.lblTenDichVu.Text = "Service";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Black;
            this.lblSoLuong.Location = new System.Drawing.Point(343, 360);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(74, 19);
            this.lblSoLuong.TabIndex = 146;
            this.lblSoLuong.Text = "Quantity:";
            // 
            // Cbb_Service
            // 
            this.Cbb_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Service.FormattingEnabled = true;
            this.Cbb_Service.Location = new System.Drawing.Point(145, 360);
            this.Cbb_Service.Name = "Cbb_Service";
            this.Cbb_Service.Size = new System.Drawing.Size(121, 26);
            this.Cbb_Service.TabIndex = 147;
            // 
            // datagridview1
            // 
            this.datagridview1.AllowDrop = true;
            this.datagridview1.AllowUserToAddRows = false;
            this.datagridview1.AllowUserToDeleteRows = false;
            this.datagridview1.AllowUserToResizeRows = false;
            this.datagridview1.AutoGenerateColumns = false;
            this.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridview1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.datagridview1.DataSource = this.orderBindingSource1;
            this.datagridview1.Location = new System.Drawing.Point(70, 58);
            this.datagridview1.Name = "datagridview1";
            this.datagridview1.ReadOnly = true;
            this.datagridview1.RowHeadersVisible = false;
            this.datagridview1.RowHeadersWidth = 51;
            this.datagridview1.RowTemplate.Height = 24;
            this.datagridview1.Size = new System.Drawing.Size(707, 278);
            this.datagridview1.TabIndex = 148;
            this.datagridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RoomID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Service";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // orderBindingSource1
            // 
            this.orderBindingSource1.DataMember = "Order";
            this.orderBindingSource1.DataSource = this.newData;
            // 
            // newData
            // 
            this.newData.DataSetName = "NewData";
            this.newData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(429, 360);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 24);
            this.numericUpDown1.TabIndex = 149;
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Add.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.ForeColor = System.Drawing.Color.White;
            this.bt_Add.Location = new System.Drawing.Point(328, 425);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(89, 41);
            this.bt_Add.TabIndex = 150;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click_1);
            // 
            // bt_Remove
            // 
            this.bt_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Remove.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove.ForeColor = System.Drawing.Color.White;
            this.bt_Remove.Location = new System.Drawing.Point(441, 425);
            this.bt_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(78, 41);
            this.bt_Remove.TabIndex = 151;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.lb_Sum);
            this.groupBox2.Controls.Add(this.bt_Remove);
            this.groupBox2.Controls.Add(this.bt_Add);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.datagridview1);
            this.groupBox2.Controls.Add(this.Cbb_Service);
            this.groupBox2.Controls.Add(this.lblSoLuong);
            this.groupBox2.Controls.Add(this.lblTenDichVu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(782, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 488);
            this.groupBox2.TabIndex = 147;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services";
            // 
            // lb_Sum
            // 
            this.lb_Sum.AutoSize = true;
            this.lb_Sum.BackColor = System.Drawing.Color.Transparent;
            this.lb_Sum.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sum.ForeColor = System.Drawing.Color.Black;
            this.lb_Sum.Location = new System.Drawing.Point(572, 357);
            this.lb_Sum.Name = "lb_Sum";
            this.lb_Sum.Size = new System.Drawing.Size(60, 27);
            this.lb_Sum.TabIndex = 152;
            this.lb_Sum.Text = "Total";
            // 
            // hotelManagementDataSet
            // 
            this.hotelManagementDataSet.DataSetName = "hotelManagementDataSet";
            this.hotelManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.hotelManagementDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // newDataBindingSource
            // 
            this.newDataBindingSource.DataSource = this.newData;
            this.newDataBindingSource.Position = 0;
            // 
            // orderTableAdapter1
            // 
            this.orderTableAdapter1.ClearBeforeFill = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiFaceRec.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1629, 605);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_Book);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn rIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txb_pupli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_RoomID;
        private System.Windows.Forms.TextBox txb_GuestName;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.DateTimePicker dtp_Leave;
        private System.Windows.Forms.DateTimePicker dtp_Arrival;
        private System.Windows.Forms.TextBox txb_Price;
        private System.Windows.Forms.TextBox txb_Days;
        private System.Windows.Forms.Label lblChiTietSoDem;
        private System.Windows.Forms.Label lblChiTietThanhTien;
        private System.Windows.Forms.Label lblChiTietNgayDi;
        private System.Windows.Forms.Label lblChiTietGiaPhong;
        private System.Windows.Forms.Label lblChiTietTenBooking;
        private System.Windows.Forms.Label lblChiTietLoaiPhong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.ComboBox Cbb_Service;
        private System.Windows.Forms.DataGridView datagridview1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Remove;
        private System.Windows.Forms.GroupBox groupBox2;
        private hotelManagementDataSet hotelManagementDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private hotelManagementDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.BindingSource newDataBindingSource;
        private NewData newData;
        private System.Windows.Forms.BindingSource orderBindingSource1;
        private NewDataTableAdapters.OrderTableAdapter orderTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lb_Sum;
    }
}