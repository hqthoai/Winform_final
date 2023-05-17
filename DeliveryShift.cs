using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MultiFaceRec
{
    class DeliveryShift
    {
        Random random = new Random();
        MY_DB mydb = new MY_DB();
        Employee[] m = new Employee[2];     // Manager
        Employee[] r = new Employee[5];     // Reception
        Employee[] l = new Employee[9];     // labor

        DataTable table = new DataTable();
        int[,] manager = new int[2, 9];
        int[,] reception = new int[5, 9];
        int[,] labor = new int[9, 9];

        struct Employee
        {
            public int eid;
            public int position;
            public int total_nightshift;
            public int weeknd_night;
            public int total_shift;
        }
        public void delivery(ref int[,] a)
        {
            SqlCommand command = new SqlCommand("SELECT EID, RoleID FROM Employee", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);


            a = new int[table.Rows.Count, 9];
            int index1 = 0, index2 = 0, index3 = 0;

            //Đổ data từ SQL vào 3 mảng nhỏ manager, reception, labor
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //a[i,0] = Convert.ToInt32(table.Rows[i][0]);
                if (table.Rows[i][1].ToString().Trim() == "1")        //Manager
                {
                    //a[i, 1] = 1;
                    manager[index1, 0] = Convert.ToInt32(table.Rows[i][0]);
                    manager[index1, 1] = 1;

                    m[index1].eid = Convert.ToInt32(table.Rows[i][0]);
                    m[index1].position = 1;
                    index1++;
                }
                else if (table.Rows[i][1].ToString().Trim() == "2") //Reception
                {
                    //a[i, 1] = 2;
                    reception[index2, 0] = Convert.ToInt32(table.Rows[i][0]);
                    reception[index2, 1] = 2;

                    r[index2].eid = Convert.ToInt32(table.Rows[i][0]);
                    r[index2].position = 2;
                    index2++;
                }
                else
                {
                    //a[i, 1] = 3;
                    labor[index3, 0] = Convert.ToInt32(table.Rows[i][0]);
                    labor[index3, 1] = 3;

                    l[index3].eid = Convert.ToInt32(table.Rows[i][0]);
                    l[index3].position = 3;
                    index3++;
                }
            }
            algorithm(a, manager, reception, labor);

            ShiftForm sf = new ShiftForm();                         // form có textBox + button
            sf.a = a;
            for (int i = 0; i < 16; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    sf.textBox1.Text = sf.textBox1.Text + a[i, k] + "  ";
                }
                sf.textBox1.Text += "\r\n";
            }
            //sf.Show();            //VỪA CHỈNH SỬA
        }
        void algorithm(int[,] a, int[,] manager, int[,] reception, int[,] labor)
        {
            for (int i = 0; i < 16; i++)                //initialize the shift table
            {
                for (int j = 2; j < 9; j++)
                {
                    a[i, j] = 0;
                }
            }

            //Morning and Afternoon: 2 receptionists, 1 manager, 4 labors
            //Evening: 1 re or manager, 1 labor
            // Manager = 1; Receptionist = 2, Labor = 3
            //Morning = 1; Afternoon = 2, evening = 3

            // Saturday, Sunday: 1 manager or 1 receptionist + 3 labors

            //Night Shift:
            for (int i = 2; i < 9; i++)
            {
                if (i >= 2 && i <= 6)
                {
                    addShift_R(reception, i, 1, 3);
                    addShift_L(labor, i, 1, 3);
                }
                else
                {
                    addShift_M(manager, i, 3);
                }
            }


            for (int i = 2; i < 9; i++)          //Days of week
            {
                int shift = 1;

                if (i == 7 || i == 8)
                {
                    addShift_L(labor, i, 3, 3);              // 3 người
                }
                for (int j = 0; j < 2; j++)       //number of shift: 2 (morning and afternoon)
                {
                    if (i == 7 || i == 8)
                    {
                        addShift_L(labor, i, 3, shift);              // 3 người
                        addShift_R(reception, i, 1, shift);
                    }
                    else
                    {
                        addShift_M(manager, i, shift);          // 1 người
                        addShift_R(reception, i, 2, shift);          // 2 người
                        addShift_L(labor, i, 4, shift);              // 4 người
                    }
                    shift++;
                }

            }
            for (int i = 0; i < 2; i++)         //đổ manager vào mảng lớn
            {
                for (int j = 0; j < 9; j++)
                {
                    a[i, j] = manager[i, j];
                }
            }

            int x = 0;
            for (int i = 2; i < 7; i++)         //đổ reception vào mảng lớn
            {
                int y = 0;
                for (int j = 0; j < 9; j++)
                {
                    a[i, j] = reception[x, y];
                    y++;
                }
                x++;
            }

            int x2 = 0;
            for (int i = 7; i < 16; i++)        //đổ labor vào mảng lớn
            {
                int y = 0;
                for (int j = 0; j < 9; j++)
                {
                    a[i, j] = labor[x2, y];
                    y++;
                }
                x2++;
            }
        }
        void addShift_M(int[,] a, int days, int shift)
        {
            int check = 0;
            while (check == 0)
            {
                int j = random.Next(0, 2);
                if (m[j].total_nightshift < 1 && shift == 3)
                    for (int i = 0; i < 2; i++)
                    {
                        if (a[i, days] == 0)
                            if (m[j].eid == a[i, 0])            //Manager.eid == tableshift.eid
                            {
                                a[i, days] = shift;             //chia ca
                                check = 1;
                                m[j].total_nightshift++;
                            }
                    }
                else if (shift == 1 || shift == 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (a[i, days] == 0)
                            if (m[j].eid == a[i, 0])            //Manager.eid == tableshift.eid
                            {
                                a[i, days] = shift;             //chia ca
                                check = 1;
                            }
                    }
                }
            }
        }
        void addShift_R(int[,] a, int days, int numberOfEmp, int shift)
        {
            for (int t = 0; t < numberOfEmp; t++)                    //number of employee in a shift
            {
                int check = 0;
                while (check == 0)
                {
                    int j = random.Next(0, 5);
                    if (r[j].total_nightshift < 1 && shift == 3)
                        for (int i = 0; i < 5; i++)
                        {
                            if (a[i, days] == 0)
                                if (r[j].eid == a[i, 0])
                                {
                                    a[i, days] = shift;
                                    check = 1;
                                    r[j].total_nightshift++;
                                }
                        }
                    else if (shift < 3 && r[j].total_shift < 6)
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            if (a[i, days] == 0)
                                if (r[j].eid == a[i, 0])
                                {
                                    a[i, days] = shift;
                                    check = 1;
                                    r[j].total_shift++;
                                }
                        }
                    }
                }
            }
        }
        void addShift_L(int[,] a, int days, int numberOfEmp, int shift)
        {
            for (int t = 0; t < numberOfEmp; t++)            // lấy 4 lao công
            {
                int check = 0;                              // add được lao công thì check = 1 else check = 0
                while (check == 0)
                {
                    int j = random.Next(0, 9);              // random trong danh sách lao công
                    if (l[j].total_nightshift < 2 && l[j].weeknd_night < 1 && shift == 3)
                        for (int i = 0; i < 9; i++)             // chạy trong danh sách lao công, kiếm lao công = eid, và chưa có ca làm việc
                        {
                            if (a[i, days] == 0)
                                if (l[j].eid == a[i, 0])
                                {
                                    a[i, days] = shift;
                                    check = 1;
                                    if (days > 6)
                                        l[j].weeknd_night++;
                                    l[j].total_nightshift++;
                                }
                        }
                    else if (shift < 3)
                    {
                        for (int i = 0; i < 9; i++)             // chạy trong danh sách lao công, kiếm lao công = eid, và chưa có ca làm việc
                        {
                            if (a[i, days] == 0)
                                if (l[j].eid == a[i, 0])
                                {
                                    a[i, days] = shift;
                                    check = 1;
                                    l[j].total_shift++;
                                }
                        }
                    }
                }
            }
        }
        public bool addShiftToSql(string[] shift)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [Shift] (Id, position, monday, tuesday, wednesday, thursday, friday, saturday, sunday) VALUES (@Id, @position, @monday, @tuesday, @wednesday, @thursday, @friday, @saturday, @sunday)", mydb.getConnection);
            for (int i = 1; i < 9; i++)
            {
                if (i == 1)
                {
                    if (shift[i] == "1")
                        shift[i] = "Manager";
                    else if (shift[i] == "2")
                        shift[i] = "Reception";
                    else
                        shift[i] = "Labor";
                }
                else
                {
                    if (shift[i] == "1")
                        shift[i] = "Morning";
                    else if (shift[i] == "2")
                        shift[i] = "Afternoon";
                    else if (shift[i] == "3")
                        shift[i] = "Evening";
                    else
                        shift[i] = "Off";
                }
            }
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(shift[0]);
            command.Parameters.Add("@position", SqlDbType.NVarChar).Value = shift[1];
            command.Parameters.Add("@monday", SqlDbType.NVarChar).Value = shift[2];
            command.Parameters.Add("@tuesday", SqlDbType.NVarChar).Value = shift[3];
            command.Parameters.Add("@wednesday", SqlDbType.NVarChar).Value = shift[4];
            command.Parameters.Add("@thursday", SqlDbType.NVarChar).Value = shift[5];
            command.Parameters.Add("@friday", SqlDbType.NVarChar).Value = shift[6];
            command.Parameters.Add("@saturday", SqlDbType.NVarChar).Value = shift[7];
            command.Parameters.Add("@sunday", SqlDbType.NVarChar).Value = shift[8];
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            return false;
        }
        public bool deleteShiftToSql(string[] shift)
        {
            SqlCommand command = new SqlCommand("DELETE [Shift]", mydb.getConnection);
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            return false;
        }
    }
}
