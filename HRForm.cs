using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class HRForm : Form
    {
        public HRForm()
        {
            InitializeComponent();
        }
        Employee employee = new Employee();
        private void HRForm_Load(object sender, EventArgs e)
        {
            //DataGridView
            dataGridView1.DataSource = employee.GetAllEmployee();
            dataGridView1.RowTemplate.Height = 60;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView1.Rows.Count);
            lb_Total.Text = ("Total: " + totale);

            //ComboBox
            comboBox1.DataSource = employee.GetAllRole();
            comboBox1.ValueMember = "RoleID";
            comboBox1.DisplayMember = "Role";
            //comboBox1.SelectedItem = null;
   
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

                    // student form 10-100, may change
                    if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                    {
                        MessageBox.Show("The Employee Age Must Be Between 18 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ////Thứ Tự các cột: id - fname - lname - bd - gdr - phn - adrs -roleid -gmail- username - passwod  pic
            tb_EID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_FirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_LastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dt_Birthday.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            // Gender
            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")||(dataGridView1.CurrentRow.Cells[4].Value.ToString() == "female"))
            {
                RadioButtonFemale.Checked = true;
                RadioButtonMale.Checked = false;
            }
            else
            {
                RadioButtonMale.Checked = true;
                RadioButtonFemale.Checked = false;
            }

            tb_Phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_Address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            int c = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            comboBox1.SelectedIndex = c-1;
            tb_Email.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            tb_UserName.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tb_Password.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(pic));
            pb_PictureImage.Image = x;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ////Thứ Tự các cột: id - fname - lname - bd - gdr - phn - adrs -roleid -gmail- username - passwod  pic
            tb_EID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tb_FirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tb_LastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dt_Birthday.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            // Gender
            if ((dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female"))
            {
                RadioButtonFemale.Checked = true;
                RadioButtonMale.Checked = false;
            }
            else
            {
                RadioButtonMale.Checked = true;
                RadioButtonFemale.Checked = false;
            }

            tb_Phone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tb_Address.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            int c = Convert.ToInt32(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            comboBox1.Text = c.ToString();
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(pic));
            pb_PictureImage.Image = x;

            tb_Email.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            tb_UserName.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            tb_Password.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
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
            dataGridView1.ClearSelection();
        }
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            //DataGridView
            dataGridView1.DataSource = employee.GetAllEmployee();
            dataGridView1.RowTemplate.Height = 60;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView1.Rows.Count);
            lb_Total.Text = ("Total: " + totale);
            CleanFields();
        }
        private void bt_UploadImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.pngl*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pb_PictureImage.Image = Image.FromFile(opf.FileName);
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
            dataGridView1.DataSource = employee.GetManager();
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView1.Rows.Count);
            lb_Total.Text = ("Total: " + totale);
        }
        private void bt_Receptionist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employee.GetRecept();
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView1.Rows.Count);
            lb_Total.Text = ("Total: " + totale);
        }
        private void bt_Labourer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employee.GetLabour();
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView1.Rows.Count);
            lb_Total.Text = ("Total: " + totale);
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employee.SearchEmployee(tb_Search.Text);
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
            int totale = Convert.ToInt32(dataGridView1.Rows.Count);
            lb_Total.Text = ("Total: " + totale);
        }

    }
}
