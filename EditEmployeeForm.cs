using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class EditEmployeeForm : Form
    {
        MY_DB mydb = new MY_DB();
        Employee employee = new Employee();
        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verif())
                {
                    int eID = Convert.ToInt32(tb_ID.Text);

                    string phone = tb_Phone.Text;
                    string email = tb_Email.Text;
                    string adrs = tb_Address.Text;

                    MemoryStream pic = new MemoryStream();
                    pb_PictureImage.Image.Save(pic, pb_PictureImage.Image.RawFormat);
                    string username = tb_UserName.Text;
                    string password = tb_Password.Text;


                    //EID, fname, lname, bdate, gender, phone, email, adrs, RoleID, pic, username, password
                    //public bool UpdateInfor(int EID, string phone, string email, string addr, string uname, string pass, MemoryStream pic)
                    {
                        if (employee.UpdateInfor(eID, phone, email, adrs, username, password, pic))
                        {
                            MessageBox.Show("Edit Successfully!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure. Click 'Yes' To Exit this Form!", "Edit User", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*gif)|*.jpg;*.pngl*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pb_PictureImage.Image = Image.FromFile(opf.FileName);
            }
        }



        bool Verif()
        {
            if (tb_ID.Text.Trim() == "" ||
                 (tb_Phone.Text.Trim() == "")
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

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Employee] where eid=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Global.GlobalRoleID1;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {

                //table = HRuser.GetHR(Global.GlobalUserID1);
                tb_ID.Text = table.Rows[0]["eid"].ToString();
                tb_Address.Text = table.Rows[0]["address"].ToString();
                tb_Email.Text = table.Rows[0]["gmail"].ToString();
                tb_Password.Text = table.Rows[0]["password"].ToString();
                tb_UserName.Text = table.Rows[0]["username"].ToString();
                tb_Phone.Text = table.Rows[0]["phone"].ToString();

                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream ms = new MemoryStream(pic);
                pb_PictureImage.Image = Image.FromStream(ms);
            }

            tb_ID.ReadOnly = true;
            tb_UserName.ReadOnly = true;
        }
    }
}
