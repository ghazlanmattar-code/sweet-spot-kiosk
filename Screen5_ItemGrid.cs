using SweetSpotDessertShop412;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen5_ItemGrid : Form
    {
        private TableLayoutPanel mainLayout;

        private readonly (string Name, string Price, Bitmap Image, string Description, string Allergens)[] cakeItems = new[]
        {
            ("Chocolate Cake", "3.500 BHD", Properties.Resources.chocolatecake, "Rich chocolate cake with smooth fudge frosting, layered with chocolate ganache. Made fresh daily with premium Belgian chocolate.", "Contains: MILK, EGGS, GLUTEN (WHEAT), TREE NUTS.\r\nMay contain traces of soy and peanuts."),
            ("Red Velvet Cake", "4.200 BHD", Properties.Resources.redvelvetcake, "Moist red velvet cake with cream cheese frosting, topped with red velvet crumbs. A classic Southern delight with a hint of cocoa.", "Contains: MILK, EGGS, GLUTEN (WHEAT).\r\nMay contain traces of tree nuts and soy."),
            ("Black Forest Cake", "4.800 BHD", Properties.Resources.BlackForestCake, "Layers of chocolate sponge cake, cherry filling, and whipped cream, topped with chocolate shavings and cherries. Inspired by German tradition.", "Contains: MILK, EGGS, GLUTEN (WHEAT), TREE NUTS.\r\nMay contain traces of soy and peanuts."),
            ("Cheesecake", "5.000 BHD", Properties.Resources.Cheesecake, "Creamy New York-style cheesecake on a graham cracker crust, topped with fresh berries. Smooth and indulgent.", "Contains: MILK, EGGS, GLUTEN (WHEAT).\r\nMay contain traces of tree nuts and soy."),
            ("Carrot Cake", "3.900 BHD", Properties.Resources.Carrotcake, "Spiced carrot cake with cream cheese frosting and walnuts. A moist, flavorful treat made with fresh carrots and cinnamon.", "Contains: MILK, EGGS, GLUTEN (WHEAT), TREE NUTS.\r\nMay contain traces of soy."),
            ("Lemon Cake", "3.300 BHD", Properties.Resources.Lemoncake, "Tangy lemon cake with lemon glaze, topped with candied lemon slices. Bright and refreshing with a zesty kick.", "Contains: EGGS, GLUTEN (WHEAT).\r\nMay contain traces of milk and soy."),
        };

        public Screen5_ItemGrid()
        {
            InitializeComponent();
            SetupResponsiveScreen();
            this.Resize += Screen5_ItemGrid_Resize;
            PopulateItems();
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
                RowCount = 4,
                ColumnCount = 1,
                BackColor = ColorTranslator.FromHtml("#FFFEF7")
            };

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8));   
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 68));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 12));  
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            this.Controls.Add(mainLayout);

            pnlHeader.Dock = DockStyle.Fill;
            lblCategory.Dock = DockStyle.Left;
            lblCategory.AutoSize = true;
            lblCount.Dock = DockStyle.Bottom;
            lblCount.AutoSize = false;
            lblCount.Height = 40;
            btnSearch.Dock = DockStyle.Right;
            btnSearch.Width = 250;
            btnSearch.FlatStyle = FlatStyle.Flat;
            mainLayout.Controls.Add(pnlHeader, 0, 0);

            pnlScrollIndicator.Dock = DockStyle.Fill;
            lblScrollIcon.Dock = DockStyle.Left;
            lblScrollIcon.Width = 80;
            lblScrollIcon.AutoSize = false;
            lblScrollText.Dock = DockStyle.Left;
            lblScrollText.AutoSize = false;
            lblScrollText.Width = 600;
            lblItemCounter.Dock = DockStyle.Right;
            lblItemCounter.Width = 400;
            lblItemCounter.AutoSize = false;
            lblItemCounter.Text = $"Showing items 1-{Math.Min(8, cakeItems.Length)} of {cakeItems.Length}";
            mainLayout.Controls.Add(pnlScrollIndicator, 0, 1);

            lblCount.Text = $"Showing {cakeItems.Length} items";

            pnlScrollContainer.Dock = DockStyle.Fill;
            pnlScrollContainer.AutoScroll = true;
            flowItems.Dock = DockStyle.Top;
            flowItems.AutoSize = true;
            flowItems.WrapContents = true;
            mainLayout.Controls.Add(pnlScrollContainer, 0, 2);

            var bottomPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 3,
                BackColor = ColorTranslator.FromHtml("#FFFEF7")
            };
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            mainLayout.Controls.Add(bottomPanel, 0, 3);

            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Click += (s, e) => { new Screen2_CategoryMenu().Show(); this.Hide(); };
            bottomPanel.Controls.Add(btnBack, 0, 0);

            pnlBasket.Dock = DockStyle.Fill;
            lblBasket.Dock = DockStyle.Fill;
            lblBasket.TextAlign = ContentAlignment.MiddleCenter;
            lblBasket.AutoSize = false;
            bottomPanel.Controls.Add(pnlBasket, 1, 0);

            btnViewBasket.Text = "Proceed >";
            btnViewBasket.Dock = DockStyle.Fill;
            btnViewBasket.FlatStyle = FlatStyle.Flat;
            btnViewBasket.Click += (s, e) => { new Screen7_QRScanner().Show(); this.Hide(); };
            bottomPanel.Controls.Add(btnViewBasket, 2, 0);

            btnSearch.Click += (s, e) => { new Screen8_Search().Show(); this.Hide(); };
        }

        private void PopulateItems()
        {
            flowItems.Controls.Clear();

            for (int i = 0; i < cakeItems.Length; i++)
            {
                var item = cakeItems[i];

                var itemPanel = new Panel
                {
                    Size = new Size(300, 420),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Margin = new Padding(15),
                    Cursor = Cursors.Hand
                };

                itemPanel.MouseEnter += (s, e) => { itemPanel.BackColor = ColorTranslator.FromHtml("#F5F5F5"); };
                itemPanel.MouseLeave += (s, e) => { itemPanel.BackColor = Color.White; };

                var pic = new PictureBox
                {
                    Image = item.Image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Top,
                    Height = 280,
                    Cursor = Cursors.Hand
                };

                var lblName = new Label
                {
                    Text = item.Name,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 70,
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#3E2723"),
                    Cursor = Cursors.Hand
                };

                var lblPrice = new Label
                {
                    Text = item.Price,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 18, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#FF9800"),
                    Cursor = Cursors.Hand
                };

                itemPanel.Click += (s, e) => NavigateToDetails(item.Name, item.Price, item.Description, item.Allergens, item.Image);
                pic.Click += (s, e) => NavigateToDetails(item.Name, item.Price, item.Description, item.Allergens, item.Image);
                lblName.Click += (s, e) => NavigateToDetails(item.Name, item.Price, item.Description, item.Allergens, item.Image);
                lblPrice.Click += (s, e) => NavigateToDetails(item.Name, item.Price, item.Description, item.Allergens, item.Image);

                itemPanel.Controls.Add(lblPrice);
                itemPanel.Controls.Add(lblName);
                itemPanel.Controls.Add(pic);

                flowItems.Controls.Add(itemPanel);
            }
        }

        private void NavigateToDetails(string itemName, string itemPrice,
                               string description, string allergens, Bitmap image)
        {
            Form detailScreen = null;

            switch (itemName)
            {
                case "Chocolate Cake":
                    detailScreen = new ChocolateCakeDetails("Cakes");
                    break;
                case "Red Velvet Cake":
                    detailScreen = new RedVelvetCakeDetails("Cakes");
                    break;
                case "Black Forest Cake":
                    detailScreen = new BlackForestCakeDetails("Cakes");
                    break;
                case "Cheesecake":
                    detailScreen = new CheesecakeDetails("Cakes");
                    break;
                case "Carrot Cake":
                    detailScreen = new CarrotCakeDetails("Cakes");
                    break;
                case "Lemon Cake":
                    detailScreen = new LemonCakeDetails("Cakes");
                    break;
            }

            if (detailScreen != null)
            {
                detailScreen.Show();
                this.Hide();
            }
        }

        private void Screen5_ItemGrid_Resize(object sender, EventArgs e)
        {
            float scale = Math.Max(0.5f, Math.Min(this.Width, this.Height) / 1000f);
            lblCategory.Font = new Font("Arial", 40 * scale, FontStyle.Bold);
            lblCount.Font = new Font("Arial", 13 * scale);
            btnSearch.Font = new Font("Arial", 15 * scale, FontStyle.Bold);
            lblScrollText.Font = new Font("Arial", 18 * scale, FontStyle.Bold);
            lblScrollIcon.Font = new Font("Segoe UI Emoji", 24 * scale);
            lblItemCounter.Font = new Font("Arial", 16 * scale, FontStyle.Bold);
            lblBasket.Font = new Font("Arial", 18 * scale, FontStyle.Bold);
            btnBack.Font = new Font("Arial", 18 * scale, FontStyle.Bold);
            btnViewBasket.Font = new Font("Arial", 18 * scale, FontStyle.Bold);
        }

        private void Screen5_ItemGrid_Load(object sender, EventArgs e) { }
        private void pnlScrollIndicator_Paint(object sender, PaintEventArgs e) { }
        private void lblScrollText_Click(object sender, EventArgs e) { }
    }
}