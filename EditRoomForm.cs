using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class EditRoomForm : Form
    {
        public EditRoomForm()
        {
            InitializeComponent();
        }
        Booking book = new Booking();
        DataTable table = new DataTable();
        Order order = new Order();
        Storage storage = new Storage();
        Bill bill = new Bill();
        private void EditRoomForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            #region Room 1

            table = book.GetBookingByID(1);
            if (table.Rows.Count > 0)
            {
                if (Convert.ToInt32(table.Rows[0][7].ToString()) == 1)                 //nếu đã book
                {
                    #region Load Room1
                    lb_Guest1.Text = table.Rows[0][1].ToString();
                    lb_Phone1.Text = table.Rows[0][2].ToString();
                    lb_pupil1.Text = table.Rows[0][3].ToString();
                    DateTime arrive = DateTime.Parse(table.Rows[0][4].ToString());
                    lb_Arrival1.Text = arrive.ToString("dd/MM/yyyy");
                    DateTime leave = DateTime.Parse(table.Rows[0][5].ToString());
                    lb_Leave1.Text = leave.ToString("dd/MM/yyyy");
                    lb_Status1.ForeColor = Color.Red;
                    lb_Status1.Text = "Occupied";
                    bt_BookRoom1.Enabled = false;
                    bt_CheckOut1.Enabled = false;

                    #endregion
                    #region kiểm tra đã tới ngày checkout hay chưa
                    DateTime Leave1 = DateTime.Parse(table.Rows[0][5].ToString());  //lấy ngày checkout
                    DateTime now = DateTime.Today;                                  //lấy ngày today dự theo thời gian của máy tính (có thể thay đổi)
                    int day = (now - Leave1).Days;
                    if (day >= 0)                                   //đến ngày trả phòng thì cho check out và cho book, nếu chưa thì ko cho book 
                    {
                        bt_CheckOut1.Enabled = true;
                    }
                    else
                    {
                        bt_BookRoom1.Enabled = false;
                    }
                    #endregion
                }
                //else                                //nếu chwua book => cho book ko cho check out
                //{
                //    bt_CheckOut1.Enabled = false;
                //    bt_BookRoom1.Enabled = true;
                //}
            }
            #endregion
            #region Room 2

            table = book.GetBookingByID(2);
            if (table.Rows.Count > 0)
            {
                if (Convert.ToInt32(table.Rows[0][7].ToString()) == 1)                 //nếu đã book
                {
                    #region Load Room1
                    lb_Guest2.Text = table.Rows[0][1].ToString();
                    lb_Phone2.Text = table.Rows[0][2].ToString();
                    lb_pupil2.Text = table.Rows[0][3].ToString();
                    DateTime arrive = DateTime.Parse(table.Rows[0][4].ToString());
                    lb_Arrival2.Text = arrive.ToString("dd/MM/yyyy");
                    DateTime leave = DateTime.Parse(table.Rows[0][5].ToString());
                    lb_Leave2.Text = leave.ToString("dd/MM/yyyy");
                    lb_Status2.ForeColor = Color.Red;
                    lb_Status2.Text = "Occupied";
                    bt_BookRoom2.Enabled = false;
                    bt_CheckOut2.Enabled = false;
                    #endregion
                    #region kiểm tra đã tới ngày checkout hay chưa
                    DateTime Leave1 = DateTime.Parse(table.Rows[0][5].ToString());  //lấy ngày checkout
                    DateTime now = DateTime.Today;                                  //lấy ngày today dự theo thời gian của máy tính (có thể thay đổi)
                    int day = (now - Leave1).Days;
                    if (day >= 0)                                   //đến ngày trả phòng thì cho check out và cho book, nếu chưa thì ko cho book 
                    {
                        bt_CheckOut2.Enabled = true;
                    }

                    #endregion
                }
                //else                                //nếu chwua book => cho book ko cho check out
                //{
                //    bt_CheckOut2.Enabled = false;
                //    bt_BookRoom2.Enabled = true;
                //}
            }
            #endregion
            #region Room 3
            table = book.GetBookingByID(3);
            if (table.Rows.Count > 0)
            {
                if (Convert.ToInt32(table.Rows[0][7].ToString()) == 1)                 //nếu đã book
                {
                    #region Load Room1
                    lb_Guest3.Text = table.Rows[0][1].ToString();
                    lb_Phone3.Text = table.Rows[0][2].ToString();
                    lb_pupil3.Text = table.Rows[0][3].ToString();
                    DateTime arrive = DateTime.Parse(table.Rows[0][4].ToString());
                    lb_Arrival3.Text = arrive.ToString("dd/MM/yyyy");
                    DateTime leave = DateTime.Parse(table.Rows[0][5].ToString());
                    lb_Leave3.Text = leave.ToString("dd/MM/yyyy");
                    lb_Status3.ForeColor = Color.Red;
                    lb_Status3.Text = "Occupied";
                    bt_BookRoom3.Enabled = false;
                    bt_CheckOut3.Enabled = true;
                    #endregion
                    #region kiểm tra đã tới ngày checkout hay chưa
                    DateTime Leave1 = DateTime.Parse(table.Rows[0][5].ToString());  //lấy ngày checkout
                    DateTime now = DateTime.Today;                                  //lấy ngày today dự theo thời gian của máy tính (có thể thay đổi)
                    int day = (now - Leave1).Days;
                    if (day >= 0)                                   //đến ngày trả phòng thì cho check out và cho book, nếu chưa thì ko cho book 
                    {
                        bt_CheckOut3.Enabled = true;
                    }
                    else
                    {
                        bt_BookRoom3.Enabled = false;
                    }
                    #endregion
                }
                //else                                //nếu chwua book => cho book ko cho check out
                //{
                //    bt_CheckOut3.Enabled = false;
                //    bt_BookRoom3.Enabled = true;
                //}
            }
            #endregion
            #region Room 4
            table = book.GetBookingByID(4);
            if (table.Rows.Count > 0)
            {

                if (Convert.ToInt32(table.Rows[0][7].ToString()) == 1)                 //nếu đã book
                {
                    #region Load Room1
                    lb_Guest4.Text = table.Rows[0][1].ToString();
                    lb_Phone4.Text = table.Rows[0][2].ToString();
                    lb_pupil4.Text = table.Rows[0][3].ToString();
                    DateTime arrive = DateTime.Parse(table.Rows[0][4].ToString());
                    lb_Arrival4.Text = arrive.ToString("dd/MM/yyyy");
                    DateTime leave = DateTime.Parse(table.Rows[0][5].ToString());
                    lb_Leave4.Text = leave.ToString("dd/MM/yyyy");
                    lb_Status4.ForeColor = Color.Red;
                    lb_Status4.Text = "Occupied";
                    bt_BookRoom4.Enabled = false;
                    bt_CheckOut4.Enabled = true;
                    #endregion
                    #region kiểm tra đã tới ngày checkout hay chưa
                    DateTime Leave1 = DateTime.Parse(table.Rows[0][5].ToString());  //lấy ngày checkout
                    DateTime now = DateTime.Today;                                  //lấy ngày today dự theo thời gian của máy tính (có thể thay đổi)
                    int day = (now - Leave1).Days;
                    if (day >= 0)                                   //đến ngày trả phòng thì cho check out và cho book, nếu chưa thì ko cho book 
                    {
                        bt_CheckOut4.Enabled = true;
                    }
                    else
                    {
                        bt_BookRoom4.Enabled = false;
                    }
                    #endregion
                }
                //else                                //nếu chwua book => cho book ko cho check out
                //{
                //    bt_CheckOut4.Enabled = false;
                //    bt_BookRoom4.Enabled = true;
                //} 
            }
            #endregion
            #region Room 5
            table = book.GetBookingByID(5);

            if (table.Rows.Count > 0)
            {


                if (Convert.ToInt32(table.Rows[0][7].ToString()) == 1)                 //nếu đã book
                {
                    #region Load Room1
                    lb_Guest5.Text = table.Rows[0][1].ToString();
                    lb_Phone5.Text = table.Rows[0][2].ToString();
                    lb_pupil5.Text = table.Rows[0][3].ToString();
                    DateTime arrive = DateTime.Parse(table.Rows[0][4].ToString());
                    lb_Arrival5.Text = arrive.ToString("dd/MM/yyyy");
                    DateTime leave = DateTime.Parse(table.Rows[0][5].ToString());
                    lb_Leave5.Text = leave.ToString("dd/MM/yyyy");
                    lb_Status5.ForeColor = Color.Red;
                    lb_Status5.Text = "Occupied";
                    bt_BookRoom5.Enabled = false;
                    bt_CheckOut5.Enabled = true;
                    #endregion
                    #region kiểm tra đã tới ngày checkout hay chưa
                    DateTime Leave1 = DateTime.Parse(table.Rows[0][5].ToString());  //lấy ngày checkout
                    DateTime now = DateTime.Today;                                  //lấy ngày today dự theo thời gian của máy tính (có thể thay đổi)
                    int day = (now - Leave1).Days;
                    if (day >= 0)                                   //đến ngày trả phòng thì cho check out và cho book, nếu chưa thì ko cho book 
                    {
                        bt_CheckOut5.Enabled = true;
                    }
                    else
                    {
                        bt_BookRoom5.Enabled = false;
                    }
                    #endregion
                }
                //else                                //nếu chwua book => cho book ko cho check out
                //{
                //    bt_CheckOut5.Enabled = false;
                //    bt_BookRoom5.Enabled = true;
                //}
            }
            #endregion
            #region Room 6
            table = book.GetBookingByID(6);
            if (table.Rows.Count > 0)
            {


                if (Convert.ToInt32(table.Rows[0][7].ToString()) == 1)                 //nếu đã book
                {
                    #region Load Room1
                    lb_Guest6.Text = table.Rows[0][1].ToString();
                    lb_Phone6.Text = table.Rows[0][2].ToString();
                    lb_pupil6.Text = table.Rows[0][3].ToString();
                    DateTime arrive = DateTime.Parse(table.Rows[0][4].ToString());
                    lb_Arrival6.Text = arrive.ToString("dd/MM/yyyy");
                    DateTime leave = DateTime.Parse(table.Rows[0][5].ToString());
                    lb_Leave6.Text = leave.ToString("dd/MM/yyyy");
                    lb_Status6.ForeColor = Color.Red;
                    lb_Status6.Text = "Occupied";
                    bt_BookRoom6.Enabled = false;
                    bt_CheckOut6.Enabled = true;
                    #endregion
                    #region kiểm tra đã tới ngày checkout hay chưa
                    DateTime Leave1 = DateTime.Parse(table.Rows[0][5].ToString());  //lấy ngày checkout
                    DateTime now = DateTime.Today;                                  //lấy ngày today dự theo thời gian của máy tính (có thể thay đổi)
                    int day = (now - Leave1).Days;
                    if (day >= 0)                                   //đến ngày trả phòng thì cho check out và cho book, nếu chưa thì ko cho book 
                    {
                        bt_CheckOut6.Enabled = true;
                    }
                    else
                    {
                        bt_BookRoom6.Enabled = false;
                    }
                    #endregion
                }
                //else                                //nếu chwua book => cho book ko cho check out
                //{
                //    bt_CheckOut6.Enabled = false;
                //    bt_BookRoom6.Enabled = true;
                //}
            }
            #endregion
        }
        #region Book Room  Click
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = DateTime.Now.ToString("T");
            lb_Date.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            //EditRoomForm_Load(null, null);
        }
        private void bt_BookRoom1_Click(object sender, EventArgs e)
        {
            int roomid = 1;
            BookingForm BF = new BookingForm(roomid);
            BF.Show(this);
        }
        private void bt_BookRoom2_Click(object sender, EventArgs e)
        {
            int roomid = 2;
            BookingForm BF = new BookingForm(roomid);
            BF.Show(this);
        }
        private void bt_BookRoom3_Click(object sender, EventArgs e)
        {
            int roomid = 3;
            BookingForm BF = new BookingForm(roomid);
            BF.Show(this);
        }
        private void bt_BookRoom4_Click(object sender, EventArgs e)
        {
            int roomid = 4;
            BookingForm BF = new BookingForm(roomid);
            BF.Show(this);
        }
        private void bt_BookRoom5_Click(object sender, EventArgs e)
        {
            int roomid = 5;
            BookingForm BF = new BookingForm(roomid);
            BF.Show(this);
        }
        private void bt_BookRoom6_Click(object sender, EventArgs e)
        {
            int roomid = 6;
            BookingForm BF = new BookingForm(roomid);
            BF.Show(this);
        }
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            EditRoomForm_Load(null, null);
        }
        #endregion

        #region Check Out Click
        private void bt_CheckOut1_Click(object sender, EventArgs e)
        {
            try
            {
                int roomID = 1;

                DataTable dt = book.GetBookingByID(roomID); 
                if (dt.Rows.Count > 0)
                {
                    bill.insert(roomID, dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(),Int32.Parse(dt.Rows[0][3].ToString()), DateTime.Parse( dt.Rows[0][4].ToString()), DateTime.Parse( dt.Rows[0][5].ToString()), Int32.Parse(dt.Rows[0][6].ToString()), Int32.Parse(dt.Rows[0][8].ToString()));
                }
                

                #region Update lại table booking
                DateTime arrive = DateTime.Today.Date;
                DateTime leave = DateTime.Today.Date;

                if (book.delete(roomID))
                {
                    #region Load Room1
                    lb_Guest1.Text = ".........................................";
                    lb_Phone1.Text = ".........................................";
                    lb_pupil1.Text = ".........................................";
                    lb_Arrival1.Text = ".........................................";
                    lb_Leave1.Text = ".........................................";
                    lb_Status1.ForeColor = Color.Lime;
                    lb_Status1.Text = "Vacant";
                    bt_BookRoom1.Enabled = true;
                    bt_CheckOut1.Enabled = false;
                    #endregion
                    MessageBox.Show("CheckOut Successfully!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CheckOut Not Succeed!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                #endregion
                #region cập nhật storage
                DataTable tableConsume = order.ConsumeTableByRoom(roomID);
                DataTable tableStorage = storage.StatictisTable();
                int AmountConsumed;
                int Pid;
                for (int i = 0; i < tableStorage.Rows.Count; i++)
                {
                    for (int j = 0; j < tableConsume.Rows.Count; j++)
                    {
                        if (tableConsume.Rows[j][0].ToString() == tableStorage.Rows[i][0].ToString())      //nếu trùng tên
                        {
                            Pid = Convert.ToInt32(tableStorage.Rows[i][2]);
                            AmountConsumed = Convert.ToInt32(tableStorage.Rows[i][1]) - Convert.ToInt32(tableConsume.Rows[j][1]);
                            storage.UpdateStorage(Pid, AmountConsumed);
                        }
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bt_CheckOut2_Click(object sender, EventArgs e)
        {
            try
            {
                #region Update lại table booking
                int roomID = 2;
                DataTable dt = book.GetBookingByID(roomID);
                if (dt.Rows.Count > 0)
                {
                    bill.insert(roomID, dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), Int32.Parse(dt.Rows[0][3].ToString()), DateTime.Parse(dt.Rows[0][4].ToString()), DateTime.Parse(dt.Rows[0][5].ToString()), Int32.Parse(dt.Rows[0][6].ToString()), Int32.Parse(dt.Rows[0][8].ToString()));
                }
                DateTime arrive = DateTime.Today.Date;
                DateTime leave = DateTime.Today.Date;
                if (book.delete(roomID))
                {
                    #region Load Room1
                    lb_Guest2.Text = ".........................................";
                    lb_Phone2.Text = ".........................................";
                    lb_pupil2.Text = ".........................................";
                    lb_Arrival2.Text = ".........................................";
                    lb_Leave2.Text = ".........................................";
                    lb_Status2.ForeColor = Color.Lime;
                    lb_Status2.Text = "Vacant";
                    bt_BookRoom2.Enabled = true;
                    bt_CheckOut2.Enabled = false;
                    #endregion
                    MessageBox.Show("CheckOut Successfully!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CheckOut Not Succeed!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                #endregion
                #region cập nhật storage
                DataTable tableConsume = order.ConsumeTableByRoom(roomID);
                DataTable tableStorage = storage.StatictisTable();
                int AmountConsumed;
                int Pid;
                for (int i = 0; i < tableStorage.Rows.Count; i++)
                {
                    for (int j = 0; j < tableConsume.Rows.Count; j++)
                    {
                        if (tableConsume.Rows[j][0].ToString() == tableStorage.Rows[i][0].ToString())      //nếu trùng tên
                        {
                            Pid = Convert.ToInt32(tableStorage.Rows[i][2]);
                            AmountConsumed = Convert.ToInt32(tableStorage.Rows[i][1]) - Convert.ToInt32(tableConsume.Rows[j][1]);
                            storage.UpdateStorage(Pid, AmountConsumed);
                        }
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bt_CheckOut3_Click(object sender, EventArgs e)
        {
            try
            {
                #region Update lại table booking
                int roomID = 3;
                DataTable dt = book.GetBookingByID(roomID);
                if (dt.Rows.Count > 0)
                {
                    bill.insert(roomID, dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), Int32.Parse(dt.Rows[0][3].ToString()), DateTime.Parse(dt.Rows[0][4].ToString()), DateTime.Parse(dt.Rows[0][5].ToString()), Int32.Parse(dt.Rows[0][6].ToString()), Int32.Parse(dt.Rows[0][8].ToString()));
                }
                DateTime arrive = DateTime.Today.Date;
                DateTime leave = DateTime.Today.Date;
                if (book.delete(roomID))
                {
                    #region Load Room1
                    lb_Guest3.Text = ".........................................";
                    lb_Phone3.Text = ".........................................";
                    lb_pupil3.Text = ".........................................";
                    lb_Arrival3.Text = ".........................................";
                    lb_Leave3.Text = ".........................................";
                    lb_Status3.ForeColor = Color.Lime;
                    lb_Status3.Text = "Vacant";
                    bt_BookRoom3.Enabled = true;
                    bt_CheckOut3.Enabled = false;
                    #endregion
                    MessageBox.Show("CheckOut Successfully!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CheckOut Not Succeed!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                #endregion
                #region cập nhật storage
                DataTable tableConsume = order.ConsumeTableByRoom(roomID);
                DataTable tableStorage = storage.StatictisTable();
                int AmountConsumed;
                int Pid;
                for (int i = 0; i < tableStorage.Rows.Count; i++)
                {
                    for (int j = 0; j < tableConsume.Rows.Count; j++)
                    {
                        if (tableConsume.Rows[j][0].ToString() == tableStorage.Rows[i][0].ToString())      //nếu trùng tên
                        {
                            Pid = Convert.ToInt32(tableStorage.Rows[i][2]);
                            AmountConsumed = Convert.ToInt32(tableStorage.Rows[i][1]) - Convert.ToInt32(tableConsume.Rows[j][1]);
                            storage.UpdateStorage(Pid, AmountConsumed);
                        }
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bt_CheckOut4_Click(object sender, EventArgs e)
        {
            try
            {
                #region Update lại table booking
                int roomID = 4;
                DataTable dt = book.GetBookingByID(roomID);
                if (dt.Rows.Count > 0)
                {
                    bill.insert(roomID, dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), Int32.Parse(dt.Rows[0][3].ToString()), DateTime.Parse(dt.Rows[0][4].ToString()), DateTime.Parse(dt.Rows[0][5].ToString()), Int32.Parse(dt.Rows[0][6].ToString()), Int32.Parse(dt.Rows[0][8].ToString()));
                }
                DateTime arrive = DateTime.Today.Date;
                DateTime leave = DateTime.Today.Date;
                if (book.delete(roomID))
                {
                    #region Load Room1
                    lb_Guest4.Text = ".........................................";
                    lb_Phone4.Text = ".........................................";
                    lb_pupil4.Text = ".........................................";
                    lb_Arrival4.Text = ".........................................";
                    lb_Leave4.Text = ".........................................";
                    lb_Status4.ForeColor = Color.Lime;
                    lb_Status4.Text = "Vacant";
                    bt_BookRoom4.Enabled = true;
                    bt_CheckOut4.Enabled = false;
                    #endregion
                    MessageBox.Show("CheckOut Successfully!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CheckOut Not Succeed!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                #endregion
                #region cập nhật storage
                DataTable tableConsume = order.ConsumeTableByRoom(roomID);
                DataTable tableStorage = storage.StatictisTable();
                int AmountConsumed;
                int Pid;
                for (int i = 0; i < tableStorage.Rows.Count; i++)
                {
                    for (int j = 0; j < tableConsume.Rows.Count; j++)
                    {
                        if (tableConsume.Rows[j][0].ToString() == tableStorage.Rows[i][0].ToString())      //nếu trùng tên
                        {
                            Pid = Convert.ToInt32(tableStorage.Rows[i][2]);
                            AmountConsumed = Convert.ToInt32(tableStorage.Rows[i][1]) - Convert.ToInt32(tableConsume.Rows[j][1]);
                            storage.UpdateStorage(Pid, AmountConsumed);
                        }
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bt_CheckOut5_Click(object sender, EventArgs e)
        {
            try
            {
                #region Update lại table booking
                int roomID = 5;
                DataTable dt = book.GetBookingByID(roomID);
                if (dt.Rows.Count > 0)
                {
                    bill.insert(roomID, dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), Int32.Parse(dt.Rows[0][3].ToString()), DateTime.Parse(dt.Rows[0][4].ToString()), DateTime.Parse(dt.Rows[0][5].ToString()), Int32.Parse(dt.Rows[0][6].ToString()), Int32.Parse(dt.Rows[0][8].ToString()));
                }
                DateTime arrive = DateTime.Today.Date;
                DateTime leave = DateTime.Today.Date;
                if (book.delete(roomID))
                {
                    #region Load Room1
                    lb_Guest5.Text = ".........................................";
                    lb_Phone5.Text = ".........................................";
                    lb_pupil5.Text = ".........................................";
                    lb_Arrival5.Text = ".........................................";
                    lb_Leave5.Text = ".........................................";
                    lb_Status5.ForeColor = Color.Lime;
                    lb_Status5.Text = "Vacant";
                    bt_BookRoom5.Enabled = true;
                    bt_CheckOut5.Enabled = false;
                    #endregion
                    MessageBox.Show("CheckOut Successfully!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CheckOut Not Succeed!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                #endregion
                #region cập nhật storage
                DataTable tableConsume = order.ConsumeTableByRoom(roomID);
                DataTable tableStorage = storage.StatictisTable();
                int AmountConsumed;
                int Pid;
                for (int i = 0; i < tableStorage.Rows.Count; i++)
                {
                    for (int j = 0; j < tableConsume.Rows.Count; j++)
                    {
                        if (tableConsume.Rows[j][0].ToString() == tableStorage.Rows[i][0].ToString())      //nếu trùng tên
                        {
                            Pid = Convert.ToInt32(tableStorage.Rows[i][2]);
                            AmountConsumed = Convert.ToInt32(tableStorage.Rows[i][1]) - Convert.ToInt32(tableConsume.Rows[j][1]);
                            storage.UpdateStorage(Pid, AmountConsumed);
                        }
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bt_CheckOut6_Click(object sender, EventArgs e)
        {
            try
            {
                #region Update lại table booking
                int roomID = 6;
                DataTable dt = book.GetBookingByID(roomID);
                if (dt.Rows.Count > 0)
                {
                    bill.insert(roomID, dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), Int32.Parse(dt.Rows[0][3].ToString()), DateTime.Parse(dt.Rows[0][4].ToString()), DateTime.Parse(dt.Rows[0][5].ToString()), Int32.Parse(dt.Rows[0][6].ToString()), Int32.Parse(dt.Rows[0][8].ToString()));
                }
                DateTime arrive = DateTime.Today.Date;
                DateTime leave = DateTime.Today.Date;
                if (book.delete(roomID))
                {
                    #region Load Room1
                    lb_Guest6.Text = ".........................................";
                    lb_Phone6.Text = ".........................................";
                    lb_pupil6.Text = ".........................................";
                    lb_Arrival6.Text = ".........................................";
                    lb_Leave6.Text = ".........................................";
                    lb_Status6.ForeColor = Color.Lime;
                    lb_Status6.Text = "Vacant";
                    bt_BookRoom6.Enabled = true;
                    bt_CheckOut6.Enabled = false;
                    #endregion
                    MessageBox.Show("CheckOut Successfully!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CheckOut Not Succeed!", "Checking Out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                #endregion
                #region cập nhật storage
                DataTable tableConsume = order.ConsumeTableByRoom(roomID);
                DataTable tableStorage = storage.StatictisTable();
                int AmountConsumed;
                int Pid;
                for (int i = 0; i < tableStorage.Rows.Count; i++)
                {
                    for (int j = 0; j < tableConsume.Rows.Count; j++)
                    {
                        if (tableConsume.Rows[j][0].ToString() == tableStorage.Rows[i][0].ToString())      //nếu trùng tên
                        {
                            Pid = Convert.ToInt32(tableStorage.Rows[i][2]);
                            AmountConsumed = Convert.ToInt32(tableStorage.Rows[i][1]) - Convert.ToInt32(tableConsume.Rows[j][1]);
                            storage.UpdateStorage(Pid, AmountConsumed);
                        }
                    }
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion


    }
}
