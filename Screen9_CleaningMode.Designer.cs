namespace SweetSpotDessertShop412
{
    partial class Screen9_CleaningMode
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlAuthentication = new System.Windows.Forms.Panel();
            this.btnCancelAuth = new System.Windows.Forms.Button();
            this.lblAuthInstruction = new System.Windows.Forms.Label();
            this.lblAuthTitle = new System.Windows.Forms.Label();
            this.btnScanStaffID = new System.Windows.Forms.Button();
            this.pnlCleaning = new System.Windows.Forms.Panel();
            this.btnEndCleaning = new System.Windows.Forms.Button();
            this.lblCleaningInstructions = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblCleaningMessage = new System.Windows.Forms.Label();
            this.lblCleaningTitle = new System.Windows.Forms.Label();
            this.pnlAuthentication.SuspendLayout();
            this.pnlCleaning.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAuthentication
            // 
            this.pnlAuthentication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlAuthentication.Controls.Add(this.btnCancelAuth);
            this.pnlAuthentication.Controls.Add(this.lblAuthInstruction);
            this.pnlAuthentication.Controls.Add(this.lblAuthTitle);
            this.pnlAuthentication.Controls.Add(this.btnScanStaffID);
            this.pnlAuthentication.Location = new System.Drawing.Point(0, 0);
            this.pnlAuthentication.Name = "pnlAuthentication";
            this.pnlAuthentication.Size = new System.Drawing.Size(100, 100);
            this.pnlAuthentication.TabIndex = 0;
            // 
            // btnCancelAuth
            // 
            this.btnCancelAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCancelAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAuth.FlatAppearance.BorderSize = 0;
            this.btnCancelAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAuth.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnCancelAuth.ForeColor = System.Drawing.Color.White;
            this.btnCancelAuth.Location = new System.Drawing.Point(0, 0);
            this.btnCancelAuth.Name = "btnCancelAuth";
            this.btnCancelAuth.Size = new System.Drawing.Size(100, 70);
            this.btnCancelAuth.TabIndex = 3;
            this.btnCancelAuth.Text = "Cancel and Return to Welcome";
            this.btnCancelAuth.UseVisualStyleBackColor = false;
            // 
            // lblAuthInstruction
            // 
            this.lblAuthInstruction.Font = new System.Drawing.Font("Arial", 24F);
            this.lblAuthInstruction.ForeColor = System.Drawing.Color.White;
            this.lblAuthInstruction.Location = new System.Drawing.Point(0, 0);
            this.lblAuthInstruction.Name = "lblAuthInstruction";
            this.lblAuthInstruction.Size = new System.Drawing.Size(100, 100);
            this.lblAuthInstruction.TabIndex = 2;
            this.lblAuthInstruction.Text = "Staff authentication required to enter cleaning mode";
            this.lblAuthInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAuthTitle
            // 
            this.lblAuthTitle.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold);
            this.lblAuthTitle.ForeColor = System.Drawing.Color.White;
            this.lblAuthTitle.Location = new System.Drawing.Point(0, 0);
            this.lblAuthTitle.Name = "lblAuthTitle";
            this.lblAuthTitle.Size = new System.Drawing.Size(100, 150);
            this.lblAuthTitle.TabIndex = 1;
            this.lblAuthTitle.Text = "🔒 STAFF ONLY";
            this.lblAuthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnScanStaffID
            // 
            this.btnScanStaffID.BackColor = System.Drawing.Color.White;
            this.btnScanStaffID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScanStaffID.FlatAppearance.BorderSize = 0;
            this.btnScanStaffID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanStaffID.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.btnScanStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnScanStaffID.Location = new System.Drawing.Point(0, 0);
            this.btnScanStaffID.Name = "btnScanStaffID";
            this.btnScanStaffID.Size = new System.Drawing.Size(600, 100);
            this.btnScanStaffID.TabIndex = 0;
            this.btnScanStaffID.Text = "SCAN STAFF ID CARD";
            this.btnScanStaffID.UseVisualStyleBackColor = false;
            // 
            // pnlCleaning
            // 
            this.pnlCleaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.pnlCleaning.Controls.Add(this.btnEndCleaning);
            this.pnlCleaning.Controls.Add(this.lblCleaningInstructions);
            this.pnlCleaning.Controls.Add(this.lblTimer);
            this.pnlCleaning.Controls.Add(this.lblCleaningMessage);
            this.pnlCleaning.Controls.Add(this.lblCleaningTitle);
            this.pnlCleaning.Location = new System.Drawing.Point(0, 0);
            this.pnlCleaning.Name = "pnlCleaning";
            this.pnlCleaning.Size = new System.Drawing.Size(100, 100);
            this.pnlCleaning.TabIndex = 1;
            // 
            // btnEndCleaning
            // 
            this.btnEndCleaning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnEndCleaning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEndCleaning.FlatAppearance.BorderSize = 0;
            this.btnEndCleaning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndCleaning.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold);
            this.btnEndCleaning.ForeColor = System.Drawing.Color.White;
            this.btnEndCleaning.Location = new System.Drawing.Point(0, 0);
            this.btnEndCleaning.Name = "btnEndCleaning";
            this.btnEndCleaning.Size = new System.Drawing.Size(100, 80);
            this.btnEndCleaning.TabIndex = 4;
            this.btnEndCleaning.Text = "END CLEANING MODE";
            this.btnEndCleaning.UseVisualStyleBackColor = false;
            // 
            // lblCleaningInstructions
            // 
            this.lblCleaningInstructions.Font = new System.Drawing.Font("Arial", 20F);
            this.lblCleaningInstructions.ForeColor = System.Drawing.Color.White;
            this.lblCleaningInstructions.Location = new System.Drawing.Point(0, 0);
            this.lblCleaningInstructions.Name = "lblCleaningInstructions";
            this.lblCleaningInstructions.Size = new System.Drawing.Size(100, 100);
            this.lblCleaningInstructions.TabIndex = 3;
            this.lblCleaningInstructions.Text = "Cleaning mode will automatically end after 60 seconds";
            this.lblCleaningInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Arial", 80F, System.Drawing.FontStyle.Bold);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(0, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 200);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "01:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCleaningMessage
            // 
            this.lblCleaningMessage.Font = new System.Drawing.Font("Arial", 32F);
            this.lblCleaningMessage.ForeColor = System.Drawing.Color.White;
            this.lblCleaningMessage.Location = new System.Drawing.Point(0, 0);
            this.lblCleaningMessage.Name = "lblCleaningMessage";
            this.lblCleaningMessage.Size = new System.Drawing.Size(100, 150);
            this.lblCleaningMessage.TabIndex = 1;
            this.lblCleaningMessage.Text = "Please sanitize the touchscreen";
            this.lblCleaningMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCleaningTitle
            // 
            this.lblCleaningTitle.Font = new System.Drawing.Font("Arial", 56F, System.Drawing.FontStyle.Bold);
            this.lblCleaningTitle.ForeColor = System.Drawing.Color.White;
            this.lblCleaningTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCleaningTitle.Name = "lblCleaningTitle";
            this.lblCleaningTitle.Size = new System.Drawing.Size(100, 200);
            this.lblCleaningTitle.TabIndex = 0;
            this.lblCleaningTitle.Text = "🧼 CLEANING MODE";
            this.lblCleaningTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Screen9_CleaningMode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pnlCleaning);
            this.Controls.Add(this.pnlAuthentication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen9_CleaningMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cleaning Mode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Screen9_CleaningMode_Load);
            this.pnlAuthentication.ResumeLayout(false);
            this.pnlCleaning.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlAuthentication;
        private System.Windows.Forms.Label lblAuthTitle;
        private System.Windows.Forms.Button btnScanStaffID;
        private System.Windows.Forms.Label lblAuthInstruction;
        private System.Windows.Forms.Button btnCancelAuth;
        private System.Windows.Forms.Panel pnlCleaning;
        private System.Windows.Forms.Label lblCleaningTitle;
        private System.Windows.Forms.Label lblCleaningMessage;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblCleaningInstructions;
        private System.Windows.Forms.Button btnEndCleaning;
    }
}