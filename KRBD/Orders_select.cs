using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRBD
{
    public partial class Orders_select : Form
    {
        public Orders_select()
        {
            InitializeComponent();
        }

        private void Orders_select_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Zakazi". При необходимости она может быть перемещена или удалена.
            this.zakaziTableAdapter.Fill(this.kRBD_RestarauntDataSet.Zakazi);
            if (EnterForm.Password != "1298" && EnterForm.Password != "1111")
            {
                this.button1.Enabled = false;
                this.button1.Visible = false;
            }
            else
            {
                this.button1.Enabled = true;
                this.button1.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders_table orders = new Orders_table();
            orders.Show();
        }
    }
}
