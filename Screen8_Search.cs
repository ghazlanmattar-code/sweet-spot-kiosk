using SweetSpotDessertShop412;
using SweetSpotDessertShop412.Components;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen8_Search : Form
    {
        private TableLayoutPanel mainLayout;
        private OnScreenKeyboard keyboard;
        private string[] allDesserts = new string[] {
            // CAKES
            "🍰 Chocolate Cake - BHD 3.500",
            "🎂 Red Velvet Cake - BHD 4.200",
            "🍰 Black Forest Cake - BHD 4.800",
            "🍰 Cheesecake - BHD 5.000",
            "🥕 Carrot Cake - BHD 3.900",
            "🍋 Lemon Cake - BHD 3.300",
            
            // DRINKS
            "☕ Iced Caramel Latte - BHD 2.900",
            "☕ Vanilla Cold Brew - BHD 2.600",
            "🍫 Nutella Hot Chocolate - BHD 3.100",
            "☕ V60 Pour-Over Coffee - BHD 2.500",
            "🍑 Peach Iced Tea - BHD 2.200",
            "🍵 Matcha Latte - BHD 3.300",
            
            // SPECIALS
            "🥥 Lamington Coconut-Chocolate Cake - BHD 3.800",
            "🧀 Halawet el Jibn - BHD 3.600",
            "☕ Dalgona Coffee - BHD 2.700",
            "⭐ Sweet Spot Signature - BHD 3.300"
        };

        public Screen8_Search()
        {
            InitializeComponent();
            SetupResponsiveScreen();
            this.Resize += Screen8_Search_Resize;
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
                RowCount = 3,
                ColumnCount = 1,
                BackColor = ColorTranslator.FromHtml("#FFFEF7")
            };

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 70));  
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            this.Controls.Add(mainLayout);

            txtSearch.Dock = DockStyle.Fill;
            txtSearch.ReadOnly = true; 
            txtSearch.Multiline = true;
            txtSearch.TextAlign = HorizontalAlignment.Center;
            txtSearch.Text = "Search for desserts...";
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Cursor = Cursors.Hand;

            txtSearch.Click += (s, e) => {
                if (txtSearch.Text == "Search for desserts...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
                ShowKeyboard();
            };

            txtSearch.TextChanged += (s, e) => {
                FilterResults();
            };

            mainLayout.Controls.Add(txtSearch, 0, 0);

            btnShowKeyboard.Dock = DockStyle.Fill;
            btnShowKeyboard.FlatStyle = FlatStyle.Flat;
            btnShowKeyboard.Click += (s, e) => {
                if (txtSearch.Text == "Search for desserts...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
                ShowKeyboard();
            };
            mainLayout.Controls.Add(btnShowKeyboard, 0, 1);

            lstResults.Dock = DockStyle.Fill;
            lstResults.Items.Clear(); 
            lstResults.SelectedIndexChanged += (s, e) => {
                if (lstResults.SelectedItem != null && lstResults.SelectedItem.ToString() != "No results found")
                {
                    if (keyboard != null && !keyboard.IsDisposed)
                        keyboard.Close();

                    string selectedItem = lstResults.SelectedItem.ToString();
                    NavigateToDetailScreen(selectedItem);
                }
            };
            mainLayout.Controls.Add(lstResults, 0, 2);

            Button btnBack = new Button
            {
                Text = "< Back",
                Dock = DockStyle.Bottom,
                Height = 60,
                Font = new Font("Arial", 18, FontStyle.Bold),
                BackColor = Color.WhiteSmoke,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnBack.Click += (s, e) => {
                if (keyboard != null && !keyboard.IsDisposed)
                    keyboard.Close();
                new Screen2_CategoryMenu().Show();
                this.Hide();
            };
            this.Controls.Add(btnBack);
            btnBack.BringToFront();
        }

        private void NavigateToDetailScreen(string selectedItem)
        {
            string itemName = selectedItem.Split(new[] { " - BHD" }, StringSplitOptions.None)[0].Trim();
            if (itemName.Length > 2 && char.IsSymbol(itemName[0]))
            {
                itemName = itemName.Substring(2).Trim();
            }

            Form detailForm = null;

            // CAKES
            if (itemName.Contains("Chocolate Cake") && !itemName.Contains("Lamington"))
                detailForm = new ChocolateCakeDetails();
            else if (itemName.Contains("Red Velvet"))
                detailForm = new RedVelvetCakeDetails();
            else if (itemName.Contains("Black Forest"))
                detailForm = new BlackForestCakeDetails();
            else if (itemName.Contains("Cheesecake"))
                detailForm = new CheesecakeDetails();
            else if (itemName.Contains("Carrot"))
                detailForm = new CarrotCakeDetails();
            else if (itemName.Contains("Lemon"))
                detailForm = new LemonCakeDetails();

            // DRINKS
            else if (itemName.Contains("Iced Caramel Latte"))
                detailForm = new IcedCaramelLatteDetails();
            else if (itemName.Contains("Vanilla Cold Brew"))
                detailForm = new VanillaColdBrewDetails();
            else if (itemName.Contains("Nutella Hot Chocolate"))
                detailForm = new NutellaHotChocolateDetails();
            else if (itemName.Contains("V60"))
                detailForm = new V60CoffeeDetails();
            else if (itemName.Contains("Peach Iced Tea"))
                detailForm = new PeachIcedTeaDetails();
            else if (itemName.Contains("Matcha Latte"))
                detailForm = new MatchaLatteDetails();

            // SPECIALS
            else if (itemName.Contains("Lamington"))
                detailForm = new LamingtonCoconutChocolateCakeDetails();
            else if (itemName.Contains("Halawet"))
                detailForm = new HalawetElJibnDetails();
            else if (itemName.Contains("Dalgona"))
                detailForm = new DalgonaCoffeeDetails();
            else if (itemName.Contains("Sweet Spot Signature"))
                detailForm = new SweetSpotSignatureDetails();

            if (detailForm != null)
            {
                detailForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Detail screen not found for this item.", "Navigation Error");
            }
        }

        private void ShowKeyboard()
        {
            if (keyboard == null || keyboard.IsDisposed)
            {
                keyboard = new OnScreenKeyboard();
                keyboard.SetTargetTextBox(txtSearch);
                keyboard.KeyboardClosed += Keyboard_KeyboardClosed;
                keyboard.Show();
                txtSearch.Focus();
            }
            else
            {
                keyboard.BringToFront();
            }
        }

        private void Keyboard_KeyboardClosed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search for desserts...";
                txtSearch.ForeColor = Color.Gray;
                lstResults.Items.Clear();
            }
        }

        private void FilterResults()
        {
            lstResults.Items.Clear();

            if (string.IsNullOrWhiteSpace(txtSearch.Text) ||
                txtSearch.Text == "Search for desserts...")
            {
                return;
            }

            string searchText = txtSearch.Text.ToLower();
            var filteredDesserts = allDesserts
                .Where(d => {
                    string itemName = d.Split(new[] { " - BHD" }, StringSplitOptions.None)[0];
                    return itemName.ToLower().Contains(searchText);
                })
                .ToArray();

            if (filteredDesserts.Length > 0)
            {
                lstResults.Items.AddRange(filteredDesserts);
            }
            else
            {
                lstResults.Items.Add("No results found");
            }
        }

        private void Screen8_Search_Resize(object sender, EventArgs e)
        {
            float scale = Math.Max(0.5f, Math.Min(this.Width, this.Height) / 1000f);
            txtSearch.Font = new Font("Arial", 48 * scale);
            btnShowKeyboard.Font = new Font("Arial", 24 * scale);
            lstResults.Font = new Font("Arial", 22 * scale);
            lstResults.ItemHeight = (int)(50 * scale);
        }

        private void Screen8_Search_Load(object sender, EventArgs e) { }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (keyboard != null && !keyboard.IsDisposed)
                keyboard.Close();
            base.OnFormClosing(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return true;
        }
    }
}