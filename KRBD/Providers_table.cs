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
using KRBD.KRBD_RestarauntDataSetTableAdapters;

namespace KRBD
{
    public partial class Providers_table : Form
    {
        public Providers_table()
        {
            InitializeComponent();
        }

        private void Provs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Providers". При необходимости она может быть перемещена или удалена.
            this.providersTableAdapter.Fill(this.kRBD_RestarauntDataSet.Providers);
            if (EnterForm.Password != "2234" && EnterForm.Password != "1111") {
                label1.Visible = false;
                label1.Enabled = false;
                panel1.Visible = false;
                panel1.Enabled = false;
            } else {
                label1.Visible = true;
                label1.Enabled = true;
                panel1.Visible = true;
                panel1.Enabled = true;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableAdapterManager temp = new TableAdapterManager();
            temp.Connection = new SqlConnection("Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True");
            this.providersTableAdapter.Adapter.Update(this.kRBD_RestarauntDataSet.Providers);
            this.Validate();
            this.providersBindingSource.EndEdit();
            temp.UpdateAll(kRBD_RestarauntDataSet);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
