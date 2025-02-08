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

namespace FileEncrypterDecrypter
{
    public partial class FileEncrypterDecrypter_ObisoJ : Form
    {
        private readonly byte[] key = Encoding.UTF8.GetBytes("aB1cD2eF3gH4iJ5kL6mN7oP8qR9sT0uV");

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
            EncryptFile(openFileDialog_Encrypt.FileName);
        }

        private void openFileDialog_Decrypt_FileOk(object sender, CancelEventArgs e)
        {
            DecryptFile(openFileDialog_Decrypt.FileName);
        }

        private void EncryptFile(string filePath)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.GenerateIV();

                string tempFilePath = filePath + ".enc";
                using (FileStream fs = new FileStream(tempFilePath, FileMode.Create))
                {
                    fs.Write(aes.IV, 0, aes.IV.Length);
                    using (CryptoStream cryptoStream = new CryptoStream(fs, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    using (FileStream inputFs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                        inputFs.CopyTo(cryptoStream);
                    }
                }
            }

            File.Delete(filePath); // Ensure the original file is closed before deleting
            File.Move(filePath + ".enc", filePath);

            MessageBox.Show("Encryption successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DecryptFile(string filePath)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                string tempFilePath = filePath + ".dec";

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] iv = new byte[aes.BlockSize / 8];
                    fs.Read(iv, 0, iv.Length);
                    aes.IV = iv;

                    using (FileStream outputFs = new FileStream(tempFilePath, FileMode.Create))
                    using (CryptoStream cryptoStream = new CryptoStream(fs, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cryptoStream.CopyTo(outputFs);
                    }
                }
            }

            File.Delete(filePath); // Ensure the original file is closed before deleting
            File.Move(filePath + ".dec", filePath);

            MessageBox.Show("Decryption successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
