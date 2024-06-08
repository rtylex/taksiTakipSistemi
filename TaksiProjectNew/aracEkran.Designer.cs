namespace TaksiProjectNew
{
    partial class aracEkran
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
            this.dgvAraclar = new System.Windows.Forms.DataGridView();
            this.btnaracEkle = new System.Windows.Forms.Button();
            this.rtbAcıklama = new System.Windows.Forms.RichTextBox();
            this.mtbAracSahibiTel = new System.Windows.Forms.MaskedTextBox();
            this.txtAracSahibi = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAracGuncelle = new System.Windows.Forms.Button();
            this.btnAracSil = new System.Windows.Forms.Button();
            this.btnAracListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAraclar
            // 
            this.dgvAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAraclar.Location = new System.Drawing.Point(12, 12);
            this.dgvAraclar.Name = "dgvAraclar";
            this.dgvAraclar.RowHeadersWidth = 51;
            this.dgvAraclar.RowTemplate.Height = 24;
            this.dgvAraclar.Size = new System.Drawing.Size(532, 353);
            this.dgvAraclar.TabIndex = 0;
            this.dgvAraclar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAraclar_CellContentClick);
            this.dgvAraclar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAraclar_CellDoubleClick);
            // 
            // btnaracEkle
            // 
            this.btnaracEkle.Location = new System.Drawing.Point(1001, 193);
            this.btnaracEkle.Name = "btnaracEkle";
            this.btnaracEkle.Size = new System.Drawing.Size(192, 31);
            this.btnaracEkle.TabIndex = 1;
            this.btnaracEkle.Text = "Araç Ekle";
            this.btnaracEkle.UseVisualStyleBackColor = true;
            this.btnaracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // rtbAcıklama
            // 
            this.rtbAcıklama.Location = new System.Drawing.Point(829, 185);
            this.rtbAcıklama.Name = "rtbAcıklama";
            this.rtbAcıklama.Size = new System.Drawing.Size(152, 130);
            this.rtbAcıklama.TabIndex = 17;
            this.rtbAcıklama.Text = "";
            // 
            // mtbAracSahibiTel
            // 
            this.mtbAracSahibiTel.Location = new System.Drawing.Point(829, 129);
            this.mtbAracSahibiTel.Mask = "(999) 000-0000";
            this.mtbAracSahibiTel.Name = "mtbAracSahibiTel";
            this.mtbAracSahibiTel.Size = new System.Drawing.Size(152, 22);
            this.mtbAracSahibiTel.TabIndex = 16;
            // 
            // txtAracSahibi
            // 
            this.txtAracSahibi.Location = new System.Drawing.Point(829, 72);
            this.txtAracSahibi.Name = "txtAracSahibi";
            this.txtAracSahibi.Size = new System.Drawing.Size(152, 22);
            this.txtAracSahibi.TabIndex = 15;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(829, 17);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(152, 22);
            this.txtPlaka.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "ACIKLAMA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(659, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "ARAC SAHİBİ TELEFON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "ARAC SAHİBİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "PLAKA";
            // 
            // btnAracGuncelle
            // 
            this.btnAracGuncelle.Location = new System.Drawing.Point(1001, 235);
            this.btnAracGuncelle.Name = "btnAracGuncelle";
            this.btnAracGuncelle.Size = new System.Drawing.Size(192, 37);
            this.btnAracGuncelle.TabIndex = 20;
            this.btnAracGuncelle.Text = "Güncelle";
            this.btnAracGuncelle.UseVisualStyleBackColor = true;
            this.btnAracGuncelle.Click += new System.EventHandler(this.btnAracGuncelle_Click);
            // 
            // btnAracSil
            // 
            this.btnAracSil.Location = new System.Drawing.Point(1001, 278);
            this.btnAracSil.Name = "btnAracSil";
            this.btnAracSil.Size = new System.Drawing.Size(192, 37);
            this.btnAracSil.TabIndex = 21;
            this.btnAracSil.Text = "SİL";
            this.btnAracSil.UseVisualStyleBackColor = true;
            this.btnAracSil.Click += new System.EventHandler(this.btnAracSil_Click);
            // 
            // btnAracListele
            // 
            this.btnAracListele.Location = new System.Drawing.Point(352, 371);
            this.btnAracListele.Name = "btnAracListele";
            this.btnAracListele.Size = new System.Drawing.Size(192, 31);
            this.btnAracListele.TabIndex = 22;
            this.btnAracListele.Text = "ARAÇLARI LİSTELE";
            this.btnAracListele.UseVisualStyleBackColor = true;
            this.btnAracListele.Click += new System.EventHandler(this.btnAracListele_Click);
            // 
            // aracEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 416);
            this.Controls.Add(this.btnAracListele);
            this.Controls.Add(this.btnAracSil);
            this.Controls.Add(this.btnAracGuncelle);
            this.Controls.Add(this.rtbAcıklama);
            this.Controls.Add(this.mtbAracSahibiTel);
            this.Controls.Add(this.txtAracSahibi);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaracEkle);
            this.Controls.Add(this.dgvAraclar);
            this.Name = "aracEkran";
            this.Text = "aracEkran";
            this.Load += new System.EventHandler(this.aracEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAraclar;
        private System.Windows.Forms.Button btnaracEkle;
        private System.Windows.Forms.RichTextBox rtbAcıklama;
        private System.Windows.Forms.MaskedTextBox mtbAracSahibiTel;
        private System.Windows.Forms.TextBox txtAracSahibi;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAracGuncelle;
        private System.Windows.Forms.Button btnAracSil;
        private System.Windows.Forms.Button btnAracListele;
    }
}