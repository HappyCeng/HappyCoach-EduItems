using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileProcess
{
    public partial class EditDelProduct : Form
    {
        public EditDelProduct()
        {
            InitializeComponent();
        }
        
        private void EditDelProduct_Load(object sender, EventArgs e)
        {
            string row = string.Empty, tmpRow = string.Empty;
            int tmpIndex;
            List<string> CategoryList = new List<string>();
            StreamReader fileProduct = File.OpenText("E:\\StokApp\\product.txt");

            row = fileProduct.ReadLine();

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

            fileProduct.Close();

            cboxProlist.Items.AddRange(CategoryList.ToArray());
        }

        private void cboxProlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cboxProlist.Text, row = string.Empty, tmprow = string.Empty;
            int tmpindex, tmpindex2;
            List<ProductInfo> productList = new List<ProductInfo>();
            DataTable dt2 = new DataTable();

            dt2.Columns.Add("Ürün Adı", typeof(string));
            dt2.Columns.Add("Stok Adedi", typeof(string));
            dt2.Columns.Add("Adet Fiyatı", typeof(string));
            //dt2.Rows.Add("1", typeof(string));

            StreamReader fileProduct = File.OpenText("E:\\StokApp\\product.txt");
            row = fileProduct.ReadLine();

            while (row != null)
            {
                ProductInfo productInfo = new ProductInfo();

                tmpindex = row.IndexOf("#");
                tmprow = row.Substring(0, tmpindex);
                if (tmprow == selected)
                {
                    tmpindex2 = row.IndexOf("#", tmpindex + 1);
                    productInfo.ProductName = row.Substring(tmpindex + 1, tmpindex2 - tmpindex - 1);
                    tmpindex = row.IndexOf("#", tmpindex2 + 1);
                    productInfo.ProductPrice = row.Substring(tmpindex2 + 1, tmpindex - tmpindex2 - 1);
                    tmpindex2 = row.IndexOf("#", tmpindex + 1);
                    productInfo.ProductStock = row.Substring(tmpindex + 1, tmpindex2 - tmpindex - 1);
                    productList.Add(productInfo);
                }
                tmpindex = 0;
                tmpindex2 = 0;
                row = fileProduct.ReadLine();
            }

            fileProduct.Close();

            foreach (ProductInfo i in productList)
            {
                dt2.Rows.Add(i.ProductName, i.ProductStock, i.ProductPrice);
            }

            dgwProlist.DataSource = dt2;

        }

      private void btnDelete_Click(object sender, EventArgs e) 
        {
            string row, del_row;
            List<string> rowList = new List<string>();

            if(dgwProlist.SelectedRows.Count > 0)
            {
                try 
                {
                    del_row = dgwProlist.SelectedRows[0].Cells[0].EditedFormattedValue.ToString();

                    dgwProlist.Rows.RemoveAt(dgwProlist.SelectedRows[0].Index);

                    StreamReader fileProduct = File.OpenText("E:\\StokApp\\product.txt");
                    row = fileProduct.ReadLine();

                    while (row != null) 
                    {
                        rowList.Add(row);
                        row = fileProduct.ReadLine();
                    }

                    fileProduct.Close();

                    StreamWriter dosyayaz = File.CreateText("E:\\StokApp\\product.txt");

                    foreach (string i in rowList)
                    {
                        if (!i.Contains(del_row))
                        {
                            dosyayaz.WriteLine(i);
                        }
                    }

                    dosyayaz.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İşlem sırasında bir hata oluştu" + ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Lüffen Silinecek Satırı Seçin!");
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string row, del_row = string.Empty, tmprow = string.Empty;
            int tmpindex, tmpindex2;

            List<ProductInfo> productList = new List<ProductInfo>();

            if (dgwProlist.SelectedRows.Count > 0)
            {
                del_row = dgwProlist.SelectedRows[0].Cells[0].EditedFormattedValue.ToString();

                StreamReader fileProduct = File.OpenText("E:\\StokApp\\product.txt");
                row = fileProduct.ReadLine();

                while (row != null)
                {
                    ProductInfo productInfo = new ProductInfo();

                    tmpindex = row.IndexOf("#");
                    productInfo.Category = row.Substring(0, tmpindex);
              
                    tmpindex2 = row.IndexOf("#", tmpindex + 1);
                    productInfo.ProductName = row.Substring(tmpindex + 1, tmpindex2 - tmpindex - 1);
                    tmpindex = row.IndexOf("#", tmpindex2 + 1);
                    productInfo.ProductStock = row.Substring(tmpindex2 + 1, tmpindex - tmpindex2 - 1);
                    tmpindex2 = row.IndexOf("#", tmpindex + 1);
                    productInfo.ProductPrice = row.Substring(tmpindex + 1, tmpindex2 - tmpindex - 1);
                    productList.Add(productInfo);
                    
                    tmpindex = 0;
                    tmpindex2 = 0;
                    row = fileProduct.ReadLine();
                }

                fileProduct.Close();
            }

            StreamWriter dosyayaz = File.CreateText("E:\\StokApp\\product.txt");

            foreach (ProductInfo i in productList)
            {
                if (del_row == i.ProductName.ToString())
                {
                    i.ProductStock = Convert.ToString(Convert.ToInt32(i.ProductStock) - 1);
                }
                dosyayaz.WriteLine(i.Category + "#" + i.ProductName + "#" + i.ProductStock + "#" + i.ProductPrice + "#");
                
            }

            dosyayaz.Close();
        }

    }
}
