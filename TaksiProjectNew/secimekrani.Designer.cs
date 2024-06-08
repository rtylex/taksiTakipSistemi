namespace TaksiProjectNew
{
    partial class secimekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(secimekrani));
            this.btnGirisEkraniYon = new System.Windows.Forms.Button();
            this.btnKayitEkraniYon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGirisEkraniYon
            // 
            this.btnGirisEkraniYon.Location = new System.Drawing.Point(470, 419);
            this.btnGirisEkraniYon.Name = "btnGirisEkraniYon";
            this.btnGirisEkraniYon.Size = new System.Drawing.Size(226, 84);
            this.btnGirisEkraniYon.TabIndex = 0;
            this.btnGirisEkraniYon.Text = "GİRİŞ YAP";
            this.btnGirisEkraniYon.UseVisualStyleBackColor = true;
            this.btnGirisEkraniYon.Click += new System.EventHandler(this.btnGirisEkraniYon_Click);
            // 
            // btnKayitEkraniYon
            // 
            this.btnKayitEkraniYon.Location = new System.Drawing.Point(238, 419);
            this.btnKayitEkraniYon.Name = "btnKayitEkraniYon";
            this.btnKayitEkraniYon.Size = new System.Drawing.Size(226, 84);
            this.btnKayitEkraniYon.TabIndex = 1;
            this.btnKayitEkraniYon.Text = "KAYIT OL";
            this.btnKayitEkraniYon.UseVisualStyleBackColor = true;
            this.btnKayitEkraniYon.Click += new System.EventHandler(this.btnKayitEkraniYon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // secimekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKayitEkraniYon);
            this.Controls.Add(this.btnGirisEkraniYon);
            this.Name = "secimekrani";
            this.Text = "secimekrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGirisEkraniYon;
        private System.Windows.Forms.Button btnKayitEkraniYon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}