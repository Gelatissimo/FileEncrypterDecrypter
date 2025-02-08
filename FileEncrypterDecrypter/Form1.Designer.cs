namespace FileEncrypterDecrypter
{
    partial class FileEncrypterDecrypter_ObisoJ
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.openFileDialog_Encrypt = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_Decrypt = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.AutoSize = true;
            this.btnEncrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEncrypt.Location = new System.Drawing.Point(0, 0);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(384, 50);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.AutoSize = true;
            this.btnDecrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDecrypt.Location = new System.Drawing.Point(0, 50);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(384, 50);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // openFileDialog_Encrypt
            // 
            this.openFileDialog_Encrypt.FileName = "openFileDialog_Encrypt";
            this.openFileDialog_Encrypt.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_Encrypt_FileOk);
            // 
            // openFileDialog_Decrypt
            // 
            this.openFileDialog_Decrypt.FileName = "openFileDialog_Decrypt";
            this.openFileDialog_Decrypt.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_Decrypt_FileOk);
            // 
            // FileEncrypterDecrypter_ObisoJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 101);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "FileEncrypterDecrypter_ObisoJ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Encrypter Decrypter - ObisoJ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Encrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Decrypt;
    }
}

