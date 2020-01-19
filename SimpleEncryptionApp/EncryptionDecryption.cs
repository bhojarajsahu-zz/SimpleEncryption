using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptionDecryption;

namespace SimpleEncryptionApp
{
    public partial class EncryptionDecryption : Form
    {
        public EncryptionDecryption()
        {
            InitializeComponent();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string result = string.Empty;
                string text = textBoxText.Text;
                string key = textBoxKey.Text;
                if (!string.IsNullOrEmpty(textBoxText.Text) && !string.IsNullOrEmpty(textBoxKey.Text))
                    result = Encryption.Encrypt(text, key);

                textBoxresult.Text = result;
            }
            catch
            {
                MessageBox.Show("Error occurred", "Encryption Decryption Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string result = string.Empty;
                string text = textBoxText.Text;
                string key = textBoxKey.Text;
                if (!string.IsNullOrEmpty(textBoxText.Text) && !string.IsNullOrEmpty(textBoxKey.Text))
                    result = Decryption.Decrypt(text, key);

                textBoxresult.Text = result;
            }
            catch
            {
                MessageBox.Show("Error occurred", "Encryption Decryption Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
