using ClassLibrary1.Entities;
using Data;
using System;
using System.Collections.Generic;

namespace WindowsFormsApplication8
{
    partial class Feeds
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
            this.LaggTillUrlLbl = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.TaBortUrllbl = new System.Windows.Forms.Label();
            this.ValjKategorilbl = new System.Windows.Forms.Label();
            this.kategoriCb = new System.Windows.Forms.ComboBox();
            this.andraUpgifterlbl = new System.Windows.Forms.Label();
            this.lyssnadePodslbl = new System.Windows.Forms.Label();
            this.sparaBtn = new System.Windows.Forms.Button();
            this.gammalUrlLbl = new System.Windows.Forms.Label();
            this.nyUrlLbl = new System.Windows.Forms.Label();
            this.nyUrlTb = new System.Windows.Forms.TextBox();
            this.RaderaUrl = new System.Windows.Forms.Button();
            this.taBortUrlCb = new System.Windows.Forms.ComboBox();
            this.sparaNyUrlBtn = new System.Windows.Forms.Button();
            this.gammalUrlCb = new System.Windows.Forms.ComboBox();
            this.gammalKatLbl = new System.Windows.Forms.Label();
            this.nyKatLbl = new System.Windows.Forms.Label();
            this.gammalKatCb = new System.Windows.Forms.ComboBox();
            this.uppdateringLbl = new System.Windows.Forms.Label();
            this.uppdatIntervallCb = new System.Windows.Forms.ComboBox();
            this.nyKatCb = new System.Windows.Forms.ComboBox();
            this.gammalUppdatCb = new System.Windows.Forms.ComboBox();
            this.nyUppdateringsintervallCb = new System.Windows.Forms.ComboBox();
            this.TidigUppdateringLbl = new System.Windows.Forms.Label();
            this.nyUppdateringsintLbl = new System.Windows.Forms.Label();
            this.laggTillNyUrlLbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.KategoriLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TaBortKatLbl = new System.Windows.Forms.Label();
            this.visaFeedsLbl = new System.Windows.Forms.Label();
            this.seFeedsLbl = new System.Windows.Forms.Label();
            this.taBortKatCb = new System.Windows.Forms.ComboBox();
            this.feedsCb = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.laggTillNyKatBtn = new System.Windows.Forms.Button();
            this.taBortKatBtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.ListPodcasts = new System.Windows.Forms.ListBox();
            this.ListCategories = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LaggTillUrlLbl
            // 
            this.LaggTillUrlLbl.AutoSize = true;
            this.LaggTillUrlLbl.Location = new System.Drawing.Point(149, 37);
            this.LaggTillUrlLbl.Name = "LaggTillUrlLbl";
            this.LaggTillUrlLbl.Size = new System.Drawing.Size(57, 13);
            this.LaggTillUrlLbl.TabIndex = 0;
            this.LaggTillUrlLbl.Text = "Lägg til Url";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(152, 55);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(125, 20);
            this.urlTextBox.TabIndex = 1;
            // 
            // TaBortUrllbl
            // 
            this.TaBortUrllbl.AutoSize = true;
            this.TaBortUrllbl.Location = new System.Drawing.Point(12, 306);
            this.TaBortUrllbl.Name = "TaBortUrllbl";
            this.TaBortUrllbl.Size = new System.Drawing.Size(88, 13);
            this.TaBortUrllbl.TabIndex = 2;
            this.TaBortUrllbl.Text = "Välj Url att ta bort";
            // 
            // ValjKategorilbl
            // 
            this.ValjKategorilbl.AutoSize = true;
            this.ValjKategorilbl.Location = new System.Drawing.Point(12, 37);
            this.ValjKategorilbl.Name = "ValjKategorilbl";
            this.ValjKategorilbl.Size = new System.Drawing.Size(65, 13);
            this.ValjKategorilbl.TabIndex = 4;
            this.ValjKategorilbl.Text = "Välj kategori";
            // 
            // kategoriCb
            // 
            this.kategoriCb.FormattingEnabled = true;
            this.kategoriCb.Location = new System.Drawing.Point(12, 53);
            this.kategoriCb.Name = "kategoriCb";
            this.kategoriCb.Size = new System.Drawing.Size(121, 21);
            this.kategoriCb.TabIndex = 5;
            // 
            // andraUpgifterlbl
            // 
            this.andraUpgifterlbl.AutoSize = true;
            this.andraUpgifterlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.andraUpgifterlbl.Location = new System.Drawing.Point(9, 109);
            this.andraUpgifterlbl.Name = "andraUpgifterlbl";
            this.andraUpgifterlbl.Size = new System.Drawing.Size(204, 16);
            this.andraUpgifterlbl.TabIndex = 6;
            this.andraUpgifterlbl.Text = "Ändra uppgifter för en specifik Url";
            // 
            // lyssnadePodslbl
            // 
            this.lyssnadePodslbl.AutoSize = true;
            this.lyssnadePodslbl.Location = new System.Drawing.Point(696, 37);
            this.lyssnadePodslbl.Name = "lyssnadePodslbl";
            this.lyssnadePodslbl.Size = new System.Drawing.Size(113, 13);
            this.lyssnadePodslbl.TabIndex = 9;
            this.lyssnadePodslbl.Text = "Nyligen lyssnade Pods";
            // 
            // sparaBtn
            // 
            this.sparaBtn.Location = new System.Drawing.Point(441, 54);
            this.sparaBtn.Name = "sparaBtn";
            this.sparaBtn.Size = new System.Drawing.Size(75, 23);
            this.sparaBtn.TabIndex = 10;
            this.sparaBtn.Text = "Spara";
            this.sparaBtn.UseVisualStyleBackColor = true;
            this.sparaBtn.Click += new System.EventHandler(this.sparaBtn_Click);
            // 
            // gammalUrlLbl
            // 
            this.gammalUrlLbl.AutoSize = true;
            this.gammalUrlLbl.Location = new System.Drawing.Point(12, 134);
            this.gammalUrlLbl.Name = "gammalUrlLbl";
            this.gammalUrlLbl.Size = new System.Drawing.Size(61, 13);
            this.gammalUrlLbl.TabIndex = 11;
            this.gammalUrlLbl.Text = "Gammal Url";
            // 
            // nyUrlLbl
            // 
            this.nyUrlLbl.AutoSize = true;
            this.nyUrlLbl.Location = new System.Drawing.Point(149, 134);
            this.nyUrlLbl.Name = "nyUrlLbl";
            this.nyUrlLbl.Size = new System.Drawing.Size(36, 13);
            this.nyUrlLbl.TabIndex = 12;
            this.nyUrlLbl.Text = "Ny Url";
            // 
            // nyUrlTb
            // 
            this.nyUrlTb.Location = new System.Drawing.Point(152, 150);
            this.nyUrlTb.Name = "nyUrlTb";
            this.nyUrlTb.Size = new System.Drawing.Size(125, 20);
            this.nyUrlTb.TabIndex = 13;
            // 
            // RaderaUrl
            // 
            this.RaderaUrl.Location = new System.Drawing.Point(156, 320);
            this.RaderaUrl.Name = "RaderaUrl";
            this.RaderaUrl.Size = new System.Drawing.Size(75, 23);
            this.RaderaUrl.TabIndex = 14;
            this.RaderaUrl.Text = "Radera";
            this.RaderaUrl.UseVisualStyleBackColor = true;
            // 
            // taBortUrlCb
            // 
            this.taBortUrlCb.FormattingEnabled = true;
            this.taBortUrlCb.Location = new System.Drawing.Point(15, 322);
            this.taBortUrlCb.Name = "taBortUrlCb";
            this.taBortUrlCb.Size = new System.Drawing.Size(121, 21);
            this.taBortUrlCb.TabIndex = 15;
            // 
            // sparaNyUrlBtn
            // 
            this.sparaNyUrlBtn.Location = new System.Drawing.Point(299, 256);
            this.sparaNyUrlBtn.Name = "sparaNyUrlBtn";
            this.sparaNyUrlBtn.Size = new System.Drawing.Size(75, 23);
            this.sparaNyUrlBtn.TabIndex = 16;
            this.sparaNyUrlBtn.Text = "Spara";
            this.sparaNyUrlBtn.UseVisualStyleBackColor = true;
            // 
            // gammalUrlCb
            // 
            this.gammalUrlCb.FormattingEnabled = true;
            this.gammalUrlCb.Location = new System.Drawing.Point(15, 150);
            this.gammalUrlCb.Name = "gammalUrlCb";
            this.gammalUrlCb.Size = new System.Drawing.Size(121, 21);
            this.gammalUrlCb.TabIndex = 17;
            // 
            // gammalKatLbl
            // 
            this.gammalKatLbl.AutoSize = true;
            this.gammalKatLbl.Location = new System.Drawing.Point(12, 186);
            this.gammalKatLbl.Name = "gammalKatLbl";
            this.gammalKatLbl.Size = new System.Drawing.Size(86, 13);
            this.gammalKatLbl.TabIndex = 20;
            this.gammalKatLbl.Text = "Gammal kategori";
            // 
            // nyKatLbl
            // 
            this.nyKatLbl.AutoSize = true;
            this.nyKatLbl.Location = new System.Drawing.Point(153, 186);
            this.nyKatLbl.Name = "nyKatLbl";
            this.nyKatLbl.Size = new System.Drawing.Size(61, 13);
            this.nyKatLbl.TabIndex = 21;
            this.nyKatLbl.Text = "Ny kategori";
            // 
            // gammalKatCb
            // 
            this.gammalKatCb.FormattingEnabled = true;
            this.gammalKatCb.Location = new System.Drawing.Point(15, 202);
            this.gammalKatCb.Name = "gammalKatCb";
            this.gammalKatCb.Size = new System.Drawing.Size(121, 21);
            this.gammalKatCb.TabIndex = 22;
            // 
            // uppdateringLbl
            // 
            this.uppdateringLbl.AutoSize = true;
            this.uppdateringLbl.Location = new System.Drawing.Point(296, 37);
            this.uppdateringLbl.Name = "uppdateringLbl";
            this.uppdateringLbl.Size = new System.Drawing.Size(106, 13);
            this.uppdateringLbl.TabIndex = 23;
            this.uppdateringLbl.Text = "Uppdateringsintervall";
            // 
            // uppdatIntervallCb
            // 
            this.uppdatIntervallCb.FormattingEnabled = true;
            this.uppdatIntervallCb.Location = new System.Drawing.Point(299, 54);
            this.uppdatIntervallCb.Name = "uppdatIntervallCb";
            this.uppdatIntervallCb.Size = new System.Drawing.Size(121, 21);
            this.uppdatIntervallCb.TabIndex = 24;
            // 
            // nyKatCb
            // 
            this.nyKatCb.FormattingEnabled = true;
            this.nyKatCb.Location = new System.Drawing.Point(152, 202);
            this.nyKatCb.Name = "nyKatCb";
            this.nyKatCb.Size = new System.Drawing.Size(121, 21);
            this.nyKatCb.TabIndex = 25;
            // 
            // gammalUppdatCb
            // 
            this.gammalUppdatCb.FormattingEnabled = true;
            this.gammalUppdatCb.Location = new System.Drawing.Point(15, 258);
            this.gammalUppdatCb.Name = "gammalUppdatCb";
            this.gammalUppdatCb.Size = new System.Drawing.Size(121, 21);
            this.gammalUppdatCb.TabIndex = 26;
            // 
            // nyUppdateringsintervallCb
            // 
            this.nyUppdateringsintervallCb.FormattingEnabled = true;
            this.nyUppdateringsintervallCb.Location = new System.Drawing.Point(152, 258);
            this.nyUppdateringsintervallCb.Name = "nyUppdateringsintervallCb";
            this.nyUppdateringsintervallCb.Size = new System.Drawing.Size(121, 21);
            this.nyUppdateringsintervallCb.TabIndex = 27;
            // 
            // TidigUppdateringLbl
            // 
            this.TidigUppdateringLbl.AutoSize = true;
            this.TidigUppdateringLbl.Location = new System.Drawing.Point(12, 242);
            this.TidigUppdateringLbl.Name = "TidigUppdateringLbl";
            this.TidigUppdateringLbl.Size = new System.Drawing.Size(145, 13);
            this.TidigUppdateringLbl.TabIndex = 28;
            this.TidigUppdateringLbl.Text = "Tidigare uppdateringsintervall";
            // 
            // nyUppdateringsintLbl
            // 
            this.nyUppdateringsintLbl.AutoSize = true;
            this.nyUppdateringsintLbl.Location = new System.Drawing.Point(153, 242);
            this.nyUppdateringsintLbl.Name = "nyUppdateringsintLbl";
            this.nyUppdateringsintLbl.Size = new System.Drawing.Size(120, 13);
            this.nyUppdateringsintLbl.TabIndex = 29;
            this.nyUppdateringsintLbl.Text = "Ny uppdateringsintervall";
            // 
            // laggTillNyUrlLbl
            // 
            this.laggTillNyUrlLbl.AutoSize = true;
            this.laggTillNyUrlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laggTillNyUrlLbl.Location = new System.Drawing.Point(10, 9);
            this.laggTillNyUrlLbl.Name = "laggTillNyUrlLbl";
            this.laggTillNyUrlLbl.Size = new System.Drawing.Size(109, 16);
            this.laggTillNyUrlLbl.TabIndex = 30;
            this.laggTillNyUrlLbl.Text = "Lägg till en ny Url";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(699, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 31;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // KategoriLbl
            // 
            this.KategoriLbl.AutoSize = true;
            this.KategoriLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KategoriLbl.Location = new System.Drawing.Point(438, 109);
            this.KategoriLbl.Name = "KategoriLbl";
            this.KategoriLbl.Size = new System.Drawing.Size(70, 16);
            this.KategoriLbl.TabIndex = 32;
            this.KategoriLbl.Text = "Kategorier";
            this.KategoriLbl.Click += new System.EventHandler(this.KategoriLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Lägg till en ny kategori";
            // 
            // TaBortKatLbl
            // 
            this.TaBortKatLbl.AutoSize = true;
            this.TaBortKatLbl.Location = new System.Drawing.Point(438, 186);
            this.TaBortKatLbl.Name = "TaBortKatLbl";
            this.TaBortKatLbl.Size = new System.Drawing.Size(128, 13);
            this.TaBortKatLbl.TabIndex = 34;
            this.TaBortKatLbl.Text = "Välj en kategori att ta bort";
            // 
            // visaFeedsLbl
            // 
            this.visaFeedsLbl.AutoSize = true;
            this.visaFeedsLbl.Location = new System.Drawing.Point(438, 306);
            this.visaFeedsLbl.Name = "visaFeedsLbl";
            this.visaFeedsLbl.Size = new System.Drawing.Size(181, 13);
            this.visaFeedsLbl.TabIndex = 35;
            this.visaFeedsLbl.Text = "Visa alla feeds till en speciell kategori";
            this.visaFeedsLbl.Click += new System.EventHandler(this.visaFeedsLbl_Click);
            // 
            // seFeedsLbl
            // 
            this.seFeedsLbl.AutoSize = true;
            this.seFeedsLbl.Location = new System.Drawing.Point(735, 350);
            this.seFeedsLbl.Name = "seFeedsLbl";
            this.seFeedsLbl.Size = new System.Drawing.Size(119, 13);
            this.seFeedsLbl.TabIndex = 36;
            this.seFeedsLbl.Text = "Se alla tillhörande feeds";
            // 
            // taBortKatCb
            // 
            this.taBortKatCb.FormattingEnabled = true;
            this.taBortKatCb.Location = new System.Drawing.Point(441, 202);
            this.taBortKatCb.Name = "taBortKatCb";
            this.taBortKatCb.Size = new System.Drawing.Size(121, 21);
            this.taBortKatCb.TabIndex = 37;
            // 
            // feedsCb
            // 
            this.feedsCb.FormattingEnabled = true;
            this.feedsCb.Location = new System.Drawing.Point(441, 322);
            this.feedsCb.Name = "feedsCb";
            this.feedsCb.Size = new System.Drawing.Size(121, 21);
            this.feedsCb.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 39;
            // 
            // laggTillNyKatBtn
            // 
            this.laggTillNyKatBtn.Location = new System.Drawing.Point(587, 147);
            this.laggTillNyKatBtn.Name = "laggTillNyKatBtn";
            this.laggTillNyKatBtn.Size = new System.Drawing.Size(75, 23);
            this.laggTillNyKatBtn.TabIndex = 40;
            this.laggTillNyKatBtn.Text = "Lägg till ";
            this.laggTillNyKatBtn.UseVisualStyleBackColor = true;
            // 
            // taBortKatBtn
            // 
            this.taBortKatBtn.Location = new System.Drawing.Point(587, 199);
            this.taBortKatBtn.Name = "taBortKatBtn";
            this.taBortKatBtn.Size = new System.Drawing.Size(75, 23);
            this.taBortKatBtn.TabIndex = 41;
            this.taBortKatBtn.Text = "Ta bort";
            this.taBortKatBtn.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(738, 375);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 42;
            // 
            // ListPodcasts
            // 
            this.ListPodcasts.FormattingEnabled = true;
            this.ListPodcasts.Location = new System.Drawing.Point(587, 375);
            this.ListPodcasts.Name = "ListPodcasts";
            this.ListPodcasts.Size = new System.Drawing.Size(120, 95);
            this.ListPodcasts.TabIndex = 43;
            // 
            // ListCategories
            // 
            this.ListCategories.FormattingEnabled = true;
            this.ListCategories.Location = new System.Drawing.Point(441, 375);
            this.ListCategories.Name = "ListCategories";
            this.ListCategories.Size = new System.Drawing.Size(120, 95);
            this.ListCategories.TabIndex = 44;
            this.ListCategories.SelectedIndexChanged += new System.EventHandler(this.ListCategories_SelectedIndexChanged);
            // 
            // Feeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 482);
            this.Controls.Add(this.ListCategories);
            this.Controls.Add(this.ListPodcasts);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.taBortKatBtn);
            this.Controls.Add(this.laggTillNyKatBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.feedsCb);
            this.Controls.Add(this.taBortKatCb);
            this.Controls.Add(this.seFeedsLbl);
            this.Controls.Add(this.visaFeedsLbl);
            this.Controls.Add(this.TaBortKatLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KategoriLbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.laggTillNyUrlLbl);
            this.Controls.Add(this.nyUppdateringsintLbl);
            this.Controls.Add(this.TidigUppdateringLbl);
            this.Controls.Add(this.nyUppdateringsintervallCb);
            this.Controls.Add(this.gammalUppdatCb);
            this.Controls.Add(this.nyKatCb);
            this.Controls.Add(this.uppdatIntervallCb);
            this.Controls.Add(this.uppdateringLbl);
            this.Controls.Add(this.gammalKatCb);
            this.Controls.Add(this.nyKatLbl);
            this.Controls.Add(this.gammalKatLbl);
            this.Controls.Add(this.gammalUrlCb);
            this.Controls.Add(this.sparaNyUrlBtn);
            this.Controls.Add(this.taBortUrlCb);
            this.Controls.Add(this.RaderaUrl);
            this.Controls.Add(this.nyUrlTb);
            this.Controls.Add(this.nyUrlLbl);
            this.Controls.Add(this.gammalUrlLbl);
            this.Controls.Add(this.sparaBtn);
            this.Controls.Add(this.lyssnadePodslbl);
            this.Controls.Add(this.andraUpgifterlbl);
            this.Controls.Add(this.kategoriCb);
            this.Controls.Add(this.ValjKategorilbl);
            this.Controls.Add(this.TaBortUrllbl);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.LaggTillUrlLbl);
            this.Name = "Feeds";
            this.Text = "Feeds";
            this.Load += new System.EventHandler(this.Feeds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LaggTillUrlLbl;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label TaBortUrllbl;
        private System.Windows.Forms.Label ValjKategorilbl;
        private System.Windows.Forms.ComboBox kategoriCb;
        private System.Windows.Forms.Label andraUpgifterlbl;
        private System.Windows.Forms.Label lyssnadePodslbl;
        private System.Windows.Forms.Button sparaBtn;
        private System.Windows.Forms.Label gammalUrlLbl;
        private System.Windows.Forms.Label nyUrlLbl;
        private System.Windows.Forms.TextBox nyUrlTb;
        private System.Windows.Forms.Button RaderaUrl;
        private System.Windows.Forms.ComboBox taBortUrlCb;
        private System.Windows.Forms.Button sparaNyUrlBtn;
        private System.Windows.Forms.ComboBox gammalUrlCb;
        private System.Windows.Forms.Label gammalKatLbl;
        private System.Windows.Forms.Label nyKatLbl;
        private System.Windows.Forms.ComboBox gammalKatCb;
        private System.Windows.Forms.Label uppdateringLbl;
        private System.Windows.Forms.ComboBox uppdatIntervallCb;
        private System.Windows.Forms.ComboBox nyKatCb;
        private System.Windows.Forms.ComboBox gammalUppdatCb;
        private System.Windows.Forms.ComboBox nyUppdateringsintervallCb;
        private System.Windows.Forms.Label TidigUppdateringLbl;
        private System.Windows.Forms.Label nyUppdateringsintLbl;
        private System.Windows.Forms.Label laggTillNyUrlLbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label KategoriLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TaBortKatLbl;
        private System.Windows.Forms.Label visaFeedsLbl;
        private System.Windows.Forms.Label seFeedsLbl;
        private System.Windows.Forms.ComboBox taBortKatCb;
        private System.Windows.Forms.ComboBox feedsCb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button laggTillNyKatBtn;
        private System.Windows.Forms.Button taBortKatBtn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox ListPodcasts;
        private System.Windows.Forms.ListBox ListCategories;

        public EventHandler urlTextBox_TextChanged { get; private set; }
    }
}