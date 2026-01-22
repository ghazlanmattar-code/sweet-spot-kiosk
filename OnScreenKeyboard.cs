using System;
using System.Drawing;
using System.Windows.Forms;

namespace SweetSpotDessertShop412.Components
{
    public partial class OnScreenKeyboard : Form
    {
        private TextBox targetTextBox;
        public event EventHandler KeyboardClosed;

        public OnScreenKeyboard()
        {
            InitializeComponent();
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1120, 360);
            this.BackColor = Color.FromArgb(60, 60, 60);
            this.Text = "On-Screen Keyboard";
        }

        public void SetTargetTextBox(TextBox textBox)
        {
            targetTextBox = textBox;
        }

        private void KeyButton_Click(object sender, EventArgs e)
        {
            if (targetTextBox != null)
            {
                Button btn = (Button)sender;

                if (btn.Text == "⌫") // Backspace
                {
                    if (targetTextBox.Text.Length > 0)
                        targetTextBox.Text = targetTextBox.Text.Substring(0, targetTextBox.Text.Length - 1);
                }
                else if (btn.Text == "SPACE")
                {
                    targetTextBox.Text += " ";
                }
                else if (btn.Text == "CLEAR")
                {
                    targetTextBox.Text = "";
                }
                else if (btn.Text == "ENTER")
                {
                    
                    this.Close();
                }
                else if (btn.Text == "CLOSE")
                {
                    this.Close();
                }
                else
                {
                    targetTextBox.Text += btn.Text;
                }

                targetTextBox.Focus();
                targetTextBox.SelectionStart = targetTextBox.Text.Length;
            }
        }

        private void OnScreenKeyboard_Load(object sender, EventArgs e)
        {
            
            CreateKeyboardLayout();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            KeyboardClosed?.Invoke(this, EventArgs.Empty);
            base.OnFormClosing(e);
        }
    }
}