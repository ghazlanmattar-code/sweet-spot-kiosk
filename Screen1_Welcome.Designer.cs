namespace SweetSpotDessertShop412
{
    partial class Screen1_Welcome
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
            this.components = new System.ComponentModel.Container();
            this.timerRotate = new System.Windows.Forms.Timer(this.components);
            this.btnStartOrder = new System.Windows.Forms.Button();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblShopName = new System.Windows.Forms.Label();
            this.picDessert = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDessert)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRotate
            // 
            this.timerRotate.Enabled = true;
            this.timerRotate.Interval = 3000;
            // 
            // btnStartOrder
            // 
            this.btnStartOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnStartOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartOrder.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold);
            this.btnStartOrder.ForeColor = System.Drawing.Color.White;
            this.btnStartOrder.Location = new System.Drawing.Point(0, 0);
            this.btnStartOrder.Name = "btnStartOrder";
            this.btnStartOrder.Size = new System.Drawing.Size(500, 100);
            this.btnStartOrder.TabIndex = 2;
            this.btnStartOrder.Text = "START ORDER!";
            this.btnStartOrder.UseVisualStyleBackColor = false;
            // 
            // lblTagline
            // 
            this.lblTagline.Font = new System.Drawing.Font("Arial", 20F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblTagline.Location = new System.Drawing.Point(0, 0);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(500, 60);
            this.lblTagline.TabIndex = 4;
            this.lblTagline.Text = "Indulge in handcrafted desserts";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShopName
            // 
            this.lblShopName.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.lblShopName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(39)))), ((int)(((byte)(35)))));
            this.lblShopName.Location = new System.Drawing.Point(0, 0);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(400, 80);
            this.lblShopName.TabIndex = 5;
            this.lblShopName.Text = "Sweet Spot Dessert Shop";
            this.lblShopName.Click += new System.EventHandler(this.label2_Click);
            // 
            // picDessert
            // 
            this.picDessert.Location = new System.Drawing.Point(0, 0);
            this.picDessert.Name = "picDessert";
            this.picDessert.Size = new System.Drawing.Size(100, 100);
            this.picDessert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDessert.TabIndex = 6;
            this.picDessert.TabStop = false;
            // 
            // Screen1_Welcome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.picDessert);
            this.Controls.Add(this.lblShopName);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.btnStartOrder);
            this.Name = "Screen1_Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sweet Spot Dessert Shop";
            this.Load += new System.EventHandler(this.Screen1_Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDessert)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerRotate;
        private System.Windows.Forms.Button btnStartOrder;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblShopName;
        private System.Windows.Forms.PictureBox picDessert;
    }
}