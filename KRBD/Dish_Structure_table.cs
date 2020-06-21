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
    public partial class Dish_Structure_table : Form
    {
        public Dish_Structure_table()
        {
            InitializeComponent();
        }

        private void Dish_Structure_table_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Components". При необходимости она может быть перемещена или удалена.
            this.componentsTableAdapter.Fill(this.kRBD_RestarauntDataSet.Components);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.kRBD_RestarauntDataSet.Dishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Dish_Structure". При необходимости она может быть перемещена или удалена.
            this.dish_StructureTableAdapter.Fill(this.kRBD_RestarauntDataSet.Dish_Structure);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableAdapterManager temp = new TableAdapterManager();
            temp.Connection = new SqlConnection("Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True");
            this.dish_StructureTableAdapter.Adapter.Update(this.kRBD_RestarauntDataSet.Rabotniki);
            this.Validate();
            this.dishStructureBindingSource.EndEdit();
            temp.UpdateAll(kRBD_RestarauntDataSet);
        }
    }
}
