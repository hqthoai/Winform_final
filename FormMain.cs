using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class FormMain : Form
    {
        public Form loginForm;
        Employee employee = new Employee();
        public FormMain()
        {
            InitializeComponent();
        }

        private void bt_HumanResource_Click(object sender, EventArgs e)
        {
            FormHRManagement HRF = new FormHRManagement();
            HRF.Show();
        }

        private void bt_ManageShift_Click(object sender, EventArgs e)
        {
            ShiftForm SF = new ShiftForm();
            SF.Show(this);
        }

        private void lb_Edit_Click(object sender, EventArgs e)
        {
            EditEmployeeForm EHRF = new EditEmployeeForm();
            EHRF.Show(this);
            FormMain_Load(null, null);
        }

        private void lb_LogOut_Click(object sender, EventArgs e)
        {
            loginForm.Visible = true;
            this.Close();
        }

        private void bt_Checkin_Click(object sender, EventArgs e)
        {
            CheckAttendanceForm CAF = new CheckAttendanceForm();
            CAF.Show(this);
        }

        private void bt_Checkout_Click(object sender, EventArgs e)
        {

        }

        private void bt_Shift_Click(object sender, EventArgs e)
        {
            EShiftForm ESF = new EShiftForm(Global.GlobalWokerID1);
            ESF.Show(this);
        }

        private void bt_Room_Click(object sender, EventArgs e)
        {
            EditRoomForm ERF = new EditRoomForm();
            ERF.Show(this);
        }

        private void bt_Bill_Click(object sender, EventArgs e)
        {
            BillForm billForm = new BillForm();
            billForm.Show(this);
        }

        private void bt_Salary_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_Stored_Click(object sender, EventArgs e)
        {
            StorageForm SF = new StorageForm();
            SF.Show(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            #region Load Form Hình ảnh và các dòng chữ welcome
            DataTable table = new DataTable();
            table = employee.GetEmployeeByID(Global.GlobalWokerID1);
            byte[] pic = (byte[])table.Rows[0]["pic"];
            MemoryStream ms = new MemoryStream(pic);
            CirclePictureBox.Image = Image.FromStream(ms);

            if (Global.GlobalRoleID1 == 1)
            {
                lb_Welcome.Text = ("Welcome Manager (" + table.Rows[0]["EID"].ToString() + ")");
            }
            if (Global.GlobalRoleID1 == 2)
            {
                lb_Welcome.Text = ("Welcome Receptionist (" + table.Rows[0]["EID"].ToString() + ")");
                bt_HumanResource.Enabled = false;
                bt_HumanResource.Visible = false;
                bt_Salary.Enabled = false;
                bt_Salary.Visible = false;
                bt_Stored.Enabled = false;
                bt_Stored.Visible = false;
                bt_ManageShift.Visible = false;

            }

            if (Global.GlobalRoleID1 == 3)
            {
                lb_Welcome.Text = ("Welcome Labour (" + table.Rows[0]["EID"].ToString() + ")");
                bt_HumanResource.Enabled = false;
                bt_HumanResource.Visible = false;
                bt_Salary.Enabled = false;
                bt_Salary.Visible = false;
                bt_Stored.Enabled = false;
                bt_Stored.Visible = false;
                bt_Room.Visible = false;
                bt_Bill.Visible = false;
                bt_ManageShift.Visible = false;
            }


            lb_FnameLname.Text = (table.Rows[0]["fname"].ToString() + " " + table.Rows[0]["lname"].ToString());

            #endregion
        }
    }
}
