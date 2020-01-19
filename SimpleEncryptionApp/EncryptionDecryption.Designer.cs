namespace SimpleEncryptionApp
{
    partial class EncryptionDecryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionDecryption));
            this.groupBoxEncrypt = new System.Windows.Forms.GroupBox();
            this.labeltext = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxresult = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.groupBoxEncrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEncrypt
            // 
            this.groupBoxEncrypt.Controls.Add(this.buttonDecrypt);
            this.groupBoxEncrypt.Controls.Add(this.buttonEncrypt);
            this.groupBoxEncrypt.Controls.Add(this.textBoxresult);
            this.groupBoxEncrypt.Controls.Add(this.labelResult);
            this.groupBoxEncrypt.Controls.Add(this.textBoxKey);
            this.groupBoxEncrypt.Controls.Add(this.labelKey);
            this.groupBoxEncrypt.Controls.Add(this.textBoxText);
            this.groupBoxEncrypt.Controls.Add(this.labeltext);
            this.groupBoxEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxEncrypt.Location = new System.Drawing.Point(0, 0);
            this.groupBoxEncrypt.Name = "groupBoxEncrypt";
            this.groupBoxEncrypt.Size = new System.Drawing.Size(436, 253);
            this.groupBoxEncrypt.TabIndex = 0;
            this.groupBoxEncrypt.TabStop = false;
            this.groupBoxEncrypt.Text = "Encryption - Decryption";
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Location = new System.Drawing.Point(29, 36);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(31, 13);
            this.labeltext.TabIndex = 0;
            this.labeltext.Text = "Text:";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(66, 33);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(309, 60);
            this.textBoxText.TabIndex = 1;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(29, 104);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(28, 13);
            this.labelKey.TabIndex = 2;
            this.labelKey.Text = "Key:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(66, 101);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(309, 20);
            this.textBoxKey.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(29, 180);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(40, 13);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "Result:";
            // 
            // textBoxresult
            // 
            this.textBoxresult.Location = new System.Drawing.Point(66, 177);
            this.textBoxresult.Multiline = true;
            this.textBoxresult.Name = "textBoxresult";
            this.textBoxresult.ReadOnly = true;
            this.textBoxresult.Size = new System.Drawing.Size(309, 60);
            this.textBoxresult.TabIndex = 5;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(207, 137);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncrypt.TabIndex = 6;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(297, 137);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonDecrypt.TabIndex = 7;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // EncryptionDecryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 253);
            this.Controls.Add(this.groupBoxEncrypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(452, 287);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(452, 287);
            this.Name = "EncryptionDecryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptionDecryption";
            this.groupBoxEncrypt.ResumeLayout(false);
            this.groupBoxEncrypt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxresult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label labeltext;
    }
}

