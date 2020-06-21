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
    public partial class Supply_table : Form
    {
        public Supply_table()
        {
            InitializeComponent();
        }

        private void Supply_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Providers". При необходимости она может быть перемещена или удалена.
            this.providersTableAdapter.Fill(this.kRBD_RestarauntDataSet.Providers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Supply". При необходимости она может быть перемещена или удалена.
            this.supplyTableAdapter.Fill(this.kRBD_RestarauntDataSet.Supply);
            if (EnterForm.Password != "2234" && EnterForm.Password != "1111") {
                panel1.Visible = false;
                panel1.Enabled = false;
            } else {
                panel1.Visible = true;
                panel1.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableAdapterManager temp = new TableAdapterManager();
            temp.Connection = new SqlConnection("Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True");
            this.supplyTableAdapter.Adapter.Update(this.kRBD_RestarauntDataSet.Supply);
            this.Validate();
            this.supplyBindingSource.EndEdit();
            temp.UpdateAll(kRBD_RestarauntDataSet);
        }
    }
}
