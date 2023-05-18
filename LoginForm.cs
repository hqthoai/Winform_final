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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        MY_DB db = new MY_DB();
       
        private void lb_Register_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            //MANAGER
            if (rdb_Manager.Checked == true)
            {
                //table username and password
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                //table gmail and password
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                DataTable table2 = new DataTable();

                //check username and password
                SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE username = @username And password = @password And RoleID = 1", db.getConnection);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                //check gmail and password
                SqlCommand command2 = new SqlCommand("SELECT * FROM Employee WHERE gmail = @gmail And password = @password And RoleID = 1", db.getConnection);
                command2.Parameters.Add("@gmail", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command2.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                adapter2.SelectCommand = command2;
                adapter2.Fill(table2);


                if ((table.Rows.Count > 0) || (table2.Rows.Count > 0))
                {

                    //gán biến id của Manager cho class global để mỗi Manager là mỗi lịch làm việc riêng
                    int ManagerID = Convert.ToInt16(table.Rows[0][0].ToString());
                    Global.SetGlobalWokerID(ManagerID);
                    int RoleID = Convert.ToInt16(table.Rows[0][8].ToString());
                    Global.SetGlobalRoleId(RoleID);
                    MessageBox.Show("Welcome Manager!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();

                    MainForm form = new MainForm();
                    form.Show(this);

                    //Gán biến form cho fromHR để gọi ngược lại loginform khi sign out
                    form.loginForm = this;
                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //RECEPTIONIST
            else if (rbt_Receptionist.Checked == true)
            {
                //table username and password
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                //table gmail and password
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                DataTable table2 = new DataTable();

                //check username and password
                SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE username = @username And password = @password  And RoleID = 2", db.getConnection);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                //check gmail and password
                SqlCommand command2 = new SqlCommand("SELECT * FROM Employee WHERE gmail = @gmail And password = @password  And RoleID = 2", db.getConnection);
                command2.Parameters.Add("@gmail", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command2.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                adapter2.SelectCommand = command2;
                adapter2.Fill(table2);


                if ((table.Rows.Count > 0) || (table2.Rows.Count > 0))
                {

                    //gán biến id của Manager cho class global để mỗi Manager là mỗi lịch làm việc riêng
                    int ReceptionistID = Convert.ToInt16(table.Rows[0][0].ToString());
                    Global.SetGlobalWokerID(ReceptionistID);
                    int RoleID = Convert.ToInt16(table.Rows[0][8].ToString());
                    Global.SetGlobalRoleId(RoleID);
                    MessageBox.Show("Welcome Receptionist!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();

                    MainForm form = new MainForm();
                    form.Show(this);

                    //Gán biến form cho fromHR để gọi ngược lại loginform khi sign out
                    form.loginForm = this;


                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbt_Labour.Checked == true)
            {
                //table username and password
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                //table gmail and password
                SqlDataAdapter adapter2 = new SqlDataAdapter();
                DataTable table2 = new DataTable();

                //check username and password
                SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE username = @username And password = @password And RoleID = 3", db.getConnection);
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                //check gmail and password
                SqlCommand command2 = new SqlCommand("SELECT * FROM Employee WHERE gmail = @gmail And password = @password And RoleID = 3", db.getConnection);
                command2.Parameters.Add("@gmail", SqlDbType.VarChar).Value = TextBoxUsername.Text;
                command2.Parameters.Add("@password", SqlDbType.VarChar).Value = TextBoxPassword.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                adapter2.SelectCommand = command2;
                adapter2.Fill(table2);


                if ((table.Rows.Count > 0) || (table2.Rows.Count > 0))
                {

                    //gán biến id của Manager cho class global để mỗi Manager là mỗi lịch làm việc riêng
                    int LabourID = Convert.ToInt16(table.Rows[0][0].ToString());
                    Global.SetGlobalWokerID(LabourID);
                    int RoleID = Convert.ToInt16(table.Rows[0][8].ToString());
                    Global.SetGlobalRoleId(RoleID);
                    MessageBox.Show("Welcome Labour!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();

                    MainForm form = new MainForm();
                    form.Show(this);

                    //Gán biến form cho fromHR để gọi ngược lại loginform khi sign out
                    form.loginForm = this;


                }
                else
                {
                    MessageBox.Show("Invalid Username Or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Chose User Type", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
