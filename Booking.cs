using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace MultiFaceRec
{
    class Booking
    {
        MY_DB mydb = new MY_DB();
        public DataTable GetRoomByID(int RoomID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE Rid = @rid ", mydb.getConnection);
            command.Parameters.Add("@rid", SqlDbType.Int).Value = RoomID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insert(int RID, string gname, string phone,int pupil, DateTime Arrrival, DateTime Leave, int price, int status)
        {

            SqlCommand command = new SqlCommand("insert into Booking values (@id, @gn, @pn, @peo, @arr,  @lea, @pr, @sta)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = RID;
            command.Parameters.Add("@gn", SqlDbType.NVarChar).Value = gname;
            //command.Parameters.Add("@pn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@pn", SqlDbType.VarChar).Value = phone;    // khoa chinh
            command.Parameters.Add("@peo", SqlDbType.Int).Value = pupil;
            command.Parameters.Add("@arr", SqlDbType.Date).Value = Arrrival;
            command.Parameters.Add("@lea", SqlDbType.Date).Value = Leave;
            command.Parameters.Add("@pr", SqlDbType.Int).Value = price;
            command.Parameters.Add("@sta", SqlDbType.Int).Value = status;

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
        public bool update(int RID, string gname, string phone, int pupil, DateTime Arrrival, DateTime Leave, int price, int status)
        {

            SqlCommand command = new SqlCommand("Update Booking SET gname = @new, phone=@pn, pupil = @peo, arrival = @arr, leave= @lea , price = @pr , status = @sta " +
                                                 " Where Rid = @id", mydb.getConnection);

            command.Parameters.Add("@new", SqlDbType.NVarChar).Value = gname;
            command.Parameters.Add("@peo", SqlDbType.Int).Value = pupil;
            command.Parameters.Add("@pn", SqlDbType.NVarChar).Value = phone;
            command.Parameters.Add("@arr", SqlDbType.Date).Value = Arrrival;
            command.Parameters.Add("@lea", SqlDbType.Date).Value = Leave;
            command.Parameters.Add("@pr", SqlDbType.Int).Value = price;
            command.Parameters.Add("@sta", SqlDbType.Int).Value = status;
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

        public bool delete(int RID)
        {
            SqlCommand command = new SqlCommand("delete from Booking where Rid = @id", mydb.getConnection);

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
        //Select all booking
        public DataTable GetBookingByID(int RoomID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Booking WHERE Rid = @rid ", mydb.getConnection);
            command.Parameters.Add("@rid", SqlDbType.Int).Value = RoomID;
            mydb.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
