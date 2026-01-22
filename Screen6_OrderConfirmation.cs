using SweetSpotDessertShop412;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen6_OrderConfirmation : Form
    {
        private TableLayoutPanel mainLayout;

        public Screen6_OrderConfirmation()
        {
            InitializeComponent();
            SetupResponsiveScreen();
            this.Resize += Screen6_OrderConfirmation_Resize;
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

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 75));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10));  
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            this.Controls.Add(mainLayout);

            lblTitle.Dock = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.AutoSize = false;
            mainLayout.Controls.Add(lblTitle, 0, 0);

            Panel centerContainer = new Panel { Dock = DockStyle.Fill };
            pnlOrderCard.Anchor = AnchorStyles.None;
            pnlOrderCard.Size = new Size(1200, 700);

            lblSummaryTitle.Dock = DockStyle.Top;
            lblSummaryTitle.Height = 100;
            lblSummaryTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblSummaryTitle.AutoSize = false;

            Panel totalPanel = new Panel { Dock = DockStyle.Top, Height = 100 };
            lblTotalLabel.Location = new Point(40, 20);
            lblTotalLabel.AutoSize = false;
            lblTotalLabel.Size = new Size(250, 70);
            lblTotalAmount.Location = new Point(270, 20);
            lblTotalAmount.AutoSize = false;
            lblTotalAmount.Size = new Size(260, 70);
            totalPanel.Controls.Add(lblTotalLabel);
            totalPanel.Controls.Add(lblTotalAmount);

            pnlWarning.Dock = DockStyle.Top;
            pnlWarning.Height = 120;
            lblWarning.Dock = DockStyle.Fill;
            lblWarning.TextAlign = ContentAlignment.MiddleLeft;
            lblWarning.AutoSize = false;

            lblInstruction.Dock = DockStyle.Top;
            lblInstruction.Height = 80;
            lblInstruction.TextAlign = ContentAlignment.MiddleCenter;
            lblInstruction.AutoSize = false;

            Panel btnPanel = new Panel { Dock = DockStyle.Fill };
            btnConfirm.Anchor = AnchorStyles.None;
            btnConfirm.Size = new Size(600, 90);
            btnPanel.Controls.Add(btnConfirm);

            pnlOrderCard.Controls.Add(btnPanel);
            pnlOrderCard.Controls.Add(lblInstruction);
            pnlOrderCard.Controls.Add(pnlWarning);
            pnlOrderCard.Controls.Add(totalPanel);
            pnlOrderCard.Controls.Add(lblSummaryTitle);

            centerContainer.Controls.Add(pnlOrderCard);
            centerContainer.Resize += (s, e) => {
                pnlOrderCard.Location = new Point(
                    (centerContainer.Width - pnlOrderCard.Width) / 2,
                    (centerContainer.Height - pnlOrderCard.Height) / 2
                );
                btnConfirm.Location = new Point(
                    (btnPanel.Width - btnConfirm.Width) / 2,
                    (btnPanel.Height - btnConfirm.Height) / 2
                );
            };

            mainLayout.Controls.Add(centerContainer, 0, 1);

            lnkBack.Dock = DockStyle.Fill;
            lnkBack.TextAlign = ContentAlignment.MiddleCenter;
            lnkBack.AutoSize = false;
            mainLayout.Controls.Add(lnkBack, 0, 2);

            lnkBack.Click += (s, e) => { new Screen4_BasketReview().Show(); this.Hide(); };
            btnConfirm.Click += (s, e) => { new Screen7_QRScanner().Show(); this.Hide(); };
        }

        private void Screen6_OrderConfirmation_Resize(object sender, EventArgs e)
        {
            float scale = Math.Max(0.5f, Math.Min(this.Width, this.Height) / 1000f);
            lblTitle.Font = new Font("Arial", 48 * scale, FontStyle.Bold);
            lblSummaryTitle.Font = new Font("Arial", 32 * scale, FontStyle.Bold);
            lblTotalLabel.Font = new Font("Arial", 30 * scale, FontStyle.Bold);
            lblTotalAmount.Font = new Font("Arial", 30 * scale, FontStyle.Bold);
            lblWarning.Font = new Font("Arial", 17 * scale);
            lblInstruction.Font = new Font("Arial", 28 * scale, FontStyle.Bold);
            btnConfirm.Font = new Font("Arial", 32 * scale, FontStyle.Bold);
            lnkBack.Font = new Font("Arial", 18 * scale);
        }

        private void Screen6_OrderConfirmation_Load(object sender, EventArgs e) { }
    }
}