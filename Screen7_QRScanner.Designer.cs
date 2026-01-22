namespace SweetSpotDessertShop412
{
    partial class Screen7_QRScanner
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlInstructions = new System.Windows.Forms.Panel();
            this.lblInstructionsTitle = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnStartScanner = new System.Windows.Forms.Button();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.pnlScanner = new System.Windows.Forms.Panel();
            this.pnlInstructions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInstructions
            // 
            this.pnlInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.pnlInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInstructions.Controls.Add(this.lblInstructionsTitle);
            this.pnlInstructions.Controls.Add(this.btnSkip);
            this.pnlInstructions.Controls.Add(this.btnStartScanner);
            this.pnlInstructions.Controls.Add(this.lblStep3);
            this.pnlInstructions.Controls.Add(this.lblStep2);
            this.pnlInstructions.Controls.Add(this.lblStep1);
            this.pnlInstructions.Location = new System.Drawing.Point(100, 150);
            this.pnlInstructions.Name = "pnlInstructions";
            this.pnlInstructions.Size = new System.Drawing.Size(600, 700);
            this.pnlInstructions.TabIndex = 0;
            // 
            // lblInstructionsTitle
            // 
            this.lblInstructionsTitle.AutoSize = true;
            this.lblInstructionsTitle.Font = new System.Drawing.Font("Arial", 23F, System.Drawing.FontStyle.Bold);
            this.lblInstructionsTitle.Location = new System.Drawing.Point(1, 10);
            this.lblInstructionsTitle.Name = "lblInstructionsTitle";
            this.lblInstructionsTitle.Size = new System.Drawing.Size(597, 54);
            this.lblInstructionsTitle.TabIndex = 0;
            this.lblInstructionsTitle.Text = "How to Position Your Card";
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.White;
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnSkip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnSkip.Location = new System.Drawing.Point(20, 610);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(560, 70);
            this.btnSkip.TabIndex = 5;
            this.btnSkip.Text = "Skip and Continue Without Discount";
            this.btnSkip.UseVisualStyleBackColor = false;
            // 
            // btnStartScanner
            // 
            this.btnStartScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnStartScanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartScanner.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.btnStartScanner.ForeColor = System.Drawing.Color.White;
            this.btnStartScanner.Location = new System.Drawing.Point(20, 500);
            this.btnStartScanner.Name = "btnStartScanner";
            this.btnStartScanner.Size = new System.Drawing.Size(560, 90);
            this.btnStartScanner.TabIndex = 4;
            this.btnStartScanner.Text = "START SCANNING";
            this.btnStartScanner.UseVisualStyleBackColor = false;
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.Font = new System.Drawing.Font("Arial", 18F);
            this.lblStep3.Location = new System.Drawing.Point(20, 220);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(456, 41);
            this.lblStep3.TabIndex = 3;
            this.lblStep3.Text = "3. Watch for green indicator";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Font = new System.Drawing.Font("Arial", 18F);
            this.lblStep2.Location = new System.Drawing.Point(20, 160);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(474, 41);
            this.lblStep2.TabIndex = 2;
            this.lblStep2.Text = "2. Keep card flat and straight";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Font = new System.Drawing.Font("Arial", 18F);
            this.lblStep1.Location = new System.Drawing.Point(20, 100);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(561, 41);
            this.lblStep1.TabIndex = 1;
            this.lblStep1.Text = "1. Hold card 5-10cm from scanner";
            // 
            // pnlScanner
            // 
            this.pnlScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlScanner.Location = new System.Drawing.Point(800, 150);
            this.pnlScanner.Name = "pnlScanner";
            this.pnlScanner.Size = new System.Drawing.Size(989, 700);
            this.pnlScanner.TabIndex = 1;
            // 
            // Screen7_QRScanner
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnlScanner);
            this.Controls.Add(this.pnlInstructions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen7_QRScanner";
            this.Text = "Screen7_QRScanner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Screen7_QRScanner_Load);
            this.pnlInstructions.ResumeLayout(false);
            this.pnlInstructions.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlInstructions;
        private System.Windows.Forms.Label lblInstructionsTitle;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.Button btnStartScanner;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Panel pnlScanner;
    }

}