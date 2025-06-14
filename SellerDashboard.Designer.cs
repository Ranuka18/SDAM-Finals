namespace Seller
{
    partial class SellerDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnViewProducts;
        private System.Windows.Forms.Button btnViewOrders;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(55, 82);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(120, 30);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(245, 82);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(120, 30);
            this.btnViewProducts.TabIndex = 1;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(406, 82);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(120, 30);
            this.btnViewOrders.TabIndex = 2;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // SellerDashboard
            // 
            this.ClientSize = new System.Drawing.Size(578, 200);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnViewOrders);
            this.Name = "SellerDashboard";
            this.Text = "Seller Dashboard";
            this.ResumeLayout(false);
        }
    }
}