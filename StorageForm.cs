using System;
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
    public partial class StorageForm : Form
    {
        public StorageForm()
        {
            InitializeComponent();
        }
        Storage storage = new Storage();
        private void StorageForm_Load(object sender, EventArgs e)
        {
            // Hiển thị tất cả các sản phẩm lên DataGridView
            dataGridView1.DataSource = storage.GetAllProduct();

            // Thiết lập chiều cao của mỗi hàng trong DataGridView là 60 pixel
            dataGridView1.RowTemplate.Height = 60;
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = storage.GetAllProduct();
            dataGridView1.RowTemplate.Height = 60;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //tb_PID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //tb_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            //numericUpDown1.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            //CultureInfo culture = new CultureInfo("vi-VN");
            //int price = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            //tb_Price.Text = price.ToString();

            if (dataGridView1.CurrentRow != null)
            {
                tb_PID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                tb_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                // Check if the cell value is null before accessing its property
                if (dataGridView1.CurrentRow.Cells[3].Value != null)
                {
                    CultureInfo culture = new CultureInfo("vi-VN");
                    tb_Price.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                }

                // Check if the cell value is null before trying to convert it to an integer
                if (dataGridView1.CurrentRow.Cells[2].Value != null)
                {
                    string quantityString = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    int quantity = 0;
                    bool isNumeric = int.TryParse(quantityString, out quantity);
                    if (isNumeric)
                    {
                        numericUpDown1.Value = quantity;
                    }
                }
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verif())
                {
                    int id = Convert.ToInt32(tb_PID.Text);
                    string name = tb_Name.Text;
                    int Price = Convert.ToInt32(tb_Price.Text);
                    int Quantity = Convert.ToInt32(numericUpDown1.Value);
                    if (numericUpDown1.Value <= 0)
                    {
                        MessageBox.Show("The Quantity Must Greater Than 0", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (storage.CheckEID(id))
                        {
                            if (storage.CheckUserName(name, id))
                            {
                                if (storage.insert(id, name, Quantity, Price))
                                {
                                    MessageBox.Show("New Product Added!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CleanFields();
                                    bt_Refresh_Click(null, null);
                                }
                                else
                                {
                                    MessageBox.Show("Error Accours While Adding New Product!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Product Name Existed!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("ID Existed!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verif())
                {
                    int id = Convert.ToInt32(tb_PID.Text);
                    string name = tb_Name.Text;
                    int Price = Convert.ToInt32(tb_Price.Text);
                    int Quantity = Convert.ToInt32(numericUpDown1.Value);
                    if (numericUpDown1.Value <= 0)
                    {
                        MessageBox.Show("The Quantity Must Greater Than 0", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (storage.Update(id, name, Quantity, Price))
                        {
                            MessageBox.Show("Product Edited!", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CleanFields();
                            bt_Refresh_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Error Accours While Editing Product!", "Edit Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bt_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(tb_PID.Text);
                if ((MessageBox.Show("Are you sure want to delete this Product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (storage.Delete(id))
                    {
                        MessageBox.Show("Product Deleted!", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CleanFields();
                        bt_Refresh_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Product Not Deleted", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            CleanFields();
        }
        bool Verif()
        {
            if ((tb_PID.Text.Trim() == "")
                || (tb_Name.Text.Trim() == "")
                || (tb_Price.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void CleanFields()
        {
            tb_PID.Text = "";
            tb_Name.Text = "";
            tb_Price.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
