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
    public partial class Create_Client : Form
    {
        public Create_Client()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CancelClient(object sender, EventArgs e)
        {
            
        }

        private void CancelClientButton_Click(object sender, EventArgs e)
        {
            Create_Order create_Order = new Create_Order();
            create_Order.Show();
            Hide();
        }

        private void CreateClientButton_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            var clientName = ClientName.Text;
            var clientPassport = ClientPassportField.Text;

            string querystring = $"insert into Clients(ClientPassport,Name) values('{clientPassport}','{clientName}')";

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
                MessageBox.Show("Ощибка создания", "Клиент не создан", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dB.closeConnection();
        }

        private void ClientPassport_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
