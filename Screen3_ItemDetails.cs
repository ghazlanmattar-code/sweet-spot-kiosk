using SweetSpotDessertShop412;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen3_ItemDetails : Form
    {
        private TableLayoutPanel mainLayout;

        public Screen3_ItemDetails()
        {
            InitializeComponent();
            SetupResponsiveScreen();
            this.Resize += Screen3_ItemDetails_Resize;
        }

        private void SetupResponsiveScreen()
        {
            
            this.Controls.Clear();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#FFFEF7");

            mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 2,
                BackColor = ColorTranslator.FromHtml("#FFFEF7")
            };

            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10));

            this.Controls.Add(mainLayout);

            picProduct.Dock = DockStyle.Fill;
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            mainLayout.Controls.Add(picProduct, 0, 0);

            var detailsPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 6,
                ColumnCount = 1,
                BackColor = ColorTranslator.FromHtml("#FFFEF7")
            };

            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));  
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10));  
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20));  
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));  
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));  
            detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15));  

            mainLayout.Controls.Add(detailsPanel, 1, 0);

            
            lblItemName.Dock = DockStyle.Fill;
            lblItemName.TextAlign = ContentAlignment.MiddleLeft;
            lblItemName.AutoSize = false;
            detailsPanel.Controls.Add(lblItemName, 0, 0);

            
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            lblPrice.AutoSize = false;
            detailsPanel.Controls.Add(lblPrice, 0, 1);

            
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.TextAlign = ContentAlignment.TopLeft;
            lblDescription.AutoSize = false;
            detailsPanel.Controls.Add(lblDescription, 0, 2);

           
            pnlAllergenWarning.Dock = DockStyle.Fill;
            lblAllergenIcon.Dock = DockStyle.Left;
            lblAllergenIcon.AutoSize = false;
            lblAllergenIcon.Width = 80;
            lblAllergenTitle.Dock = DockStyle.Top;
            lblAllergenTitle.AutoSize = false;
            lblAllergenTitle.Height = 50;
            lblAllergenContent.Dock = DockStyle.Fill;
            lblAllergenContent.AutoSize = false;
            detailsPanel.Controls.Add(pnlAllergenWarning, 0, 3);

            
            var qtyPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = ColorTranslator.FromHtml("#FFFEF7")
            };
            qtyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30));
            qtyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));

            detailsPanel.Controls.Add(qtyPanel, 0, 4);

            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
            lblQuantity.AutoSize = false;
            qtyPanel.Controls.Add(lblQuantity, 0, 0);

            Panel numPanel = new Panel { Dock = DockStyle.Fill };
            numQuantity.Anchor = AnchorStyles.Left;
            numQuantity.Width = 150;
            numPanel.Controls.Add(numQuantity);
            qtyPanel.Controls.Add(numPanel, 1, 0);

            
            btnAddToBasket.Dock = DockStyle.Fill;
            btnAddToBasket.FlatStyle = FlatStyle.Flat;
            btnAddToBasket.Click += (s, e) => { new Screen4_BasketReview().Show(); this.Hide(); };
            detailsPanel.Controls.Add(btnAddToBasket, 0, 5);

            
            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Click += (s, e) => { new Screen5_ItemGrid().Show(); this.Hide(); };
            mainLayout.Controls.Add(btnBack, 0, 1);
            mainLayout.SetColumnSpan(btnBack, 2);
        }

        private void Screen3_ItemDetails_Resize(object sender, EventArgs e)
        {
            float scale = Math.Max(0.5f, Math.Min(this.Width, this.Height) / 1000f);
            lblItemName.Font = new Font("Arial", 47 * scale, FontStyle.Bold);
            lblPrice.Font = new Font("Arial", 34 * scale, FontStyle.Bold);
            lblDescription.Font = new Font("Arial", 18 * scale);
            lblAllergenTitle.Font = new Font("Arial", 24 * scale, FontStyle.Bold);
            lblAllergenContent.Font = new Font("Arial", 15 * scale);
            lblAllergenIcon.Font = new Font("Segoe UI Emoji", 32 * scale);
            lblQuantity.Font = new Font("Arial", 24 * scale, FontStyle.Bold);
            numQuantity.Font = new Font("Arial", 32 * scale, FontStyle.Bold);
            btnAddToBasket.Font = new Font("Arial", 28 * scale, FontStyle.Bold);
            btnBack.Font = new Font("Arial", 18 * scale, FontStyle.Bold);
        }

        private void Screen3_ItemDetails_Load(object sender, EventArgs e) { }
        private void lblAllergenTitle_Click(object sender, EventArgs e) { }
    }
}