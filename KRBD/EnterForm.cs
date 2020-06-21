using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KRBD {
    public partial class EnterForm : Form {
        private static string pass = "";
        public static string Password { get { return pass; } set { pass = value; } }
        public EnterForm() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void passwordButton_Click(object sender, EventArgs e) {
            pass = passwordBox.Text;
            if (pass == "1298" || pass == "1155") { //Официант, повар
                WaiterChefForm temp = new WaiterChefForm();
                temp.Show();
            } else if (pass == "2234") { //Ответственный за поставки
                ControllerForm temp = new ControllerForm();
                temp.Show();
            } else if (pass == "1111") { // Администратор
                Admin adm = new Admin();
                adm.Show();
            } else if (pass == "8978") { //Директор
                Director dir = new Director();
                dir.Show();

            } else {
                MessageBox.Show("Неверный пароль!");
            }
        }

        private void button1_Click(object sender, EventArgs e) {

            CustomerForm cust = new CustomerForm();
            cust.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}