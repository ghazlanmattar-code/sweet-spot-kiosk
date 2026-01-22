using System;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen4_BasketReview : Form
    {
        private TableLayoutPanel mainLayout;
        private Label lblTitle;
        private Panel summaryPanel;
        private Button btnConfirmOrder;
        private Button btnAddMoreItems;
        private Button btnCancelOrder;

        
        public bool DiscountApplied { get; set; } = false;
        public string StaffId { get; set; } = "";
        public decimal DiscountPercentage { get; set; } = 10;

        private decimal subtotal = 0;
        private decimal discount = 0;
        private decimal total = 0;

        public Screen4_BasketReview()
        {
            SetupResponsiveScreen();
            this.Resize += Screen4_BasketReview_Resize;
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
                BackColor = ColorTranslator.FromHtml("#FFFEF7"),
                Padding = new Padding(100)
            };

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100)); 
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60));   
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40));   
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 150)); 

            this.Controls.Add(mainLayout);

            
            lblTitle = new Label
            {
                Text = "Review Your Order",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 36, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#3E2723"),
                TextAlign = ContentAlignment.MiddleCenter
            };
            mainLayout.Controls.Add(lblTitle, 0, 0);

            
            Panel itemsPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true
            };

            Label lblItems = new Label
            {
                Text = $"Items in basket: 4\n\n" +
                       "• Chocolate Cake x2 - BHD 7.000\n" +
                       "• Iced Caramel Latte x1 - BHD 2.900\n" +
                       "• Carrot Cake x1 - BHD 3.900",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 20, FontStyle.Bold),
                Padding = new Padding(30),
                ForeColor = ColorTranslator.FromHtml("#3E2723")
            };
            itemsPanel.Controls.Add(lblItems);
            mainLayout.Controls.Add(itemsPanel, 0, 1);

            
            summaryPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = ColorTranslator.FromHtml("#E3F2FD"),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(30)
            };

            string summaryText = $"Subtotal: BHD 13.800\n";
            if (DiscountApplied)
            {
                summaryText += $"Staff Discount ({DiscountPercentage}%): -BHD {discount:F3}\n";
            }
            summaryText += $"Discount Applied (10%): BHD 1.380\n";
            summaryText += $"\nTOTAL: BHD 12.420";

            Label lblSummary = new Label
            {
                Text = summaryText,
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 24, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#3E2723"),
                TextAlign = ContentAlignment.MiddleLeft
            };
            summaryPanel.Controls.Add(lblSummary);
            mainLayout.Controls.Add(summaryPanel, 0, 2);

            
            TableLayoutPanel buttonsPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 1
            };
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            buttonsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));

            
            btnAddMoreItems = new Button
            {
                Text = "Add More Items",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 18, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#2196F3"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Margin = new Padding(5)
            };
            btnAddMoreItems.FlatAppearance.BorderSize = 0;
            btnAddMoreItems.Click += BtnAddMoreItems_Click;
            buttonsPanel.Controls.Add(btnAddMoreItems, 0, 0);

            
            btnCancelOrder = new Button
            {
                Text = "Cancel Order",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 18, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#F44336"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Margin = new Padding(5)
            };
            btnCancelOrder.FlatAppearance.BorderSize = 0;
            btnCancelOrder.Click += BtnCancelOrder_Click;
            buttonsPanel.Controls.Add(btnCancelOrder, 1, 0);

            
            btnConfirmOrder = new Button
            {
                Text = "CONFIRM ORDER",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 22, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#4CAF50"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Margin = new Padding(5)
            };
            btnConfirmOrder.FlatAppearance.BorderSize = 0;
            btnConfirmOrder.Click += BtnConfirmOrder_Click;
            buttonsPanel.Controls.Add(btnConfirmOrder, 2, 0);

            mainLayout.Controls.Add(buttonsPanel, 0, 3);
        }


        private void BtnConfirmOrder_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(
                $"Please confirm your order:\n\n" +
                $"Total Amount: BHD 12.420 (discount applied)\n" +
                $"Items: 4\n\n" +
                $"Submit your order?",
                "Confirm Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                
                ShowOrderProcessing();
            }
        }

        private void ShowOrderProcessing()
        {
            
            Form processingForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized,
                BackColor = ColorTranslator.FromHtml("#FFFEF7"),
                StartPosition = FormStartPosition.CenterScreen
            };

            Label lblProcessing = new Label
            {
                Text = "⏳\n\nProcessing Your Order...\n\nPlease Wait",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 32, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#FF9800")
            };
            processingForm.Controls.Add(lblProcessing);

            
            Timer processingTimer = new Timer { Interval = 2000 }; 
            processingTimer.Tick += (s, e) =>
            {
                processingTimer.Stop();
                processingForm.Close();

                
                ShowOrderConfirmation();
            };

            processingTimer.Start();
            processingForm.ShowDialog();
        }

        private void ShowOrderConfirmation()
        {
            
            string orderNumber = GenerateOrderNumber();

            MessageBox.Show(
                $"✓ Order Confirmed!\n\n" +
                $"Order Number: {orderNumber}\n\n" +
                $"Your order has been sent to the preparation area.\n" +
                $"Total: BHD 12.420",
                "Order Sent to Kitchen",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            
            Screen9_OrderComplete orderComplete = new Screen9_OrderComplete(orderNumber, total);
            orderComplete.Show();
            this.Hide();
        }

        private string GenerateOrderNumber()
        {
            
            return $"ORD-{DateTime.Now:yyyyMMdd}-{new Random().Next(100, 999)}";
        }

        private void BtnAddMoreItems_Click(object sender, EventArgs e)
        {
            
            new Screen2_CategoryMenu().Show();
            this.Hide();
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel your entire order?\n\n" +
                "All items will be removed from your basket.",
                "Cancel Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                BasketManager.ClearBasket();
                MessageBox.Show(
                    "Your order has been cancelled.\n\nReturning to welcome screen...",
                    "Order Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                new Screen1_Welcome().Show();
                this.Hide();
            }
        }

        private void Screen4_BasketReview_Resize(object sender, EventArgs e)
        {
            float scale = Math.Max(0.5f, Math.Min(this.Width, this.Height) / 1000f);
            if (lblTitle != null) lblTitle.Font = new Font("Arial", 36 * scale, FontStyle.Bold);
            if (btnConfirmOrder != null) btnConfirmOrder.Font = new Font("Arial", 22 * scale, FontStyle.Bold);
            if (btnAddMoreItems != null) btnAddMoreItems.Font = new Font("Arial", 18 * scale, FontStyle.Bold);
            if (btnCancelOrder != null) btnCancelOrder.Font = new Font("Arial", 18 * scale, FontStyle.Bold);
        }
    }
}