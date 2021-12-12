
namespace JveJcilarDBupdate.Forms
{
    partial class frmAylikRapor
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
            this.dgvAylikRapor = new System.Windows.Forms.DataGridView();
            this.btnAylikRapor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAylikRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAylikRapor
            // 
            this.dgvAylikRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAylikRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAylikRapor.Location = new System.Drawing.Point(135, 79);
            this.dgvAylikRapor.Name = "dgvAylikRapor";
            this.dgvAylikRapor.RowTemplate.Height = 35;
            this.dgvAylikRapor.Size = new System.Drawing.Size(524, 299);
            this.dgvAylikRapor.TabIndex = 3;
            // 
            // btnAylikRapor
            // 
            this.btnAylikRapor.Location = new System.Drawing.Point(306, 21);
            this.btnAylikRapor.Name = "btnAylikRapor";
            this.btnAylikRapor.Size = new System.Drawing.Size(188, 42);
            this.btnAylikRapor.TabIndex = 2;
            this.btnAylikRapor.Text = "Aylık Rapor";
            this.btnAylikRapor.UseVisualStyleBackColor = true;
            this.btnAylikRapor.Click += new System.EventHandler(this.btnAylikRapor_Click);
            // 
            // frmAylikRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JveJcilarDBupdate.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAylikRapor);
            this.Controls.Add(this.btnAylikRapor);
            this.Name = "frmAylikRapor";
            this.Text = "frmAylikRapor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAylikRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAylikRapor;
        private System.Windows.Forms.Button btnAylikRapor;
    }
}