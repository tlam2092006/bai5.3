using System.Globalization;

namespace WinFormsApp5._3
{
    public partial class Form1 : Form
    {
        private readonly List<Product> products = new();
        private Product? selectedProduct;

        public Form1()
        {
            InitializeComponent();
            InitializeProductGrid();
            RefreshProductsGrid();
        }

        private void InitializeProductGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.Columns.Clear();
            dgvProducts.Columns.AddRange(
                new DataGridViewTextBoxColumn
                {
                    Name = "productIdColumn",
                    DataPropertyName = nameof(Product.ProductId),
                    HeaderText = "Mã SP",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "productNameColumn",
                    DataPropertyName = nameof(Product.ProductName),
                    HeaderText = "Tên SP",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "unitPriceColumn",
                    DataPropertyName = nameof(Product.UnitPrice),
                    HeaderText = "Đơn giá",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "quantityColumn",
                    DataPropertyName = nameof(Product.Quantity),
                    HeaderText = "Số lượng",
                    ReadOnly = true
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "categoryColumn",
                    DataPropertyName = nameof(Product.Category),
                    HeaderText = "Danh mục",
                    ReadOnly = true
                });
        }

        private void AddProduct(object? sender, EventArgs e)
        {
            var product = ReadProductFromInputs();
            if (product is null)
            {
                return;
            }

            if (products.Any(item => string.Equals(item.ProductId, product.ProductId, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            products.Add(product);
            searchTextBox.Clear();
            RefreshProductsGrid();
        }

        private void UpdateProduct(object? sender, EventArgs e)
        {
            if (selectedProduct is null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var updatedProduct = ReadProductFromInputs();
            if (updatedProduct is null)
            {
                return;
            }

            if (products.Any(item => !ReferenceEquals(item, selectedProduct) &&
                                     string.Equals(item.ProductId, updatedProduct.ProductId, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            selectedProduct.ProductId = updatedProduct.ProductId;
            selectedProduct.ProductName = updatedProduct.ProductName;
            selectedProduct.UnitPrice = updatedProduct.UnitPrice;
            selectedProduct.Quantity = updatedProduct.Quantity;
            selectedProduct.Category = updatedProduct.Category;
            RefreshProductsGrid(searchTextBox.Text);
        }

        private void DeleteProduct(object? sender, EventArgs e)
        {
            if (selectedProduct is null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmation = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa sản phẩm '{selectedProduct.ProductName}'?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                products.Remove(selectedProduct);
                selectedProduct = null;
                RefreshProductsGrid(searchTextBox.Text);
            }
        }

        private void SearchProducts(object? sender, EventArgs e)
        {
            RefreshProductsGrid(searchTextBox.Text);
        }

        private void ProductsGrid_SelectionChanged(object? sender, EventArgs e)
        {
            selectedProduct = dgvProducts.CurrentRow?.DataBoundItem as Product;
            if (selectedProduct is null)
            {
                return;
            }

            productIdTextBox.Text = selectedProduct.ProductId;
            productNameTextBox.Text = selectedProduct.ProductName;
            unitPriceTextBox.Text = selectedProduct.UnitPrice.ToString(CultureInfo.CurrentCulture);
            quantityTextBox.Text = selectedProduct.Quantity.ToString(CultureInfo.CurrentCulture);
            categoryTextBox.Text = selectedProduct.Category;
        }

        private Product? ReadProductFromInputs()
        {
            if (string.IsNullOrWhiteSpace(productIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(productNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(categoryTextBox.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (!decimal.TryParse(unitPriceTextBox.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Đơn giá phải là số không âm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                unitPriceTextBox.Focus();
                return null;
            }

            if (!int.TryParse(quantityTextBox.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out var quantity) || quantity < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên không âm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                quantityTextBox.Focus();
                return null;
            }

            return new Product
            {
                ProductId = productIdTextBox.Text.Trim(),
                ProductName = productNameTextBox.Text.Trim(),
                UnitPrice = unitPrice,
                Quantity = quantity,
                Category = categoryTextBox.Text.Trim()
            };
        }

        private void RefreshProductsGrid(string? searchTerm = null)
        {
            var productsToDisplay = string.IsNullOrWhiteSpace(searchTerm)
                ? products
                : products.Where(product => product.ProductName.Contains(searchTerm.Trim(), StringComparison.CurrentCultureIgnoreCase)).ToList();

            productsSource.DataSource = productsToDisplay;
            productsSource.ResetBindings(false);
        }
    }
}
