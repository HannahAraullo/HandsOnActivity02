using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    

    public partial class frmAddProduct : Form
    {
        private string _ProductName;
        private string _Category;
        private string _MfgDate;
        private string _ExpDate;
        private string _Description;

        private int _Quantity;
        private double _SellPrice;

        BindingSource showProductList;
        public string Product_Name(string name)
        {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                throw new StringFormatException("Invalid Product Name");
            }
          
            return name;
           
        }
       public int Quantity(string qty)
        {
            
                if (!Regex.IsMatch(qty, @"^[0-9]"))
            { 
                throw new NumberFormatException("Invalid Quantity");
            }
                    return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {

            if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
            {
                throw new CurrencyFormatException("Invalid Price");
            }
             return Convert.ToDouble(price); 
            
        }

        public frmAddProduct()
        {
            InitializeComponent();
            showProductList = new BindingSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            string[] ListOfProductCategory = new string[]
           {
                "Beverage",
                "Bread/Bakery",
                "Canned/Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Meat",
                "Personal Care",
                "Other"
           };

            foreach(string items in ListOfProductCategory)
            {
                cbCategory.Items.Add(items);
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {

                _ProductName = Product_Name(txtProductName.Text);
                _Category = cbCategory.Text;
                _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                _ExpDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                _Description = richTxtDescription.Text;
                _Quantity = Quantity(txtQuantity.Text);
                _SellPrice = SellingPrice(txtSellPrice.Text);

                showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description));
                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = showProductList;
            }
            catch(NumberFormatException nx)
            {
                MessageBox.Show(nx.Message);
            }
            catch (StringFormatException sx)
            {
                MessageBox.Show(sx.Message);
            }
            catch (CurrencyFormatException cx)
            {
                MessageBox.Show(cx.Message);
            }

        }
    }

    public class NumberFormatException : Exception
    {
        public NumberFormatException(string qty) : base(qty) { }
    }

    public class StringFormatException : Exception
    {
        public StringFormatException(string name) : base(name) { }
    }

    public class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string price) : base(price) { }
    }
}
