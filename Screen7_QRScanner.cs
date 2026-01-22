using SweetSpotDessertShop412;
using SweetSpotDessertShop412.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen7_QRScanner : Form
    {
        private TableLayoutPanel mainLayout;
        private bool discountApplied = false;
        private string scannedStaffId = "";
        private Panel scannerDisplayPanel;

        public Screen7_QRScanner()
        {
            InitializeComponent();
            SetupResponsiveScreen();
            this.Resize += Screen7_QRScanner_Resize;
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
                RowCount = 1,
                ColumnCount = 2,
                BackColor = ColorTranslator.FromHtml("#FFFEF7"),
                Padding = new Padding(100, 150, 100, 150)
            };

            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            this.Controls.Add(mainLayout);

            pnlInstructions.Dock = DockStyle.Fill;
            pnlInstructions.Padding = new Padding(30);

            pnlInstructions.Controls.Clear();

            btnStartScanner.Dock = DockStyle.Bottom;
            btnStartScanner.Height = 100;
            btnStartScanner.FlatStyle = FlatStyle.Flat;
            btnStartScanner.Text = "START SCANNING";
            btnStartScanner.BackColor = ColorTranslator.FromHtml("#4CAF50");
            btnStartScanner.ForeColor = Color.White;
            btnStartScanner.FlatAppearance.BorderSize = 0;
            btnStartScanner.Cursor = Cursors.Hand;
            pnlInstructions.Controls.Add(btnStartScanner);

            Panel buttonSpacer = new Panel { Dock = DockStyle.Bottom, Height = 15 };
            pnlInstructions.Controls.Add(buttonSpacer);

            btnSkip.Dock = DockStyle.Bottom;
            btnSkip.Height = 70;
            btnSkip.FlatStyle = FlatStyle.Flat;
            btnSkip.Text = "Skip and Continue Without Discount";
            btnSkip.BackColor = Color.White;
            btnSkip.ForeColor = ColorTranslator.FromHtml("#3E2723");
            btnSkip.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#3E2723");
            btnSkip.FlatAppearance.BorderSize = 2;
            btnSkip.Cursor = Cursors.Hand;
            pnlInstructions.Controls.Add(btnSkip);

            Panel spacer = new Panel { Dock = DockStyle.Fill };
            pnlInstructions.Controls.Add(spacer);

            lblStep3.Dock = DockStyle.Top;
            lblStep3.Height = 60;
            lblStep3.AutoSize = false;
            lblStep3.TextAlign = ContentAlignment.MiddleLeft;
            lblStep3.Text = "3. Watch for green indicator";
            pnlInstructions.Controls.Add(lblStep3);

            lblStep2.Dock = DockStyle.Top;
            lblStep2.Height = 60;
            lblStep2.AutoSize = false;
            lblStep2.TextAlign = ContentAlignment.MiddleLeft;
            lblStep2.Text = "2. Keep card flat and straight";
            pnlInstructions.Controls.Add(lblStep2);

            lblStep1.Dock = DockStyle.Top;
            lblStep1.Height = 60;
            lblStep1.AutoSize = false;
            lblStep1.TextAlign = ContentAlignment.MiddleLeft;
            lblStep1.Text = "1. Hold card 5-10cm from scanner";
            pnlInstructions.Controls.Add(lblStep1);

            lblInstructionsTitle.Dock = DockStyle.Top;
            lblInstructionsTitle.Height = 80;
            lblInstructionsTitle.TextAlign = ContentAlignment.TopLeft;
            lblInstructionsTitle.AutoSize = false;
            lblInstructionsTitle.Text = "How to Position Your Card";
            pnlInstructions.Controls.Add(lblInstructionsTitle);

            mainLayout.Controls.Add(pnlInstructions, 0, 0);

            scannerDisplayPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblPlaceholder = new Label
            {
                Text = "📷\n\nScanner will appear here\n\nClick 'START SCANNING' to begin",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.Gray
            };
            scannerDisplayPanel.Controls.Add(lblPlaceholder);

            mainLayout.Controls.Add(scannerDisplayPanel, 1, 0);

            btnStartScanner.Click += BtnStartScanner_Click;
            btnSkip.Click += BtnSkip_Click;
        }

        private void BtnStartScanner_Click(object sender, EventArgs e)
        {
            try
            {
                scannerDisplayPanel.Controls.Clear();

                Label lblLoading = new Label
                {
                    Text = "🎥\n\nOpening Camera...\n\nPlease wait",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 20, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#4CAF50")
                };
                scannerDisplayPanel.Controls.Add(lblLoading);
                scannerDisplayPanel.Refresh();

                using (QRReaderForm qrReader = new QRReaderForm(QRReaderForm.ScannerMode.LoyaltyDiscount))
                {
                    qrReader.StartPosition = FormStartPosition.Manual;

                    Point scannerLocation = scannerDisplayPanel.PointToScreen(Point.Empty);
                    qrReader.Location = new Point(
                        scannerLocation.X + (scannerDisplayPanel.Width - qrReader.Width) / 2,
                        scannerLocation.Y + (scannerDisplayPanel.Height - qrReader.Height) / 2
                    );

                    DialogResult result = qrReader.ShowDialog(this);

                    if (result == DialogResult.OK && !string.IsNullOrEmpty(qrReader.ScannedResult))
                    {
                        
                        scannedStaffId = qrReader.ScannedResult;
                        discountApplied = true;

                        
                        scannerDisplayPanel.Controls.Clear();
                        Label lblSuccess = new Label
                        {
                            Text = "✓\n\nScan Successful!\n\nDiscount Applied",
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Arial", 24, FontStyle.Bold),
                            ForeColor = ColorTranslator.FromHtml("#4CAF50")
                        };
                        scannerDisplayPanel.Controls.Add(lblSuccess);
                        scannerDisplayPanel.BackColor = Color.FromArgb(232, 245, 233);

                        
                        MessageBox.Show(
                            $"✓ Loyalty Card Scanned Successfully!\n\n" +
                            $"Staff ID: {scannedStaffId}\n\n" +
                            $"10% discount has been applied to your order.",
                            "Discount Applied",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        
                        ProceedToBasketReview();
                    }
                    else
                    {
                        RestorePlaceholder();

                        MessageBox.Show(
                            "QR code scanning was cancelled.\n\n" +
                            "Click 'START SCANNING' to try again, or 'Skip' to continue without discount.",
                            "Scan Cancelled",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                RestorePlaceholder();

                MessageBox.Show(
                    "Error opening QR scanner:\n\n" + ex.Message + "\n\n" +
                    "Please ensure your camera is connected and try again.",
                    "Scanner Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void RestorePlaceholder()
        {
            scannerDisplayPanel.Controls.Clear();
            scannerDisplayPanel.BackColor = Color.FromArgb(245, 245, 245);

            Label lblPlaceholder = new Label
            {
                Text = "📷\n\nScanner will appear here\n\nClick 'START SCANNING' to begin",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = Color.Gray
            };
            scannerDisplayPanel.Controls.Add(lblPlaceholder);
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to skip the loyalty discount?\n\n" +
                "You will not receive the 10% discount.",
                "Skip Discount",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                discountApplied = false;
                scannedStaffId = "";
                ProceedToBasketReview();
            }
        }

        private void ProceedToBasketReview()
        {
            Screen4_BasketReview basketReview = new Screen4_BasketReview
            {
                DiscountApplied = discountApplied,
                StaffId = scannedStaffId,
                DiscountPercentage = 10
            };

            basketReview.Show();
            this.Hide();
        }

        private void Screen7_QRScanner_Resize(object sender, EventArgs e)
        {
            float scale = Math.Max(0.5f, Math.Min(this.Width, this.Height) / 1000f);
            lblInstructionsTitle.Font = new Font("Arial", 23 * scale, FontStyle.Bold);
            lblStep1.Font = new Font("Arial", 18 * scale);
            lblStep2.Font = new Font("Arial", 18 * scale);
            lblStep3.Font = new Font("Arial", 18 * scale);
            btnStartScanner.Font = new Font("Arial", 28 * scale, FontStyle.Bold);
            btnSkip.Font = new Font("Arial", 15 * scale, FontStyle.Bold);
        }

        private void Screen7_QRScanner_Load(object sender, EventArgs e) { }
    }
}