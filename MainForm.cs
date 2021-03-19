using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Какой_то_урок
{
    public partial class MainForm : Form
    {
        private int kolPages = 0;


        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;

            tabControl1.TabPages.Add("Новая");
            tabControl1.SelectTab(kolPages);
            tabControl1.SelectedTab.Controls.Add(browser);
            kolPages++;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(toolStripText.Text))
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(toolStripText.Text);
            }
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;

            tabControl1.TabPages.Add("www.Google.com");
            tabControl1.SelectedTab.Controls.Add(browser);
            tabControl1.SelectTab(kolPages);
            kolPages++;
        }
    }
}
