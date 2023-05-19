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
        Employee[] m = new Employee[2];     // Manager - 2
        Employee[] r = new Employee[5];     // Reception  - 5
        Employee[] l = new Employee[9];     // labor - 9

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

        // đưa dữ liệu về lịch làm việc vào một đối tượng ShiftForm
        public void delivery(ref int[,] a)
        {
            //SqlCommand command = new SqlCommand("SELECT EID, RoleID FROM Employee", mydb.getConnection);
            SqlCommand command = new SqlCommand("SELECT eid, roleID FROM Employee", mydb.getConnection);    // khoa chinh
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
                    sf.textBox.Text = sf.textBox.Text + a[i, k] + "  ";
                }
                sf.textBox.Text += "\r\n";
            }
            //sf.Show();            //VỪA CHỈNH SỬA
        }

        void algorithm(int[,] a, int[,] manager, int[,] reception, int[,] labor)
        {
            // bảng lịch trình kích thước 16x9
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
            // 2, 3, 4, 5, 6, 7, CN
            // 2, 3, 4, 5, 6, 7, 8
            for (int i = 2; i < 9; i++)
            {
                if (i >= 2 && i <= 6)   // thứ 2 đến thứ 6
                {
                    addShift_R(reception, i, 1, 3); // 1 tiếp tân
                    addShift_L(labor, i, 1, 3);     // 1 lao công
                }
                else
                {
                    addShift_M(manager, i, 3);  // 1 quản lý cho ca đêm 
                }
            }


            // các ngày trong tuần nói chung: Từ t2 --> CN
            for (int i = 2; i < 9; i++)          //Days of week
            {
                int shift = 1;      // ca sáng

                if (i == 7 || i == 8)       // nếu thứ 7 hoặc chủ nhật 
                {
                    addShift_L(labor, i, 3, 3);              // 3 người lao công vào ca đêm
                }


                // Chạy từ ca sáng đến ca chiều
                for (int j = 0; j < 2; j++)       //number of shift: 2 (morning and afternoon)
                {
                    if (i == 7 || i == 8)       // nếu t7 hoặc CN
                    {
                        addShift_L(labor, i, 3, shift);              // 3 người lao công cho ca sáng
                        addShift_R(reception, i, 1, shift);         // 1 người tiếp tân cho ca sáng
                    }

                    // các ngày còn lại
                    else
                    {
                        addShift_M(manager, i, shift);          // 1 người
                        addShift_R(reception, i, 2, shift);          // 2 người
                        addShift_L(labor, i, 4, shift);              // 4 người
                    }
                    //j=0 xong ca sáng --> đến ca tối
                    shift++;

                    // j=1 xong ca tối. Hết ngày Sai điều kiện. Sang ngày thứ 3 và tiếp tục lặp 
                }

            }


            // có 2 người quản lý
            for (int i = 0; i < 2; i++)         //đổ manager vào mảng lớn a
            {
                for (int j = 0; j < 9; j++)
                {
                    a[i, j] = manager[i, j];        // mana[2, 9]
                }
            }

            int x = 0;      // chỉ số hàng
            // chạy từ T2-->T6 (5 lễ tân)
            for (int i = 2; i < 7; i++)         //đổ reception vào mảng lớn a
            {
                int y = 0;  // số cột
                for (int j = 0; j < 9; j++)
                {
                    a[i, j] = reception[x, y];
                    y++;
                }
                x++;
            }

            int x2 = 0;
            for (int i = 7; i < 16; i++)        //đổ labor vào mảng lớn a
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

        // chia ca cho manager
        void addShift_M(int[,] a, int days, int shift)
        {
            int check = 0;  // xác định ca làm việc được thêm vào hay chưa?

            while (check == 0)
            {
                int j = random.Next(0, 2);      // chọn 1 trong 2 thằng quản lý --> bắt quản lý làm việc 

                // nếu qly đc chọn chưa làm ca đêm và ca làm việc mới được thêm vào (shift==3 là ca đêm)
                // sẽ tìm kiếm trong mảng 2D a và thêm ca làm việc này vào trong bảng lịch trình a


                if (m[j].total_nightshift < 1 && shift == 3)
                    for (int i = 0; i < 2; i++)
                    {
                        if (a[i, days] == 0)
                            if (m[j].eid == a[i, 0])            //Manager.eid == tableshift.eid
                            {
                                a[i, days] = shift;             //chia ca
                                check = 1;
                                m[j].total_nightshift++;    // số ca đêm làm của quản lý được chọn tăng lên
                            }
                    }


                else if (shift == 1 || shift == 2) // không phải ca làm việc "đêm"
                {
                    
                    for (int i = 0; i < 2; i++)
                    {
                        // tìm kiếm các ô trống trong bảng lịch trình a
                        // thêm ca làm việc vào ô trống
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

        // chia ca cho nhân viên lễ tân - Receptionist
        void addShift_R(int[,] a, int days, int numberOfEmp, int shift)
        {
            // thêm lễ tân vào một ca làm việc
            for (int t = 0; t < numberOfEmp; t++)                    //number of employee in a shift
            {
                int check = 0;  // check là ca làm việc đã được thêm hay chưa?
                while (check == 0)
                {
                    int j = random.Next(0, 5);      // chọn 1 trong 5 để làm việc trong ca việc mới đc thêm vào

                    // chưa làm việc ca đêm và ca làm việc mới được thêm vào là một ca đêm
                    if (r[j].total_nightshift < 1 && shift == 3)
                        for (int i = 0; i < 5; i++)
                        {
                            // tìm kiếm ô trông trong lịch trình a
                            //thêm ca làm việc vào ô đó
                            if (a[i, days] == 0)
                                if (r[j].eid == a[i, 0])
                                {
                                    a[i, days] = shift;
                                    check = 1;
                                    r[j].total_nightshift++; //tăng số ca đêm đã làm của lễ tân
                                }
                        }

                    //ca mới đc thêm vào không phải ca đêm 
                    //ca làm việc đã làm của lễ tân vượt quá giới hạn được phép (6 ca/ tuần)
                    else if (shift < 3 && r[j].total_shift < 6)
                    {
                        // chạy tìm lễ tân khác
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

        // chia ca cho người lao công - labor
        void addShift_L(int[,] a, int days, int numberOfEmp, int shift)
        {
            for (int t = 0; t < numberOfEmp; t++)            // lấy 4 lao công
            {
                //xác định xem một ca làm việc đã được thêm vào hay chưa
                int check = 0;                              // add được lao công thì check = 1 else check = 0
                while (check == 0)
                {
                    int j = random.Next(0, 9);              // random trong danh sách lao công 1 trong 9 người
                    //chưa làm 2 "ca đêm" và chưa làm "ca đêm vào cuối tuần" (nếu ngày đó là thứ Bảy hoặc Chủ Nhật)
                    //và ca làm việc mới được thêm vào là một ca đêm
                    if (l[j].total_nightshift < 2 && l[j].weeknd_night < 1 && shift == 3)
                        for (int i = 0; i < 9; i++)             // chạy trong danh sách lao công, kiếm lao công = eid, và chưa có ca làm việc
                        {
                            //tìm kiếm các ô trống trong bảng lịch trình a 
                            if (a[i, days] == 0)
                                if (l[j].eid == a[i, 0])
                                {
                                    a[i, days] = shift; //thêm ca làm việc vào ô đó
                                    check = 1;
                                    if (days > 6)
                                        l[j].weeknd_night++; // tăng số ca đêm cuối tuần đã làm lên (nếu ngày đó là thứ Bảy hoặc Chủ Nhật).
                                    l[j].total_nightshift++; //tăng số ca đêm đã làm của lao động
                                }
                        }
                    
                    // không phải ca đêm
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
            //SqlCommand command = new SqlCommand("INSERT INTO [Shift] (Id, position, monday, tuesday,
            //wednesday, thursday, friday, saturday, sunday) VALUES (@Id, @position, @monday, @tuesday,
            //@wednesday, @thursday, @friday, @saturday, @sunday)", mydb.getConnection);

            SqlCommand command = new SqlCommand("INSERT INTO [Shift] (id, position, monday, tuesday, wednesday, " +
                "thursday, friday, saturday, sunday) VALUES (@Id, @position, @monday, @tuesday, " +
                "@wednesday, @thursday, @friday, @saturday, @sunday)", mydb.getConnection);     // khoa chinh
            for (int i = 1; i < 9; i++)
            {
                if (i == 1)
                {
                    if (shift[i] == "1")        // ca sáng
                        shift[i] = "Manager";
                    else if (shift[i] == "2")       // ca ca chiều
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
            //command.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(shift[0]);
            //command.Parameters.Add("@position", SqlDbType.NVarChar).Value = shift[1];
            //command.Parameters.Add("@monday", SqlDbType.NVarChar).Value = shift[2];
            //command.Parameters.Add("@tuesday", SqlDbType.NVarChar).Value = shift[3];
            //command.Parameters.Add("@wednesday", SqlDbType.NVarChar).Value = shift[4];
            //command.Parameters.Add("@thursday", SqlDbType.NVarChar).Value = shift[5];
            //command.Parameters.Add("@friday", SqlDbType.NVarChar).Value = shift[6];
            //command.Parameters.Add("@saturday", SqlDbType.NVarChar).Value = shift[7];
            //command.Parameters.Add("@sunday", SqlDbType.NVarChar).Value = shift[8];

            // khoa chinh
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(shift[0]);
            command.Parameters.Add("@position", SqlDbType.VarChar).Value = shift[1];
            command.Parameters.Add("@monday", SqlDbType.VarChar).Value = shift[2];
            command.Parameters.Add("@tuesday", SqlDbType.VarChar).Value = shift[3];
            command.Parameters.Add("@wednesday", SqlDbType.VarChar).Value = shift[4];
            command.Parameters.Add("@thursday", SqlDbType.VarChar).Value = shift[5];
            command.Parameters.Add("@friday", SqlDbType.VarChar).Value = shift[6];
            command.Parameters.Add("@saturday", SqlDbType.VarChar).Value = shift[7];
            command.Parameters.Add("@sunday", SqlDbType.VarChar).Value = shift[8];





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
