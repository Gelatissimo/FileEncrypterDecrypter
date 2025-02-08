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
            FileStream fs = new FileStream(openFileDialog_Encrypt.FileName, FileMode.OpenOrCreate);

            int[] temp = new int[fs.Length];

            for (int x = 0; x < fs.Length; x++) { temp[x] = fs.ReadByte(); }
            for (int x = 0; x < fs.Length; x++)
            {
                temp[x] = temp[x] + 3; //to be changed
            }
            fs.Close();

            fs = new FileStream(openFileDialog_Encrypt.FileName, FileMode.OpenOrCreate);
            for (int x = 0; x < fs.Length; x++) { fs.WriteByte((byte)temp[x]); }
            fs.Close();
        }

        private void openFileDialog_Decrypt_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(openFileDialog_Decrypt.FileName, FileMode.OpenOrCreate);

            int[] temp = new int[fs.Length];

            for (int x = 0; x < fs.Length; x++) { temp[x] = fs.ReadByte(); }
            for (int x = 0; x < fs.Length; x++)
            {
                temp[x] = temp[x] - 3; //to be changed
            }
            fs.Close();

            fs = new FileStream(openFileDialog_Decrypt.FileName, FileMode.OpenOrCreate);
            for (int x = 0; x < fs.Length; x++) { fs.WriteByte((byte)temp[x]); }
            fs.Close();
        }
    }
}
