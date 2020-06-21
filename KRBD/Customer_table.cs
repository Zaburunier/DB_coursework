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
    public partial class Customer_table : Form
    {
        public Customer_table()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Customer". При необходимости она может быть перемещена или удалена.
            this.customerTableAdapter.Fill(this.kRBD_RestarauntDataSet.Customer);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableAdapterManager temp = new TableAdapterManager();
            temp.Connection = new SqlConnection("Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True");
            this.customerTableAdapter.Adapter.Update(this.kRBD_RestarauntDataSet.Customer);
            this.Validate();
            this.customerBindingSource.EndEdit();
            temp.UpdateAll(kRBD_RestarauntDataSet);
        }
    }
}
