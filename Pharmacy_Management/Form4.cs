using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_Management
{
     public partial class Form4 : Form
    {
        Products[] arr;
        int x;
        public Form4(Products[] arr , int x)
        {
            this.arr = arr;
            this.x = x;
            InitializeComponent();
        }
        int selectedRow;
        private void Form4_Load(object sender, EventArgs e)
        {
             for (int i = 0; i < x; i++)
            {
                comboBox1.Items.Add(arr[i].getID_of_Products());
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                double tmp = 0;
                double.TryParse(dataGridView1.Rows[i].Cells[4].Value.ToString(), out tmp);
                total += tmp;
            }
            textBox4.Text = total+" "+"EGP".ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = comboBox1.SelectedIndex;
            textBox1.Text = (arr[idx].getName_of_Products());
            textBox2.Text = (arr[idx].getProduct_price() + " ");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home a = new Home(arr, x);
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double tax = 0;
            x = 0;
            double am = double.Parse(textBox3.Text);
            tax = am * arr[x].getProduct_price();
        
            dataGridView1.Rows.Add(comboBox1.Text,textBox1.Text,textBox2.Text +" "+"EGP", textBox3.Text,tax+" "+"EGP");
            x++;
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(" Done ");
        }
    }
}
