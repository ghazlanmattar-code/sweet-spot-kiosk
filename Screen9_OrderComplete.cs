using SweetSpotDessertShop412.Components;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen9_OrderComplete : Form
    {
        private TableLayoutPanel mainLayout;
        private string orderNumber;
        private decimal totalAmount;
        private OnScreenKeyboard keyboard;

        public Screen9_OrderComplete(string orderNum, decimal total)
        {
            orderNumber = orderNum;
            totalAmount = total;
            InitializeComponent();
            SetupResponsiveScreen();
            this.Resize += Screen9_OrderComplete_Resize;
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
                RowCount = 5,
                ColumnCount = 1,
                BackColor = ColorTranslator.FromHtml("#FFFEF7"),
                Padding = new Padding(100)
            };

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120)); 
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 150)); 
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 200)); 
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));  
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80)); 

            this.Controls.Add(mainLayout);

            
            Label lblTitle = new Label
            {
                Text = "✓ Order Complete!",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 48, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#4CAF50"),
                TextAlign = ContentAlignment.MiddleCenter
            };
            mainLayout.Controls.Add(lblTitle, 0, 0);

            
            Panel orderPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = ColorTranslator.FromHtml("#E8F5E9"),
                BorderStyle = BorderStyle.FixedSingle
            };
            Label lblOrderNumber = new Label
            {
                Text = $"Order Number: {orderNumber}\nTotal: BHD 12.420",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 28, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#2E7D32"),
                TextAlign = ContentAlignment.MiddleCenter
            };
            orderPanel.Controls.Add(lblOrderNumber);
            mainLayout.Controls.Add(orderPanel, 0, 1);

            
            Panel instructionsPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = ColorTranslator.FromHtml("#FFF3E0"),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(30)
            };
            Label lblInstructions = new Label
            {
                Text = "📍 Collection Instructions:\n\n" +
                       "Please proceed to the counter with your order number.\n" +
                       "Your order will be ready shortly.",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 22),
                ForeColor = ColorTranslator.FromHtml("#E65100"),
                TextAlign = ContentAlignment.MiddleLeft
            };
            instructionsPanel.Controls.Add(lblInstructions);
            mainLayout.Controls.Add(instructionsPanel, 0, 2);

           
            Panel receiptPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(40)
            };

            Label lblReceiptTitle = new Label
            {
                Text = "📧 Would you like a receipt?",
                Dock = DockStyle.Top,
                Height = 60,
                Font = new Font("Arial", 26, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#3E2723"),
                TextAlign = ContentAlignment.MiddleLeft
            };
            receiptPanel.Controls.Add(lblReceiptTitle);

            
            TableLayoutPanel buttonsPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1,
                Padding = new Padding(0, 80, 0, 0)
            };
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            buttonsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            
            Button btnPrintReceipt = new Button
            {
                Text = "🖨️  Print Receipt",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 24, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#673AB7"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Margin = new Padding(10)
            };
            btnPrintReceipt.FlatAppearance.BorderSize = 0;
            btnPrintReceipt.Click += BtnPrintReceipt_Click;
            buttonsPanel.Controls.Add(btnPrintReceipt, 0, 0);

            
            Button btnEmailReceipt = new Button
            {
                Text = "📧  Email Receipt",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 24, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#2196F3"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Margin = new Padding(10)
            };
            btnEmailReceipt.FlatAppearance.BorderSize = 0;
            btnEmailReceipt.Click += BtnEmailReceipt_Click;
            buttonsPanel.Controls.Add(btnEmailReceipt, 0, 1);

            receiptPanel.Controls.Add(buttonsPanel);
            mainLayout.Controls.Add(receiptPanel, 0, 3);

            
            Button btnSkip = new Button
            {
                Text = "Skip - Continue Without Receipt",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 18, FontStyle.Bold),
                BackColor = Color.White,
                ForeColor = ColorTranslator.FromHtml("#3E2723"),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnSkip.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#3E2723");
            btnSkip.FlatAppearance.BorderSize = 2;
            btnSkip.Click += BtnSkip_Click;
            mainLayout.Controls.Add(btnSkip, 0, 4);
        }

        private void BtnPrintReceipt_Click(object sender, EventArgs e)
        {
            
            Form printingForm = new Form
            {
                Size = new Size(600, 300),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = Color.White
            };

            Label lblPrinting = new Label
            {
                Text = "🖨️\n\nPrinting Receipt...\n\nPlease wait",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 20, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#673AB7")
            };
            printingForm.Controls.Add(lblPrinting);

            
            Timer printTimer = new Timer { Interval = 3000 }; 
            printTimer.Tick += (s, ev) =>
            {
                printTimer.Stop();
                printingForm.Close();

                MessageBox.Show(
                    "✓ Receipt printed successfully!\n\n" +
                    "Please collect your receipt from the printer tray.",
                    "Print Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                
                GoToThankYouScreen();
            };

            printTimer.Start();
            printingForm.ShowDialog();
        }

        private void BtnEmailReceipt_Click(object sender, EventArgs e)
        {
            
            Form emailForm = new Form
            {
                Size = new Size(800, 400),
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                BackColor = ColorTranslator.FromHtml("#FFFEF7"),
                Text = "Email Receipt"
            };

            Label lblPrompt = new Label
            {
                Text = "Please enter your email address:",
                Location = new Point(50, 30),
                Size = new Size(700, 40),
                Font = new Font("Arial", 18, FontStyle.Bold),
                ForeColor = ColorTranslator.FromHtml("#3E2723")
            };
            emailForm.Controls.Add(lblPrompt);

            TextBox txtEmail = new TextBox
            {
                Location = new Point(50, 90),
                Size = new Size(700, 60),
                Font = new Font("Arial", 24),
                ReadOnly = true,
                Text = "Tap to enter email..."
            };
            txtEmail.Click += (s, ev) =>
            {
                if (txtEmail.Text == "Tap to enter email...")
                {
                    txtEmail.Text = "";
                }
                ShowKeyboardForEmail(txtEmail);
            };
            emailForm.Controls.Add(txtEmail);

            Button btnSend = new Button
            {
                Text = "📧  Send Receipt",
                Location = new Point(50, 180),
                Size = new Size(700, 80),
                Font = new Font("Arial", 22, FontStyle.Bold),
                BackColor = ColorTranslator.FromHtml("#4CAF50"),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.Click += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text == "Tap to enter email...")
                {
                    MessageBox.Show("Please enter a valid email address.", "Email Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (keyboard != null && !keyboard.IsDisposed)
                    keyboard.Close();

                emailForm.Close();

                
                MessageBox.Show(
                    $"✓ Receipt sent successfully!\n\n" +
                    $"A copy of your receipt has been emailed to:\n{txtEmail.Text}",
                    "Email Sent",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                
                GoToThankYouScreen();
            };
            emailForm.Controls.Add(btnSend);

            Button btnCancel = new Button
            {
                Text = "Cancel",
                Location = new Point(50, 280),
                Size = new Size(700, 60),
                Font = new Font("Arial", 16),
                BackColor = Color.White,
                ForeColor = ColorTranslator.FromHtml("#3E2723"),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderSize = 1;
            btnCancel.Click += (s, ev) =>
            {
                if (keyboard != null && !keyboard.IsDisposed)
                    keyboard.Close();
                emailForm.Close();
            };
            emailForm.Controls.Add(btnCancel);

            emailForm.ShowDialog();
        }

        private void ShowKeyboardForEmail(TextBox targetTextBox)
        {
            if (keyboard == null || keyboard.IsDisposed)
            {
                keyboard = new OnScreenKeyboard();
                keyboard.SetTargetTextBox(targetTextBox);
                keyboard.Show();
            }
            else
            {
                keyboard.BringToFront();
            }
        }

        private void BtnSkip_Click(object sender, EventArgs e)
        {
            
            GoToThankYouScreen();
        }

        private void GoToThankYouScreen()
        {
            
            Screen10_ThankYou thankYou = new Screen10_ThankYou();
            thankYou.Show();
            this.Hide();
        }

        private void Screen9_OrderComplete_Resize(object sender, EventArgs e)
        {
            
            float scale = Math.Max(0.5f, Math.Min(this.Width, this.Height) / 1000f);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Screen9_OrderComplete
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Screen9_OrderComplete";
            this.Text = "Order Complete";
            this.Load += new System.EventHandler(this.Screen9_OrderComplete_Load);
            this.ResumeLayout(false);

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (keyboard != null && !keyboard.IsDisposed)
                keyboard.Close();
            base.OnFormClosing(e);
        }

        private void Screen9_OrderComplete_Load(object sender, EventArgs e)
        {
            
        }
    }
}