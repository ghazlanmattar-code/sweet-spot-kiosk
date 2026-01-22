namespace SweetSpotDessertShop412
{
    partial class LamingtonCoconutChocolateCakeDetails
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlAllergenWarning = new System.Windows.Forms.Panel();
            this.lblAllergenContent = new System.Windows.Forms.Label();
            this.lblAllergenTitle = new System.Windows.Forms.Label();
            this.lblAllergenIcon = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToBasket = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.pnlAllergenWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();

            this.picProduct.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picProduct.Location = new System.Drawing.Point(60, 120);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(800, 800);
            this.picProduct.TabIndex = 0;
            this.picProduct.TabStop = false;

            this.lblItemName.Font = new System.Drawing.Font("Arial", 47F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.lblItemName.Location = new System.Drawing.Point(864, 120);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(1054, 146);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Lamington Coconut-Chocolate Cake";

            this.lblPrice.Font = new System.Drawing.Font("Arial", 34F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(255, 152, 0);
            this.lblPrice.Location = new System.Drawing.Point(900, 244);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(415, 90);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "BHD 3.800";

            this.lblDescription.Font = new System.Drawing.Font("Arial", 18F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.lblDescription.Location = new System.Drawing.Point(900, 348);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(960, 155);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";

            this.pnlAllergenWarning.BackColor = System.Drawing.Color.FromArgb(255, 235, 238);
            this.pnlAllergenWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAllergenWarning.Controls.Add(this.lblAllergenContent);
            this.pnlAllergenWarning.Controls.Add(this.lblAllergenTitle);
            this.pnlAllergenWarning.Controls.Add(this.lblAllergenIcon);
            this.pnlAllergenWarning.Location = new System.Drawing.Point(900, 501);
            this.pnlAllergenWarning.Name = "pnlAllergenWarning";
            this.pnlAllergenWarning.Size = new System.Drawing.Size(960, 166);
            this.pnlAllergenWarning.TabIndex = 4;

            this.lblAllergenContent.Font = new System.Drawing.Font("Arial", 15F);
            this.lblAllergenContent.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.lblAllergenContent.Location = new System.Drawing.Point(165, 75);
            this.lblAllergenContent.Name = "lblAllergenContent";
            this.lblAllergenContent.Size = new System.Drawing.Size(790, 81);
            this.lblAllergenContent.TabIndex = 2;
            this.lblAllergenContent.Text = "Allergen information";

            this.lblAllergenTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblAllergenTitle.ForeColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.lblAllergenTitle.Location = new System.Drawing.Point(161, 11);
            this.lblAllergenTitle.Name = "lblAllergenTitle";
            this.lblAllergenTitle.Size = new System.Drawing.Size(708, 60);
            this.lblAllergenTitle.TabIndex = 1;
            this.lblAllergenTitle.Text = "ALLERGEN INFORMATION";

            this.lblAllergenIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 32F);
            this.lblAllergenIcon.ForeColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.lblAllergenIcon.Location = new System.Drawing.Point(20, 38);
            this.lblAllergenIcon.Name = "lblAllergenIcon";
            this.lblAllergenIcon.Size = new System.Drawing.Size(103, 85);
            this.lblAllergenIcon.TabIndex = 0;
            this.lblAllergenIcon.Text = "⚠️";

            this.lblQuantity.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(900, 717);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(235, 60);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";

            this.numQuantity.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.numQuantity.Location = new System.Drawing.Point(1140, 706);
            this.numQuantity.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            this.numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(150, 81);
            this.numQuantity.TabIndex = 6;
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });

            this.btnAddToBasket.BackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            this.btnAddToBasket.Cursor = System.Windows.Forms.Cursors.No;
            this.btnAddToBasket.Enabled = false;
            this.btnAddToBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToBasket.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.btnAddToBasket.ForeColor = System.Drawing.Color.White;
            this.btnAddToBasket.Location = new System.Drawing.Point(900, 840);
            this.btnAddToBasket.Name = "btnAddToBasket";
            this.btnAddToBasket.Size = new System.Drawing.Size(927, 80);
            this.btnAddToBasket.TabIndex = 7;
            this.btnAddToBasket.Text = "REVIEW ALLERGEN INFO FIRST";
            this.btnAddToBasket.UseVisualStyleBackColor = false;

            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(62, 39, 35);
            this.btnBack.Location = new System.Drawing.Point(900, 969);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(296, 52);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "< Back to Menu";
            this.btnBack.UseVisualStyleBackColor = false;

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 254, 247);
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddToBasket);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.pnlAllergenWarning);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.picProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LamingtonCoconutChocolateCakeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lamington Coconut-Chocolate Cake Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LamingtonCoconutChocolateCakeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.pnlAllergenWarning.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlAllergenWarning;
        private System.Windows.Forms.Label lblAllergenContent;
        private System.Windows.Forms.Label lblAllergenTitle;
        private System.Windows.Forms.Label lblAllergenIcon;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAddToBasket;
        private System.Windows.Forms.Button btnBack;
    }
}