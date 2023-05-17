using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class ShiftForm : Form
    {
        internal int[,] a;
        public ShiftForm()
        {
            InitializeComponent();
        }

        private void ShiftForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Shift]", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        MY_DB mydb = new MY_DB();
        private void button1_Click(object sender, EventArgs e)
        {
            DeliveryShift dl = new DeliveryShift();
            dl.delivery(ref a);
            string[] shift = new string[9];
            dl.deleteShiftToSql(shift);
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    shift[j] = a[i, j].ToString();
                }
                dl.addShiftToSql(shift);
            }
            ShiftForm_Load(null, null);
        }
    }
}
