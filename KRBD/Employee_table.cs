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
    public partial class Employee_table : Form
    {
        public Employee_table()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.kRBD_RestarauntDataSet.Employee);
            if (EnterForm.Password != "8978" && EnterForm.Password != "1111") {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableAdapterManager temp = new TableAdapterManager();
            temp.Connection = new SqlConnection("Data Source=DESKTOP-PA5M2I4\\SQLEXPRESS;Initial Catalog=KRBD_Restaraunt;Integrated Security=True");
            this.employeeTableAdapter.Adapter.Update(this.kRBD_RestarauntDataSet.Rabotniki);
            this.Validate();
            this.employeeBindingSource.EndEdit();
            temp.UpdateAll(kRBD_RestarauntDataSet);
        }
    }
}
