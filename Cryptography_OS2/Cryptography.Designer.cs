namespace Cryptography_OS2
{
    partial class Cryptography
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
            this.btnOpenTextFile = new System.Windows.Forms.Button();
            this.textBoxTextFile = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTajniKljuc = new System.Windows.Forms.Button();
            this.labelAES = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenTextFile
            // 
            this.btnOpenTextFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenTextFile.Name = "btnOpenTextFile";
            this.btnOpenTextFile.Size = new System.Drawing.Size(104, 69);
            this.btnOpenTextFile.TabIndex = 0;
            this.btnOpenTextFile.Text = "Učitaj datoteku";
            this.btnOpenTextFile.UseVisualStyleBackColor = true;
            this.btnOpenTextFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTextFile
            // 
            this.textBoxTextFile.Location = new System.Drawing.Point(122, 12);
            this.textBoxTextFile.Multiline = true;
            this.textBoxTextFile.Name = "textBoxTextFile";
            this.textBoxTextFile.ReadOnly = true;
            this.textBoxTextFile.Size = new System.Drawing.Size(745, 69);
            this.textBoxTextFile.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTajniKljuc);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 153);
            this.panel1.TabIndex = 2;
            // 
            // btnTajniKljuc
            // 
            this.btnTajniKljuc.Location = new System.Drawing.Point(3, 3);
            this.btnTajniKljuc.Name = "btnTajniKljuc";
            this.btnTajniKljuc.Size = new System.Drawing.Size(101, 36);
            this.btnTajniKljuc.TabIndex = 0;
            this.btnTajniKljuc.Text = "Stvori tajni ključ";
            this.btnTajniKljuc.UseVisualStyleBackColor = true;
            this.btnTajniKljuc.Click += new System.EventHandler(this.btnTajniKljuc_Click);
            // 
            // labelAES
            // 
            this.labelAES.AutoSize = true;
            this.labelAES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAES.Location = new System.Drawing.Point(147, 99);
            this.labelAES.Name = "labelAES";
            this.labelAES.Size = new System.Drawing.Size(38, 16);
            this.labelAES.TabIndex = 3;
            this.labelAES.Text = "AES";
            this.labelAES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cryptography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 321);
            this.Controls.Add(this.labelAES);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTextFile);
            this.Controls.Add(this.btnOpenTextFile);
            this.Name = "Cryptography";
            this.Text = "Cryptography";
            this.Load += new System.EventHandler(this.CryptographyForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenTextFile;
        private System.Windows.Forms.TextBox textBoxTextFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTajniKljuc;
        private System.Windows.Forms.Label labelAES;
    }
}

