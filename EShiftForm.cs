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
    public partial class EShiftForm : Form
    {
        public int EmployeeID;
        public EShiftForm(int Eid)
        {
            InitializeComponent();
            EmployeeID = Eid;
        }
        MY_DB mydb = new MY_DB();
        private void EShiftForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Shift] where id = @eid", mydb.getConnection);
            command.Parameters.Add("@eid", SqlDbType.Int).Value = EmployeeID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
