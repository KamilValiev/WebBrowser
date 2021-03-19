
namespace Какой_то_урок
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.ToolStrip();
            this.menuStripGoBackBut = new System.Windows.Forms.ToolStripButton();
            this.menuStripGoForwardBut = new System.Windows.Forms.ToolStripButton();
            this.menuStripRefreshBut = new System.Windows.Forms.ToolStripButton();
            this.menuStripAdressLine = new System.Windows.Forms.ToolStripTextBox();
            this.menuStripSearchBut = new System.Windows.Forms.ToolStripButton();
            this.menuStripAddPageBut = new System.Windows.Forms.ToolStripButton();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripGoBackBut,
            this.menuStripGoForwardBut,
            this.menuStripRefreshBut,
            this.menuStripAdressLine,
            this.menuStripSearchBut,
            this.menuStripAddPageBut,
            this.toolStripButton1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuStripGoBackBut
            // 
            this.menuStripGoBackBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuStripGoBackBut.Image = global::Какой_то_урок.Properties.Resources.go_next_icon_180851;
            this.menuStripGoBackBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripGoBackBut.Name = "menuStripGoBackBut";
            this.menuStripGoBackBut.Size = new System.Drawing.Size(29, 24);
            this.menuStripGoBackBut.Text = "toolStripButton1";
            this.menuStripGoBackBut.ToolTipText = "Нажмите, чтобы вернуться\r\n";
            this.menuStripGoBackBut.Click += new System.EventHandler(this.menuStripGoBackBut_Click);
            // 
            // menuStripGoForwardBut
            // 
            this.menuStripGoForwardBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuStripGoForwardBut.Image = global::Какой_то_урок.Properties.Resources.go_previous_icon_1808521;
            this.menuStripGoForwardBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripGoForwardBut.Name = "menuStripGoForwardBut";
            this.menuStripGoForwardBut.Size = new System.Drawing.Size(29, 24);
            this.menuStripGoForwardBut.Text = "toolStripButton2";
            this.menuStripGoForwardBut.ToolTipText = "Нажмите, чтобы перейти вперёд\r\n\r\n\r\n";
            this.menuStripGoForwardBut.Click += new System.EventHandler(this.menuStripGoForwardBut_Click);
            // 
            // menuStripRefreshBut
            // 
            this.menuStripRefreshBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuStripRefreshBut.Image = global::Какой_то_урок.Properties.Resources.view_refresh_icon_180918;
            this.menuStripRefreshBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripRefreshBut.Name = "menuStripRefreshBut";
            this.menuStripRefreshBut.Size = new System.Drawing.Size(29, 24);
            this.menuStripRefreshBut.Text = "toolStripButton3";
            this.menuStripRefreshBut.ToolTipText = "Обновить эту страницу\r\n";
            this.menuStripRefreshBut.Click += new System.EventHandler(this.menuStripRefreshBut_Click);
            // 
            // menuStripAdressLine
            // 
            this.menuStripAdressLine.AccessibleDescription = "";
            this.menuStripAdressLine.AccessibleName = "";
            this.menuStripAdressLine.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStripAdressLine.Name = "menuStripAdressLine";
            this.menuStripAdressLine.Size = new System.Drawing.Size(400, 27);
            this.menuStripAdressLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menuStripAdressLine_KeyDown);
            // 
            // menuStripSearchBut
            // 
            this.menuStripSearchBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuStripSearchBut.Image = global::Какой_то_урок.Properties.Resources.edit_find_icon_180814;
            this.menuStripSearchBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripSearchBut.Name = "menuStripSearchBut";
            this.menuStripSearchBut.Size = new System.Drawing.Size(29, 24);
            // 
            // menuStripAddPageBut
            // 
            this.menuStripAddPageBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuStripAddPageBut.Image = ((System.Drawing.Image)(resources.GetObject("menuStripAddPageBut.Image")));
            this.menuStripAddPageBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuStripAddPageBut.Name = "menuStripAddPageBut";
            this.menuStripAddPageBut.Size = new System.Drawing.Size(29, 24);
            this.menuStripAddPageBut.Text = "+";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 423);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 394);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(3, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(786, 388);
            this.webBrowser.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainForm";
            this.Text = "Opera";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuStrip;
        private System.Windows.Forms.ToolStripButton menuStripAddPageBut;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripTextBox menuStripAdressLine;
        private System.Windows.Forms.ToolStripButton menuStripSearchBut;
        private System.Windows.Forms.ToolStripButton menuStripGoBackBut;
        private System.Windows.Forms.ToolStripButton menuStripGoForwardBut;
        private System.Windows.Forms.ToolStripButton menuStripRefreshBut;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

