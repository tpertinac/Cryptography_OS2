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
            this.btnOpenCleanText = new System.Windows.Forms.Button();
            this.textBoxCleanText = new System.Windows.Forms.TextBox();
            this.btnOpenSecretKey = new System.Windows.Forms.Button();
            this.textBoxAesKey = new System.Windows.Forms.TextBox();
            this.btnGenerateSecretKey = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCleanText = new System.Windows.Forms.Label();
            this.btnSaveCleanText = new System.Windows.Forms.Button();
            this.btnClearTextBoxLeft = new System.Windows.Forms.Button();
            this.btnClearTextBoxRight = new System.Windows.Forms.Button();
            this.btnSaveCryptoText = new System.Windows.Forms.Button();
            this.lblCryptoText = new System.Windows.Forms.Label();
            this.btnOpenCryptoText = new System.Windows.Forms.Button();
            this.textBoxCryptoText = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAES = new System.Windows.Forms.TabPage();
            this.btnAesDecrypt = new System.Windows.Forms.Button();
            this.btnAesCrypt = new System.Windows.Forms.Button();
            this.btnClearSecretKeyTextBox = new System.Windows.Forms.Button();
            this.btnSaveSecretKey = new System.Windows.Forms.Button();
            this.lblSecretKeyAes = new System.Windows.Forms.Label();
            this.tabRSA = new System.Windows.Forms.TabPage();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.btnDecryptRSA = new System.Windows.Forms.Button();
            this.btnCryptRSA = new System.Windows.Forms.Button();
            this.btnClearRSAKeys = new System.Windows.Forms.Button();
            this.btnSaveRSAKeys = new System.Windows.Forms.Button();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.btnOpenRSAKeys = new System.Windows.Forms.Button();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.btnGenerateKeyPairsRSA = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnDigitalSignature = new System.Windows.Forms.Button();
            this.btnCheckDigitalSignature = new System.Windows.Forms.Button();
            this.textBoxDigitalSignature = new System.Windows.Forms.TextBox();
            this.textBoxHash = new System.Windows.Forms.TextBox();
            this.btnCheckHash = new System.Windows.Forms.Button();
            this.btnCreateHash = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAES.SuspendLayout();
            this.tabRSA.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenCleanText
            // 
            this.btnOpenCleanText.Location = new System.Drawing.Point(12, 293);
            this.btnOpenCleanText.Name = "btnOpenCleanText";
            this.btnOpenCleanText.Size = new System.Drawing.Size(174, 30);
            this.btnOpenCleanText.TabIndex = 0;
            this.btnOpenCleanText.Text = "Učitaj datoteku";
            this.btnOpenCleanText.UseVisualStyleBackColor = true;
            this.btnOpenCleanText.Click += new System.EventHandler(this.btnOpenCleanText_Click);
            // 
            // textBoxCleanText
            // 
            this.textBoxCleanText.Location = new System.Drawing.Point(12, 27);
            this.textBoxCleanText.Multiline = true;
            this.textBoxCleanText.Name = "textBoxCleanText";
            this.textBoxCleanText.Size = new System.Drawing.Size(174, 260);
            this.textBoxCleanText.TabIndex = 1;
            // 
            // btnOpenSecretKey
            // 
            this.btnOpenSecretKey.Location = new System.Drawing.Point(6, 125);
            this.btnOpenSecretKey.Name = "btnOpenSecretKey";
            this.btnOpenSecretKey.Size = new System.Drawing.Size(104, 47);
            this.btnOpenSecretKey.TabIndex = 4;
            this.btnOpenSecretKey.Text = "Učitaj tajni ključ";
            this.btnOpenSecretKey.UseVisualStyleBackColor = true;
            this.btnOpenSecretKey.Click += new System.EventHandler(this.btnOpenSecretKey_Click);
            // 
            // textBoxAesKey
            // 
            this.textBoxAesKey.Location = new System.Drawing.Point(116, 19);
            this.textBoxAesKey.Multiline = true;
            this.textBoxAesKey.Name = "textBoxAesKey";
            this.textBoxAesKey.Size = new System.Drawing.Size(270, 206);
            this.textBoxAesKey.TabIndex = 3;
            // 
            // btnGenerateSecretKey
            // 
            this.btnGenerateSecretKey.Location = new System.Drawing.Point(6, 19);
            this.btnGenerateSecretKey.Name = "btnGenerateSecretKey";
            this.btnGenerateSecretKey.Size = new System.Drawing.Size(104, 47);
            this.btnGenerateSecretKey.TabIndex = 0;
            this.btnGenerateSecretKey.Text = "Generiraj tajni ključ";
            this.btnGenerateSecretKey.UseVisualStyleBackColor = true;
            this.btnGenerateSecretKey.Click += new System.EventHandler(this.btnGenerateSecretKey_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // lblCleanText
            // 
            this.lblCleanText.AutoSize = true;
            this.lblCleanText.Location = new System.Drawing.Point(73, 9);
            this.lblCleanText.Name = "lblCleanText";
            this.lblCleanText.Size = new System.Drawing.Size(52, 13);
            this.lblCleanText.TabIndex = 5;
            this.lblCleanText.Text = "Čisti tekst";
            // 
            // btnSaveCleanText
            // 
            this.btnSaveCleanText.Location = new System.Drawing.Point(13, 329);
            this.btnSaveCleanText.Name = "btnSaveCleanText";
            this.btnSaveCleanText.Size = new System.Drawing.Size(173, 30);
            this.btnSaveCleanText.TabIndex = 6;
            this.btnSaveCleanText.Text = "Spremi datoteku";
            this.btnSaveCleanText.UseVisualStyleBackColor = true;
            this.btnSaveCleanText.Click += new System.EventHandler(this.btnSaveCleanText_Click);
            // 
            // btnClearTextBoxLeft
            // 
            this.btnClearTextBoxLeft.Location = new System.Drawing.Point(13, 365);
            this.btnClearTextBoxLeft.Name = "btnClearTextBoxLeft";
            this.btnClearTextBoxLeft.Size = new System.Drawing.Size(173, 30);
            this.btnClearTextBoxLeft.TabIndex = 7;
            this.btnClearTextBoxLeft.Text = "Isprazni text box";
            this.btnClearTextBoxLeft.UseVisualStyleBackColor = true;
            this.btnClearTextBoxLeft.Click += new System.EventHandler(this.btnClearTextBoxLeft_Click);
            // 
            // btnClearTextBoxRight
            // 
            this.btnClearTextBoxRight.Location = new System.Drawing.Point(713, 365);
            this.btnClearTextBoxRight.Name = "btnClearTextBoxRight";
            this.btnClearTextBoxRight.Size = new System.Drawing.Size(174, 30);
            this.btnClearTextBoxRight.TabIndex = 12;
            this.btnClearTextBoxRight.Text = "Isprazni text box";
            this.btnClearTextBoxRight.UseVisualStyleBackColor = true;
            this.btnClearTextBoxRight.Click += new System.EventHandler(this.btnClearTextBoxRight_Click_1);
            // 
            // btnSaveCryptoText
            // 
            this.btnSaveCryptoText.Location = new System.Drawing.Point(713, 329);
            this.btnSaveCryptoText.Name = "btnSaveCryptoText";
            this.btnSaveCryptoText.Size = new System.Drawing.Size(174, 30);
            this.btnSaveCryptoText.TabIndex = 11;
            this.btnSaveCryptoText.Text = "Spremi datoteku";
            this.btnSaveCryptoText.UseVisualStyleBackColor = true;
            this.btnSaveCryptoText.Click += new System.EventHandler(this.btnSaveCryptoText_Click);
            // 
            // lblCryptoText
            // 
            this.lblCryptoText.AutoSize = true;
            this.lblCryptoText.Location = new System.Drawing.Point(760, 9);
            this.lblCryptoText.Name = "lblCryptoText";
            this.lblCryptoText.Size = new System.Drawing.Size(73, 13);
            this.lblCryptoText.TabIndex = 10;
            this.lblCryptoText.Text = "Kriptirani tekst";
            // 
            // btnOpenCryptoText
            // 
            this.btnOpenCryptoText.Location = new System.Drawing.Point(713, 293);
            this.btnOpenCryptoText.Name = "btnOpenCryptoText";
            this.btnOpenCryptoText.Size = new System.Drawing.Size(174, 30);
            this.btnOpenCryptoText.TabIndex = 8;
            this.btnOpenCryptoText.Text = "Učitaj datoteku";
            this.btnOpenCryptoText.UseVisualStyleBackColor = true;
            this.btnOpenCryptoText.Click += new System.EventHandler(this.btnOpenCryptoText_Click);
            // 
            // textBoxCryptoText
            // 
            this.textBoxCryptoText.Location = new System.Drawing.Point(713, 25);
            this.textBoxCryptoText.Multiline = true;
            this.textBoxCryptoText.Name = "textBoxCryptoText";
            this.textBoxCryptoText.Size = new System.Drawing.Size(174, 260);
            this.textBoxCryptoText.TabIndex = 13;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabAES);
            this.tabControl1.Controls.Add(this.tabRSA);
            this.tabControl1.Location = new System.Drawing.Point(192, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(515, 260);
            this.tabControl1.TabIndex = 14;
            // 
            // tabAES
            // 
            this.tabAES.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabAES.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabAES.Controls.Add(this.btnAesDecrypt);
            this.tabAES.Controls.Add(this.btnAesCrypt);
            this.tabAES.Controls.Add(this.btnClearSecretKeyTextBox);
            this.tabAES.Controls.Add(this.btnSaveSecretKey);
            this.tabAES.Controls.Add(this.lblSecretKeyAes);
            this.tabAES.Controls.Add(this.btnGenerateSecretKey);
            this.tabAES.Controls.Add(this.btnOpenSecretKey);
            this.tabAES.Controls.Add(this.textBoxAesKey);
            this.tabAES.Location = new System.Drawing.Point(4, 25);
            this.tabAES.Name = "tabAES";
            this.tabAES.Padding = new System.Windows.Forms.Padding(3);
            this.tabAES.Size = new System.Drawing.Size(507, 231);
            this.tabAES.TabIndex = 0;
            this.tabAES.Text = "Simetrično(AES)";
            // 
            // btnAesDecrypt
            // 
            this.btnAesDecrypt.Location = new System.Drawing.Point(392, 125);
            this.btnAesDecrypt.Name = "btnAesDecrypt";
            this.btnAesDecrypt.Size = new System.Drawing.Size(105, 100);
            this.btnAesDecrypt.TabIndex = 17;
            this.btnAesDecrypt.Text = "Dekriptiraj";
            this.btnAesDecrypt.UseVisualStyleBackColor = true;
            this.btnAesDecrypt.Click += new System.EventHandler(this.btnAesDecrypt_Click);
            // 
            // btnAesCrypt
            // 
            this.btnAesCrypt.Location = new System.Drawing.Point(392, 19);
            this.btnAesCrypt.Name = "btnAesCrypt";
            this.btnAesCrypt.Size = new System.Drawing.Size(105, 100);
            this.btnAesCrypt.TabIndex = 16;
            this.btnAesCrypt.Text = "Kriptiraj";
            this.btnAesCrypt.UseVisualStyleBackColor = true;
            this.btnAesCrypt.Click += new System.EventHandler(this.btnAesCrypt_Click);
            // 
            // btnClearSecretKeyTextBox
            // 
            this.btnClearSecretKeyTextBox.Location = new System.Drawing.Point(6, 178);
            this.btnClearSecretKeyTextBox.Name = "btnClearSecretKeyTextBox";
            this.btnClearSecretKeyTextBox.Size = new System.Drawing.Size(104, 47);
            this.btnClearSecretKeyTextBox.TabIndex = 15;
            this.btnClearSecretKeyTextBox.Text = "Isprazni text box";
            this.btnClearSecretKeyTextBox.UseVisualStyleBackColor = true;
            this.btnClearSecretKeyTextBox.Click += new System.EventHandler(this.btnClearSecretKeyTextBox_Click);
            // 
            // btnSaveSecretKey
            // 
            this.btnSaveSecretKey.Location = new System.Drawing.Point(6, 72);
            this.btnSaveSecretKey.Name = "btnSaveSecretKey";
            this.btnSaveSecretKey.Size = new System.Drawing.Size(104, 47);
            this.btnSaveSecretKey.TabIndex = 6;
            this.btnSaveSecretKey.Text = "Spremi tajni ključ";
            this.btnSaveSecretKey.UseVisualStyleBackColor = true;
            this.btnSaveSecretKey.Click += new System.EventHandler(this.btnSaveSecretKey_Click);
            // 
            // lblSecretKeyAes
            // 
            this.lblSecretKeyAes.AutoSize = true;
            this.lblSecretKeyAes.Location = new System.Drawing.Point(229, 3);
            this.lblSecretKeyAes.Name = "lblSecretKeyAes";
            this.lblSecretKeyAes.Size = new System.Drawing.Size(55, 13);
            this.lblSecretKeyAes.TabIndex = 5;
            this.lblSecretKeyAes.Text = "Tajni ključ";
            // 
            // tabRSA
            // 
            this.tabRSA.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabRSA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabRSA.Controls.Add(this.lblPrivateKey);
            this.tabRSA.Controls.Add(this.textBoxPrivateKey);
            this.tabRSA.Controls.Add(this.btnDecryptRSA);
            this.tabRSA.Controls.Add(this.btnCryptRSA);
            this.tabRSA.Controls.Add(this.btnClearRSAKeys);
            this.tabRSA.Controls.Add(this.btnSaveRSAKeys);
            this.tabRSA.Controls.Add(this.lblPublicKey);
            this.tabRSA.Controls.Add(this.btnOpenRSAKeys);
            this.tabRSA.Controls.Add(this.textBoxPublicKey);
            this.tabRSA.Controls.Add(this.btnGenerateKeyPairsRSA);
            this.tabRSA.Location = new System.Drawing.Point(4, 25);
            this.tabRSA.Name = "tabRSA";
            this.tabRSA.Padding = new System.Windows.Forms.Padding(3);
            this.tabRSA.Size = new System.Drawing.Size(507, 231);
            this.tabRSA.TabIndex = 1;
            this.tabRSA.Text = "Asimetrično(RSA)";
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(302, 3);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(67, 13);
            this.lblPrivateKey.TabIndex = 27;
            this.lblPrivateKey.Text = "Privatni ključ";
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(262, 19);
            this.textBoxPrivateKey.Multiline = true;
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(147, 200);
            this.textBoxPrivateKey.TabIndex = 26;
            // 
            // btnDecryptRSA
            // 
            this.btnDecryptRSA.Location = new System.Drawing.Point(415, 121);
            this.btnDecryptRSA.Name = "btnDecryptRSA";
            this.btnDecryptRSA.Size = new System.Drawing.Size(82, 98);
            this.btnDecryptRSA.TabIndex = 25;
            this.btnDecryptRSA.Text = "Dekriptiraj";
            this.btnDecryptRSA.UseVisualStyleBackColor = true;
            this.btnDecryptRSA.Click += new System.EventHandler(this.btnDecryptRSA_Click);
            // 
            // btnCryptRSA
            // 
            this.btnCryptRSA.Location = new System.Drawing.Point(415, 19);
            this.btnCryptRSA.Name = "btnCryptRSA";
            this.btnCryptRSA.Size = new System.Drawing.Size(82, 96);
            this.btnCryptRSA.TabIndex = 24;
            this.btnCryptRSA.Text = "Kriptiraj";
            this.btnCryptRSA.UseVisualStyleBackColor = true;
            this.btnCryptRSA.Click += new System.EventHandler(this.btnCryptRSA_Click);
            // 
            // btnClearRSAKeys
            // 
            this.btnClearRSAKeys.Location = new System.Drawing.Point(5, 174);
            this.btnClearRSAKeys.Name = "btnClearRSAKeys";
            this.btnClearRSAKeys.Size = new System.Drawing.Size(97, 45);
            this.btnClearRSAKeys.TabIndex = 23;
            this.btnClearRSAKeys.Text = "Isprazni text box";
            this.btnClearRSAKeys.UseVisualStyleBackColor = true;
            this.btnClearRSAKeys.Click += new System.EventHandler(this.btnClearRSAKeys_Click);
            // 
            // btnSaveRSAKeys
            // 
            this.btnSaveRSAKeys.Location = new System.Drawing.Point(5, 70);
            this.btnSaveRSAKeys.Name = "btnSaveRSAKeys";
            this.btnSaveRSAKeys.Size = new System.Drawing.Size(97, 45);
            this.btnSaveRSAKeys.TabIndex = 22;
            this.btnSaveRSAKeys.Text = "Spremi par ključeva";
            this.btnSaveRSAKeys.UseVisualStyleBackColor = true;
            this.btnSaveRSAKeys.Click += new System.EventHandler(this.btnSaveRSAKeys_Click);
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Location = new System.Drawing.Point(152, 3);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(58, 13);
            this.lblPublicKey.TabIndex = 21;
            this.lblPublicKey.Text = "Javni Ključ";
            // 
            // btnOpenRSAKeys
            // 
            this.btnOpenRSAKeys.Location = new System.Drawing.Point(5, 121);
            this.btnOpenRSAKeys.Name = "btnOpenRSAKeys";
            this.btnOpenRSAKeys.Size = new System.Drawing.Size(97, 45);
            this.btnOpenRSAKeys.TabIndex = 20;
            this.btnOpenRSAKeys.Text = "Učitaj ključeve";
            this.btnOpenRSAKeys.UseVisualStyleBackColor = true;
            this.btnOpenRSAKeys.Click += new System.EventHandler(this.btnOpenRSAKeys_Click);
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(108, 19);
            this.textBoxPublicKey.Multiline = true;
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(147, 200);
            this.textBoxPublicKey.TabIndex = 19;
            // 
            // btnGenerateKeyPairsRSA
            // 
            this.btnGenerateKeyPairsRSA.Location = new System.Drawing.Point(6, 19);
            this.btnGenerateKeyPairsRSA.Name = "btnGenerateKeyPairsRSA";
            this.btnGenerateKeyPairsRSA.Size = new System.Drawing.Size(96, 45);
            this.btnGenerateKeyPairsRSA.TabIndex = 18;
            this.btnGenerateKeyPairsRSA.Text = "Generiraj par ključeva";
            this.btnGenerateKeyPairsRSA.UseVisualStyleBackColor = true;
            this.btnGenerateKeyPairsRSA.Click += new System.EventHandler(this.btnGenerateKeyPairsRSA_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(376, 365);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(132, 30);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Isprazni sve text boxove";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnDigitalSignature
            // 
            this.btnDigitalSignature.Location = new System.Drawing.Point(204, 329);
            this.btnDigitalSignature.Name = "btnDigitalSignature";
            this.btnDigitalSignature.Size = new System.Drawing.Size(104, 30);
            this.btnDigitalSignature.TabIndex = 16;
            this.btnDigitalSignature.Text = "Potpiši pourku";
            this.btnDigitalSignature.UseVisualStyleBackColor = true;
            this.btnDigitalSignature.Click += new System.EventHandler(this.btnDigitalSignature_Click);
            // 
            // btnCheckDigitalSignature
            // 
            this.btnCheckDigitalSignature.Location = new System.Drawing.Point(590, 329);
            this.btnCheckDigitalSignature.Name = "btnCheckDigitalSignature";
            this.btnCheckDigitalSignature.Size = new System.Drawing.Size(105, 30);
            this.btnCheckDigitalSignature.TabIndex = 17;
            this.btnCheckDigitalSignature.Text = "Provjeri potpis";
            this.btnCheckDigitalSignature.UseVisualStyleBackColor = true;
            this.btnCheckDigitalSignature.Click += new System.EventHandler(this.btnCheckDigitalSignature_Click);
            // 
            // textBoxDigitalSignature
            // 
            this.textBoxDigitalSignature.Location = new System.Drawing.Point(314, 329);
            this.textBoxDigitalSignature.Multiline = true;
            this.textBoxDigitalSignature.Name = "textBoxDigitalSignature";
            this.textBoxDigitalSignature.Size = new System.Drawing.Size(270, 30);
            this.textBoxDigitalSignature.TabIndex = 18;
            // 
            // textBoxHash
            // 
            this.textBoxHash.Location = new System.Drawing.Point(314, 293);
            this.textBoxHash.Multiline = true;
            this.textBoxHash.Name = "textBoxHash";
            this.textBoxHash.Size = new System.Drawing.Size(270, 30);
            this.textBoxHash.TabIndex = 21;
            // 
            // btnCheckHash
            // 
            this.btnCheckHash.Location = new System.Drawing.Point(590, 293);
            this.btnCheckHash.Name = "btnCheckHash";
            this.btnCheckHash.Size = new System.Drawing.Size(105, 30);
            this.btnCheckHash.TabIndex = 20;
            this.btnCheckHash.Text = "Provjeri sažetak";
            this.btnCheckHash.UseVisualStyleBackColor = true;
            this.btnCheckHash.Click += new System.EventHandler(this.btnCheckHash_Click);
            // 
            // btnCreateHash
            // 
            this.btnCreateHash.Location = new System.Drawing.Point(204, 293);
            this.btnCreateHash.Name = "btnCreateHash";
            this.btnCreateHash.Size = new System.Drawing.Size(104, 30);
            this.btnCreateHash.TabIndex = 19;
            this.btnCreateHash.Text = "Napravi sažetak";
            this.btnCreateHash.UseVisualStyleBackColor = true;
            this.btnCreateHash.Click += new System.EventHandler(this.btnCreateHash_Click);
            // 
            // Cryptography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 423);
            this.Controls.Add(this.textBoxHash);
            this.Controls.Add(this.btnCheckHash);
            this.Controls.Add(this.btnCreateHash);
            this.Controls.Add(this.textBoxDigitalSignature);
            this.Controls.Add(this.btnCheckDigitalSignature);
            this.Controls.Add(this.btnDigitalSignature);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxCryptoText);
            this.Controls.Add(this.btnClearTextBoxRight);
            this.Controls.Add(this.btnSaveCryptoText);
            this.Controls.Add(this.lblCryptoText);
            this.Controls.Add(this.btnOpenCryptoText);
            this.Controls.Add(this.btnClearTextBoxLeft);
            this.Controls.Add(this.btnSaveCleanText);
            this.Controls.Add(this.lblCleanText);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxCleanText);
            this.Controls.Add(this.btnOpenCleanText);
            this.Name = "Cryptography";
            this.Text = "Cryptography";
            this.Load += new System.EventHandler(this.CryptographyForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabAES.ResumeLayout(false);
            this.tabAES.PerformLayout();
            this.tabRSA.ResumeLayout(false);
            this.tabRSA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCleanText;
        private System.Windows.Forms.TextBox textBoxCleanText;
        private System.Windows.Forms.Button btnGenerateSecretKey;
        private System.Windows.Forms.TextBox textBoxAesKey;
        private System.Windows.Forms.Button btnOpenSecretKey;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblCleanText;
        private System.Windows.Forms.Button btnSaveCleanText;
        private System.Windows.Forms.Button btnClearTextBoxLeft;
        private System.Windows.Forms.Button btnClearTextBoxRight;
        private System.Windows.Forms.Button btnSaveCryptoText;
        private System.Windows.Forms.Label lblCryptoText;
        private System.Windows.Forms.Button btnOpenCryptoText;
        private System.Windows.Forms.TextBox textBoxCryptoText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAES;
        private System.Windows.Forms.TabPage tabRSA;
        private System.Windows.Forms.Label lblSecretKeyAes;
        private System.Windows.Forms.Button btnSaveSecretKey;
        private System.Windows.Forms.Button btnClearSecretKeyTextBox;
        private System.Windows.Forms.Button btnAesDecrypt;
        private System.Windows.Forms.Button btnAesCrypt;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.Button btnDecryptRSA;
        private System.Windows.Forms.Button btnCryptRSA;
        private System.Windows.Forms.Button btnClearRSAKeys;
        private System.Windows.Forms.Button btnSaveRSAKeys;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.Button btnOpenRSAKeys;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.Button btnGenerateKeyPairsRSA;
        private System.Windows.Forms.Button btnDigitalSignature;
        private System.Windows.Forms.Button btnCheckDigitalSignature;
        private System.Windows.Forms.TextBox textBoxDigitalSignature;
        private System.Windows.Forms.TextBox textBoxHash;
        private System.Windows.Forms.Button btnCheckHash;
        private System.Windows.Forms.Button btnCreateHash;
    }
}

