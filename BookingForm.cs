﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class BookingForm : Form
    {
        public static int Roomid;
        int numberofpeople;
        CultureInfo culture = new CultureInfo("vi-VN");
        public BookingForm(int RoomID)
        {
            InitializeComponent();
            Roomid = RoomID;
        }
        Booking book = new Booking();
        Storage storage = new Storage();
        Order order = new Order();
        private void BookingForm_Load(object sender, EventArgs e)
        {
            #region Booking Room
            //Load 2 datetimepicker
            lb_RoomID.Text = Roomid.ToString();
            //dtp_Arrival.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtp_Arrival.Value = DateTime.Now;
            dtp_Leave.Value = DateTime.Now;
            //Load giá phòng và số người ở phòng để so sánh
            DataTable table = new DataTable();
            table = book.GetRoomByID(Roomid);
            txb_Price.Text = table.Rows[0]["Price"].ToString();
            numberofpeople = Convert.ToInt32(table.Rows[0]["Capacity"]);
            #endregion

            #region Ordering Service
            //Load Combobox
            Cbb_Service.DataSource = storage.GetAllProduct();
            Cbb_Service.DisplayMember = "Pname";
            Cbb_Service.ValueMember = "PID";
            //datagridvew
            datagridview1.DataSource = order.GetOrderByID(Roomid);
            #endregion
        }

        private void dtp_Leave_Leave(object sender, EventArgs e)
        {
            if (dtp_Arrival.Value > dtp_Leave.Value)
            {
                MessageBox.Show("Invalid Booking Schedual!", "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime Arrive, Leave;
                Arrive = dtp_Arrival.Value;
                Leave = dtp_Leave.Value;
                int days = (Leave - Arrive).Days;
                txb_Days.Text = (days + 1).ToString();
                lb_total.Text = (Convert.ToInt32(txb_Price.Text) * (days + 1)).ToString("c", culture);
            }
        }
        private void dtp_Leave_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_Arrival.Value > dtp_Leave.Value)
            {
                MessageBox.Show("Invalid Booking Schedual!", "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime Arrive, Leave;
                Arrive = dtp_Arrival.Value;
                Leave = dtp_Leave.Value;
                int days = (Leave - Arrive).Days;
                txb_Days.Text = (days + 1).ToString();
                CultureInfo culture = new CultureInfo("vi-VN");
            }
        }

        private void bt_Add_Click_1(object sender, EventArgs e)
        {
            int Pid = Convert.ToInt32(Cbb_Service.SelectedValue);
            DataTable table = new DataTable();
            table = storage.GetAllProductByID(Pid);
            int RoomID = Roomid;
            int price = Convert.ToInt32(table.Rows[0][1]);
            string Pname = table.Rows[0][0].ToString();
            int amount = Convert.ToInt32(numericUpDown1.Value);
            int total = price * amount;
            //total.ToString("c", culture);
            if(numericUpDown1.Value > 0 )
            {
                if(order.IfExist(Pname, RoomID))
                {
                    for( int i = 0; i < datagridview1.Rows.Count;i++)
                    {
                        if(datagridview1.Rows[i].Cells[1].Value.ToString() == Pname)
                        {
                            amount += Convert.ToInt32(datagridview1.Rows[i].Cells[3].Value);
                            total = price * amount;
                            break;
                        }    
                    }    
                    if(order.UpdateExist(Pname, RoomID,amount,total))
                    {
                        BookingForm_Load(null, null);
                        int sum = 0;
                        for (int i = 0; i < datagridview1.Rows.Count; i++)
                        {
                            sum += Convert.ToInt32(datagridview1.Rows[i].Cells[4].Value);
                        }
                        lb_Sum.Text = ("Total: " + sum.ToString("c", culture));
                        sum = 0;
                    }   
                    else
                    {
                        MessageBox.Show("Error While Ordering!", "Order Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }    
                }   
                else
                {
                    if (order.insert(RoomID, Pname, price, amount, total))
                    {
                        BookingForm_Load(null, null);
                        int sum = 0;
                        for (int i = 0; i < datagridview1.Rows.Count; i++)
                        {
                            sum += Convert.ToInt32(datagridview1.Rows[i].Cells[4].Value);
                        }
                        lb_Sum.Text = ("Total: " + sum.ToString("c", culture));
                        sum = 0;
                    }
                    else
                    {
                        MessageBox.Show("Error While Ordering!", "Order Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } 
            }
            else
            {
                MessageBox.Show("Order A Value!", "Order Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    

        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                string pname = datagridview1.CurrentRow.Cells[1].Value.ToString();
                if ((MessageBox.Show("Are you sure want to delete this Order?", "Delete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (order.Delete(pname))
                    {
                        MessageBox.Show("Order Deleted!", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        datagridview1.ClearSelection();
                        BookingForm_Load(null, null);
                        int sum = 0;
                        for (int i = 0; i < datagridview1.Rows.Count; i++)
                        {
                            sum += Convert.ToInt32(datagridview1.Rows[i].Cells[4].Value);
                        }
                        lb_Sum.Text = ("Total: " + sum.ToString("c", culture));
                        sum = 0;
                    }
                    else
                    {
                        MessageBox.Show("Order Not Deleted", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Chose An Order To Delete", "Delete Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }

        
        private void datagridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < datagridview1.Rows.Count; i++)
            {
                sum += Convert.ToInt32(datagridview1.Rows[i].Cells[4].Value);
            }
            lb_Sum.Text = ("Total: " + sum.ToString("c", culture));
            sum = 0;
        }

        private void dtp_Leave_ValueChanged_1(object sender, EventArgs e)
        {
            if (dtp_Arrival.Value > dtp_Leave.Value)
            {
                MessageBox.Show("Invalid Booking Schedual!", "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime Arrive, Leave;
                Arrive = dtp_Arrival.Value;
                Leave = dtp_Leave.Value;
                int days = (Leave - Arrive).Days;
                txb_Days.Text = (days + 1).ToString();
                CultureInfo culture = new CultureInfo("vi-VN");
            }
        }

        private void dtp_Leave_Leave_1(object sender, EventArgs e)
        {
            if (dtp_Arrival.Value > dtp_Leave.Value)
            {
                MessageBox.Show("Invalid Booking Schedual!", "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime Arrive, Leave;
                Arrive = dtp_Arrival.Value;
                Leave = dtp_Leave.Value;
                int days = (Leave - Arrive).Days;
                txb_Days.Text = (days + 1).ToString();
                lb_total.Text = (Convert.ToInt32(txb_Price.Text) * (days + 1)).ToString("c", culture);
            }
        }

        private void bt_Book_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txb_GuestName.Text.Trim() == "" || txb_Phone.Text.Trim() == "" || txb_pupli.Text.Trim() == "")
                {
                    MessageBox.Show("Empty Fields!", "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int RID = Convert.ToInt32(lb_RoomID.Text);
                    string Gname = txb_GuestName.Text;
                    string Phone = txb_Phone.Text;
                    int people = Convert.ToInt32(txb_pupli.Text);
                    DateTime arr = dtp_Arrival.Value;
                    DateTime leave = dtp_Leave.Value;
                    int price = Convert.ToInt32(txb_Price.Text);
                    if (dtp_Arrival.Value > dtp_Leave.Value)
                    {
                        MessageBox.Show("Invalid Booking Schedual!", "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (Convert.ToInt32(txb_pupli.Text) > numberofpeople)
                        {
                            MessageBox.Show("Pupil Excees Room Size!", "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int status = 1;
                            if (book.insert(RID, Gname, Phone, people, arr, leave, price, status))
                            {
                                MessageBox.Show("Booking Room Sucessfully!", "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("An Error Accours While Booking Room!", "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtp_Arrival_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_Arrival.Value <= DateTime.Now.Date)
            {
                MessageBox.Show("Arrival Day Must Start From Today!", "Booking Room", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_Arrival.Value = DateTime.Now.Date;
            }    
        }
    }
}
