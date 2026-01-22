namespace SweetSpotDessertShop412
{
    partial class Screen5_ItemGrid
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlScrollIndicator = new System.Windows.Forms.Panel();
            this.lblItemCounter = new System.Windows.Forms.Label();
            this.lblScrollText = new System.Windows.Forms.Label();
            this.lblScrollIcon = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBasket = new System.Windows.Forms.Panel();
            this.lblBasket = new System.Windows.Forms.Label();
            this.btnViewBasket = new System.Windows.Forms.Button();
            this.pnlScrollContainer = new System.Windows.Forms.Panel();
            this.flowItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlScrollIndicator.SuspendLayout();
            this.pnlBasket.SuspendLayout();
            this.pnlScrollContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.pnlHeader.Controls.Add(this.btnSearch);
            this.pnlHeader.Controls.Add(this.lblCount);
            this.pnlHeader.Controls.Add(this.lblCategory);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(100, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 60);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search Instead";
            this.btnSearch.UseVisualStyleBackColor = false;
            //
            // lblCount
            //
            this.lblCount.Font = new System.Drawing.Font("Arial", 13F);
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 35);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "Showing 12 items";
            //
            // lblCategory
            //
            this.lblCategory.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(0, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 93);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Cakes";
            //
            // pnlScrollIndicator
            //
            this.pnlScrollIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
            this.pnlScrollIndicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScrollIndicator.Controls.Add(this.lblItemCounter);
            this.pnlScrollIndicator.Controls.Add(this.lblScrollText);
            this.pnlScrollIndicator.Controls.Add(this.lblScrollIcon);
            this.pnlScrollIndicator.Location = new System.Drawing.Point(0, 0);
            this.pnlScrollIndicator.Name = "pnlScrollIndicator";
            this.pnlScrollIndicator.Size = new System.Drawing.Size(100, 70);
            this.pnlScrollIndicator.TabIndex = 1;
            this.pnlScrollIndicator.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlScrollIndicator_Paint);
            //
            // lblItemCounter
            //
            this.lblItemCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.lblItemCounter.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblItemCounter.ForeColor = System.Drawing.Color.White;
            this.lblItemCounter.Location = new System.Drawing.Point(0, 0);
            this.lblItemCounter.Name = "lblItemCounter";
            this.lblItemCounter.Size = new System.Drawing.Size(100, 45);
            this.lblItemCounter.TabIndex = 2;
            this.lblItemCounter.Text = "Showing items 1-8 of 12";
            this.lblItemCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblScrollText
            //
            this.lblScrollText.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblScrollText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblScrollText.Location = new System.Drawing.Point(0, 0);
            this.lblScrollText.Name = "lblScrollText";
            this.lblScrollText.Size = new System.Drawing.Size(100, 55);
            this.lblScrollText.TabIndex = 1;
            this.lblScrollText.Text = "Swipe or scroll down to see more items";
            this.lblScrollText.Click += new System.EventHandler(this.lblScrollText_Click);
            //
            // lblScrollIcon
            //
            this.lblScrollIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 24F);
            this.lblScrollIcon.Location = new System.Drawing.Point(0, 0);
            this.lblScrollIcon.Name = "lblScrollIcon";
            this.lblScrollIcon.Size = new System.Drawing.Size(80, 65);
            this.lblScrollIcon.TabIndex = 0;
            this.lblScrollIcon.Text = "👆";
            this.lblScrollIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnBack
            //
            this.btnBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnBack.FlatAppearance.BorderSize = 2;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 57);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "< Back";
            this.btnBack.UseVisualStyleBackColor = false;
            //
            // pnlBasket
            //
            this.pnlBasket.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBasket.Controls.Add(this.lblBasket);
            this.pnlBasket.Location = new System.Drawing.Point(0, 0);
            this.pnlBasket.Name = "pnlBasket";
            this.pnlBasket.Size = new System.Drawing.Size(100, 56);
            this.pnlBasket.TabIndex = 4;
            //
            // lblBasket
            //
            this.lblBasket.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblBasket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblBasket.Location = new System.Drawing.Point(0, 0);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(100, 45);
            this.lblBasket.TabIndex = 0;
            this.lblBasket.Text = "🛒 Basket: 0 items";
            this.lblBasket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnViewBasket
            //
            this.btnViewBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnViewBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBasket.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.btnViewBasket.ForeColor = System.Drawing.Color.White;
            this.btnViewBasket.Location = new System.Drawing.Point(0, 0);
            this.btnViewBasket.Name = "btnViewBasket";
            this.btnViewBasket.Size = new System.Drawing.Size(100, 56);
            this.btnViewBasket.TabIndex = 5;
            this.btnViewBasket.Text = "Proceed >";
            this.btnViewBasket.UseVisualStyleBackColor = false;
            //
            // pnlScrollContainer
            //
            this.pnlScrollContainer.AutoScroll = true;
            this.pnlScrollContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlScrollContainer.Controls.Add(this.flowItems);
            this.pnlScrollContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlScrollContainer.Name = "pnlScrollContainer";
            this.pnlScrollContainer.Size = new System.Drawing.Size(100, 100);
            this.pnlScrollContainer.TabIndex = 2;
            //
            // flowItems
            //
            this.flowItems.Location = new System.Drawing.Point(0, 0);
            this.flowItems.Name = "flowItems";
            this.flowItems.Size = new System.Drawing.Size(100, 100);
            this.flowItems.TabIndex = 0;
            //
            // Screen5_ItemGrid
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnViewBasket);
            this.Controls.Add(this.pnlBasket);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlScrollContainer);
            this.Controls.Add(this.pnlScrollIndicator);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen5_ItemGrid";
            this.Text = "Item Grid";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Screen5_ItemGrid_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlScrollIndicator.ResumeLayout(false);
            this.pnlBasket.ResumeLayout(false);
            this.pnlScrollContainer.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Panel pnlScrollIndicator;
        private System.Windows.Forms.Label lblItemCounter;
        private System.Windows.Forms.Label lblScrollText;
        private System.Windows.Forms.Label lblScrollIcon;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlBasket;
        private System.Windows.Forms.Label lblBasket;
        private System.Windows.Forms.Button btnViewBasket;
        private System.Windows.Forms.Panel pnlScrollContainer;
        private System.Windows.Forms.FlowLayoutPanel flowItems;
    }
}