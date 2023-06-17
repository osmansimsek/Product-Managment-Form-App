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
    public partial class FormProductAdd : Form
    {
        private readonly FormProductInfo _formProductInfo;
        private ProductFile _productFile;

        public FormProductAdd(FormProductInfo formProductInfo)
        {
            InitializeComponent();
            this._formProductInfo = formProductInfo;
            this._productFile = new ProductFile();
        }

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            txtCategory.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtColor.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
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

            Product product = new Product
            {
                ProductName = txtName.Text.Trim(),
                ProductCategory = txtCategory.Text.Trim(),
                ProductColor = txtColor.Text.Trim(),
                ProductPrice = Convert.ToDouble(txtPrice.Text.Trim()),
                ProductWeight = Convert.ToDouble(txtWeight.Text.Trim()),
            };

            _productFile.SaveProduct(product);

            MessageBox.Show("Product added successfully");
            this._formProductInfo.Display();
            this.Close();
        }

  
    }
}
