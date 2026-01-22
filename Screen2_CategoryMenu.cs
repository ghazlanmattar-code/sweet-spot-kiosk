using SweetSpotDessertShop412;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen2_CategoryMenu : Form
    {
        private TableLayoutPanel mainLayout;

        public Screen2_CategoryMenu()
        {
            InitializeComponent();
            SetupResponsiveScreen();
            this.Resize += Screen2_CategoryMenu_Resize;
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

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15));  
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            this.Controls.Add(mainLayout);

            
            pnlSelectedCategory.Dock = DockStyle.Fill;
            lblSelectedCategory.Dock = DockStyle.Fill;
            lblSelectedCategory.TextAlign = ContentAlignment.MiddleLeft;
            lblSelectedCategory.AutoSize = false;
            mainLayout.Controls.Add(pnlSelectedCategory, 0, 0);

           
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.AutoSize = false;
            mainLayout.Controls.Add(lblTitle, 0, 1);

            
            var buttonPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 3,
                BackColor = ColorTranslator.FromHtml("#FFFEF7")
            };
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            mainLayout.Controls.Add(buttonPanel, 0, 2);

            
            var cakeButton = CreateCategoryButton("Cakes", Properties.Resources.categorycake, () => NavigateToGrid("Cakes"));
            buttonPanel.Controls.Add(cakeButton, 0, 0);

            var drinkButton = CreateCategoryButton("Drinks", Properties.Resources.categorydrinks, () => NavigateToGrid("Drinks"));
            buttonPanel.Controls.Add(drinkButton, 1, 0);

            var specialButton = CreateCategoryButton("Specials", Properties.Resources.categoryspecials, () => NavigateToGrid("Specials"));
            buttonPanel.Controls.Add(specialButton, 2, 0);

            
            var bottomPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 2,
                BackColor = ColorTranslator.FromHtml("#FFFEF7")
            };
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            bottomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80));
            bottomPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            mainLayout.Controls.Add(bottomPanel, 0, 3);

            btnBack.Dock = DockStyle.Fill;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Click += (s, e) => { new Screen1_Welcome().Show(); this.Hide(); };
            bottomPanel.Controls.Add(btnBack, 0, 0);

            btnSearch.Dock = DockStyle.Fill;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Click += (s, e) => { new Screen8_Search().Show(); this.Hide(); };
            bottomPanel.Controls.Add(btnSearch, 1, 0);
        }

        private Panel CreateCategoryButton(string categoryName, Image categoryImage, Action onClickAction)
        {
            
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.WhiteSmoke,
                Cursor = Cursors.Hand,
                Margin = new Padding(10)
            };

            
            buttonPanel.Paint += (s, e) => {
                ControlPaint.DrawBorder(e.Graphics, buttonPanel.ClientRectangle,
                    Color.Gray, ButtonBorderStyle.Solid);
            };

            
            TableLayoutPanel innerLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1,
                BackColor = Color.WhiteSmoke,
                Cursor = Cursors.Hand
            };
            innerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60));  
            innerLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40));  
            innerLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            
            PictureBox pictureBox = new PictureBox
            {
                Dock = DockStyle.Fill,
                Image = categoryImage,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.WhiteSmoke,
                Cursor = Cursors.Hand
            };

            
            Label label = new Label
            {
                Text = categoryName,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 42, FontStyle.Bold),
                ForeColor = Color.FromArgb(62, 39, 35),
                BackColor = Color.WhiteSmoke,
                Cursor = Cursors.Hand
            };

            innerLayout.Controls.Add(pictureBox, 0, 0);
            innerLayout.Controls.Add(label, 0, 1);
            buttonPanel.Controls.Add(innerLayout);

            
            EventHandler clickHandler = (s, e) => onClickAction?.Invoke();

            buttonPanel.Click += clickHandler;
            pictureBox.Click += clickHandler;
            label.Click += clickHandler;
            innerLayout.Click += clickHandler;

            
            EventHandler enterHandler = (s, e) => {
                buttonPanel.BackColor = Color.FromArgb(230, 230, 230);
                innerLayout.BackColor = Color.FromArgb(230, 230, 230);
                pictureBox.BackColor = Color.FromArgb(230, 230, 230);
                label.BackColor = Color.FromArgb(230, 230, 230);
            };

            EventHandler leaveHandler = (s, e) => {
                buttonPanel.BackColor = Color.WhiteSmoke;
                innerLayout.BackColor = Color.WhiteSmoke;
                pictureBox.BackColor = Color.WhiteSmoke;
                label.BackColor = Color.WhiteSmoke;
            };

            buttonPanel.MouseEnter += enterHandler;
            pictureBox.MouseEnter += enterHandler;
            label.MouseEnter += enterHandler;
            innerLayout.MouseEnter += enterHandler;

            buttonPanel.MouseLeave += leaveHandler;
            pictureBox.MouseLeave += leaveHandler;
            label.MouseLeave += leaveHandler;
            innerLayout.MouseLeave += leaveHandler;

            return buttonPanel;
        }

        private void NavigateToGrid(string category)
        {
            if (category == "Cakes")
            {
                new Screen5_ItemGrid().Show();
            }
            else if (category == "Drinks")
            {
                new Screen5b_DrinkGrid().Show();
            }
            else if (category == "Specials")
            {
                new Screen5c_SpecialGrid().Show();
            }
            this.Hide();
        }

        private void Screen2_CategoryMenu_Resize(object sender, EventArgs e)
        {
            float scale = Math.Max(0.5f, Math.Min(this.Width, this.Height) / 1000f);
            lblSelectedCategory.Font = new Font("Arial", 48 * scale, FontStyle.Bold);
            lblTitle.Font = new Font("Arial", 32 * scale);
            btnBack.Font = new Font("Arial", 18 * scale, FontStyle.Bold);
            btnSearch.Font = new Font("Arial", 20 * scale, FontStyle.Bold);
        }

        private void Screen2_CategoryMenu_Load(object sender, EventArgs e) { }
    }
}