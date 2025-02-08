using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEncrypterDecrypter
{
    public partial class FileEncrypterDecrypter_ObisoJ : Form
    {
        private readonly byte[] key = Encoding.UTF8.GetBytes("meowmeowmeow");

        public FileEncrypterDecrypter_ObisoJ()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            openFileDialog_Encrypt.ShowDialog();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            openFileDialog_Decrypt.ShowDialog();
        }

        private void openFileDialog_Encrypt_FileOk(object sender, CancelEventArgs e)
        {
            byte[] fileBytes = File.ReadAllBytes(openFileDialog_Encrypt.FileName);
            byte[] encryptedBytes = XorCipher(fileBytes);
            File.WriteAllBytes(openFileDialog_Encrypt.FileName, encryptedBytes);
            MessageBox.Show("File successfully encrypted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openFileDialog_Decrypt_FileOk(object sender, CancelEventArgs e)
        {
            byte[] fileBytes = File.ReadAllBytes(openFileDialog_Decrypt.FileName);
            byte[] decryptedBytes = XorCipher(fileBytes);
            File.WriteAllBytes(openFileDialog_Decrypt.FileName, decryptedBytes);
            MessageBox.Show("File successfully decrypted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private byte[] XorCipher(byte[] data)
        {
            byte[] result = new byte[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                result[i] = (byte)(data[i] ^ key[i % key.Length]);
            }
            return result;
        }
    }
}
