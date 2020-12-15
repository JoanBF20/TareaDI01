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
    public partial class Edit : Form
    {
        Product productModel;
        List<string> ProductNumbers;
        List<Product> Products;
        bool loadProduct = false;
        public Edit(Product product)
        {
            this.productModel = product;
            this.Text = "Editar " + product.ProductModel;
            ProductNumbers = product.ProductNumber.Split(new char[] { ';' }).ToList();
            InitializeComponent();
            setData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setData()
        {
            DataAcces db = new DataAcces();
            comboBox1.DataSource = ProductNumbers;
            Products = db.GetProduct(productModel.ProductModel);
            showProduct();
        }

        private void showProduct()
        {
            if (loadProduct)
            {
                textName.Text = Products.ElementAt(comboBox1.SelectedIndex).Name;
                textProductNumber.Text = Products.ElementAt(comboBox1.SelectedIndex).ProductNumber;
                textColor.Text = Products.ElementAt(comboBox1.SelectedIndex).Color;
                textDescription.Text = Products.ElementAt(comboBox1.SelectedIndex).Description;
                textClass.Text = Products.ElementAt(comboBox1.SelectedIndex).Class;
                textProductModel.Text = Products.ElementAt(comboBox1.SelectedIndex).ProductModel;
                textListPrice.Text = Products.ElementAt(comboBox1.SelectedIndex).ListPrice;
                textSize.Text = Products.ElementAt(comboBox1.SelectedIndex).Size;
                textProductLine.Text = Products.ElementAt(comboBox1.SelectedIndex).ProductLine;
                textClass.Text = Products.ElementAt(comboBox1.SelectedIndex).Class;
                textStyle.Text = Products.ElementAt(comboBox1.SelectedIndex).Style;
                textCategory.Text = Products.ElementAt(comboBox1.SelectedIndex).Category;
                textSubCategory.Text = Products.ElementAt(comboBox1.SelectedIndex).SubCategory;
            } else
            {
                loadProduct = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showProduct();
        }
    }
}
