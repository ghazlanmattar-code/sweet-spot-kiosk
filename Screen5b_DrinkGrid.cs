using SweetSpotDessertShop412;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen5b_DrinkGrid : Form
    {
        private TableLayoutPanel mainLayout;

        private readonly (string Name, string Price, Bitmap Image, string Description, string Allergens)[] drinkItems = new[]
        {
            ("Iced Caramel Latte", "2.900 BHD", Properties.Resources.Iced_Caramel_Latte, "Smooth espresso blended with cold milk and sweet caramel syrup, served over ice. A refreshing and indulgent coffee treat.", "Contains: MILK.\r\nMay contain soy."),
            ("Vanilla Cold Brew", "2.600 BHD", Properties.Resources.Vanilla_Cold_Brew, "Smooth cold-brewed coffee infused with vanilla, served chilled. A mellow and naturally sweet coffee experience.", "May contain soy."),
            ("Nutella Hot Chocolate", "3.100 BHD", Properties.Resources.nutellahotchocolate, "Rich hot chocolate blended with Nutella hazelnut spread, topped with whipped cream. A decadent and warming treat.", "Contains: MILK, TREE NUTS (HAZELNUTS), SOY.\r\nMay contain peanuts and gluten."),
            ("V60 Pour-Over Coffee", "2.500 BHD", Properties.Resources.V60, "Artisan pour-over coffee made with precision brewing. Clean, aromatic, and highlights the coffee's natural flavors.", "No common allergens.\r\nMay contain traces of milk."),
            ("Peach Iced Tea", "2.200 BHD", Properties.Resources.Peach_Iced_Tea, "Refreshing black tea infused with sweet peach flavor, served ice-cold. A perfect thirst quencher on warm days.", "No common allergens.\r\nMay contain traces of sulfites."),
            ("Matcha Latte", "3.300 BHD", Properties.Resources.Matcha_Latte, "Premium Japanese matcha green tea whisked with steamed milk. Earthy, vibrant, and packed with antioxidants.", "Contains: MILK.\r\nMay contain soy.")
        };

        public Screen5b_DrinkGrid()
        {
            InitializeComponent();
            SetupResponsiveScreen();
            this.Resize += Screen5b_DrinkGrid_Resize;
            PopulateItems();
            UpdateBasketDisplay();
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
            lblCategory.Text = "Drinks";
            lblCount.Dock = DockStyle.Bottom;
            lblCount.AutoSize = false;
            lblCount.Height = 40;
            lblCount.Text = $"Showing {drinkItems.Length} items";
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
            lblItemCounter.Text = $"Showing items 1-{Math.Min(8, drinkItems.Length)} of {drinkItems.Length}";
            mainLayout.Controls.Add(pnlScrollIndicator, 0, 1);

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

            for (int i = 0; i < drinkItems.Length; i++)
            {
                var item = drinkItems[i];

                var itemPanel = new Panel
                {
                    Size = new Size(300, 420),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Margin = new Padding(15),
                    Cursor = Cursors.Hand
                };

                itemPanel.MouseEnter += (s, e) => {
                    itemPanel.BackColor = ColorTranslator.FromHtml("#F5F5F5");
                };
                itemPanel.MouseLeave += (s, e) => {
                    itemPanel.BackColor = Color.White;
                };

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
                case "Iced Caramel Latte":
                    detailScreen = new IcedCaramelLatteDetails("Drinks");
                    break;
                case "Vanilla Cold Brew":
                    detailScreen = new VanillaColdBrewDetails("Drinks");
                    break;
                case "Nutella Hot Chocolate":
                    detailScreen = new NutellaHotChocolateDetails("Drinks");
                    break;
                case "V60 Pour-Over Coffee":
                    detailScreen = new V60CoffeeDetails("Drinks");
                    break;
                case "Peach Iced Tea":
                    detailScreen = new PeachIcedTeaDetails("Drinks");
                    break;
                case "Matcha Latte":
                    detailScreen = new MatchaLatteDetails("Cakes");
                    break;
            }

            if (detailScreen != null)
            {
                detailScreen.Show();
                this.Hide();
            }
        }

        private void UpdateBasketDisplay()
        {
            lblBasket.Text = BasketManager.GetBasketText();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                UpdateBasketDisplay();
            }
        }

        private void Screen5b_DrinkGrid_Resize(object sender, EventArgs e)
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

        private void Screen5b_DrinkGrid_Load(object sender, EventArgs e) { }
        private void pnlScrollIndicator_Paint(object sender, PaintEventArgs e) { }
        private void lblScrollText_Click(object sender, EventArgs e) { }
    }
}