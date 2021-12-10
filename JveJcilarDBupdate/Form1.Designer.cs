
namespace JveJcilarDBupdate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.katAyarlaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kafeBilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kafeGörünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.katAyarlaToolStripMenuItem1,
            this.kafeBilgiToolStripMenuItem,
            this.menüToolStripMenuItem,
            this.kafeGörünümToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 34);
            // 
            // katAyarlaToolStripMenuItem1
            // 
            this.katAyarlaToolStripMenuItem1.Name = "katAyarlaToolStripMenuItem1";
            this.katAyarlaToolStripMenuItem1.Size = new System.Drawing.Size(120, 34);
            this.katAyarlaToolStripMenuItem1.Text = "Kat ayarla";
            this.katAyarlaToolStripMenuItem1.Click += new System.EventHandler(this.katAyarlaToolStripMenuItem1_Click);
            // 
            // kafeBilgiToolStripMenuItem
            // 
            this.kafeBilgiToolStripMenuItem.Name = "kafeBilgiToolStripMenuItem";
            this.kafeBilgiToolStripMenuItem.Size = new System.Drawing.Size(114, 34);
            this.kafeBilgiToolStripMenuItem.Text = "Kafe Bilgi";
            this.kafeBilgiToolStripMenuItem.Click += new System.EventHandler(this.kafeBilgiToolStripMenuItem_Click);
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(79, 34);
            this.menüToolStripMenuItem.Text = "Menü";
            this.menüToolStripMenuItem.Click += new System.EventHandler(this.menüToolStripMenuItem_Click);
            // 
            // kafeGörünümToolStripMenuItem
            // 
            this.kafeGörünümToolStripMenuItem.Name = "kafeGörünümToolStripMenuItem";
            this.kafeGörünümToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.kafeGörünümToolStripMenuItem.Text = "Kafe Görünüm";
            this.kafeGörünümToolStripMenuItem.Click += new System.EventHandler(this.kafeGörünümToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem katAyarlaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kafeBilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kafeGörünümToolStripMenuItem;
    }
}

