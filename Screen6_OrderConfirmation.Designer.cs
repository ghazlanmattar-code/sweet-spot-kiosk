namespace SweetSpotDessertShop412
{
    partial class Screen6_OrderConfirmation
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlOrderCard = new System.Windows.Forms.Panel();
            this.pnlWarning = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lnkBack = new System.Windows.Forms.LinkLabel();
            this.pnlOrderCard.SuspendLayout();
            this.pnlWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 100);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Confirm Your Order";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOrderCard
            // 
            this.pnlOrderCard.BackColor = System.Drawing.Color.White;
            this.pnlOrderCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderCard.Controls.Add(this.pnlWarning);
            this.pnlOrderCard.Controls.Add(this.btnConfirm);
            this.pnlOrderCard.Controls.Add(this.lblInstruction);
            this.pnlOrderCard.Controls.Add(this.lblTotalAmount);
            this.pnlOrderCard.Controls.Add(this.lblTotalLabel);
            this.pnlOrderCard.Controls.Add(this.lblSummaryTitle);
            this.pnlOrderCard.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderCard.Name = "pnlOrderCard";
            this.pnlOrderCard.Size = new System.Drawing.Size(1200, 700);
            this.pnlOrderCard.TabIndex = 1;
            // 
            // pnlWarning
            // 
            this.pnlWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.pnlWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWarning.Controls.Add(this.lblWarning);
            this.pnlWarning.Location = new System.Drawing.Point(0, 0);
            this.pnlWarning.Name = "pnlWarning";
            this.pnlWarning.Size = new System.Drawing.Size(100, 100);
            this.pnlWarning.TabIndex = 5;
            // 
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Arial", 17F);
            this.lblWarning.Location = new System.Drawing.Point(0, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(100, 87);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "⚠️ Important: Once you tap \"CONFIRM ORDER\" below, your order will be sent to the kitchen and cannot be changed.";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(0, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(600, 90);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "CONFIRM ORDER";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.lblInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblInstruction.Location = new System.Drawing.Point(0, 0);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(100, 65);
            this.lblInstruction.TabIndex = 3;
            this.lblInstruction.Text = "👇 TAP CONFIRM TO SEND ORDER 👇";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(0, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(100, 70);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "BHD 5.7";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblTotalLabel.Location = new System.Drawing.Point(0, 0);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(100, 70);
            this.lblTotalLabel.TabIndex = 1;
            this.lblTotalLabel.Text = "TOTAL:";
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(100, 80);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Order Summary";
            // 
            // lnkBack
            // 
            this.lnkBack.Font = new System.Drawing.Font("Arial", 18F);
            this.lnkBack.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.lnkBack.Location = new System.Drawing.Point(0, 0);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(100, 45);
            this.lnkBack.TabIndex = 2;
            this.lnkBack.TabStop = true;
            this.lnkBack.Text = "< Go back to edit order";
            this.lnkBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Screen6_OrderConfirmation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.pnlOrderCard);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen6_OrderConfirmation";
            this.Text = "Order Confirmation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Screen6_OrderConfirmation_Load);
            this.pnlOrderCard.ResumeLayout(false);
            this.pnlWarning.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlOrderCard;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Panel pnlWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.LinkLabel lnkBack;
    }
}