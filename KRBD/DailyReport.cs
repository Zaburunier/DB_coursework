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
namespace KRBD {
    public partial class DailyReport : Form {
        public DailyReport() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string date = textBox1.Text;
            string conString = "Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand command = new SqlCommand("exec Date_orders @date", con);
            SqlParameter date_param = new SqlParameter("@date", date);
            command.Parameters.Add(date_param);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 40;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 40;
            adapter.Update(data);

            adapter = new SqlDataAdapter();
            command = new SqlCommand("exec Date_Checks @date", con);
            date_param = new SqlParameter("@date", date);
            command.Parameters.Add(date_param);
            adapter.SelectCommand = command;
            data = new DataSet();
            adapter.Fill(data);
            dataGridView2.DataSource = data.Tables[0];
            dataGridView2.Columns[0].Width = 80;
            dataGridView2.Columns[1].Width = 50;
            adapter.Update(data);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
