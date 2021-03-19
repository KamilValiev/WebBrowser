using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;


namespace Какой_то_урок
{
    public partial class MainForm : Form
    {
        private int kolPages = 0;


        public MainForm()
        {
            InitializeComponent();
        }
        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://www.") && !address.StartsWith("https://www."))
            { 
                 address = "http://www." + address;
            }
            try
            {
                webBrowser.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }
        
        
        private void menuStripAddPageBut_Click(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;

            tabControl.TabPages.Add("Новая");
            tabControl.SelectTab(kolPages);
            tabControl.SelectedTab.Controls.Add(browser);
            kolPages++;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(menuStripAdressLine.Text))
            {
                ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(menuStripAdressLine.Text);
            }
        }
        

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = ((WebBrowser)tabControl.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;

            tabControl.TabPages.Add("новая");
            tabControl.SelectedTab.Controls.Add(browser);
            tabControl.SelectTab(kolPages);
            kolPages++;
        }


        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            menuStripGoBackBut.Enabled = webBrowser.CanGoBack;
        }
        private void menuStripGoBackBut_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }


        private void menuStripGoForwardBut_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }
        private void webBrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            menuStripGoForwardBut.Enabled = webBrowser.CanGoForward;
        }


        private void menuStripAdressLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(menuStripAdressLine.Text);
            }
        }

        private void menuStripReloadBut_Click(object sender, EventArgs e)
        {
            if (!webBrowser.Url.Equals("about:blank"))
            {
                webBrowser.Refresh();
            } 
        }

        private void menuStripSearchBut_Click(object sender, EventArgs e)
        {
            Navigate(menuStripAdressLine.Text);
        }
    }
}
