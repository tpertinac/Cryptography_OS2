using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Virgil.Crypto;

namespace Cryptography_OS2
{
    public partial class Cryptography : Form
    {
        public Cryptography()
        {
            InitializeComponent();
        }

        private void CryptographyForm_Load(object sender, EventArgs e)
        {

        }

        private string Open_Text(string textfile)
        {
            string path = @"C:\Users\Tomek\Desktop\OS2 projekt\Cryptography_OS2\Crypto files\" + textfile;
            string fulltext = "";

            if (!File.Exists(path))
            {
                toolStripStatusLabel1.Text = "Datoteka " + textfile+ " ne postoji!";
                return fulltext;
            }
            else
            {
                StreamReader sr = new StreamReader(path);
                fulltext = sr.ReadToEnd();
                sr.Close();
                toolStripStatusLabel1.Text = "Datoteka "+ textfile+ " je ucitana!";
                return fulltext;
            }
        }

        private void Save_Text(string filename, string text)
        {
            string path = @"C:\Users\Tomek\Desktop\OS2 projekt\Cryptography_OS2\Crypto files\" + filename;
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(text);
                sw.Close();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            textBoxCleanText.Clear();
            textBoxAesKey.Clear();
            textBoxCryptoText.Clear();
            textBoxPublicKey.Clear();
            textBoxPrivateKey.Clear();
        }

        //Lijeva strana
        private void btnOpenCleanText_Click(object sender, EventArgs e)
        {
            textBoxCleanText.Text = Open_Text("cisti_tekst.txt");
        }

        private void btnSaveCleanText_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxCleanText.Text))
            {
                toolStripStatusLabel1.Text = "Ne postoji tekst!";
                return;
            }
            else
            {
                Save_Text("cisti_tekst.txt", textBoxCleanText.Text);
                toolStripStatusLabel1.Text = "Datoteka cisti_tekst.txt je spremljena!";
            }
        }

        private void btnClearTextBoxLeft_Click(object sender, EventArgs e)
        {
            textBoxCleanText.Clear();
        }

        //Desna strana
        private void btnOpenCryptoText_Click(object sender, EventArgs e)
        {
           textBoxCryptoText.Text = Open_Text("kriptirani_tekst.txt");
        }

        private void btnSaveCryptoText_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxCryptoText.Text))
            {
                toolStripStatusLabel1.Text = "Ne postoji kriptirani tekst!";
                return;
            }
            else
            {
                Save_Text("kriptirani_tekst.txt", textBoxCryptoText.Text);
                toolStripStatusLabel1.Text = "Datoteka kriptirani_tekst.txt je spremljena!";
            }
        }

        private void btnClearTextBoxRight_Click_1(object sender, EventArgs e)
        {
            textBoxCryptoText.Clear();
        }

        //AES funkcionalnosti buttona
        private void btnGenerateSecretKey_Click(object sender, EventArgs e)
        {
            using (AesCryptoServiceProvider aes = new AesCryptoServiceProvider())
            {
                aes.KeySize = 256;
                SoapHexBinary shb = new SoapHexBinary(aes.Key);
                textBoxAesKey.Text = shb.ToString();
            }
            if (!String.IsNullOrWhiteSpace(textBoxAesKey.Text)) btnSaveSecretKey.PerformClick();
        }

        private void btnOpenSecretKey_Click(object sender, EventArgs e)
        {
            textBoxAesKey.Text = Open_Text("tajni_kljuc.txt");
        }

        private void btnSaveSecretKey_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxAesKey.Text))
            {
                toolStripStatusLabel1.Text = "Kljuc nije generiran!";
                return;
            }
            else
            {
                Save_Text("tajni_kljuc.txt", textBoxAesKey.Text);
                toolStripStatusLabel1.Text = "Datoteka tajni_kljuc.txt je spremljena!";
            }
        }

        private void btnClearSecretKeyTextBox_Click(object sender, EventArgs e)
        {
            textBoxAesKey.Clear();
        }

        //AES enkripcija
        private void btnAesCrypt_Click(object sender, EventArgs e)
        {
            string cleantext = Open_Text("cisti_tekst.txt");
            if (cleantext == null)
            {
                toolStripStatusLabel1.Text = "Datoteka cisti_tekst.txt ne postoji!";
                return;
            }
            else if (cleantext.Length <= 0)
            {
                toolStripStatusLabel1.Text = "Datoteka cisti_tekst.txt je prazna!";
                return;
            }
            else
            {
                textBoxCleanText.Text = cleantext;
                string aeskey = Open_Text("tajni_kljuc.txt");
                if (aeskey == null) return;
                else if (aeskey.Length <= 0)
                {
                    toolStripStatusLabel1.Text = "Datoteka tajni_kljuc.txt je prazna!";
                    return;
                }
                else
                {
                    textBoxAesKey.Text = aeskey;
                    try
                    {
                        byte[] encryptedtext;
                        SoapHexBinary shb = SoapHexBinary.Parse(aeskey);
                        using (Aes aesAlg = Aes.Create())
                        {
                            aesAlg.Key = shb.Value;

                            aesAlg.GenerateIV();
                            SoapHexBinary ivth = new SoapHexBinary(aesAlg.IV);
                            Save_Text("IV.txt", ivth.ToString());

                            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                            using (MemoryStream msEncrypt = new MemoryStream())
                            {
                                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                                {
                                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                                    {
                                        swEncrypt.Write(cleantext);
                                    }
                                    encryptedtext = msEncrypt.ToArray();
                                }
                            }
                        }
                        textBoxCryptoText.Text = Convert.ToBase64String(encryptedtext);
                    }
                    catch (Exception)
                    {
                        toolStripStatusLabel1.Text = "Enkripcija neuspjela! Provjerite ispravnost ključa, IV-a ili originalni tekst";
                        return;
                    }
                    Save_Text("kriptirani_tekst.txt", textBoxCryptoText.Text);
                    toolStripStatusLabel1.Text = "Tekst kriptiran i pospremljen";
                }
            }
        }

        //AES dekripcija
        private void btnAesDecrypt_Click(object sender, EventArgs e)
        {
            string cryptedtext = Open_Text("kriptirani_tekst.txt");
            if (cryptedtext == null)
            {
                toolStripStatusLabel1.Text = "Datoteka kriptirani_tekst.txt ne postoji!";
                return;
            }
            else if (cryptedtext.Length <= 0)
            {
                toolStripStatusLabel1.Text = "Datoteka kriptirani_tekst.txt je prazna!";
                return;
            }
            else
            {
                string decryptedtext;
                textBoxCryptoText.Text = cryptedtext;
                string aeskey = Open_Text("tajni_kljuc.txt");
                if (aeskey == null) return;
                else if (aeskey.Length <= 0)
                {
                    toolStripStatusLabel1.Text = "Datoteka tajni_kljuc.txt je prazna!";
                    return;
                }
                else
                {
                    textBoxAesKey.Text = aeskey;
                    try
                    {
                        byte[] texttodecrypt = Convert.FromBase64String(cryptedtext);
                        SoapHexBinary shb = SoapHexBinary.Parse(aeskey);

                        using (Aes aesAlg = Aes.Create())
                        {
                            aesAlg.Key = shb.Value;

                            string IV = Open_Text("IV.txt");
                            SoapHexBinary ivtb = SoapHexBinary.Parse(IV);
                            aesAlg.IV = ivtb.Value;

                            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                            using (MemoryStream msDecrypt = new MemoryStream(texttodecrypt))
                            {
                                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                                {
                                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                                    {
                                        decryptedtext = srDecrypt.ReadToEnd();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        toolStripStatusLabel1.Text = "Dekripcije neuspjela! Provjerite ispravnost ključa, IV-a ili kriptiranog teksta";
                        return;
                    }
                    if (decryptedtext != Open_Text("cisti_tekst.txt"))
                    {
                        toolStripStatusLabel1.Text = "Dekriptirani tekst ne odgovara orginalnom tekstu!";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Dekriptiranje je uspješno završeno";
                    }
                    textBoxCleanText.Text = decryptedtext;
                }
            }
        }

        //RSA funkcionalnosti buttona
        private void btnGenerateKeyPairsRSA_Click(object sender, EventArgs e)
        {
            var keypairs = VirgilKeyPair.Generate(VirgilKeyPair.Type.RSA_2048);

            string pathpubkey = @"C:\Users\Tomek\Desktop\OS2 projekt\Cryptography_OS2\Crypto files\javni_kljuc.txt";
            File.WriteAllBytes(pathpubkey, keypairs.PublicKey());

            string pathprivkey = @"C:\Users\Tomek\Desktop\OS2 projekt\Cryptography_OS2\Crypto files\privatni_kljuc.txt";
            File.WriteAllBytes(pathprivkey, keypairs.PrivateKey());

            if (File.Exists(pathpubkey) && File.Exists(pathprivkey)) btnOpenRSAKeys.PerformClick();
        }
        private void btnOpenRSAKeys_Click(object sender, EventArgs e)
        {
            string publickey = Open_Text("javni_kljuc.txt");
            string privatekey = Open_Text("privatni_kljuc.txt");
            if (!String.IsNullOrEmpty(publickey)) textBoxPublicKey.Text = publickey;
            if (!String.IsNullOrEmpty(privatekey)) textBoxPrivateKey.Text = privatekey;
            else toolStripStatusLabel1.Text = "Datoteke javnog i/ili privatnog kljuca ne postoje!";
        }

        private void btnSaveRSAKeys_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPublicKey.Text) || String.IsNullOrWhiteSpace(textBoxPrivateKey.Text))
            {
                toolStripStatusLabel1.Text = "Ne postoji par ključeva!";
                return;
            }
            else
            {
                Save_Text("javni_kljuc.txt", textBoxPublicKey.Text);
                Save_Text("privatni_kljuc.txt", textBoxPrivateKey.Text);
                toolStripStatusLabel1.Text = "Datoteke javni_kljuc.txt i privatni_kljuc.txt su spremljene!";
            }
        }

        private void btnClearRSAKeys_Click(object sender, EventArgs e)
        {
            textBoxPublicKey.Clear();
            textBoxPrivateKey.Clear();
        }

        //RSA enkripcija
        private void btnCryptRSA_Click(object sender, EventArgs e)
        {
            try
            {
                string cleantext = Open_Text("cisti_tekst.txt");
                if (String.IsNullOrEmpty(cleantext)) return;
                textBoxCleanText.Text = cleantext;

                string pubkey = Open_Text("javni_kljuc.txt");
                if (String.IsNullOrEmpty(pubkey)) return;
                byte[] publickey = Encoding.ASCII.GetBytes(pubkey);
                textBoxPublicKey.Text = pubkey;

                string encryptedtext = CryptoHelper.Encrypt(cleantext, "RecipientID", publickey);
                if (String.IsNullOrEmpty(encryptedtext)) return;
                Save_Text("kriptirani_tekst.txt", encryptedtext);
                textBoxCryptoText.Text = encryptedtext;
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Greška! Provjerite datoteke cistog teksta i javnog kljuca!";
                return;
            }
            toolStripStatusLabel1.Text = "Datoteka je uspješno kriptirana";
        }


        //RSA dekripcija
        private void btnDecryptRSA_Click(object sender, EventArgs e)
        {
            string decryptedText;
            try
            {
                string cryptedtext = Open_Text("kriptirani_tekst.txt");
                if (String.IsNullOrEmpty(cryptedtext)) return;
                textBoxCryptoText.Text = cryptedtext;

                string privkey = Open_Text("privatni_kljuc.txt");
                if (String.IsNullOrEmpty(privkey)) return;
                byte[] privatekey = Encoding.ASCII.GetBytes(privkey);
                textBoxPrivateKey.Text = privkey;

                decryptedText = CryptoHelper.Decrypt(cryptedtext, "RecipientID", privatekey);
                if(String.IsNullOrEmpty(decryptedText)) return;
            }
            catch (Exception)
            {
                toolStripStatusLabel1.Text = "Greška! Provjerite datoteke kriptiranog teksta i privatnog kljuca!";
                return;
            }
            if (decryptedText != Open_Text("cisti_tekst.txt"))
            {
                toolStripStatusLabel1.Text = "Dekriptirani tekst ne odgovara orginalnom tekstu!";
            }
            else
            {
                toolStripStatusLabel1.Text = "Dekriptiranje je uspješno završeno";
            }
            textBoxCleanText.Text = decryptedText;
        }

    }
}
