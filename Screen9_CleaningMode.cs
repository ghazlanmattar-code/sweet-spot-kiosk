using SweetSpotDessertShop412.Components;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SweetSpotDessertShop412
{
    public partial class Screen9_CleaningMode : Form
    {
        private TableLayoutPanel mainLayout;
        private Timer cleaningTimer;
        private int secondsRemaining = 60; 
        private bool isAuthenticated = false;

        public Screen9_CleaningMode()
        {
            InitializeComponent();
            SetupResponsiveScreen();
            this.Resize += Screen9_CleaningMode_Resize;

            
            cleaningTimer = new Timer();
            cleaningTimer.Interval = 1000; 
            cleaningTimer.Tick += CleaningTimer_Tick;
        }

        private void SetupResponsiveScreen()
        {
            this.Controls.Clear();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#2E7D32"); 

            mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = 1,
                BackColor = ColorTranslator.FromHtml("#2E7D32")
            };

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            this.Controls.Add(mainLayout);

            
            pnlAuthentication.Dock = DockStyle.Fill;
            pnlAuthentication.Visible = true;

            lblAuthTitle.Dock = DockStyle.Top;
            lblAuthTitle.Height = 150;
            lblAuthTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblAuthTitle.AutoSize = false;

            lblAuthInstruction.Dock = DockStyle.Top;
            lblAuthInstruction.Height = 100;
            lblAuthInstruction.TextAlign = ContentAlignment.MiddleCenter;
            lblAuthInstruction.AutoSize = false;

            Panel btnPanel = new Panel { Dock = DockStyle.Fill };
            btnScanStaffID.Anchor = AnchorStyles.None;
            btnScanStaffID.Size = new Size(600, 100);
            btnScanStaffID.FlatStyle = FlatStyle.Flat;
            btnScanStaffID.Click += BtnScanStaffID_Click;
            btnPanel.Controls.Add(btnScanStaffID);

            btnPanel.Resize += (s, e) => {
                btnScanStaffID.Location = new Point(
                    (btnPanel.Width - btnScanStaffID.Width) / 2,
                    (btnPanel.Height - btnScanStaffID.Height) / 2 - 100
                );
            };

            btnCancelAuth.Dock = DockStyle.Bottom;
            btnCancelAuth.Height = 70;
            btnCancelAuth.FlatStyle = FlatStyle.Flat;
            btnCancelAuth.Click += BtnCancelAuth_Click;

            pnlAuthentication.Controls.Add(btnPanel);
            pnlAuthentication.Controls.Add(lblAuthInstruction);
            pnlAuthentication.Controls.Add(lblAuthTitle);
            pnlAuthentication.Controls.Add(btnCancelAuth);

            mainLayout.Controls.Add(pnlAuthentication, 0, 0);

            
            pnlCleaning.Dock = DockStyle.Fill;
            pnlCleaning.Visible = false;

            lblCleaningTitle.Dock = DockStyle.Top;
            lblCleaningTitle.Height = 200;
            lblCleaningTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblCleaningTitle.AutoSize = false;

            lblCleaningMessage.Dock = DockStyle.Top;
            lblCleaningMessage.Height = 150;
            lblCleaningMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblCleaningMessage.AutoSize = false;

            lblTimer.Dock = DockStyle.Top;
            lblTimer.Height = 200;
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblTimer.AutoSize = false;

            lblCleaningInstructions.Dock = DockStyle.Top;
            lblCleaningInstructions.Height = 100;
            lblCleaningInstructions.TextAlign = ContentAlignment.MiddleCenter;
            lblCleaningInstructions.AutoSize = false;

            btnEndCleaning.Dock = DockStyle.Bottom;
            btnEndCleaning.Height = 80;
            btnEndCleaning.FlatStyle = FlatStyle.Flat;
            btnEndCleaning.Click += BtnEndCleaning_Click;

            pnlCleaning.Controls.Add(btnEndCleaning);
            pnlCleaning.Controls.Add(lblCleaningInstructions);
            pnlCleaning.Controls.Add(lblTimer);
            pnlCleaning.Controls.Add(lblCleaningMessage);
            pnlCleaning.Controls.Add(lblCleaningTitle);

            mainLayout.Controls.Add(pnlCleaning, 0, 0);
        }

        private void BtnScanStaffID_Click(object sender, EventArgs e)
        {
            try
            {
                
                btnScanStaffID.Enabled = false;
                btnScanStaffID.Text = "Opening Scanner...";
                this.Update(); 

           
                using (QRReaderForm qrReader = new QRReaderForm(QRReaderForm.ScannerMode.StaffAuthentication))
                {
                    DialogResult result = qrReader.ShowDialog(this);

                   
                    btnScanStaffID.Enabled = true;
                    btnScanStaffID.Text = "SCAN STAFF ID CARD";

                    
                    this.Activate();
                    this.Focus();
                    this.BringToFront();

                    if (result == DialogResult.OK && qrReader.IsValidScan && !string.IsNullOrEmpty(qrReader.ScannedResult))
                    {
                        // Valid staff ID scanned
                        isAuthenticated = true;
                        MessageBox.Show(
                            "✓ Staff authenticated successfully!\n\n" +
                            "Staff ID: " + qrReader.ScannedResult + "\n\n" +
                            "Starting cleaning mode...",
                            "Authentication Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        
                        this.Activate();
                        StartCleaningMode();
                    }
                    else if (result == DialogResult.Cancel && !string.IsNullOrEmpty(qrReader.ScannedResult))
                    {
                        // Invalid staff ID - error message
                        MessageBox.Show(
                            "⛔ ACCESS DENIED\n\n" +
                            "Authentication failed.\n" +
                            "Returning to welcome screen...",
                            "Authentication Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        
                        new Screen1_Welcome().Show();
                        this.Close();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                
                btnScanStaffID.Enabled = true;
                btnScanStaffID.Text = "SCAN STAFF ID CARD";

                MessageBox.Show(
                    "Error opening scanner:\n\n" + ex.Message,
                    "Scanner Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void StartCleaningMode()
        {
            try
            {
                
                pnlAuthentication.Visible = false;
                pnlCleaning.Visible = true;

                
                this.Update();
                this.Refresh();

                
                secondsRemaining = 60;
                UpdateTimerDisplay();

                
                cleaningTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error starting cleaning mode:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CleaningTimer_Tick(object sender, EventArgs e)
        {
            secondsRemaining--;
            UpdateTimerDisplay();

            if (secondsRemaining <= 0)
            {
                cleaningTimer.Stop();
                EndCleaningMode();
            }
        }

        private void UpdateTimerDisplay()
        {
            int minutes = secondsRemaining / 60;
            int seconds = secondsRemaining % 60;
            lblTimer.Text = $"{minutes:D2}:{seconds:D2}";
        }

        private void BtnEndCleaning_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure cleaning is complete?\n\nThe kiosk will return to the welcome screen.",
                "End Cleaning Mode",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                cleaningTimer.Stop();
                EndCleaningMode();
            }
        }

        private void BtnCancelAuth_Click(object sender, EventArgs e)
        {
            
            new Screen1_Welcome().Show();
            this.Close();
        }

        private void EndCleaningMode()
        {
            MessageBox.Show(
                "Cleaning mode complete!\n\nThe kiosk is now ready for customers.",
                "Cleaning Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            new Screen1_Welcome().Show();
            this.Close();
        }

        private void Screen9_CleaningMode_Resize(object sender, EventArgs e)
        {
            float scale = Math.Max(0.5f, Math.Min(this.Width, this.Height) / 1000f);

            
            lblAuthTitle.Font = new Font("Arial", 48 * scale, FontStyle.Bold);
            lblAuthInstruction.Font = new Font("Arial", 24 * scale);
            btnScanStaffID.Font = new Font("Arial", 28 * scale, FontStyle.Bold);
            btnCancelAuth.Font = new Font("Arial", 18 * scale, FontStyle.Bold);

            
            lblCleaningTitle.Font = new Font("Arial", 56 * scale, FontStyle.Bold);
            lblCleaningMessage.Font = new Font("Arial", 32 * scale);
            lblTimer.Font = new Font("Arial", 80 * scale, FontStyle.Bold);
            lblCleaningInstructions.Font = new Font("Arial", 20 * scale);
            btnEndCleaning.Font = new Font("Arial", 24 * scale, FontStyle.Bold);
        }

        private void Screen9_CleaningMode_Load(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (cleaningTimer != null)
            {
                cleaningTimer.Stop();
                cleaningTimer.Dispose();
            }
            base.OnFormClosing(e);
        }
    }
}