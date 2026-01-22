namespace SweetSpotDessertShop412
{
    partial class Screen8_Search
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowKeyboard = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 48F);
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ReadOnly = true;
            this.txtSearch.Size = new System.Drawing.Size(100, 118);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnShowKeyboard
            // 
            this.btnShowKeyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnShowKeyboard.Font = new System.Drawing.Font("Arial", 24F);
            this.btnShowKeyboard.ForeColor = System.Drawing.Color.White;
            this.btnShowKeyboard.Location = new System.Drawing.Point(0, 0);
            this.btnShowKeyboard.Name = "btnShowKeyboard";
            this.btnShowKeyboard.Size = new System.Drawing.Size(100, 75);
            this.btnShowKeyboard.TabIndex = 1;
            this.btnShowKeyboard.Text = "Touch to Type";
            this.btnShowKeyboard.UseVisualStyleBackColor = false;
            // 
            // lstResults
            // 
            this.lstResults.Font = new System.Drawing.Font("Arial", 22F);
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 50;
            this.lstResults.Location = new System.Drawing.Point(0, 0);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(100, 554);
            this.lstResults.TabIndex = 2;
            // 
            // Screen8_Search
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.btnShowKeyboard);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Screen8_Search";
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Screen8_Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnShowKeyboard;
        private System.Windows.Forms.ListBox lstResults;
    }
}