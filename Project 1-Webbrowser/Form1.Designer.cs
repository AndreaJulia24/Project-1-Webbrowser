namespace Project_1_Webbrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.GoHome = new System.Windows.Forms.ToolStripButton();
            this.Next = new System.Windows.Forms.ToolStripButton();
            this.Back = new System.Windows.Forms.ToolStripButton();
            this.Navigate = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBlockedWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GoHome,
            this.Next,
            this.Back,
            this.Navigate,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // GoHome
            // 
            this.GoHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoHome.Image = ((System.Drawing.Image)(resources.GetObject("GoHome.Image")));
            this.GoHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoHome.Name = "GoHome";
            this.GoHome.Size = new System.Drawing.Size(23, 22);
            this.GoHome.Text = "toolStripButton1";
            this.GoHome.Click += new System.EventHandler(this.GoHome_Click);
            // 
            // Next
            // 
            this.Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
            this.Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(23, 22);
            this.Next.Text = "toolStripButton2";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Back.Image = ((System.Drawing.Image)(resources.GetObject("Back.Image")));
            this.Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(23, 22);
            this.Back.Text = "toolStripButton3";
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Navigate
            // 
            this.Navigate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Navigate.Image = ((System.Drawing.Image)(resources.GetObject("Navigate.Image")));
            this.Navigate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Navigate.Name = "Navigate";
            this.Navigate.Size = new System.Drawing.Size(23, 22);
            this.Navigate.Text = "toolStripButton4";
            this.Navigate.Click += new System.EventHandler(this.Navigate_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBlockedWordsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // addBlockedWordsToolStripMenuItem
            // 
            this.addBlockedWordsToolStripMenuItem.Name = "addBlockedWordsToolStripMenuItem";
            this.addBlockedWordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addBlockedWordsToolStripMenuItem.Text = "Add Blocked Words";
            this.addBlockedWordsToolStripMenuItem.Click += new System.EventHandler(this.addBlockedWordsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.webBrowser1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton GoHome;
        private System.Windows.Forms.ToolStripButton Next;
        private System.Windows.Forms.ToolStripButton Back;
        private System.Windows.Forms.ToolStripButton Navigate;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBlockedWordsToolStripMenuItem;
    }
}

