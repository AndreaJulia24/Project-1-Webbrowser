using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_Webbrowser
{
    public partial class AddBlockedWordsForm : Form
    {
        private readonly ICollection<string> blockedWords;
        public AddBlockedWordsForm(ICollection<string> wordsList)
        {
            InitializeComponent();
            blockedWords = wordsList ?? throw new ArgumentNullException(nameof(wordsList));
        }

        private void AddBlockedWordsForm_Load(object sender, EventArgs e)
        {
            this.Text = "Add Blocked Words";
        }

        private void AddWordButton_Click(object sender, EventArgs e)
        {
            string newKeyword = textNewKeyword.Text.Trim();
            if (!string.IsNullOrEmpty(newKeyword) && !blockedWords.Contains(newKeyword))
            {
                blockedWords.Add(newKeyword);
                MessageBox.Show($"The word '{newKeyword}' has been added to the blocked list.");
                textNewKeyword.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid, non-duplicate word.");
            }
        }

        private void SaveAndClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
