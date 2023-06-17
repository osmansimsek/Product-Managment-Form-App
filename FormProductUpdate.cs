using FormApp.Data;
using FormApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class FormProductUpdate : Form
    {

        private readonly FormProductInfo _formProductInfo;
        private List<Product> _products;
        private ProductFile _productFile;
        private int _index;

        public FormProductUpdate(FormProductInfo formProductInfo, int index)
        {
            InitializeComponent();
            this._formProductInfo = formProductInfo;
            this._productFile = new ProductFile();
            this._index = index;
        }

        private void FormProductUpdate_Load(object sender, EventArgs e)
        {
            this._products = _productFile.ListProduct();

            txtName.Text = _products[this._index].ProductName.Trim();
            txtCategory.Text = _products[this._index].ProductCategory.Trim();
            txtPrice.Text = _products[this._index].ProductPrice.ToString().Trim();
            txtWeight.Text = _products[this._index].ProductWeight.ToString().Trim();
            txtColor.Text = _products[this._index].ProductColor.Trim();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Product name is empty");
                return;
            }

            if (txtCategory.Text.Trim().Length == 0)
            {
                MessageBox.Show("Product category is empty");
                return;
            }

            if (txtPrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("Product price is empty");
                return;
            }

            if (txtWeight.Text.Trim().Length == 0)
            {
                MessageBox.Show("Product weight is empty");
                return;
            }

            if (txtColor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Product color is empty");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrice.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Product price is only numbers");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtWeight.Text, "^[0-9]+$"))
            {
                MessageBox.Show("Product weight is only numbers");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtColor.Text, "^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$"))
            {
                MessageBox.Show("Product color is not valid hex");
                return;
            }

            _products[this._index].ProductName = txtName.Text.Trim();
            _products[this._index].ProductCategory = txtCategory.Text.Trim();
            _products[this._index].ProductColor = txtColor.Text.Trim();
            _products[this._index].ProductPrice = Convert.ToDouble(txtPrice.Text.Trim());
            _products[this._index].ProductWeight = Convert.ToDouble(txtWeight.Text.Trim());

            this._productFile.UpdateProduct(_products);

            MessageBox.Show("Product update successfully");
            this._formProductInfo.Display();
            this.Close();
        }
    }
}
