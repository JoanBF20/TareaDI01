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
        private int defaultResultsPerPage = 28;
        private bool update = true; 

        ProductFilters filters;

        private List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
            DataAcces db = new DataAcces();
            numericUpDown1.Minimum = 1;
            resultsPerPage.SelectedIndex = 2;
            filters = new ProductFilters(textBox1.Text);
            products = db.GetProducts(defaultResultsPerPage, 0, filters);
            dataGridView1.DataSource = products;
            int countProducts = db.CountProducts(filters);
            dataGridView1.Show();
            numericUpDown1.Maximum = countProducts / defaultResultsPerPage;
            label2.Text = "de " + countProducts / defaultResultsPerPage;

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
            if (resultsPerPage.SelectedIndex > 0 && update)
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
    }
}
