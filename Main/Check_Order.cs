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
    public partial class Check_Order : Form
    {
        public Check_Order()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Order create_Order = new Create_Order();
            create_Order.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_page main_Page = new Main_page();
            main_Page.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_page main_Page2 = new Main_page();
            main_Page2.Show();
            Hide();
        }
    }
}
