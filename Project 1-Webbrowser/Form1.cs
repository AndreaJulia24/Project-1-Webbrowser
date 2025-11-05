using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Project_1_Webbrowser
{
    public partial class Form1 : Form
    {
        private List<string> blockedWords = new List<string> { "facebook", "twitter", "instagram" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GoHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Navigate_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

            string currentUrl = e.Url.ToString().ToLower();
            foreach (string blockedWord in blockedWords)
            {
                if (currentUrl.Contains(blockedWord))
                {
                    MessageBox.Show("Access to this website is blocked.");
                    e.Cancel = true;
                    return;
                }
            }
        }

        //3.- Kulcsszavak hozzáadása egy új Űrlapon (Form).
        

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(toolStripTextBox1.Text);
            }
        }

        private void addBlockedWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AddBlockedWordsForm addForm = new AddBlockedWordsForm(blockedWords))
            {
                addForm.ShowDialog();
            }
        }
    }
}
