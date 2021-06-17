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
                ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(address);
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }
        
        private void menuStripDeletePageBut_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count > 1)
            {
                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
                tabControl.SelectTab(tabControl.TabPages.Count - 1);
                kolPages--;
            }
        }
        private void menuStripAddPageBut_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Add("Новая вкладка");
            WebBrowser web = new WebBrowser();
            tabControl.SelectedTab.Controls.Add(web);
            web.Visible = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += browser_DocumentCompleted;
            tabControl.SelectTab(kolPages);
            kolPages++;
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = ((WebBrowser)tabControl.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            menuStripGoBackBut.Enabled = webBrowser.CanGoBack;
        }
        private void menuStripGoBackBut_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoBack();
        }


        private void menuStripGoForwardBut_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).GoForward();

        }
        private void webBrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            menuStripGoForwardBut.Enabled = webBrowser.CanGoForward;
        }


        private void menuStripAdressLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(menuStripAdressLine.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(menuStripAdressLine.Text);
                }
            }
        }
        private void menuStripSearchBut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(menuStripAdressLine.Text))
            {
                ((WebBrowser)tabControl.SelectedTab.Controls[0]).Navigate(menuStripAdressLine.Text);
            }
        }


        private void menuStripRefreshBut_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).Refresh();
        }
        private void menuStripStopBut_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl.SelectedTab.Controls[0]).Stop();
        }
    }
}
