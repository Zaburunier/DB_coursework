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
    public partial class Refill_table : Form
    {
        public Refill_table()
        {
            InitializeComponent();
        }

        private void Refill_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Supply". При необходимости она может быть перемещена или удалена.
            this.supplyTableAdapter.Fill(this.kRBD_RestarauntDataSet.Supply);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Component". При необходимости она может быть перемещена или удалена.
            this.componentTableAdapter.Fill(this.kRBD_RestarauntDataSet.Component);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Refill". При необходимости она может быть перемещена или удалена.
            this.refillTableAdapter.Fill(this.kRBD_RestarauntDataSet.Refill);
            if (EnterForm.Password != "2234" && EnterForm.Password != "1111") {
                label5.Visible = false;
                label5.Enabled = false;
                panel1.Visible = false;
                panel1.Enabled = false;
            } else {
                label5.Visible = true;
                label5.Enabled = true;
                panel1.Visible = true;
                panel1.Enabled = true;
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableAdapterManager temp = new TableAdapterManager();
            temp.Connection = new SqlConnection("Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True");
            this.refillTableAdapter.Adapter.Update(this.kRBD_RestarauntDataSet.Refill);
            this.Validate();
            this.refillBindingSource.EndEdit();
            temp.UpdateAll(kRBD_RestarauntDataSet);
        }
    }
}
