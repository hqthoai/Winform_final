using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFaceRec
{
    internal class Bill
    {
        MY_DB mydb = new MY_DB();
        Order order = new Order();
        public DataTable GetOrderByRID(int RoomID)
        {
           
            
            DataTable table = new DataTable();
            order.GetOrderByID(RoomID);

            return table;
        }

        public DataTable GetAllBill()
        {
            SqlCommand command = new SqlCommand("SELECT Room.Type as TypeofRoom, Gname as CusNam, Phone as PhoneNum, Arrival as ArrvialDate," +
                " Leave as LeaveDate,RPrice as RoomPrice, SPrice as SerPrice, TotalPrice as Total " +
                "FROM Bill join Room on Room.RID = Bill.RID", mydb.getConnection);
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable GetBillByID(int RoomID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Bill WHERE RID = @rid ", mydb.getConnection);
            command.Parameters.Add("@rid", SqlDbType.Int).Value = RoomID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insert(int RID, string gname, string phone, int pupil, DateTime Arrrival, DateTime Leave, int rPrice, int sPrice)
        {

            SqlCommand command = new SqlCommand("insert into Bill values (@id, @gn, @pn, @peo, @arr,  @lea, @rP, @sP, @tP)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = RID;
            command.Parameters.Add("@gn", SqlDbType.NVarChar).Value = gname;
            //command.Parameters.Add("@pn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@pn", SqlDbType.VarChar).Value = phone;    // khoa chinh
            command.Parameters.Add("@peo", SqlDbType.Int).Value = pupil;
            command.Parameters.Add("@arr", SqlDbType.Date).Value = Arrrival;
            command.Parameters.Add("@lea", SqlDbType.Date).Value = Leave;
            command.Parameters.Add("@rP", SqlDbType.Int).Value = rPrice;
            command.Parameters.Add("@sP", SqlDbType.Int).Value = sPrice;
            command.Parameters.Add("@tP", SqlDbType.Int).Value = rPrice+sPrice;
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
        public bool update(int RID, string gname, string phone, int pupil, DateTime Arrrival, DateTime Leave, int rPrice, int sPrice)
        {

            SqlCommand command = new SqlCommand("Update Bill SET gname = @new, phone=@pn, pupil = @peo, arrival = @arr, leave= @lea , RPrice = @rP , SPrice = @sP , TotalPrice=@tP" +
                                                 " Where Rid = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = RID;
            command.Parameters.Add("@gn", SqlDbType.NVarChar).Value = gname;
            //command.Parameters.Add("@pn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@pn", SqlDbType.VarChar).Value = phone;    // khoa chinh
            command.Parameters.Add("@peo", SqlDbType.Int).Value = pupil;
            command.Parameters.Add("@arr", SqlDbType.Date).Value = Arrrival;
            command.Parameters.Add("@lea", SqlDbType.Date).Value = Leave;
            command.Parameters.Add("@rP", SqlDbType.Int).Value = rPrice;
            command.Parameters.Add("@sP", SqlDbType.Int).Value = sPrice;
            command.Parameters.Add("@tP", SqlDbType.Int).Value = rPrice + sPrice;
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

        public bool delete(int RID)
        {
            SqlCommand command = new SqlCommand("delete from Bill where Rid = @id", mydb.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = RID;

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



    }
}
