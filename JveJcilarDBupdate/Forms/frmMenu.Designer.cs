
namespace KafeAdisyon.Forms
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.pbKategori = new System.Windows.Forms.PictureBox();
            this.lstKategori = new System.Windows.Forms.ListBox();
            this.btnKategoriKaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.pbUrun = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(165, 10);
            this.txtKategoriAdi.Margin = new System.Windows.Forms.Padding(5);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(269, 32);
            this.txtKategoriAdi.TabIndex = 1;
            // 
            // pbKategori
            // 
            this.pbKategori.Location = new System.Drawing.Point(165, 56);
            this.pbKategori.Name = "pbKategori";
            this.pbKategori.Size = new System.Drawing.Size(269, 261);
            this.pbKategori.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKategori.TabIndex = 2;
            this.pbKategori.TabStop = false;
            this.pbKategori.Click += new System.EventHandler(this.pbKategori_Click);
            // 
            // lstKategori
            // 
            this.lstKategori.FormattingEnabled = true;
            this.lstKategori.ItemHeight = 25;
            this.lstKategori.Location = new System.Drawing.Point(442, 10);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(264, 579);
            this.lstKategori.TabIndex = 3;
            this.lstKategori.SelectedIndexChanged += new System.EventHandler(this.lstKategori_SelectedIndexChanged);
            // 
            // btnKategoriKaydet
            // 
            this.btnKategoriKaydet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKategoriKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriKaydet.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnKategoriKaydet.Location = new System.Drawing.Point(212, 336);
            this.btnKategoriKaydet.Name = "btnKategoriKaydet";
            this.btnKategoriKaydet.Size = new System.Drawing.Size(173, 49);
            this.btnKategoriKaydet.TabIndex = 4;
            this.btnKategoriKaydet.Text = "Kategori Kaydet";
            this.btnKategoriKaydet.UseVisualStyleBackColor = false;
            this.btnKategoriKaydet.Click += new System.EventHandler(this.btnKategoriKaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(714, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(829, 18);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(5);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(269, 32);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // pbUrun
            // 
            this.pbUrun.Location = new System.Drawing.Point(829, 110);
            this.pbUrun.Name = "pbUrun";
            this.pbUrun.Size = new System.Drawing.Size(269, 261);
            this.pbUrun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrun.TabIndex = 2;
            this.pbUrun.TabStop = false;
            this.pbUrun.Click += new System.EventHandler(this.pbUrun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(714, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fiyat";
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Location = new System.Drawing.Point(829, 66);
            this.nFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(269, 32);
            this.nFiyat.TabIndex = 5;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUrunKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunKaydet.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnUrunKaydet.Location = new System.Drawing.Point(829, 377);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(173, 49);
            this.btnUrunKaydet.TabIndex = 4;
            this.btnUrunKaydet.Text = "Ürün Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = false;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 25;
            this.lstUrunler.Location = new System.Drawing.Point(1106, 10);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(264, 579);
            this.lstUrunler.TabIndex = 3;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKategoriGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriGuncelle.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(212, 402);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(173, 49);
            this.btnKategoriGuncelle.TabIndex = 7;
            this.btnKategoriGuncelle.Text = "Kategori Güncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnKategoriGuncelle.Click += new System.EventHandler(this.btnKategoriGuncelle_Click);
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUrunGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunGuncelle.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(829, 444);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(173, 49);
            this.btnUrunGuncelle.TabIndex = 8;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUrunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUrunSil.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnUrunSil.Location = new System.Drawing.Point(829, 513);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(173, 49);
            this.btnUrunSil.TabIndex = 9;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKategoriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKategoriSil.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnKategoriSil.Location = new System.Drawing.Point(212, 470);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(173, 49);
            this.btnKategoriSil.TabIndex = 10;
            this.btnKategoriSil.Text = "Kategori Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JveJcilarDBupdate.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1370, 617);
            this.Controls.Add(this.btnKategoriSil);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnKategoriGuncelle);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.btnUrunKaydet);
            this.Controls.Add(this.btnKategoriKaydet);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.lstKategori);
            this.Controls.Add(this.pbUrun);
            this.Controls.Add(this.pbKategori);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMenu";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.PictureBox pbKategori;
        private System.Windows.Forms.ListBox lstKategori;
        private System.Windows.Forms.Button btnKategoriKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.PictureBox pbUrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnKategoriGuncelle;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnKategoriSil;
    }
}