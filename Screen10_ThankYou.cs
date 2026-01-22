using System;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen10_ThankYou : Form
    {
        private Timer redirectTimer;
        private int countdown = 10; 
        private Label lblCountdown;

        public Screen10_ThankYou()
        {
            InitializeComponent();
            SetupResponsiveScreen();
            StartRedirectTimer();
        }

        private void SetupResponsiveScreen()
        {
            this.Controls.Clear();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#FFFEF7");

            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 4,
                ColumnCount = 1,
                BackColor = ColorTranslator.FromHtml("#FFFEF7")
            };

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30)); 
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25)); 
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25)); 
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20)); 

            this.Controls.Add(mainLayout);

            
            Label lblLogo = new Label
            {
                Text = "🧁\n\nSweet Spot\nDessert Shop",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 48, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#FF6B9D"),
                TextAlign = ContentAlignment.BottomCenter
            };
            mainLayout.Controls.Add(lblLogo, 0, 0);

            
            Label lblThankYou = new Label
            {
                Text = "Thank You!",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 72, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#4CAF50"),
                TextAlign = ContentAlignment.MiddleCenter
            };
            mainLayout.Controls.Add(lblThankYou, 0, 1);

            
            Label lblMessage = new Label
            {
                Text = "We hope you enjoy your desserts!\n\nPlease collect your order at the counter.",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 28),
                ForeColor = ColorTranslator.FromHtml("#3E2723"),
                TextAlign = ContentAlignment.TopCenter
            };
            mainLayout.Controls.Add(lblMessage, 0, 2);

            
            Panel countdownPanel = new Panel
            {
                Dock = DockStyle.Fill
            };

            lblCountdown = new Label
            {
                Text = $"Returning to welcome screen in {countdown} seconds...",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 24),
                ForeColor = ColorTranslator.FromHtml("#757575"),
                TextAlign = ContentAlignment.TopCenter
            };
            countdownPanel.Controls.Add(lblCountdown);

            
            Button btnReturnNow = new Button
            {
                Text = "Return to Welcome Screen Now",
                Dock = DockStyle.Bottom,
                Height = 80,
                Font = new Font("Arial", 20, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#2196F3"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Margin = new Padding(200, 20, 200, 20)
            };
            btnReturnNow.FlatAppearance.BorderSize = 0;
            btnReturnNow.Click += BtnReturnNow_Click;
            countdownPanel.Controls.Add(btnReturnNow);

            mainLayout.Controls.Add(countdownPanel, 0, 3);
        }

        private void StartRedirectTimer()
        {
            
            redirectTimer = new Timer
            {
                Interval = 1000 
            };

            redirectTimer.Tick += (s, e) =>
            {
                countdown--;
                lblCountdown.Text = $"Returning to welcome screen in {countdown} seconds...";

                if (countdown <= 0)
                {
                    redirectTimer.Stop();
                    ReturnToWelcome();
                }
            };

            redirectTimer.Start();
        }

        private void BtnReturnNow_Click(object sender, EventArgs e)
        {
            if (redirectTimer != null)
            {
                redirectTimer.Stop();
            }
            ReturnToWelcome();
        }

        private void ReturnToWelcome()
        {
            
            BasketManager.ClearBasket();

            Screen1_Welcome welcome = new Screen1_Welcome();
            welcome.Show();
            this.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(1920, 1080);
            this.Name = "Screen10_ThankYou";
            this.Text = "Thank You";
            this.ResumeLayout(false);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (redirectTimer != null)
            {
                redirectTimer.Stop();
                redirectTimer.Dispose();
            }
            base.OnFormClosing(e);
        }
    }
}