namespace Project_1_Webbrowser
{
    partial class AddBlockedWordsForm
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
            this.textNewKeyword = new System.Windows.Forms.TextBox();
            this.AddWordButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveAndClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNewKeyword
            // 
            this.textNewKeyword.Location = new System.Drawing.Point(104, 31);
            this.textNewKeyword.Name = "textNewKeyword";
            this.textNewKeyword.Size = new System.Drawing.Size(132, 20);
            this.textNewKeyword.TabIndex = 0;
            // 
            // AddWordButton
            // 
            this.AddWordButton.Location = new System.Drawing.Point(104, 69);
            this.AddWordButton.Name = "AddWordButton";
            this.AddWordButton.Size = new System.Drawing.Size(97, 23);
            this.AddWordButton.TabIndex = 1;
            this.AddWordButton.Text = "AddWord";
            this.AddWordButton.UseVisualStyleBackColor = true;
            this.AddWordButton.Click += new System.EventHandler(this.AddWordButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New keyword:";
            // 
            // SaveAndClose
            // 
            this.SaveAndClose.Location = new System.Drawing.Point(104, 115);
            this.SaveAndClose.Name = "SaveAndClose";
            this.SaveAndClose.Size = new System.Drawing.Size(132, 22);
            this.SaveAndClose.TabIndex = 3;
            this.SaveAndClose.Text = "Save and Close";
            this.SaveAndClose.UseVisualStyleBackColor = true;
            this.SaveAndClose.Click += new System.EventHandler(this.SaveAndClose_Click);
            // 
            // AddBlockedWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveAndClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddWordButton);
            this.Controls.Add(this.textNewKeyword);
            this.Name = "AddBlockedWordsForm";
            this.Text = "AddBlockedWordsForm";
            this.Load += new System.EventHandler(this.AddBlockedWordsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNewKeyword;
        private System.Windows.Forms.Button AddWordButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveAndClose;
    }
}