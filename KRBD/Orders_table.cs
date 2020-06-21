using KRBD.KRBD_RestarauntDataSetTableAdapters;
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

namespace KRBD
{
    public partial class Orders_table : Form
    {
        public Orders_table()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Posetiteli". При необходимости она может быть перемещена или удалена.
            this.posetiteliTableAdapter.Fill(this.kRBD_RestarauntDataSet.Posetiteli);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Rabotniki". При необходимости она может быть перемещена или удалена.
            this.rabotnikiTableAdapter.Fill(this.kRBD_RestarauntDataSet.Rabotniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.kRBD_RestarauntDataSet.Orders);
            this.dishesTableAdapter1.Fill(this.kRBD_RestarauntDataSet.Dishes);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableAdapterManager temp = new TableAdapterManager();
            temp.Connection = new SqlConnection("Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True");
            this.ordersTableAdapter.Adapter.Update(this.kRBD_RestarauntDataSet.Orders);
            this.Validate();
            this.ordersBindingSource.EndEdit();
            temp.UpdateAll(kRBD_RestarauntDataSet);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer_table cust = new Customer_table();
            cust.Show();
        }

        private void bindingNavigator1_Enter(object sender, EventArgs e)
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView2.Update();
            dataGridView2.Refresh();
            dataGridView3.Update();
            dataGridView3.Refresh();
            dataGridView4.Update();
            dataGridView4.Refresh();
        }
    }
}
