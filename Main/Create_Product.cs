using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Create_Product : Form
    {
        public Create_Product()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create_Order create_Order = new Create_Order();
            create_Order.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            var item = ProductName.Text;
            var unit = ProductUnit.Text;
            var price = ProductPrice.Text;
            var quantityUnit = QuantityUnit.Text;

            string querystring = $"insert into Products(Item,Unit,Price,Quantity) values('{item}','{unit}','{price}', '{quantityUnit}' )";

            SqlCommand command = new SqlCommand(querystring, dB.getConnection());
            dB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {

                Create_Order create_Order = new Create_Order();
                this.Hide();
                create_Order.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Ощибка создания", "Продукт не создан", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dB.closeConnection();
        }
    }
}
