using SweetSpotDessertShop412;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen1_Welcome : Form
    {
        private int imageIndex = 0;
        private Image[] dessertImages;
        private TableLayoutPanel mainLayout;

        public Screen1_Welcome()
        {
            InitializeComponent();

            
            dessertImages = new Image[] {
                Properties.Resources.cake,
                Properties.Resources.cupcake,
                Properties.Resources.cookie,
                Properties.Resources.donut,
                Properties.Resources.pie,
                Properties.Resources.icecream
            };

            SetupResponsiveScreen();

            timerRotate.Tick += timerRotate_Tick;
            timerRotate.Interval = 3000;
            timerRotate.Start();

            this.Resize += Screen1_Welcome_Resize;
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

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8));   
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 37));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20));  
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            this.Controls.Add(mainLayout);

            
            lblShopName.Dock = DockStyle.Fill;
            lblShopName.TextAlign = ContentAlignment.MiddleCenter;
            lblShopName.AutoSize = false;
            mainLayout.Controls.Add(lblShopName, 0, 0);

            
            lblTagline.Dock = DockStyle.Fill;
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;
            lblTagline.AutoSize = false;
            mainLayout.Controls.Add(lblTagline, 0, 1);

            
            picDessert.Dock = DockStyle.Fill;
            picDessert.SizeMode = PictureBoxSizeMode.Zoom;
            mainLayout.Controls.Add(picDessert, 0, 2);

            
            Panel buttonContainer = new Panel
            {
                Dock = DockStyle.Fill
            };

            btnStartOrder.Anchor = AnchorStyles.None;
            btnStartOrder.Size = new Size(500, 100);
            btnStartOrder.Location = new Point(
                (buttonContainer.Width - btnStartOrder.Width) / 2,
                (buttonContainer.Height - btnStartOrder.Height) / 2
            );
            btnStartOrder.FlatStyle = FlatStyle.Flat;
            btnStartOrder.FlatAppearance.BorderSize = 0;

            buttonContainer.Controls.Add(btnStartOrder);
            buttonContainer.Resize += (s, e) => {
                btnStartOrder.Location = new Point(
                    (buttonContainer.Width - btnStartOrder.Width) / 2,
                    (buttonContainer.Height - btnStartOrder.Height) / 2
                );
            };

            mainLayout.Controls.Add(buttonContainer, 0, 3);

            
            btnStartOrder.MouseEnter += btnStartOrder_MouseEnter;
            btnStartOrder.MouseLeave += btnStartOrder_MouseLeave;
            btnStartOrder.Click += btnStartOrder_Click;

            
            Button btnStaffMode = new Button
            {
                Size = new Size(140, 50),
                Location = new Point(10, 10),
                BackColor = ColorTranslator.FromHtml("#4CAF50"),
                ForeColor = Color.White,
                Text = "🔒 Staff",
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnStaffMode.FlatAppearance.BorderSize = 0;
            btnStaffMode.Click += BtnStaffMode_Click;

            this.Controls.Add(btnStaffMode);
            btnStaffMode.BringToFront();

            UpdateDessertImage();
        }

        private void timerRotate_Tick(object sender, EventArgs e)
        {
            imageIndex = (imageIndex + 1) % dessertImages.Length;
            UpdateDessertImage();
        }

        private void UpdateDessertImage()
        {
            try
            {
                if (dessertImages != null && dessertImages.Length > 0)
                    picDessert.Image = dessertImages[imageIndex];
            }
            catch { /* Handle error */ }
        }

        private void Screen1_Welcome_Resize(object sender, EventArgs e)
        {
            float scale = Math.Max(0.5f, Math.Min(this.Width, this.Height) / 600f);
            lblShopName.Font = new Font("Arial", 56 * scale, FontStyle.Bold);
            lblTagline.Font = new Font("Arial", 28 * scale);
            btnStartOrder.Font = new Font("Arial", 16 * scale, FontStyle.Bold);
        }

        private void btnStartOrder_MouseEnter(object sender, EventArgs e)
        {
            btnStartOrder.BackColor = ColorTranslator.FromHtml("#C2185B");
        }

        private void btnStartOrder_MouseLeave(object sender, EventArgs e)
        {
            btnStartOrder.BackColor = ColorTranslator.FromHtml("#E91E63");
        }

        private void btnStartOrder_Click(object sender, EventArgs e)
        {
            new Screen2_CategoryMenu().Show();
            this.Hide();
        }

        private void BtnStaffMode_Click(object sender, EventArgs e)
        {
            
            new Screen9_CleaningMode().Show();
            this.Hide();
        }

        private void Screen1_Welcome_Load(object sender, EventArgs e) { }
        private void picDessert_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}