namespace WindowsFormsApp1
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
            this.Podlist = new System.Windows.Forms.ListBox();
            this.showPods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Podlist
            // 
            this.Podlist.FormattingEnabled = true;
            this.Podlist.Location = new System.Drawing.Point(70, 56);
            this.Podlist.Name = "Podlist";
            this.Podlist.Size = new System.Drawing.Size(241, 290);
            this.Podlist.TabIndex = 0;
            this.Podlist.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // showPods
            // 
            this.showPods.Location = new System.Drawing.Point(374, 56);
            this.showPods.Name = "showPods";
            this.showPods.Size = new System.Drawing.Size(227, 182);
            this.showPods.TabIndex = 1;
            this.showPods.Text = "button1";
            this.showPods.UseVisualStyleBackColor = true;
            this.showPods.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 429);
            this.Controls.Add(this.showPods);
            this.Controls.Add(this.Podlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Podlist;
        private System.Windows.Forms.Button showPods;
    }
}

