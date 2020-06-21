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
    public partial class Dish_table : Form
    {
        public Dish_table()
        {
            InitializeComponent();
        }

        private void Dishes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableAdapterManager temp = new TableAdapterManager();
            temp.Connection = new SqlConnection("Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True");
            this.dishTableAdapter1.Adapter.Update(this.kRBD_RestarauntDataSet.Rabotniki);
            this.Validate();
            this.bindingSource1.EndEdit();
            temp.UpdateAll(kRBD_RestarauntDataSet);
        }

        private void Dish_table_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Dish". При необходимости она может быть перемещена или удалена.
            this.dishTableAdapter1.Fill(this.kRBD_RestarauntDataSet.Dish);
            if (EnterForm.Password != "1155" && EnterForm.Password != "1111")
            {
                this.button2.Enabled = false;
                this.button2.Visible = false;
                this.panel1.Enabled = false;
                this.panel1.Visible = false;
            }
            else
            {
                this.button2.Enabled = true;
                this.button2.Visible = true;
                this.panel1.Enabled = true;
                this.panel1.Visible = true;
            }

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TableAdapterManager temp = new TableAdapterManager();
            temp.Connection = new SqlConnection("Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True");
            this.dishTableAdapter1.Adapter.Update(this.kRBD_RestarauntDataSet.Dish);
            this.Validate();
            this.bindingSource1.EndEdit();
            temp.UpdateAll(kRBD_RestarauntDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dish_Structure_table struc = new Dish_Structure_table();
            struc.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
