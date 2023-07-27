using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Pharmacy_Management
{
    public partial class Login : Form
    {
        Products[] arr;
        int x;
        public Login()
        {
            arr = new Products[10000];
            x = 0;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string pass = textBox2.Text;
            if (Name.Equals("0") && pass.Equals("0"))
            {
                this.Hide();
                Home f1 = new Home(arr,x);
                f1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Account");
                textBox1.Text = " ";
                textBox2.Text = " ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
