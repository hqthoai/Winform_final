using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
namespace MultiFaceRec
{
    class Storage
    {
        MY_DB mydb = new MY_DB();
        public bool insert(int Pid, string Pname, int quanity, int price)
        {
            //SqlCommand command = new SqlCommand("INSERT INTO Storage (Pid, Pname, quanity, price)" +
            //                                                 " VALUES (@id, @pn, @qn, @pr)", mydb.getConnection);


            SqlCommand command = new SqlCommand("INSERT INTO Storage (Pid, pname, quanity, price)" +
                                                             " VALUES (@id, @pn, @qn, @pr)", mydb.getConnection);   // khoa chinh
            command.Parameters.Add("@id", SqlDbType.Int).Value = Pid;
            command.Parameters.Add("@pn", SqlDbType.NVarChar).Value = Pname;
            command.Parameters.Add("@qn", SqlDbType.Int).Value = quanity;
            command.Parameters.Add("@pr", SqlDbType.Int).Value = price;


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
        public bool Update(int Pid, string Pname, int quanity, int price)
        {
            SqlCommand command = new SqlCommand("UPDATE Storage SET pname = @pn, quanity = @qn, price = @pr" +
                                                             " WHERE Pid = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Pid;
            command.Parameters.Add("@pn", SqlDbType.NVarChar).Value = Pname;
            command.Parameters.Add("@qn", SqlDbType.Int).Value = quanity;
            command.Parameters.Add("@pr", SqlDbType.Int).Value = price;

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
        public bool UpdateStorage(int Pid, int quanity)
        {
            //SqlCommand command = new SqlCommand("UPDATE Storage SET  quanity = @qn" + " WHERE Pid = @id", mydb.getConnection);
            SqlCommand command = new SqlCommand("UPDATE Storage SET  quanity = @qn" + " WHERE Pid = @id", mydb.getConnection); // khoa chinh
            command.Parameters.Add("@id", SqlDbType.Int).Value = Pid;
            command.Parameters.Add("@qn", SqlDbType.Int).Value = quanity;
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
        public bool Delete(int Pid)
        {
            //SqlCommand command = new SqlCommand("DELETE FROM Storage WHERE pid = @eid", mydb.getConnection);
            SqlCommand command = new SqlCommand("DELETE FROM Storage WHERE Pid = @eid", mydb.getConnection); // khoa chinh
            command.Parameters.Add("@eid", SqlDbType.Int).Value = Pid;
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
        //Lấy danh sách tất cả món ăn
        public DataTable GetAllProduct()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Storage ", mydb.getConnection);
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool CheckEID(int PID)
        {
            //SqlCommand command = new SqlCommand("SELECT * FROM Storage where pid = @eid", mydb.getConnection);
            SqlCommand command = new SqlCommand("SELECT * FROM Storage where Pid = @eid", mydb.getConnection); // khoa chinh
            command.Parameters.Add("@eid", SqlDbType.Int).Value = PID;
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
        public bool CheckUserName(string ProductName, int Pid)
        {
            //SqlCommand command = new SqlCommand("SELECT * FROM Storage where pname = @un and pid <> @eid", mydb.getConnection);
            SqlCommand command = new SqlCommand("SELECT * FROM Storage where pname = @un and Pid <> @eid", mydb.getConnection); // khoa chinh
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = ProductName;
            command.Parameters.Add("@eid", SqlDbType.Int).Value = Pid;
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
        public DataTable GetAllProductByID(int Pid)
        {
            //SqlCommand command = new SqlCommand("SELECT Pname, price FROM Storage Where Pid = @id", mydb.getConnection);
            SqlCommand command = new SqlCommand("SELECT pname, price FROM Storage Where Pid = @id", mydb.getConnection); // khoa chinh
            command.Parameters.Add("@id", SqlDbType.Int).Value = Pid;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable StatictisTable()
        {
            //SqlCommand command = new SqlCommand("select Pname, quanity, pid from storage", mydb.getConnection);
            SqlCommand command = new SqlCommand("select pname, quanity, Pid from Storage", mydb.getConnection); // khoa chinh
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
