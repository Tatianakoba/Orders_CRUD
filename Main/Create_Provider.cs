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
    public partial class Create_Provider : Form
    {
        
        public Create_Provider()
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

        private void CreateProvider_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            var providerName = ProviderName.Text;
            var providerINN = ProviderINN.Text;

            string querystring = $"insert into Provider(Name,INN) values('{providerName}','{providerINN}')";

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
                MessageBox.Show("Ощибка создания", "Поставщик не создан", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dB.closeConnection();
        }
    }
}
