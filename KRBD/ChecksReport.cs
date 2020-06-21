using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRBD {
    public partial class ChecksReport : Form {
        public ChecksReport() {
            InitializeComponent();
        }

        private void ChecksReport_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Day_checks". При необходимости она может быть перемещена или удалена.
            this.day_checksTableAdapter.Fill(this.kRBD_RestarauntDataSet.Day_checks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Orders_checks". При необходимости она может быть перемещена или удалена.
            this.orders_checksTableAdapter.Fill(this.kRBD_RestarauntDataSet.Orders_checks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Orders_checks". При необходимости она может быть перемещена или удалена.
            this.orders_checksTableAdapter.Fill(this.kRBD_RestarauntDataSet.Orders_checks);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kRBD_RestarauntDataSet.Day_checks". При необходимости она может быть перемещена или удалена.
            this.day_checksTableAdapter.Fill(this.kRBD_RestarauntDataSet.Day_checks);

        }
    }
}
