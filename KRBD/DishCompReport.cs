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
    public partial class DishCompReport : Form
    {
        public DishCompReport()
        {
            InitializeComponent();
        }

        private void DishCompReport_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = textBox1.Text;
            string conString = "Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand command = new SqlCommand("exec Dish_Consumption @date", con);
            SqlParameter date_param = new SqlParameter("@date", date);
            command.Parameters.Add(date_param);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 140;
            dataGridView1.Columns[2].Width = 50;
            adapter.Update(data);

            adapter = new SqlDataAdapter();
            command = new SqlCommand("exec Component_Consumption @date", con);
            date_param = new SqlParameter("@date", date);
            command.Parameters.Add(date_param);
            adapter.SelectCommand = command;
            data = new DataSet();
            adapter.Fill(data);
            dataGridView2.DataSource = data.Tables[0];
            dataGridView2.Columns[0].Width = 30;
            dataGridView2.Columns[1].Width = 140;
            dataGridView2.Columns[2].Width = 50;
            adapter.Update(data);

            adapter = new SqlDataAdapter();
            command = new SqlCommand("exec Component_Refill @date", con);
            date_param = new SqlParameter("@date", date);
            command.Parameters.Add(date_param);
            adapter.SelectCommand = command;
            data = new DataSet();
            adapter.Fill(data);
            dataGridView3.DataSource = data.Tables[0];
            dataGridView3.Columns[0].Width = 30;
            dataGridView3.Columns[1].Width = 140;
            dataGridView3.Columns[2].Width = 50;
            adapter.Update(data);
            con.Close();
        }
    }
}
