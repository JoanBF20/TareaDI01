using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaDI01
{
    public partial class Form1 : Form
    {
        private bool update = true; 

        ProductFilters filters;

        private List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            DataAcces db = new DataAcces();
            dataGridView1.DataSource = products;
            update = false;
            numericUpDown1.Minimum = 1;
            update = false;
            resultsPerPage.SelectedIndex = 2;
            updateData();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
                updateData();
        }

        private void resultsPerPage_SelectedIndexChanged(object sender, EventArgs e)
        {
                updateData();
        }

        private void updateData()
        {
            Console.WriteLine("tryupdate");
            if (update)
            {
                DataAcces db = new DataAcces();
                filters = new ProductFilters(textBox1.Text);
                int page = (int)numericUpDown1.Value - 1;
                if ((int)numericUpDown1.Value - 1 < 0)
                    page = (int)numericUpDown1.Value;
                products = db.GetProducts(int.Parse(resultsPerPage.SelectedItem.ToString()), page, filters);
                int countProducts = db.CountProducts(filters);
                numericUpDown1.Maximum = countProducts / int.Parse(resultsPerPage.SelectedItem.ToString());
                label2.Text = "de " + countProducts / int.Parse(resultsPerPage.SelectedItem.ToString());
                if (countProducts / int.Parse(resultsPerPage.SelectedItem.ToString()) < 1)
                {
                    update = false;
                    label2.Text = "de 1";
                    numericUpDown1.Minimum = 1;
                }
                dataGridView1.DataSource = products;
                dataGridView1.Show();
            }
            update = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateData();
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        Product product = products[e.RowIndex];
        Edit EditForm = new Edit(product);
        EditForm.Show();
        }
    }
}
