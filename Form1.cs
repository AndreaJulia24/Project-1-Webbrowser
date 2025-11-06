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
<<<<<<< HEAD
using System.Diagnostics;
=======
>>>>>>> dc55c244936f812c0b1cf2cb540885d292c76351

namespace Project_1_Webbrowser
{
    public partial class Form1 : Form
    {
        private List<string> blockedWords = new List<string> { "facebook", "twitter", "instagram" };
<<<<<<< HEAD
        private DatabaseManager _dbManager;
        public Form1()
        {
            InitializeComponent();
            //trace naplozas
           string logFilePath = "blockedUrl.txt";
           Trace.Listeners.Add(new TextWriterTraceListener(logFilePath));
           Trace.AutoFlush = true;

           _dbManager = new DatabaseManager();
           
           LoadKeyWordsToComboBox();

=======
        public Form1()
        {
            InitializeComponent();
>>>>>>> dc55c244936f812c0b1cf2cb540885d292c76351
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
<<<<<<< HEAD
         /*   foreach (string blockedWord in blockedWords)
=======
            foreach (string blockedWord in blockedWords)
>>>>>>> dc55c244936f812c0b1cf2cb540885d292c76351
            {
                if (currentUrl.Contains(blockedWord))
                {
                    MessageBox.Show("Access to this website is blocked.");
                    e.Cancel = true;
                    return;
                }
<<<<<<< HEAD
            }*/
            // 6- LINQ használata az URL-ek szűréséhez -lambda használat NELKUL

            var matchedWords= from word in blockedWords
                               where currentUrl.Contains(word)
                               select word;

            string firstBlockWord= matchedWords.FirstOrDefault();

            if (firstBlockWord != null)
            {
                MessageBox.Show("Access to this website is blocked. (Linq)");
                e.Cancel = true;
                return;
            }

            LogBlockedUrlAsync(currentUrl);

        }

        //3.- Kulcsszavak hozzáadása egy új Űrlapon (Form).

=======
            }
        }

        //3.- Kulcsszavak hozzáadása egy új Űrlapon (Form).
        
>>>>>>> dc55c244936f812c0b1cf2cb540885d292c76351

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
<<<<<<< HEAD
            LoadKeyWordsToComboBox();
        }
        //4.- Kulcsszólista megjelenítése egy legördülő listában (ComboBox).
        //5 Kulcsszó törlése
        private void LoadKeyWordsToComboBox()
        {
            toolStripComboKeyWords.Items.Clear();
            foreach (string word in blockedWords)
            {
                toolStripComboKeyWords.Items.Add(word);
            }

            if (toolStripComboKeyWords.Items.Count > 0)
            {
                toolStripComboKeyWords.SelectedIndex = 0;
            }
        }

        private void btnDeletedKeyWord_Click(object sender, EventArgs e)
        {
            if (toolStripComboKeyWords.SelectedItem != null)
            {
                MessageBox.Show("Please select a keyword to deleted","Attention", MessageBoxButtons.OK);
            }

            string keyword= toolStripComboKeyWords.SelectedItem.ToString();
            if (_dbManager.DeleteKeyword(keyword))
            {
                LoadKeyWordsToComboBox(); // Frissíti a ComboBox-ot
                MessageBox.Show($"A '{keyword}' kulcsszó sikeresen törölve.", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //megerosites kerese
            DialogResult result = MessageBox.Show($"Are you sure you want to delete the keyword '{keyword}'?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                blockedWords.Remove(keyword);
                LoadKeyWordsToComboBox();
            }

        }

        private void toolStripComboKeyWords_Click(object sender, EventArgs e)
        {

        }
        //7- AsyncTask használata az URL-ek szűréséhez a fajlba irasahoz a Trace osztalyon keresztul,
        //without lambda

       private async void LogBlockedUrlAsync(string url)
        {
            try
            {
                await Task.Run(delegate
                {
                    Trace.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Blocked: {url}");
                    Trace.Flush();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error logging blocked URL: {ex.Message}");
            }
        }



=======
        }
>>>>>>> dc55c244936f812c0b1cf2cb540885d292c76351
    }
}
