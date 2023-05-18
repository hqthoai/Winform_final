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
    }
}
