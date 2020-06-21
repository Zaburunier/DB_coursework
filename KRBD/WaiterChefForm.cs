using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRBD
{
    public partial class WaiterChefForm : Form
    {
        public WaiterChefForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders_select orders = new Orders_select();
            orders.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dish_table dish = new Dish_table();
            dish.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WaiterForm_Load(object sender, EventArgs e)
        {
            if (EnterForm.Password == "1298")
                this.Text = "Официант";
            if (EnterForm.Password == "1155")
                this.Text = "Повар";
        }
    }
}
