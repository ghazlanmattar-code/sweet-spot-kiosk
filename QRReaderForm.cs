using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace SweetSpotDessertShop412.Components
{
    public partial class QRReaderForm : Form
    {
        
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private BarcodeReader barcodeReader;

        
        private readonly object frameLock = new object();
        private Bitmap currentFrame;


        private bool isScanning = false;
        private bool cameraStarted = false;

       
        public enum ScannerMode
        {
            StaffAuthentication,
            LoyaltyDiscount
        }

        private ScannerMode currentMode;

        // Valid QR codes for each mode
        private readonly string[] validStaffCodes = { "STAFF001", "STAFF002", "STAFF003", "EMP123", "EMPLOYEE456" };
        private readonly string[] validLoyaltyCodes = { "LOYALTY2024", "VIP-MEMBER-001", "GOLD-CARD-2024", "REWARDS-MEMBER", "LOYALTY-PREMIUM" };

        
        public string ScannedResult { get; private set; }
        public bool IsValidScan { get; private set; }

        public QRReaderForm(ScannerMode mode = ScannerMode.LoyaltyDiscount)
        {
            InitializeComponent();
            currentMode = mode;
            InitializeScanner();
        }

        private void InitializeScanner()
        {
            
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(900, 700);
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            if (currentMode == ScannerMode.StaffAuthentication)
            {
                this.Text = "QR Code Scanner - Staff Authentication";
                lblTitle.Text = "📷 Staff QR Code Scanner - Scan Your ID Card";
            }
            else
            {
                this.Text = "QR Code Scanner - Loyalty Discount";
                lblTitle.Text = "📷 Loyalty QR Code Scanner - Scan Your Loyalty Card";
            }

            
            barcodeReader = new BarcodeReader
            {
                AutoRotate = true,
                TryInverted = true, 
                Options = new ZXing.Common.DecodingOptions
                {
                    TryHarder = true,
                    PossibleFormats = new[] { BarcodeFormat.QR_CODE },
                    PureBarcode = false, 
                    TryInverted = true 
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                {
                    MessageBox.Show(
                        "No camera detected!\n\nPlease connect a camera and try again.",
                        "Camera Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }

                
                cboCamera.Items.Clear();
                foreach (FilterInfo device in videoDevices)
                {
                    cboCamera.Items.Add(device.Name);
                }

                // Select first camera
                cboCamera.SelectedIndex = 0;

                // Enable start button
                btnStart.Enabled = true;
                btnDecode.Enabled = false;
                takePhoto.Enabled = false;

                // Update instructions based on mode
                if (currentMode == ScannerMode.StaffAuthentication)
                {
                    UpdateInstructions("Select your camera and click 'Start Camera' to scan staff ID.");
                }
                else
                {
                    UpdateInstructions("Select your camera and click 'Start Camera' to scan loyalty card.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error initializing camera:\n\n" + ex.Message,
                    "Initialization Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cboCamera.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a camera from the dropdown list.",
                    "No Camera Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                
                StopCamera();

                
                videoSource = new VideoCaptureDevice(videoDevices[cboCamera.SelectedIndex].MonikerString);

                
                if (videoSource.VideoCapabilities.Length > 0)
                {
                    videoSource.VideoResolution = videoSource.VideoCapabilities[0];
                }

                
                videoSource.NewFrame += VideoSource_NewFrame;

                // Start camera
                videoSource.Start();

                
                cameraStarted = true;
                btnStart.Enabled = false;
                btnStart.Text = "Camera Running";
                btnStart.BackColor = Color.Gray;
                btnDecode.Enabled = true;
                takePhoto.Enabled = true;
                cboCamera.Enabled = false;

                UpdateInstructions("Camera started! Click 'Start Scan' to begin scanning for QR codes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error starting camera:\n\n" + ex.Message + "\n\nTry selecting a different camera.",
                    "Camera Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                StopCamera();
                btnStart.Enabled = true;
                btnStart.Text = "Start Camera";
                btnStart.BackColor = Color.FromArgb(76, 175, 80);
                cboCamera.Enabled = true;
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                
                Bitmap newFrame = (Bitmap)eventArgs.Frame.Clone();

                lock (frameLock)
                {
                    
                    if (currentFrame != null)
                    {
                        currentFrame.Dispose();
                    }
                    currentFrame = newFrame;
                }

                
                if (pictureBox1.InvokeRequired)
                {
                    pictureBox1.Invoke(new Action(() =>
                    {
                        lock (frameLock)
                        {
                            if (currentFrame != null)
                            {
                                
                                if (pictureBox1.Image != null)
                                {
                                    var oldImage = pictureBox1.Image;
                                    pictureBox1.Image = null;
                                    oldImage.Dispose();
                                }

                                
                                pictureBox1.Image = (Bitmap)currentFrame.Clone();
                            }
                        }
                    }));
                }
            }
            catch
            {
                
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (!cameraStarted)
            {
                MessageBox.Show(
                    "Please start the camera first!",
                    "Camera Not Started",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!isScanning)
            {
                // Start scanning
                isScanning = true;
                timer1.Start();
                btnDecode.Text = "⏸ Stop Scan";
                btnDecode.BackColor = Color.FromArgb(255, 152, 0);
                UpdateInstructions("🔍 SCANNING... Hold QR code steady in front of camera. Works with black or white backgrounds!");
            }
            else
            {
                // Stop scanning
                isScanning = false;
                timer1.Stop();
                btnDecode.Text = "Start Scan";
                btnDecode.BackColor = Color.FromArgb(233, 30, 99);
                UpdateInstructions("Scanning stopped. Click 'Start Scan' to resume.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isScanning || !cameraStarted)
            {
                return;
            }

            Bitmap frameToScan = null;

            try
            {
                
                lock (frameLock)
                {
                    if (currentFrame != null)
                    {
                        frameToScan = (Bitmap)currentFrame.Clone();
                    }
                }

                
                if (frameToScan != null)
                {
                    
                    Result result = barcodeReader.Decode(frameToScan);

                    if (result != null && !string.IsNullOrEmpty(result.Text))
                    {
                        
                        HandleSuccessfulScan(result.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                
                System.Diagnostics.Debug.WriteLine("Decode error: " + ex.Message);
            }
            finally
            {
               
                if (frameToScan != null)
                {
                    frameToScan.Dispose();
                }
            }
        }

        private bool IsValidCode(string code)
        {
            if (currentMode == ScannerMode.StaffAuthentication)
            {
                return Array.Exists(validStaffCodes, c => c.Equals(code, StringComparison.OrdinalIgnoreCase));
            }
            else // LoyaltyDiscount
            {
                return Array.Exists(validLoyaltyCodes, c => c.Equals(code, StringComparison.OrdinalIgnoreCase));
            }
        }

        private void HandleSuccessfulScan(string qrData)
        {
            
            isScanning = false;
            timer1.Stop();

            
            IsValidScan = IsValidCode(qrData);

            
            ScannedResult = qrData;

            
            if (txtResult.InvokeRequired)
            {
                txtResult.Invoke(new Action(() =>
                {
                    txtResult.Items.Add(qrData);
                    if (txtResult.Items.Count > 0)
                        txtResult.SelectedIndex = txtResult.Items.Count - 1;
                }));
            }
            else
            {
                txtResult.Items.Add(qrData);
                if (txtResult.Items.Count > 0)
                    txtResult.SelectedIndex = txtResult.Items.Count - 1;
            }

            
            StopCamera();

            
            this.BeginInvoke(new Action(() =>
            {
                if (IsValidScan)
                {
                    
                    if (currentMode == ScannerMode.StaffAuthentication)
                    {
                        MessageBox.Show(
                            "✓ Staff ID Verified!\n\n" +
                            "Staff ID: " + qrData + "\n\n" +
                            "Authentication successful.",
                            "Scan Complete",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "✓ Loyalty Card Verified!\n\n" +
                            "Loyalty ID: " + qrData + "\n\n" +
                            "10% discount has been applied!",
                            "Scan Complete - Discount Applied",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }

                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // Invalid code
                    if (currentMode == ScannerMode.StaffAuthentication)
                    {
                        MessageBox.Show(
                            "✗ Invalid Staff ID!\n\n" +
                            "Scanned Code: " + qrData + "\n\n" +
                            "This is not a valid staff ID card.\n" +
                            "Please use your official staff ID.",
                            "Invalid Staff ID",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "✗ Invalid Loyalty Card!\n\n" +
                            "Scanned Code: " + qrData + "\n\n" +
                            "This loyalty card is not recognized.\n" +
                            "Please check your card or register for our loyalty program.",
                            "Invalid Loyalty Card",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }

                    
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }));
        }

        private void takePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                lock (frameLock)
                {
                    if (currentFrame != null)
                    {
                        
                        if (pictureBox2.Image != null)
                        {
                            pictureBox2.Image.Dispose();
                        }

                        
                        pictureBox2.Image = (Bitmap)currentFrame.Clone();

                        MessageBox.Show(
                            "Photo captured successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "No image available. Please start the camera first.",
                            "No Image",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error capturing photo:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void StopCamera()
        {
            try
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    
                    videoSource.NewFrame -= VideoSource_NewFrame;

                    
                    videoSource.SignalToStop();

                    
                    var videoSourceToStop = videoSource;

                    
                    System.Threading.Tasks.Task.Run(() =>
                    {
                        try
                        {
                            if (videoSourceToStop != null)
                            {
                                videoSourceToStop.WaitForStop();
                            }
                        }
                        catch { }
                    });
                }
            }
            catch
            {
                
            }
            finally
            {
                cameraStarted = false;
                videoSource = null;
            }
        }

        private void UpdateInstructions(string text)
        {
            if (label1.InvokeRequired)
            {
                label1.Invoke(new Action(() => label1.Text = text));
            }
            else
            {
                label1.Text = text;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
                isScanning = false;

                
                if (timer1 != null)
                {
                    timer1.Stop();
                }

                
                if (videoSource != null)
                {
                    try
                    {
                        if (videoSource.IsRunning)
                        {
                            videoSource.NewFrame -= VideoSource_NewFrame;
                            videoSource.SignalToStop();
                            
                        }
                    }
                    catch { }
                    finally
                    {
                        videoSource = null;
                    }
                }

                
                lock (frameLock)
                {
                    if (currentFrame != null)
                    {
                        try
                        {
                            currentFrame.Dispose();
                        }
                        catch { }
                        currentFrame = null;
                    }
                }

                
                try
                {
                    if (pictureBox1 != null && pictureBox1.Image != null)
                    {
                        var img = pictureBox1.Image;
                        pictureBox1.Image = null;
                        img.Dispose();
                    }
                }
                catch { }

                try
                {
                    if (pictureBox2 != null && pictureBox2.Image != null)
                    {
                        var img = pictureBox2.Image;
                        pictureBox2.Image = null;
                        img.Dispose();
                    }
                }
                catch { }
            }
            catch
            {
                
            }
        }
    }
}