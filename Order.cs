using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MultiFaceRec
{
    class Order
    {
        MY_DB mydb = new MY_DB();
        public bool insert(int RID, string Pname, int Price, int Amount, int Total)
        {

            SqlCommand command = new SqlCommand("INSERT INTO [order1] ( rid, Pname, price, amount, total ) VALUES  ( @id, @pn, @pr, @am, @tt )", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = RID;
            command.Parameters.Add("@pn", SqlDbType.NVarChar).Value = Pname;
            command.Parameters.Add("@pr", SqlDbType.Int).Value = Price;
            command.Parameters.Add("@am", SqlDbType.Int).Value = Amount;
            command.Parameters.Add("@tt", SqlDbType.Int).Value = Total;

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
        public bool Delete(string name)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [order1] WHERE pname= @name", mydb.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

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
        //Lấy Tất cả order của room đó dựa theo id phòng
        public DataTable GetOrderByID(int RoomID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Order1] WHERE Rid = @rid ", mydb.getConnection);
            command.Parameters.Add("rid", SqlDbType.Int).Value = RoomID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //tìm sự tồn tại  của 1 món nếu order nhiều lần
        public bool IfExist(string pname, int roomID)
        {
            SqlCommand command = new SqlCommand("select * From [order1] WHERE pname= " + "'" + pname.ToString() + "' And rid = @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.Int).Value = roomID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
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
        //update số lượng và giá cả món đã order nhiều lần thay vì thêm 1 dòng
        public bool UpdateExist(string pname, int roomID, int amount, int total)
        {
            SqlCommand command = new SqlCommand("UPDATE [order1] set Amount =@Am , total = @tt WHERE pname= " + "'" + pname.ToString() + "' And rid = @id", mydb.getConnection);
            command.Parameters.Add("id", SqlDbType.Int).Value = roomID;
            command.Parameters.Add("Am", SqlDbType.Int).Value = amount;
            command.Parameters.Add("tt", SqlDbType.Int).Value = total;
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
        //Lấy Tất cả order ở các phòng để kiếm duyệt kho (Table Consume)
        public DataTable ConsumeTableByRoom(int RoomID)
        {
            //SqlCommand command = new SqlCommand("select Pname, sum(amount) as Consumed from [order] where rid = @id group by Pname", mydb.getConnection); 
            SqlCommand command = new SqlCommand("select Pname, sum(amount) as Consumed from [order1] where Rid = @id group by Pname", mydb.getConnection);       // khoa chinh
            command.Parameters.Add("id", SqlDbType.Int).Value = RoomID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


    }
}
