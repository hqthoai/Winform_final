namespace MultiFaceRec
{
    partial class CheckAttendanceForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb_Date = new System.Windows.Forms.Label();
            this.bt_CheckAttendace = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.bt_Start = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_YearBorn = new System.Windows.Forms.TextBox();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.lb_NumberRegcon = new System.Windows.Forms.Label();
            this.lb_RegconPerSon = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Stop = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lb_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.bt_Stastictis = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox_Active = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Date.ForeColor = System.Drawing.Color.Red;
            this.lb_Date.Location = new System.Drawing.Point(35, 23);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(36, 25);
            this.lb_Date.TabIndex = 23;
            this.lb_Date.Text = "00";
            // 
            // bt_CheckAttendace
            // 
            this.bt_CheckAttendace.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_CheckAttendace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CheckAttendace.ForeColor = System.Drawing.Color.White;
            this.bt_CheckAttendace.Location = new System.Drawing.Point(252, 145);
            this.bt_CheckAttendace.Name = "bt_CheckAttendace";
            this.bt_CheckAttendace.Size = new System.Drawing.Size(124, 61);
            this.bt_CheckAttendace.TabIndex = 16;
            this.bt_CheckAttendace.Text = "Điểm Danh";
            this.bt_CheckAttendace.UseVisualStyleBackColor = false;
            this.bt_CheckAttendace.Click += new System.EventHandler(this.bt_CheckAttendace_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reset.ForeColor = System.Drawing.Color.White;
            this.bt_Reset.Location = new System.Drawing.Point(400, 20);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(124, 47);
            this.bt_Reset.TabIndex = 15;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // bt_Start
            // 
            this.bt_Start.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Start.ForeColor = System.Drawing.Color.White;
            this.bt_Start.Location = new System.Drawing.Point(252, 21);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(124, 47);
            this.bt_Start.TabIndex = 14;
            this.bt_Start.Text = "Start";
            this.bt_Start.UseVisualStyleBackColor = false;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add.Location = new System.Drawing.Point(428, 110);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(134, 40);
            this.bt_Add.TabIndex = 13;
            this.bt_Add.Text = "Add";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // txb_ID
            // 
            this.txb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ID.Location = new System.Drawing.Point(265, 120);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(127, 28);
            this.txb_ID.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.bt_Add);
            this.groupBox1.Controls.Add(this.txb_ID);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txb_YearBorn);
            this.groupBox1.Controls.Add(this.txb_Name);
            this.groupBox1.Controls.Add(this.lb_NumberRegcon);
            this.groupBox1.Controls.Add(this.lb_RegconPerSon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(67, 420);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 186);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Dữ Liệu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(294, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "MSSV";
            // 
            // txb_YearBorn
            // 
            this.txb_YearBorn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_YearBorn.Location = new System.Drawing.Point(428, 45);
            this.txb_YearBorn.Name = "txb_YearBorn";
            this.txb_YearBorn.Size = new System.Drawing.Size(134, 28);
            this.txb_YearBorn.TabIndex = 10;
            // 
            // txb_Name
            // 
            this.txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Name.Location = new System.Drawing.Point(265, 45);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(127, 28);
            this.txb_Name.TabIndex = 9;
            // 
            // lb_NumberRegcon
            // 
            this.lb_NumberRegcon.AutoSize = true;
            this.lb_NumberRegcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NumberRegcon.ForeColor = System.Drawing.Color.Red;
            this.lb_NumberRegcon.Location = new System.Drawing.Point(24, 151);
            this.lb_NumberRegcon.Name = "lb_NumberRegcon";
            this.lb_NumberRegcon.Size = new System.Drawing.Size(20, 22);
            this.lb_NumberRegcon.TabIndex = 8;
            this.lb_NumberRegcon.Text = "0";
            // 
            // lb_RegconPerSon
            // 
            this.lb_RegconPerSon.AutoSize = true;
            this.lb_RegconPerSon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RegconPerSon.ForeColor = System.Drawing.Color.Red;
            this.lb_RegconPerSon.Location = new System.Drawing.Point(24, 73);
            this.lb_RegconPerSon.Name = "lb_RegconPerSon";
            this.lb_RegconPerSon.Size = new System.Drawing.Size(72, 22);
            this.lb_RegconPerSon.TabIndex = 7;
            this.lb_RegconPerSon.Text = "Nobody";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số người phát hiện được";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên người nhận diện";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(475, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Năm sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(294, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên";
            // 
            // bt_Stop
            // 
            this.bt_Stop.BackColor = System.Drawing.Color.Red;
            this.bt_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Stop.ForeColor = System.Drawing.Color.White;
            this.bt_Stop.Location = new System.Drawing.Point(400, 145);
            this.bt_Stop.Name = "bt_Stop";
            this.bt_Stop.Size = new System.Drawing.Size(124, 61);
            this.bt_Stop.TabIndex = 17;
            this.bt_Stop.Text = "Dừng";
            this.bt_Stop.UseVisualStyleBackColor = false;
            this.bt_Stop.Click += new System.EventHandler(this.bt_Stop_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.Color.Red;
            this.lb_time.Location = new System.Drawing.Point(35, 57);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(36, 25);
            this.lb_time.TabIndex = 22;
            this.lb_time.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.imageBox1);
            this.groupBox2.Controls.Add(this.bt_Stastictis);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.listBox_Active);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.bt_Stop);
            this.groupBox2.Controls.Add(this.bt_CheckAttendace);
            this.groupBox2.Controls.Add(this.bt_Reset);
            this.groupBox2.Controls.Add(this.bt_Start);
            this.groupBox2.Location = new System.Drawing.Point(702, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(588, 594);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Thông Tin";
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(26, 21);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(220, 185);
            this.imageBox1.TabIndex = 33;
            this.imageBox1.TabStop = false;
            // 
            // bt_Stastictis
            // 
            this.bt_Stastictis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_Stastictis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Stastictis.ForeColor = System.Drawing.Color.White;
            this.bt_Stastictis.Location = new System.Drawing.Point(400, 73);
            this.bt_Stastictis.Name = "bt_Stastictis";
            this.bt_Stastictis.Size = new System.Drawing.Size(124, 41);
            this.bt_Stastictis.TabIndex = 32;
            this.bt_Stastictis.Text = "Thống kê";
            this.bt_Stastictis.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(169, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(198, 48);
            this.label12.TabIndex = 29;
            this.label12.Text = "Check In Time";
            // 
            // listBox_Active
            // 
            this.listBox_Active.FormattingEnabled = true;
            this.listBox_Active.ItemHeight = 16;
            this.listBox_Active.Location = new System.Drawing.Point(60, 281);
            this.listBox_Active.Name = "listBox_Active";
            this.listBox_Active.Size = new System.Drawing.Size(394, 148);
            this.listBox_Active.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_Date);
            this.groupBox3.Controls.Add(this.lb_time);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(61, 445);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 95);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thời Gian";
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(67, 12);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(594, 380);
            this.imageBoxFrameGrabber.TabIndex = 11;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // CheckAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MultiFaceRec.Properties.Resources._243c235be38865bb05ef056fd81422a3;
            this.ClientSize = new System.Drawing.Size(1394, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckAttendanceForm";
            this.Text = "CheckIn";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Button bt_CheckAttendace;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_YearBorn;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label lb_NumberRegcon;
        private System.Windows.Forms.Label lb_RegconPerSon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Stop;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button bt_Stastictis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox_Active;
        private System.Windows.Forms.GroupBox groupBox3;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
    }
}

