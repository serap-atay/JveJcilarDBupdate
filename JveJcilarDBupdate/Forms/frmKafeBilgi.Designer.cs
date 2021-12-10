
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
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(100, 258);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 34);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtKafeAd
            // 
            this.txtKafeAd.Location = new System.Drawing.Point(54, 192);
            this.txtKafeAd.Name = "txtKafeAd";
            this.txtKafeAd.Size = new System.Drawing.Size(181, 23);
            this.txtKafeAd.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbLogo.Location = new System.Drawing.Point(54, 26);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(181, 127);
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lstKafeBilgi
            // 
            this.lstKafeBilgi.FormattingEnabled = true;
            this.lstKafeBilgi.ItemHeight = 15;
            this.lstKafeBilgi.Location = new System.Drawing.Point(343, 26);
            this.lstKafeBilgi.Name = "lstKafeBilgi";
            this.lstKafeBilgi.Size = new System.Drawing.Size(143, 124);
            this.lstKafeBilgi.TabIndex = 3;
            // 
            // frmKafeBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}