namespace WindowsFormsApplication8
{
    partial class Kategorier
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
            this.KategoriLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nyKatLbl = new System.Windows.Forms.Label();
            this.LaggTillBtn = new System.Windows.Forms.Button();
            this.TaBortKatLbl = new System.Windows.Forms.Label();
            this.taBortBtn = new System.Windows.Forms.Button();
            this.valjKategoriCb = new System.Windows.Forms.ComboBox();
            this.visaFeedsLbl = new System.Windows.Forms.Label();
            this.valjKategoriLbl = new System.Windows.Forms.Label();
            this.seFeedsLbl = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.taBortKatCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // KategoriLbl
            // 
            this.KategoriLbl.AutoSize = true;
            this.KategoriLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KategoriLbl.Location = new System.Drawing.Point(23, 22);
            this.KategoriLbl.Name = "KategoriLbl";
            this.KategoriLbl.Size = new System.Drawing.Size(70, 16);
            this.KategoriLbl.TabIndex = 0;
            this.KategoriLbl.Text = "Kategorier";
            this.KategoriLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 1;
            // 
            // nyKatLbl
            // 
            this.nyKatLbl.AutoSize = true;
            this.nyKatLbl.Location = new System.Drawing.Point(23, 64);
            this.nyKatLbl.Name = "nyKatLbl";
            this.nyKatLbl.Size = new System.Drawing.Size(113, 13);
            this.nyKatLbl.TabIndex = 2;
            this.nyKatLbl.Text = "Lägg till en ny kategori";
            // 
            // LaggTillBtn
            // 
            this.LaggTillBtn.Location = new System.Drawing.Point(224, 80);
            this.LaggTillBtn.Name = "LaggTillBtn";
            this.LaggTillBtn.Size = new System.Drawing.Size(75, 23);
            this.LaggTillBtn.TabIndex = 3;
            this.LaggTillBtn.Text = "Lägg till";
            this.LaggTillBtn.UseVisualStyleBackColor = true;
            // 
            // TaBortKatLbl
            // 
            this.TaBortKatLbl.AutoSize = true;
            this.TaBortKatLbl.Location = new System.Drawing.Point(23, 121);
            this.TaBortKatLbl.Name = "TaBortKatLbl";
            this.TaBortKatLbl.Size = new System.Drawing.Size(128, 13);
            this.TaBortKatLbl.TabIndex = 4;
            this.TaBortKatLbl.Text = "Välj en kategori att ta bort";
            // 
            // taBortBtn
            // 
            this.taBortBtn.Location = new System.Drawing.Point(224, 134);
            this.taBortBtn.Name = "taBortBtn";
            this.taBortBtn.Size = new System.Drawing.Size(75, 23);
            this.taBortBtn.TabIndex = 6;
            this.taBortBtn.Text = "Ta bort";
            this.taBortBtn.UseVisualStyleBackColor = true;
            // 
            // valjKategoriCb
            // 
            this.valjKategoriCb.FormattingEnabled = true;
            this.valjKategoriCb.Location = new System.Drawing.Point(29, 230);
            this.valjKategoriCb.Name = "valjKategoriCb";
            this.valjKategoriCb.Size = new System.Drawing.Size(121, 21);
            this.valjKategoriCb.TabIndex = 7;
            // 
            // visaFeedsLbl
            // 
            this.visaFeedsLbl.AutoSize = true;
            this.visaFeedsLbl.Location = new System.Drawing.Point(26, 191);
            this.visaFeedsLbl.Name = "visaFeedsLbl";
            this.visaFeedsLbl.Size = new System.Drawing.Size(181, 13);
            this.visaFeedsLbl.TabIndex = 8;
            this.visaFeedsLbl.Text = "Visa alla feeds till en speciell kategori";
            // 
            // valjKategoriLbl
            // 
            this.valjKategoriLbl.AutoSize = true;
            this.valjKategoriLbl.Location = new System.Drawing.Point(29, 211);
            this.valjKategoriLbl.Name = "valjKategoriLbl";
            this.valjKategoriLbl.Size = new System.Drawing.Size(65, 13);
            this.valjKategoriLbl.TabIndex = 9;
            this.valjKategoriLbl.Text = "Välj kategori";
            // 
            // seFeedsLbl
            // 
            this.seFeedsLbl.AutoSize = true;
            this.seFeedsLbl.Location = new System.Drawing.Point(221, 211);
            this.seFeedsLbl.Name = "seFeedsLbl";
            this.seFeedsLbl.Size = new System.Drawing.Size(119, 13);
            this.seFeedsLbl.TabIndex = 10;
            this.seFeedsLbl.Text = "Se alla tillhörande feeds";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(224, 227);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 11;
            // 
            // taBortKatCb
            // 
            this.taBortKatCb.FormattingEnabled = true;
            this.taBortKatCb.Location = new System.Drawing.Point(29, 135);
            this.taBortKatCb.Name = "taBortKatCb";
            this.taBortKatCb.Size = new System.Drawing.Size(121, 21);
            this.taBortKatCb.TabIndex = 12;
            // 
            // Kategorier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 357);
            this.Controls.Add(this.taBortKatCb);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.seFeedsLbl);
            this.Controls.Add(this.valjKategoriLbl);
            this.Controls.Add(this.visaFeedsLbl);
            this.Controls.Add(this.valjKategoriCb);
            this.Controls.Add(this.taBortBtn);
            this.Controls.Add(this.TaBortKatLbl);
            this.Controls.Add(this.LaggTillBtn);
            this.Controls.Add(this.nyKatLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KategoriLbl);
            this.Name = "Kategorier";
            this.Text = "Kategorier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KategoriLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nyKatLbl;
        private System.Windows.Forms.Button LaggTillBtn;
        private System.Windows.Forms.Label TaBortKatLbl;
        private System.Windows.Forms.Button taBortBtn;
        private System.Windows.Forms.ComboBox valjKategoriCb;
        private System.Windows.Forms.Label visaFeedsLbl;
        private System.Windows.Forms.Label valjKategoriLbl;
        private System.Windows.Forms.Label seFeedsLbl;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox taBortKatCb;
    }
}