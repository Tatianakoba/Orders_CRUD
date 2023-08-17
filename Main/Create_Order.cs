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
    public partial class Create_Order : Form
    {
        
        public Create_Order()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
        }

       

       

        private void button6_Click(object sender, EventArgs e)
        {
            Main_page main_Page = new Main_page();
            main_Page.Show();
            Hide();
        }

       


        private void button2_Click(object sender, EventArgs e)
        {
            Create_Client create_Client = new Create_Client();
            create_Client.Show();
            Hide();
        }

        

        private void button7_Click_1(object sender, EventArgs e)
        {
            Check_Order order = new Check_Order();
            order.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Create_Provider provider = new Create_Provider();
            provider.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Create_Client client = new Create_Client();
            client.Show();
            Hide();

        }

        
        

        private void Create_Order_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersDataSet2.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter1.Fill(this.ordersDataSet2.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersDataSetProducts.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.ordersDataSetProducts.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersDataSetClients.Clients". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersDataSet1.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.ordersDataSet1.Provider);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var providerINN = ProviderINN.Text;
            

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable table = new DataTable();

            //string querystring = $"select Id,Name,INN from Provider where Name='{providerINN}'";
            ////SqlCommand command = new SqlCommand(querystring, DB_provider.getConnection());

            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            //if (table.Rows.Count == 1)
            //{
            //    Create_Order create_Order = new Create_Order();
            //    this.Hide();
            //    create_Order.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Такого поставщика нет", "Создайте поставщика", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            Create_Product product = new Create_Product();
            product.Show();
            Hide();
        }

        private void AddString_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = true;
            ProductSelection.Visible = true;
            ProductQuantity.Visible = true;
        }

        private void DeleteString_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            ProductSelection.Visible = false;
            ProductQuantity.Visible = false;
        }
    }
}
