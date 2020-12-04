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
        Product product;
        public Edit(Product product)
        {
            this.product = product;
            InitializeComponent();
            this.Text = "Editar Producte: " + product.ProductID;
            setData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setData()
        {
            numericProductID.Value = product.ProductID;
            textName.Text = product.Name;
            textProductNumber.Text = product.ProductNumber;
            checkMakeFlag.Checked = product.MakeFlag;
            checkFinishedGoodsFlag.Checked = product.FinishedGoodsFlag;
            textColor.Text = product.Color;
            numericSafetyStockLevel.Value = product.SafetyStockLevel;
            numericReorderPoint.Value = product.ReorderPoint;
            numericStandardCost.Value = product.StandardCost;
            numericListPrice.Value = product.ListPrice;
            textSize.Text = product.Size;
            textSizeUnitMeasureCode.Text = product.SizeUnitMeasureCode;
            textWeightUnitMeasureCode.Text = product.WeightUnitMeasureCode;
            numericWeight.Value = product.Weight;
            numericDaysToManufacture.Value = product.DaysToManufacture;
            textProductLine.Text = product.ProductLine;
            textClass.Text = product.Class;
            textStyle.Text = product.Style;
            numericProductSubcategoryID.Value = product.ProductSubcategoryID;
            numericProductModelID.Value = product.ProductModelID;
            DateTime nulldate = new DateTime(1,1,1);
            if (product.SellStartDate > dateSellStartDate.MinDate)
            {
                dateSellStartDate.Value = product.SellStartDate;

            } else
            {
                checkNullSellStartDate.Checked = true;
            }
            if (product.SellEndDate > dateSellEndDate.MinDate)
            {
                dateSellEndDate.Value = product.SellEndDate;

            }
            else
            {
                checkNullSellEndDate.Checked = true;
            }
            if (product.DiscontinuedDate > dateDiscontinuedDate.MinDate)
            {
                dateDiscontinuedDate.Value = product.DiscontinuedDate;

            }
            else
            {
                checkNullDiscontinuedDate.Checked = true;

            }
            textRowguid.Text = product.rowguid.ToString();
            if (product.ModifiedDate > dateModifiedDate.MinDate)
            {
                dateModifiedDate.Value = product.ModifiedDate;

            }
            else
            {
                checkNullModifiedDate.Checked = true;
            }



        }
    }
}
