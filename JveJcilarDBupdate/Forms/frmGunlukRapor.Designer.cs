
namespace JveJcilarDBupdate.Forms
{
    partial class frmGunlukRapor
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
            this.btnGunlukRapor = new System.Windows.Forms.Button();
            this.dgvGunlukRapor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunlukRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGunlukRapor
            // 
            this.btnGunlukRapor.Location = new System.Drawing.Point(306, 21);
            this.btnGunlukRapor.Name = "btnGunlukRapor";
            this.btnGunlukRapor.Size = new System.Drawing.Size(188, 42);
            this.btnGunlukRapor.TabIndex = 0;
            this.btnGunlukRapor.Text = "Günlük Rapor";
            this.btnGunlukRapor.UseVisualStyleBackColor = true;
            this.btnGunlukRapor.Click += new System.EventHandler(this.btnGunlukRapor_Click);
            // 
            // dgvGunlukRapor
            // 
            this.dgvGunlukRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGunlukRapor.Location = new System.Drawing.Point(135, 79);
            this.dgvGunlukRapor.Name = "dgvGunlukRapor";
            this.dgvGunlukRapor.RowTemplate.Height = 25;
            this.dgvGunlukRapor.Size = new System.Drawing.Size(524, 299);
            this.dgvGunlukRapor.TabIndex = 1;
            // 
            // frmGunlukRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGunlukRapor);
            this.Controls.Add(this.btnGunlukRapor);
            this.Name = "frmGunlukRapor";
            this.Text = "frmGunlukRapor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGunlukRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGunlukRapor;
        private System.Windows.Forms.DataGridView dgvGunlukRapor;
    }
}