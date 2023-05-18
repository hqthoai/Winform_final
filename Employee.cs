using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace MultiFaceRec
{
    class Employee
    {
        MY_DB mydb = new MY_DB();
        //Thêm 1 nhân viên mới
        public bool insert(int EID, string fname, string lname, DateTime bDate, string gender, string phone, string email, string addr, int roleID, MemoryStream pic, string uname, string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Employee (eid, fname, lname, bdate, gender, phone, address, pic, roleID, username, password, gmail )" +
                                                             " VALUES (@id, @fn, @ln, @bdt,@gdr,@phn,@adrs,@pic, @rID, @uname, @pwd, @gm)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = EID;
            //command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;    // khoa chinh
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.Date).Value = bDate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = addr;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            command.Parameters.Add("@rID", SqlDbType.Int).Value = roleID;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@pwd", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@gm", SqlDbType.VarChar).Value = email;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //Xóa nhân viên dựa theo id
        public bool Delete(int EmployeeID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Employee WHERE eid = @eid", mydb.getConnection);
            command.Parameters.Add("@eid", SqlDbType.Int).Value = EmployeeID;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //Cập Nhật Lại Nhân viên
        public bool Update(int EID, string fname, string lname, DateTime bDate, string gender, string phone, string email, string addr, int roleID, MemoryStream pic, string uname, string pass)
        {
            SqlCommand command = new SqlCommand("UPDATE Employee SET fname= @fn , lname = @ln, bdate = @bdt, gender = @gdr, phone = @phn, address =@adrs , pic =@pic, roleID = @rID, username = @uname, password = @pwd, gmail =@gm" +
                                                             " WHERE eid = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = EID;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.Date).Value = bDate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = addr;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            command.Parameters.Add("@rID", SqlDbType.Int).Value = roleID;
            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@pwd", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@gm", SqlDbType.VarChar).Value = email;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }


        //Cập Nhật Lại Nhân viên
        public bool UpdateInfor(int EID, string phone, string email, string addr, string uname, string pass, MemoryStream pic)
        {
            SqlCommand command = new SqlCommand("UPDATE Employee SET phone = @phn, address =@adrs , pic =@pic, username = @uname, password = @pwd, gmail =@gm" +
                                                             " WHERE eid = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = EID;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = addr;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();

            command.Parameters.Add("@uname", SqlDbType.VarChar).Value = uname;
            command.Parameters.Add("@pwd", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@gm", SqlDbType.VarChar).Value = email;

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }




        //Lấy danh sách tất cả nhân viên
        public DataTable GetAllEmployee()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Employee ", mydb.getConnection);
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Lấy toàn bộ vai trò
        public DataTable GetAllRole()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Role ", mydb.getConnection);
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Dùng ID để kiếm Employee
        public DataTable GetEmployeeByID(int GlobalEID_ID)
        {
            //SqlCommand command = new SqlCommand("SELECT * FROM Employee Where Eid = @EID", mydb.getConnection);
            SqlCommand command = new SqlCommand("SELECT * FROM Employee Where eid = @EID", mydb.getConnection);     // khoa chinh
            command.Parameters.Add("@EID", SqlDbType.Int).Value = GlobalEID_ID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //Cập Nhật Thông Tin Cơ Bản Cho Employee (Dùng Trong MainForm)
        public bool UpdateBasicInfo(string Phone, string Email, string Address, string username, string password, MemoryStream pic, int EmployeeID)
        {
            SqlCommand command = new SqlCommand("UPDATE Employee SET phone = @pn, gmail = @gm, address = @ad, username = @un , password = @pass, pic = @pic WHERE eid = @eid", mydb.getConnection);
            command.Parameters.Add("pn", SqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@gm", SqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@ad", SqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = pic.ToArray();
            command.Parameters.Add("@eid", SqlDbType.Int).Value = EmployeeID;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }
        //Kiểm tra sự tồn tại của username trước Khi ADD/EDIT
        public bool CheckUserName(string username, int employeeID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Employee where username = @un and eid <> @eid", mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        //Kiểm tra sự tồn tại của ID trước khi ADD/EDIT
        public bool CheckEID(int employeeID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Employee where eid = @eid", mydb.getConnection);
            command.Parameters.Add("@eid", SqlDbType.Int).Value = employeeID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }
        }
        public DataTable GetManager()
        {
            //SqlCommand command = new SqlCommand("select * from employee where roleid = 1 ", mydb.getConnection);
            SqlCommand command = new SqlCommand("select * from Employee where roleID = 1 ", mydb.getConnection);    // khoa chinh
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable GetRecept()
        {
            //SqlCommand command = new SqlCommand("select * from employee where roleid = 2", mydb.getConnection);
            SqlCommand command = new SqlCommand("select * from Employee where roleID = 2", mydb.getConnection);     // khoa chinh
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable GetLabour()
        {
            //SqlCommand command = new SqlCommand("select * from employee where roleid = 3 ", mydb.getConnection);/
            SqlCommand command = new SqlCommand("select * from Employee where roleID = 3 ", mydb.getConnection);
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable SearchEmployee(string SearchText)
        {
            //SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE CONCAT(fname, lname, username, roleID) LIKE '%" + SearchText + "%'", mydb.getConnection);
            SqlCommand command = new SqlCommand("SELECT * FROM Employee WHERE CONCAT(fname, lname, username, roleID) LIKE '%" + SearchText + "%'", mydb.getConnection);     // khoa chinh
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }





    }
}
