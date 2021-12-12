
namespace JveJcilarDBupdate.Forms
{
    partial class frmKafeBilgi
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtKafeAd = new System.Windows.Forms.TextBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lstKafeBilgi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(228, 334);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 34);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtKafeAd
            // 
            this.txtKafeAd.Location = new System.Drawing.Point(228, 40);
            this.txtKafeAd.Name = "txtKafeAd";
            this.txtKafeAd.Size = new System.Drawing.Size(181, 23);
            this.txtKafeAd.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbLogo.Location = new System.Drawing.Point(228, 97);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(338, 203);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // lstKafeBilgi
            // 
            this.lstKafeBilgi.FormattingEnabled = true;
            this.lstKafeBilgi.ItemHeight = 15;
            this.lstKafeBilgi.Location = new System.Drawing.Point(688, 23);
            this.lstKafeBilgi.Name = "lstKafeBilgi";
            this.lstKafeBilgi.Size = new System.Drawing.Size(169, 244);
            this.lstKafeBilgi.TabIndex = 3;
            this.lstKafeBilgi.SelectedIndexChanged += new System.EventHandler(this.lstKafeBilgi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "İşletme Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "İşletme Logo:";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(478, 334);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(88, 34);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(353, 334);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(89, 34);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmKafeBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JveJcilarDBupdate.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKafeBilgi);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.txtKafeAd);
            this.Controls.Add(this.btnEkle);
            this.Name = "frmKafeBilgi";
            this.Text = "frmKafeBilgi";
            this.Load += new System.EventHandler(this.frmKafeBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKafeAd;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ListBox lstKafeBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}