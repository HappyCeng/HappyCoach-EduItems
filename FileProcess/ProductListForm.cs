using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace FileProcess
{
    public partial class ProductListForm : Form
    {
        public ProductListForm()
        {
            InitializeComponent();
        }

        private void ProductListForm_Load(object sender, EventArgs e)
        {
            //combobox dolduruyoruz.
            string row = string.Empty, tmpRow = string.Empty;
            int tmpIndex;
            List<string> CategoryList = new List<string>();
            StreamReader fileProduct = File.OpenText("E:\\StokApp\\product.txt");

            row = fileProduct.ReadLine();
            //her kategoriden bir tane eklemek için
            while (row != null)
            {
                tmpIndex = row.IndexOf("#");
                tmpRow = row.Substring(0, tmpIndex);
                if (!CategoryList.Contains(tmpRow))
                {
                    CategoryList.Add(tmpRow);
                }
                row = fileProduct.ReadLine();
            }

            cBoxCategories.Items.AddRange(CategoryList.ToArray());
                       
        }

        private void cBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cBoxCategories.Text, row = string.Empty, tmpRow = string.Empty;
            int tmpIndex, tmpIndex2;
            List<ProductInfo> ProductList = new List<ProductInfo>();
            DataTable dt = new DataTable();

            StreamReader fileProduct = File.OpenText("E:\\StokApp\\product.txt");

            row = fileProduct.ReadLine();

            while (row != null)
            {
                ProductInfo productInfo = new ProductInfo();

                tmpIndex = row.IndexOf("#");
                tmpRow = row.Substring(0, tmpIndex);
                if (tmpRow == selected)
                {
                    tmpIndex2 = row.IndexOf("#", tmpIndex + 1);
                    productInfo.ProductName = row.Substring(tmpIndex + 1, tmpIndex2 - tmpIndex - 1);
                    tmpIndex = row.IndexOf("#", tmpIndex2 + 1);
                    productInfo.ProductStock = row.Substring(tmpIndex2 + 1, tmpIndex - tmpIndex2 - 1);
                    tmpIndex2 = row.IndexOf("#", tmpIndex + 1);
                    productInfo.ProductPrice = row.Substring(tmpIndex + 1, tmpIndex2 - tmpIndex - 1);
                    ProductList.Add(productInfo);
                }
                tmpIndex = 0;
                tmpIndex2 = 0;
                row = fileProduct.ReadLine();
            }

            dt.Columns.Add("Ürün Adı", typeof(string));
            dt.Columns.Add("Stok Adedi", typeof(string));
            dt.Columns.Add("Adet Fiyatı", typeof(string));
            foreach (ProductInfo i in ProductList)
            {
                dt.Rows.Add(i.ProductName, i.ProductStock, i.ProductPrice);
            }

            dataGridView1.DataSource = dt;

        }
    }
}
