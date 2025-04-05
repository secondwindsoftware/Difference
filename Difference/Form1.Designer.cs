namespace Difference
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnHome = new Button();
            addressBar = new TextBox();
            BtnRefresh = new Button();
            BtnForward = new Button();
            BtnBack = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // BtnHome
            // 
            BtnHome.BackgroundImage = (Image)resources.GetObject("BtnHome.BackgroundImage");
            BtnHome.BackgroundImageLayout = ImageLayout.Zoom;
            BtnHome.FlatAppearance.BorderSize = 0;
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Location = new Point(537, 12);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(62, 39);
            BtnHome.TabIndex = 0;
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += button1_Click;
            // 
            // addressBar
            // 
            addressBar.Location = new Point(133, 67);
            addressBar.Multiline = true;
            addressBar.Name = "addressBar";
            addressBar.Size = new Size(821, 27);
            addressBar.TabIndex = 6;
            addressBar.Text = "https://";
            addressBar.TextChanged += textBox1_TextChanged;
            addressBar.KeyUp += addressBar_KeyUp;
            // 
            // BtnRefresh
            // 
            BtnRefresh.BackgroundImage = (Image)resources.GetObject("BtnRefresh.BackgroundImage");
            BtnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            BtnRefresh.FlatAppearance.BorderSize = 0;
            BtnRefresh.FlatStyle = FlatStyle.Flat;
            BtnRefresh.Location = new Point(1114, 12);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(62, 56);
            BtnRefresh.TabIndex = 10;
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += Refresh_Click;
            // 
            // BtnForward
            // 
            BtnForward.BackgroundImage = (Image)resources.GetObject("BtnForward.BackgroundImage");
            BtnForward.BackgroundImageLayout = ImageLayout.Stretch;
            BtnForward.FlatAppearance.BorderSize = 0;
            BtnForward.FlatStyle = FlatStyle.Flat;
            BtnForward.ForeColor = SystemColors.ControlLight;
            BtnForward.Location = new Point(75, 16);
            BtnForward.Name = "BtnForward";
            BtnForward.Size = new Size(62, 36);
            BtnForward.TabIndex = 11;
            BtnForward.UseVisualStyleBackColor = true;
            BtnForward.Click += Forward_Click;
            // 
            // BtnBack
            // 
            BtnBack.BackgroundImage = (Image)resources.GetObject("BtnBack.BackgroundImage");
            BtnBack.BackgroundImageLayout = ImageLayout.Stretch;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Location = new Point(11, 14);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(56, 40);
            BtnBack.TabIndex = 12;
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += button7_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.BackColor = Color.Black;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(12, 113);
            webView.Name = "webView";
            webView.Size = new Size(1164, 1419);
            webView.Source = new Uri("https://www.duckduckgo.com", UriKind.Absolute);
            webView.TabIndex = 13;
            webView.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 1544);
            Controls.Add(webView);
            Controls.Add(BtnBack);
            Controls.Add(BtnForward);
            Controls.Add(BtnRefresh);
            Controls.Add(addressBar);
            Controls.Add(BtnHome);
            Name = "Form1";
            Text = "Difference";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnHome;
        private TextBox addressBar;
        private Button BtnRefresh;
        private Button BtnForward;
        private Button BtnBack;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}
