using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412.Components
{
    partial class OnScreenKeyboard
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
            this.SuspendLayout();

            
            CreateKeyboardLayout();

             
            // OnScreenKeyboard
             
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1920, 300);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OnScreenKeyboard";
            this.Text = "Keyboard";
            this.Load += new System.EventHandler(this.OnScreenKeyboard_Load);
            this.ResumeLayout(false);
        }

        private void CreateKeyboardLayout()
        {
            int buttonWidth = 80;
            int buttonHeight = 50;
            int spacing = 10;
            int startX = 50;
            int startY = 20;

            Font buttonFont = new Font("Arial", 16, FontStyle.Bold);
            Color buttonColor = Color.White;
            Color buttonForeColor = Color.Black;

            // Row 1: Numbers
            string[] row1 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            for (int i = 0; i < row1.Length; i++)
            {
                CreateButton(row1[i], startX + i * (buttonWidth + spacing), startY, buttonWidth, buttonHeight, buttonFont, buttonColor, buttonForeColor);
            }

            // BACKSPACE button
            CreateButton("⌫", startX + 900, startY + 0 * (buttonHeight + spacing), 150, buttonHeight, buttonFont, Color.FromArgb(255, 152, 0), Color.White);

            // Row 2: Q to P
            string[] row2 = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P" };
            for (int i = 0; i < row2.Length; i++)
            {
                CreateButton(row2[i], startX + 40 + i * (buttonWidth + spacing), startY + (buttonHeight + spacing), buttonWidth, buttonHeight, buttonFont, buttonColor, buttonForeColor);
            }

            // Row 3: A to L
            string[] row3 = { "A", "S", "D", "F", "G", "H", "J", "K", "L" };
            for (int i = 0; i < row3.Length; i++)
            {
                CreateButton(row3[i], startX + 80 + i * (buttonWidth + spacing), startY + 2 * (buttonHeight + spacing), buttonWidth, buttonHeight, buttonFont, buttonColor, buttonForeColor);
            }

            // ENTER button
            CreateButton("ENTER", startX + 890, startY + 2 * (buttonHeight + spacing), 150, buttonHeight, buttonFont, Color.FromArgb(76, 175, 80), Color.White);

            // Row 4: Z to M
            string[] row4 = { "Z", "X", "C", "V", "B", "N", "M" };
            for (int i = 0; i < row4.Length; i++)
            {
                CreateButton(row4[i], startX + 120 + i * (buttonWidth + spacing), startY + 3 * (buttonHeight + spacing), buttonWidth, buttonHeight, buttonFont, buttonColor, buttonForeColor);
            }

            // @ button
            CreateButton("@", startX + -40, startY + 3 * (buttonHeight + spacing), 150, buttonHeight, buttonFont, buttonColor, buttonForeColor);

            // . button
            CreateButton(".", startX + 750, startY + 3 * (buttonHeight + spacing), 150, buttonHeight, buttonFont, buttonColor, buttonForeColor);

            // Row 5: Special keys
            // CLEAR button
            CreateButton("CLEAR", startX + 100, startY + 4 * (buttonHeight + spacing), 150, buttonHeight, buttonFont, Color.FromArgb(211, 47, 47), Color.White);

            // SPACE button (wide)
            CreateButton("SPACE", startX + 260, startY + 4 * (buttonHeight + spacing), 400, buttonHeight, buttonFont, buttonColor, buttonForeColor);

            // CLOSE button
            CreateButton("CLOSE", startX + 890, startY + 4 * (buttonHeight + spacing), 150, buttonHeight, buttonFont, Color.FromArgb(233, 30, 99), Color.White);
        }

        private void CreateButton(string text, int x, int y, int width, int height, Font font, Color backColor, Color foreColor)
        {
            Button btn = new Button
            {
                Text = text,
                Location = new System.Drawing.Point(x, y),
                Size = new System.Drawing.Size(width, height),
                Font = font,
                BackColor = backColor,
                ForeColor = foreColor,
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Cursor = System.Windows.Forms.Cursors.Hand,
                TabStop = false
            };
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            btn.Click += new System.EventHandler(this.KeyButton_Click);
            this.Controls.Add(btn);
        }

        #endregion
    }
}