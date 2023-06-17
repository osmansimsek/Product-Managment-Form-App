using FormApp.Data;
using FormApp.Entity;

namespace FormApp
{
    public partial class FormProductInfo : Form
    {
        private List<Product> products;
        private ProductFile productFile;

        public FormProductInfo()
        {
            InitializeComponent();
            productFile = new ProductFile();
            products = new List<Product>();
        }

        public void Display()
        {
            dataGridViewProduct.Rows.Clear();
            products.Clear();

            foreach (Product product in productFile.ListProduct())
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewProduct);
                row.Cells[0].Value = product.ProductName;
                row.Cells[1].Value = product.ProductCategory;
                row.Cells[2].Value = product.ProductPrice;
                row.Cells[3].Value = product.ProductWeight;
                row.Cells[4].Value = product.ProductColor;


                dataGridViewProduct.Rows.Add(row);
                dataGridViewProduct.Refresh();
                products.Add(product);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormProductAdd form = new FormProductAdd(this);
            form.ShowDialog();
        }

        private void FormProductInfo_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                FormProductUpdate form = new FormProductUpdate(this, e.RowIndex);
                form.ShowDialog();

                return;
            }

            if(e.ColumnIndex == 6)
            {
                if(MessageBox.Show("Are you want to delete student record?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    productFile.DeleteProduct(products, e.RowIndex);
                    Display();

                    MessageBox.Show("Product deleted successfully");
                }
            }
        }
    }
}