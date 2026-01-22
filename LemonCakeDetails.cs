using System;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
    {
        public partial class LemonCakeDetails : Form
        {
            private TableLayoutPanel mainLayout;
            private string returnCategory = "Drinks";
            private bool allergenAcknowledged = false; 

            public LemonCakeDetails()
            {
                InitializeComponent();
                SetupResponsiveScreen();
                this.Resize += LemonCakeDetails_Resize;
                LoadItemDetails();
            }

            public LemonCakeDetails(string category) : this()
            {
                returnCategory = category;
            }

            private void LoadItemDetails()
            {
                picProduct.Image = Properties.Resources.Lemoncake;
                lblItemName.Text = "Lemon Cake";
                lblPrice.Text = "BHD 3.300";
                lblDescription.Text = "Light and zesty lemon sponge with tangy lemon glaze. Refreshingly citrusy with the perfect balance of sweet and tart.";
                lblAllergenContent.Text = "Contains: MILK, EGGS, GLUTEN (WHEAT).\r\nMay contain traces of soy and tree nuts.";
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
                    BackColor = ColorTranslator.FromHtml("#FFFEF7"),
                    Padding = new Padding(50)
                };

                detailsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
                detailsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
                detailsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 150));
                detailsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
                detailsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120));
                detailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

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
                pnlAllergenWarning.Cursor = Cursors.Hand;
                pnlAllergenWarning.Click += PnlAllergenWarning_Click;

                lblAllergenIcon.Dock = DockStyle.Left;
                lblAllergenIcon.AutoSize = false;
                lblAllergenIcon.Width = 80;
                lblAllergenIcon.Cursor = Cursors.Hand;
                lblAllergenIcon.Click += PnlAllergenWarning_Click;

                lblAllergenTitle.Dock = DockStyle.Top;
                lblAllergenTitle.AutoSize = false;
                lblAllergenTitle.Height = 50;
                lblAllergenTitle.Cursor = Cursors.Hand;
                lblAllergenTitle.Click += PnlAllergenWarning_Click;

                lblAllergenContent.Dock = DockStyle.Fill;
                lblAllergenContent.AutoSize = false;
                lblAllergenContent.Cursor = Cursors.Hand;
                lblAllergenContent.Click += PnlAllergenWarning_Click;

                detailsPanel.Controls.Add(pnlAllergenWarning, 0, 3);

                var qtyPanel = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 4,
                    RowCount = 1,
                    BackColor = ColorTranslator.FromHtml("#FFFEF7")
                };
                qtyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200));
                qtyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
                qtyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
                qtyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));

                detailsPanel.Controls.Add(qtyPanel, 0, 4);

                lblQuantity.Dock = DockStyle.Fill;
                lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
                lblQuantity.AutoSize = false;
                lblQuantity.Text = "Quantity:";
                qtyPanel.Controls.Add(lblQuantity, 0, 0);

                Button btnMinus = new Button
                {
                    Text = "−",
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 32, FontStyle.Bold),
                    BackColor = ColorTranslator.FromHtml("#FF9800"),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                btnMinus.FlatAppearance.BorderSize = 0;
                btnMinus.Click += (s, e) => {
                    if (numQuantity.Value > numQuantity.Minimum)
                        numQuantity.Value--;
                };
                qtyPanel.Controls.Add(btnMinus, 1, 0);

                numQuantity.Dock = DockStyle.Fill;
                numQuantity.TextAlign = HorizontalAlignment.Center;
                numQuantity.ReadOnly = true;
                qtyPanel.Controls.Add(numQuantity, 2, 0);

                Button btnPlus = new Button
                {
                    Text = "+",
                    Dock = DockStyle.Fill,
                    Font = new Font("Arial", 32, FontStyle.Bold),
                    BackColor = ColorTranslator.FromHtml("#4CAF50"),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                btnPlus.FlatAppearance.BorderSize = 0;
                btnPlus.Click += (s, e) => {
                    if (numQuantity.Value < numQuantity.Maximum)
                        numQuantity.Value++;
                };
                qtyPanel.Controls.Add(btnPlus, 3, 0);

                btnAddToBasket.Dock = DockStyle.Fill;
                btnAddToBasket.FlatStyle = FlatStyle.Flat;
                btnAddToBasket.Enabled = false;
                btnAddToBasket.BackColor = ColorTranslator.FromHtml("#CCCCCC");
                btnAddToBasket.ForeColor = Color.White;
                btnAddToBasket.Text = "REVIEW ALLERGEN INFO FIRST";
                btnAddToBasket.Cursor = Cursors.No;
                btnAddToBasket.FlatAppearance.BorderSize = 0;
                btnAddToBasket.Click += BtnAddToBasket_Click;
                btnAddToBasket.Margin = new Padding(0, 20, 0, 0);
                detailsPanel.Controls.Add(btnAddToBasket, 0, 5);

                btnBack.Dock = DockStyle.Fill;
                btnBack.FlatStyle = FlatStyle.Flat;
                btnBack.Click += (s, e) => { ReturnToCategoryScreen(); };
                mainLayout.Controls.Add(btnBack, 0, 1);
                mainLayout.SetColumnSpan(btnBack, 2);
            }

            
            private void PnlAllergenWarning_Click(object sender, EventArgs e)
            {
                if (!allergenAcknowledged)
                {
                    allergenAcknowledged = true;
                    pnlAllergenWarning.BackColor = ColorTranslator.FromHtml("#C8E6C9");
                    pnlAllergenWarning.Cursor = Cursors.Default;
                    btnAddToBasket.Enabled = true;
                    btnAddToBasket.Cursor = Cursors.Hand;
                    btnAddToBasket.BackColor = ColorTranslator.FromHtml("#4CAF50");
                    btnAddToBasket.Text = "ADD TO BASKET";
                    MessageBox.Show(
                        "✓ Allergen information acknowledged.\n\nYou can now add this item to your basket.",
                        "Allergen Info Read",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }

            
            private void BtnAddToBasket_Click(object sender, EventArgs e)
            {
                if (!allergenAcknowledged)
                {
                    MessageBox.Show(
                        "Please click on the allergen information panel to acknowledge you have read it before adding to basket.",
                        "Review Allergen Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                int quantity = (int)numQuantity.Value;
                for (int i = 0; i < quantity; i++)
                {
                    BasketManager.AddItem();
                }
                ShowPostAddDialog();
            }

            private void ShowPostAddDialog()
            {
                Form dialogForm = new Form
                {
                    Text = "Item Added!",
                    Size = new Size(700, 400),
                    StartPosition = FormStartPosition.CenterScreen,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false,
                    BackColor = ColorTranslator.FromHtml("#FFFEF7")
                };

                Label lblMessage = new Label
                {
                    Text = $"✓ {numQuantity.Value} x Iced Caramel Latte added to basket!\n\nWhat would you like to do next?", 
                    Font = new Font("Arial", 18, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#3E2723"),
                    AutoSize = false,
                    Size = new Size(660, 120),
                    Location = new Point(20, 20),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Button btnContinueShopping = new Button
                {
                    Text = "Continue Shopping in " + returnCategory,
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    Size = new Size(660, 70),
                    Location = new Point(20, 150),
                    BackColor = ColorTranslator.FromHtml("#2196F3"),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                btnContinueShopping.FlatAppearance.BorderSize = 0;
                btnContinueShopping.Click += (s, e) => {
                    dialogForm.Close();
                    ReturnToCategoryScreen();
                };

                Button btnProceedToCheckout = new Button
                {
                    Text = "Proceed to Loyalty Scan & Checkout",
                    Font = new Font("Arial", 16, FontStyle.Bold),
                    Size = new Size(660, 70),
                    Location = new Point(20, 240),
                    BackColor = ColorTranslator.FromHtml("#4CAF50"),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                btnProceedToCheckout.FlatAppearance.BorderSize = 0;
                btnProceedToCheckout.Click += (s, e) => {
                    dialogForm.Close();
                    new Screen7_QRScanner().Show();
                    this.Hide();
                };

                dialogForm.Controls.Add(lblMessage);
                dialogForm.Controls.Add(btnContinueShopping);
                dialogForm.Controls.Add(btnProceedToCheckout);

                dialogForm.ShowDialog();
            }

            private void ReturnToCategoryScreen()
            {
                switch (returnCategory.ToLower())
                {
                    case "drinks":
                        new Screen5b_DrinkGrid().Show();
                        break;
                    case "specials":
                        new Screen5c_SpecialGrid().Show();
                        break;
                    default:
                        new Screen5_ItemGrid().Show();
                        break;
                }
                this.Hide();
            }

            private void LemonCakeDetails_Resize(object sender, EventArgs e)
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

            private void LemonCakeDetails_Load(object sender, EventArgs e) { }
        }
    }