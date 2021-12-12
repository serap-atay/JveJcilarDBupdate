
namespace JavaVeJavacilar.Forms
{
    partial class frmKatlar
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
            this.txtKatAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.lstKatlar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMasaSayisi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKafeBilgisi = new System.Windows.Forms.ComboBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kat Adı";
            // 
            // txtKatAdi
            // 
            this.txtKatAdi.Location = new System.Drawing.Point(201, 148);
            this.txtKatAdi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKatAdi.Name = "txtKatAdi";
            this.txtKatAdi.Size = new System.Drawing.Size(304, 26);
            this.txtKatAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(98, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(49, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sıra ";
            // 
            // txtSira
            // 
            this.txtSira.Location = new System.Drawing.Point(201, 211);
            this.txtSira.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(304, 26);
            this.txtSira.TabIndex = 3;
            // 
            // lstKatlar
            // 
            this.lstKatlar.BackColor = System.Drawing.Color.Black;
            this.lstKatlar.ForeColor = System.Drawing.Color.Goldenrod;
            this.lstKatlar.FormattingEnabled = true;
            this.lstKatlar.ItemHeight = 20;
            this.lstKatlar.Location = new System.Drawing.Point(539, 38);
            this.lstKatlar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstKatlar.Name = "lstKatlar";
            this.lstKatlar.Size = new System.Drawing.Size(411, 404);
            this.lstKatlar.TabIndex = 4;
            this.lstKatlar.SelectedIndexChanged += new System.EventHandler(this.lstKatlar_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(14, 445);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 54);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(186, 445);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(151, 54);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(360, 446);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 53);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(201, 272);
            this.txtKod.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(304, 26);
            this.txtKod.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(102, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kod";
            // 
            // txtMasaSayisi
            // 
            this.txtMasaSayisi.Location = new System.Drawing.Point(201, 337);
            this.txtMasaSayisi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMasaSayisi.Name = "txtMasaSayisi";
            this.txtMasaSayisi.Size = new System.Drawing.Size(304, 26);
            this.txtMasaSayisi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(46, 340);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Masa Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4);
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kafe Bilgisi";
            // 
            // cmbKafeBilgisi
            // 
            this.cmbKafeBilgisi.FormattingEnabled = true;
            this.cmbKafeBilgisi.Location = new System.Drawing.Point(203, 396);
            this.cmbKafeBilgisi.Name = "cmbKafeBilgisi";
            this.cmbKafeBilgisi.Size = new System.Drawing.Size(302, 28);
            this.cmbKafeBilgisi.TabIndex = 14;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Black;
            this.btnTemizle.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnTemizle.Location = new System.Drawing.Point(413, 70);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(92, 53);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmKatlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JveJcilarDBupdate.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1066, 545);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.cmbKafeBilgisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMasaSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstKatlar);
            this.Controls.Add(this.txtSira);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKatAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmKatlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katlar";
            this.Load += new System.EventHandler(this.frmKatlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKatAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.ListBox lstKatlar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMasaSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKafeBilgisi;
        private System.Windows.Forms.Button btnTemizle;
    }
}