using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiFaceRec
{
    public partial class BillForm : Form
    {
        public BillForm()
        {
            InitializeComponent();
        }
        Bill bill = new Bill();

        private void BillForm_Load(object sender, EventArgs e)
        {

            dataGridViewBill.DataSource = bill.GetAllBill();
        }

        private void dataGridViewBill_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BillDetail detail = new BillDetail();
            detail.labelRID.Text = dataGridViewBill.CurrentRow.Cells[0].Value.ToString();
            detail.labelType.Text = dataGridViewBill.CurrentRow.Cells[1].Value.ToString();
            detail.labelGName.Text = dataGridViewBill.CurrentRow.Cells[2].Value.ToString(); 
            detail.labelPhone.Text = dataGridViewBill.CurrentRow.Cells[3].Value.ToString();

            detail.labelADate.Text = dataGridViewBill.CurrentRow.Cells[4].Value.ToString();
            detail.labelLDate.Text = dataGridViewBill.CurrentRow.Cells[5].Value.ToString();
            detail.labelRP.Text = dataGridViewBill.CurrentRow.Cells[6].Value.ToString();
            detail.labelSP.Text = dataGridViewBill.CurrentRow.Cells[7].Value.ToString();
            detail.labelTP.Text = dataGridViewBill.CurrentRow.Cells[8].Value.ToString();
            detail.Show();

        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            dataGridViewBill.DataSource = bill.GetBillToday();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewBill.DataSource = bill.GetAllBill();
        }
    }
}
