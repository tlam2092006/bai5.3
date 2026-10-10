namespace WinFormsApp5._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel topLayout;
        private GroupBox informationGroup;
        private TableLayoutPanel informationLayout;
        private GroupBox functionGroup;
        private FlowLayoutPanel buttonLayout;
        private FlowLayoutPanel searchLayout;
        private Label productIdLabel;
        private Label productNameLabel;
        private Label unitPriceLabel;
        private Label quantityLabel;
        private Label categoryLabel;
        private TextBox productIdTextBox;
        private TextBox productNameTextBox;
        private TextBox unitPriceTextBox;
        private TextBox quantityTextBox;
        private TextBox categoryTextBox;
        private TextBox searchTextBox;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private Button searchButton;
        private DataGridView dgvProducts;
        private BindingSource productsSource;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainLayout = new TableLayoutPanel();
            topLayout = new TableLayoutPanel();
            informationGroup = new GroupBox();
            informationLayout = new TableLayoutPanel();
            productIdLabel = new Label();
            productIdTextBox = new TextBox();
            productNameLabel = new Label();
            productNameTextBox = new TextBox();
            unitPriceLabel = new Label();
            unitPriceTextBox = new TextBox();
            quantityLabel = new Label();
            quantityTextBox = new TextBox();
            categoryLabel = new Label();
            categoryTextBox = new TextBox();
            functionGroup = new GroupBox();
            buttonLayout = new FlowLayoutPanel();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            searchLayout = new FlowLayoutPanel();
            searchTextBox = new TextBox();
            searchButton = new Button();
            dgvProducts = new DataGridView();
            productsSource = new BindingSource(components);
            mainLayout.SuspendLayout();
            topLayout.SuspendLayout();
            informationGroup.SuspendLayout();
            informationLayout.SuspendLayout();
            functionGroup.SuspendLayout();
            buttonLayout.SuspendLayout();
            searchLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsSource).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(topLayout, 0, 0);
            mainLayout.Controls.Add(dgvProducts, 0, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10);
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 205F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1050, 680);
            mainLayout.TabIndex = 0;
            // 
            // topLayout
            // 
            topLayout.ColumnCount = 2;
            topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68F));
            topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32F));
            topLayout.Controls.Add(informationGroup, 0, 0);
            topLayout.Controls.Add(functionGroup, 1, 0);
            topLayout.Dock = DockStyle.Fill;
            topLayout.Location = new Point(13, 13);
            topLayout.Name = "topLayout";
            topLayout.RowCount = 1;
            topLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            topLayout.Size = new Size(1024, 199);
            topLayout.TabIndex = 0;
            // 
            // informationGroup
            // 
            informationGroup.Controls.Add(informationLayout);
            informationGroup.Dock = DockStyle.Fill;
            informationGroup.Location = new Point(3, 3);
            informationGroup.Name = "informationGroup";
            informationGroup.Padding = new Padding(10);
            informationGroup.Size = new Size(690, 193);
            informationGroup.TabIndex = 0;
            informationGroup.TabStop = false;
            informationGroup.Text = "Thông tin sản phẩm";
            // 
            // informationLayout
            // 
            informationLayout.ColumnCount = 2;
            informationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            informationLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            informationLayout.Controls.Add(productIdLabel, 0, 0);
            informationLayout.Controls.Add(productIdTextBox, 1, 0);
            informationLayout.Controls.Add(productNameLabel, 0, 1);
            informationLayout.Controls.Add(productNameTextBox, 1, 1);
            informationLayout.Controls.Add(unitPriceLabel, 0, 2);
            informationLayout.Controls.Add(unitPriceTextBox, 1, 2);
            informationLayout.Controls.Add(quantityLabel, 0, 3);
            informationLayout.Controls.Add(quantityTextBox, 1, 3);
            informationLayout.Controls.Add(categoryLabel, 0, 4);
            informationLayout.Controls.Add(categoryTextBox, 1, 4);
            informationLayout.Dock = DockStyle.Fill;
            informationLayout.Location = new Point(10, 30);
            informationLayout.Name = "informationLayout";
            informationLayout.Padding = new Padding(5);
            informationLayout.RowCount = 5;
            informationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            informationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            informationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            informationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            informationLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            informationLayout.Size = new Size(670, 153);
            informationLayout.TabIndex = 0;
            // 
            // productIdLabel
            // 
            productIdLabel.Dock = DockStyle.Fill;
            productIdLabel.Location = new Point(8, 5);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(104, 28);
            productIdLabel.TabIndex = 0;
            productIdLabel.Text = "Mã SP:";
            productIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productIdTextBox
            // 
            productIdTextBox.Dock = DockStyle.Fill;
            productIdTextBox.Location = new Point(118, 8);
            productIdTextBox.Name = "productIdTextBox";
            productIdTextBox.Size = new Size(544, 27);
            productIdTextBox.TabIndex = 1;
            // 
            // productNameLabel
            // 
            productNameLabel.Dock = DockStyle.Fill;
            productNameLabel.Location = new Point(8, 33);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(104, 28);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "Tên SP:";
            productNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Dock = DockStyle.Fill;
            productNameTextBox.Location = new Point(118, 36);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(544, 27);
            productNameTextBox.TabIndex = 3;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.Dock = DockStyle.Fill;
            unitPriceLabel.Location = new Point(8, 61);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new Size(104, 28);
            unitPriceLabel.TabIndex = 4;
            unitPriceLabel.Text = "Đơn giá:";
            unitPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // unitPriceTextBox
            // 
            unitPriceTextBox.Dock = DockStyle.Fill;
            unitPriceTextBox.Location = new Point(118, 64);
            unitPriceTextBox.Name = "unitPriceTextBox";
            unitPriceTextBox.Size = new Size(544, 27);
            unitPriceTextBox.TabIndex = 5;
            // 
            // quantityLabel
            // 
            quantityLabel.Dock = DockStyle.Fill;
            quantityLabel.Location = new Point(8, 89);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(104, 28);
            quantityLabel.TabIndex = 6;
            quantityLabel.Text = "Số lượng:";
            quantityLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Dock = DockStyle.Fill;
            quantityTextBox.Location = new Point(118, 92);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(544, 27);
            quantityTextBox.TabIndex = 7;
            // 
            // categoryLabel
            // 
            categoryLabel.Dock = DockStyle.Fill;
            categoryLabel.Location = new Point(8, 117);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(104, 31);
            categoryLabel.TabIndex = 8;
            categoryLabel.Text = "Danh mục:";
            categoryLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // categoryTextBox
            // 
            categoryTextBox.Dock = DockStyle.Fill;
            categoryTextBox.Location = new Point(118, 120);
            categoryTextBox.Name = "categoryTextBox";
            categoryTextBox.Size = new Size(544, 27);
            categoryTextBox.TabIndex = 9;
            // 
            // functionGroup
            // 
            functionGroup.Controls.Add(buttonLayout);
            functionGroup.Controls.Add(searchLayout);
            functionGroup.Dock = DockStyle.Fill;
            functionGroup.Location = new Point(699, 3);
            functionGroup.Name = "functionGroup";
            functionGroup.Padding = new Padding(10);
            functionGroup.Size = new Size(322, 193);
            functionGroup.TabIndex = 1;
            functionGroup.TabStop = false;
            functionGroup.Text = "Chức năng";
            // 
            // buttonLayout
            // 
            buttonLayout.AutoSize = true;
            buttonLayout.Controls.Add(addButton);
            buttonLayout.Controls.Add(updateButton);
            buttonLayout.Controls.Add(deleteButton);
            buttonLayout.Dock = DockStyle.Top;
            buttonLayout.Location = new Point(10, 130);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.Size = new Size(302, 38);
            buttonLayout.TabIndex = 0;
            buttonLayout.WrapContents = false;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(82, 32);
            addButton.TabIndex = 0;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddProduct;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(91, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(82, 32);
            updateButton.TabIndex = 1;
            updateButton.Text = "Sửa";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateProduct;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(179, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(82, 32);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Xóa";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteProduct;
            // 
            // searchLayout
            // 
            searchLayout.Controls.Add(searchTextBox);
            searchLayout.Controls.Add(searchButton);
            searchLayout.Dock = DockStyle.Top;
            searchLayout.Location = new Point(10, 30);
            searchLayout.Margin = new Padding(0, 10, 0, 0);
            searchLayout.Name = "searchLayout";
            searchLayout.Padding = new Padding(0, 10, 0, 0);
            searchLayout.Size = new Size(302, 100);
            searchLayout.TabIndex = 1;
            searchLayout.WrapContents = false;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(3, 13);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(145, 27);
            searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(154, 13);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(95, 32);
            searchButton.TabIndex = 1;
            searchButton.Text = "Tìm kiếm";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchProducts;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.Window;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.DataSource = productsSource;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(13, 218);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1024, 449);
            dgvProducts.TabIndex = 1;
            dgvProducts.SelectionChanged += ProductsGrid_SelectionChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 680);
            Controls.Add(mainLayout);
            MinimumSize = new Size(850, 550);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh sách sản phẩm";
            mainLayout.ResumeLayout(false);
            topLayout.ResumeLayout(false);
            informationGroup.ResumeLayout(false);
            informationLayout.ResumeLayout(false);
            informationLayout.PerformLayout();
            functionGroup.ResumeLayout(false);
            functionGroup.PerformLayout();
            buttonLayout.ResumeLayout(false);
            searchLayout.ResumeLayout(false);
            searchLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
