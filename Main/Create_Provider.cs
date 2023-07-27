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
    public partial class Create_Provider : Form
    {
        public Create_Provider()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Create_Order create_Order = new Create_Order();
            create_Order.Show();
            Hide();
        }
    }
}
