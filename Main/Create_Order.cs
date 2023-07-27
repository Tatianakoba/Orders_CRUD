using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label7.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            label7.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            Create_Product product = new Create_Product();
            product.Show();
            Hide();
        }
    }
}
