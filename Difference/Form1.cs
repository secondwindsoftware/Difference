using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Windows.Forms;

namespace Difference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView.NavigationStarting += EnsureHttps;
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.WebMessageReceived += UpdateAddressBar;
        }

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            addressBar.Text = uri;
            webView.CoreWebView2.PostWebMessageAsString(uri);
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            //webView.Size = this.ClientSize - new System.Drawing.Size(webView.Location);
            //goButton.Left = this.ClientSize.Width - goButton.Width;
            //addressBar.Width = goButton.Left - addressBar.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate("https://duckduckgo.com");

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (webView.CanGoBack) 
            { 
            webView.CoreWebView2.GoBack();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(addressBar.Text);
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Reload();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Forward_Click(object sender, EventArgs e)
        {
            BtnBack.FlatStyle = FlatStyle.Flat;
            if (webView.CanGoBack)
            {
                webView.CoreWebView2.GoBack();
            }
        }

        private void addressBar_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webView.CoreWebView2.Navigate(addressBar.Text);
            }
        }
    }
}
