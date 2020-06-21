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
    public partial class Director : Form {
        public Director() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Dish_table dish = new Dish_table();
            dish.Show();
        }

        private void button12_Click(object sender, EventArgs e) {
            Orders_select orders = new Orders_select();
            orders.Show();
        }

        private void button13_Click(object sender, EventArgs e) {
            Employee_table empl = new Employee_table();
            empl.Show();
        }

        private void button14_Click(object sender, EventArgs e) {
            Providers_table provs = new Providers_table();
            provs.Show();
        }

        private void button15_Click(object sender, EventArgs e) {
            Supply_table sup = new Supply_table();
            sup.Show();
        }

        private void button6_Click(object sender, EventArgs e) {
            DishCompReport report = new DishCompReport();
            report.Show();
        }

        private void button3_Click(object sender, EventArgs e) {
            DailyReport report = new DailyReport();
            report.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            ChecksReport report = new ChecksReport();
            report.Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            Refill_table refill = new Refill_table();
            refill.Show();
        }
    }
}
