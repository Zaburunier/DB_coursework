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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Dish". При необходимости она может быть перемещена или удалена.
            this.dishTableAdapter.Fill(this.kRBD_RestarauntDataSet.Dish);

        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection dr = dataGridView3.SelectedRows;
            int dishId = 0;
            if (dr.Count > 0)
                dishId = Convert.ToInt32(dr[0].Cells[0].Value);
            string conString = "Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand dishCommand = new SqlCommand("exec Sostav @dish_id", con);
            SqlParameter dish_name_param = new SqlParameter("@dish_id", dishId);
            dishCommand.Parameters.Add(dish_name_param);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = dishCommand;
            DataSet data = new DataSet();
            adapter.Fill(data);
            data.Tables[0].Columns[0].ColumnName = "Component";
            dataGridView4.DataSource = data.Tables[0];
            dataGridView4.Columns[0].Width = 130;
            adapter.Update(data);
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableAdapterManager temp = new TableAdapterManager();
            temp.Connection = new SqlConnection("Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True");
            this.dishTableAdapter.Adapter.Update(this.kRBD_RestarauntDataSet.Rabotniki);
            this.Validate();
            this.dishBindingSource.EndEdit();
            temp.UpdateAll(kRBD_RestarauntDataSet);
        }
    }
}
