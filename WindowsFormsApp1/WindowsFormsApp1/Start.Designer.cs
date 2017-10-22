using System;

namespace WindowsFormsApplication8
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
            this.kategoriButton = new System.Windows.Forms.Button();
            this.feedsButton = new System.Windows.Forms.Button();
            this.chooseButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // kategoriButton
            // 
            this.kategoriButton.Location = new System.Drawing.Point(354, 56);
            this.kategoriButton.Name = "kategoriButton";
            this.kategoriButton.Size = new System.Drawing.Size(75, 23);
            this.kategoriButton.TabIndex = 0;
            this.kategoriButton.Text = "Kategorier";
            this.kategoriButton.UseVisualStyleBackColor = true;
            this.kategoriButton.Click += new System.EventHandler(this.kategoriButton_Click);
            // 
            // feedsButton
            // 
            this.feedsButton.Location = new System.Drawing.Point(354, 96);
            this.feedsButton.Name = "feedsButton";
            this.feedsButton.Size = new System.Drawing.Size(75, 23);
            this.feedsButton.TabIndex = 1;
            this.feedsButton.Text = "Feeds";
            this.feedsButton.UseVisualStyleBackColor = true;
            this.feedsButton.Click += new System.EventHandler(this.feedsButton_Click);
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(163, 105);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(75, 26);
            this.chooseButton.TabIndex = 2;
            this.chooseButton.Text = "Välj";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 248);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chooseButton);
            this.Controls.Add(this.feedsButton);
            this.Controls.Add(this.kategoriButton);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        private void kategoriButton_Click(object sender, EventArgs e)
        {
            Kategorier k = new Kategorier();
            k.Show();
        }

        #endregion

        private System.Windows.Forms.Button kategoriButton;
        private System.Windows.Forms.Button feedsButton;
        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

