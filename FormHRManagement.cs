using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class lbl_Close : Form
    {
        Employee employee = new Employee();
        internal LoginForm loginForm;

        public lbl_Close()
        {
            InitializeComponent();
        }

        private void bt_Upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.pngl*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pb_PictureImage.Image = Image.FromFile(opf.FileName);
            }
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            //DataGridView
            dataGridView.DataSource = employee.GetAllEmployee();
            dataGridView.RowTemplate.Height = 60;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView.ClearSelection();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView.Rows.Count);
            lb_Total.Text = ("Total: " + totale);
            CleanFields();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verif())
                {
                    int EID = Convert.ToInt32(tb_EID.Text);
                    string fname = tb_FirstName.Text;
                    string lname = tb_LastName.Text;
                    DateTime bdate = dt_Birthday.Value;
                    string gender = "Male";
                    string phone = tb_Phone.Text;
                    string email = tb_Email.Text;
                    string adrs = tb_Address.Text;
                    int RoleID = Convert.ToInt32(comboBox1.SelectedValue);
                    MemoryStream pic = new MemoryStream();
                    pb_PictureImage.Image.Save(pic, pb_PictureImage.Image.RawFormat);
                    string username = tb_UserName.Text;
                    string password = tb_Password.Text;
                    if (RadioButtonFemale.Checked)
                    {
                        gender = "Female";
                    }
                    int born_year = dt_Birthday.Value.Year;
                    int this_year = DateTime.Now.Year;
                    if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("The Employee Age Must Be Between 18 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!CheckEmail(tb_Email.Text))
                    {
                        MessageBox.Show("Hãy Nhập Đúng Định Dạng Của Gmail", "HR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (employee.CheckEID(EID))
                        {
                            if (employee.CheckUserName(username, EID))
                            {
                                if (employee.insert(EID, fname, lname, bdate, gender, phone, email, adrs, RoleID, pic, username, password))
                                {
                                    if (RoleID == 1) MessageBox.Show("New Manager Added!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (RoleID == 2) MessageBox.Show("New Receptionist Added!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (RoleID == 3) MessageBox.Show("New Labour Added!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanFields();
                                    bt_Refresh_Click(null, null);
                                }
                                else
                                {
                                    MessageBox.Show("Error Accours While Adding New Employee!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("UserName Existed!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ID Existed!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Error: " + E.Message, "Adding New Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verif())
                {
                    int EID = Convert.ToInt32(tb_EID.Text);
                    string fname = tb_FirstName.Text;
                    string lname = tb_LastName.Text;
                    DateTime bdate = dt_Birthday.Value;
                    string gender = "Male";
                    string phone = tb_Phone.Text;
                    string email = tb_Email.Text;
                    string adrs = tb_Address.Text;
                    int RoleID = Convert.ToInt32(comboBox1.SelectedValue);
                    MemoryStream pic = new MemoryStream();
                    pb_PictureImage.Image.Save(pic, pb_PictureImage.Image.RawFormat);
                    string username = tb_UserName.Text;
                    string password = tb_Password.Text;
                    if (RadioButtonFemale.Checked)
                    {
                        gender = "Female";
                    }
                    int born_year = dt_Birthday.Value.Year;
                    int this_year = DateTime.Now.Year;
                    if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("The Employee Age Must Be Between 18 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!CheckEmail(tb_Email.Text))
                    {
                        MessageBox.Show("Hãy Nhập Đúng Định Dạng Của Gmail", "HR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    else
                    {
                        if (employee.Update(EID, fname, lname, bdate, gender, phone, email, adrs, RoleID, pic, username, password))
                        {
                            if (RoleID == 1) MessageBox.Show("Manager Edited!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (RoleID == 2) MessageBox.Show("Receptionist Edited!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (RoleID == 3) MessageBox.Show("Labour Edited!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CleanFields();
                            bt_Refresh_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Error Accours While Editing Employee!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb_EID.Text);
                int RoleID = Convert.ToInt32(comboBox1.SelectedValue);
                if ((MessageBox.Show("Are you sure want to delete this Employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (employee.Delete(id))
                    {
                        if (RoleID == 1) MessageBox.Show("Manager Deleted!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (RoleID == 2) MessageBox.Show("Receptionist Deleted!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (RoleID == 3) MessageBox.Show("Labour Deleted!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanFields();
                        bt_Refresh_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Employee Not Deleted", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        private void bt_Manager_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = employee.GetManager();
            dataGridView.ClearSelection();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView.Rows.Count);
            lb_Total.Text = ("Total: " + totale);
        }

        private void bt_Receptionist_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = employee.GetRecept();
            dataGridView.ClearSelection();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView.Rows.Count);
            lb_Total.Text = ("Total: " + totale);
        }

        private void bt_Labourer_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = employee.GetLabour();
            dataGridView.ClearSelection();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView.Rows.Count);
            lb_Total.Text = ("Total: " + totale);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = employee.SearchEmployee(tb_Search.Text);
            dataGridView.ClearSelection();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView.Rows.Count);
            lb_Total.Text = ("Total: " + totale);
        }

        private void tb_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_FirstName_TextChanged(object sender, EventArgs e)
        {
            // Define regular expression pattern
            string pattern = @"^[a-zA-Z\s\u0080-\uFFFF]*$";


            // Check if input matches pattern
            if (!Regex.IsMatch(tb_FirstName.Text, pattern))
            {
                // Display error message
                MessageBox.Show("Không được nhập số", "" +
                    "Human Resource",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tb_FirstName.Text = ""; // Clear the textbox
            }
        }

        private void tb_LastName_TextChanged(object sender, EventArgs e)
        {
            // Define regular expression pattern
            string pattern = @"^[a-zA-Z\s\u0080-\uFFFF]*$";


            // Check if input matches pattern
            if (!Regex.IsMatch(tb_LastName.Text, pattern))
            {
                // Display error message
                MessageBox.Show("Không được nhập số", "" +
                    "Human Resource",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                tb_LastName.Text = ""; // Clear the textbox
            }
        }

        private void tb_EID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập Số!", "Human Resource", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập Số!", "Human Resource", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormHRManagement_Load(object sender, EventArgs e)
        {

            //DataGridView
            dataGridView.DataSource = employee.GetAllEmployee();
            dataGridView.RowTemplate.Height = 60;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView.ClearSelection();
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView.Rows.Count);
            lb_Total.Text = ("Total: " + totale);

            //ComboBox
            comboBox1.DataSource = employee.GetAllRole();
            comboBox1.ValueMember = "RoleID";
            comboBox1.DisplayMember = "Role";
            //comboBox1.SelectedItem = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////Thứ Tự các cột: id - fname - lname - bd - gdr - phn - adrs -roleid -gmail- username - passwod  pic
            tb_EID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            tb_FirstName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            tb_LastName.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            dt_Birthday.Value = (DateTime)dataGridView.CurrentRow.Cells[3].Value;

            // Gender
            if ((dataGridView.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                RadioButtonFemale.Checked = true;
                RadioButtonMale.Checked = false;
            }
            else
            {
                RadioButtonMale.Checked = true;
                RadioButtonFemale.Checked = false;
            }

            tb_Phone.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            tb_Address.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            int c = Convert.ToInt32(dataGridView.CurrentRow.Cells[8].Value.ToString());
            comboBox1.Text = c.ToString();
            byte[] pic;
            pic = (byte[])dataGridView.CurrentRow.Cells[7].Value;
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(pic));
            pb_PictureImage.Image = x;

            tb_Email.Text = dataGridView.CurrentRow.Cells[11].Value.ToString();
            tb_UserName.Text = dataGridView.CurrentRow.Cells[9].Value.ToString();
            tb_Password.Text = dataGridView.CurrentRow.Cells[10].Value.ToString();
        }

        bool Verif()
        {
            if ((tb_EID.Text.Trim() == "")
                || (tb_FirstName.Text.Trim() == "")
                || (tb_LastName.Text.Trim() == "")
                || (tb_Phone.Text.Trim() == "")
                || (tb_Email.Text.Trim() == "")
                || (tb_Address.Text.Trim() == "")
                || (tb_UserName.Text.Trim() == "")
                || (tb_Password.Text.Trim() == "")
                || (pb_PictureImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void CleanFields()
        {
            tb_EID.Text = "";
            tb_FirstName.Text = "";
            tb_LastName.Text = "";
            tb_Phone.Text = "";
            tb_Email.Text = "";
            tb_Address.Text = "";
            tb_UserName.Text = "";
            tb_Password.Text = "";
            tb_Search.Text = "";
            pb_PictureImage.Image = null;
            comboBox1.SelectedItem = null;
            dt_Birthday.Value = DateTime.Now;
            dataGridView.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ////Thứ Tự các cột: id - fname - lname - bd - gdr - phn - adrs -roleid -gmail- username - passwod  pic
            tb_EID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            tb_FirstName.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            tb_LastName.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            dt_Birthday.Value = (DateTime)dataGridView.CurrentRow.Cells[3].Value;

            // Gender
            if ((dataGridView.CurrentRow.Cells[4].Value.ToString() == "Female") || (dataGridView.CurrentRow.Cells[4].Value.ToString() == "female"))
            {
                RadioButtonFemale.Checked = true;
                RadioButtonMale.Checked = false;
            }
            else
            {
                RadioButtonMale.Checked = true;
                RadioButtonFemale.Checked = false;
            }

            tb_Phone.Text = dataGridView.CurrentRow.Cells[5].Value.ToString();
            tb_Address.Text = dataGridView.CurrentRow.Cells[6].Value.ToString();
            int c = Convert.ToInt32(dataGridView.CurrentRow.Cells[8].Value.ToString());
            comboBox1.SelectedIndex = c - 1;
            tb_Email.Text = dataGridView.CurrentRow.Cells[11].Value.ToString();
            tb_UserName.Text = dataGridView.CurrentRow.Cells[9].Value.ToString();
            tb_Password.Text = dataGridView.CurrentRow.Cells[10].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView.CurrentRow.Cells[7].Value;
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(pic));
            pb_PictureImage.Image = x;
        }

        // hàm kiểm tra nhập gmail
        private bool CheckEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@gmail\.com$");
                if (!regex.IsMatch(email))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
