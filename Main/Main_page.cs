﻿using System;
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
    public partial class Main_page : Form
    {
        public Main_page()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Order create_Order = new Create_Order();
            create_Order.Show();
            Hide();
        }

        private void Main_page_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ordersDataSet.OrdersTable". При необходимости она может быть перемещена или удалена.
            this.ordersTableTableAdapter.Fill(this.ordersDataSet.OrdersTable);

        }
    }
}
