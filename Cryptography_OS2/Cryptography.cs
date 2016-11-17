using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        OpenFileDialog ofd = new OpenFileDialog();

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "text|*.txt";
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) {
                string filename = ofd.FileName;
                string filetext = File.ReadAllText(filename);
                textBoxTextFile.Text = filetext;
            }
        }

        private void btnTajniKljuc_Click(object sender, EventArgs e)
        {
            AesManaged aes = new AesManaged();
            aes.GenerateKey();
            string path = AppDomain.CurrentDomain.BaseDirectory + "tajni_kljuc.txt";
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.Write(aes.Key.ToString());
                sw.Close();
            }
        }
    }
}
