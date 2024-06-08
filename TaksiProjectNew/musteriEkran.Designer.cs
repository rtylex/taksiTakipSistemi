namespace TaksiProjectNew
{
    partial class musteriEkran
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
            this.dgvMusteriListele = new System.Windows.Forms.DataGridView();
            this.btnMusteriKayit = new System.Windows.Forms.Button();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.rtbAdresTarif = new System.Windows.Forms.RichTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMusteriAra = new System.Windows.Forms.Button();
            this.txtMusteriTelefonArama = new System.Windows.Forms.MaskedTextBox();
            this.lblMusteriArama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteriListele
            // 
            this.dgvMusteriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriListele.Location = new System.Drawing.Point(12, 71);
            this.dgvMusteriListele.Name = "dgvMusteriListele";
            this.dgvMusteriListele.RowHeadersWidth = 51;
            this.dgvMusteriListele.RowTemplate.Height = 24;
            this.dgvMusteriListele.Size = new System.Drawing.Size(668, 359);
            this.dgvMusteriListele.TabIndex = 0;
            this.dgvMusteriListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMusteriListele_CellDoubleClick);
            // 
            // btnMusteriKayit
            // 
            this.btnMusteriKayit.Location = new System.Drawing.Point(1009, 47);
            this.btnMusteriKayit.Name = "btnMusteriKayit";
            this.btnMusteriKayit.Size = new System.Drawing.Size(192, 37);
            this.btnMusteriKayit.TabIndex = 17;
            this.btnMusteriKayit.Text = "Kayıt Et";
            this.btnMusteriKayit.UseVisualStyleBackColor = true;
            this.btnMusteriKayit.Click += new System.EventHandler(this.btnMusteriKayit_Click);
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Location = new System.Drawing.Point(830, 231);
            this.mtbTelefon.Mask = "(999) 000-0000";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(100, 22);
            this.mtbTelefon.TabIndex = 16;
            // 
            // rtbAdresTarif
            // 
            this.rtbAdresTarif.Location = new System.Drawing.Point(830, 108);
            this.rtbAdresTarif.Name = "rtbAdresTarif";
            this.rtbAdresTarif.Size = new System.Drawing.Size(119, 100);
            this.rtbAdresTarif.TabIndex = 15;
            this.rtbAdresTarif.Text = "";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(830, 71);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(119, 22);
            this.txtAdres.TabIndex = 14;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(830, 43);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(119, 22);
            this.txtAdSoyad.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "TELEFON";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "ADRES TARİF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "ADRES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "ADI SOYADI";
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(1009, 108);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(192, 37);
            this.btnMusteriGuncelle.TabIndex = 18;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.Location = new System.Drawing.Point(1009, 169);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(192, 37);
            this.btnKayitSil.TabIndex = 19;
            this.btnKayitSil.Text = "SİL";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Müşteri Profilleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMusteriAra
            // 
            this.btnMusteriAra.Location = new System.Drawing.Point(258, 20);
            this.btnMusteriAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteriAra.Name = "btnMusteriAra";
            this.btnMusteriAra.Size = new System.Drawing.Size(146, 27);
            this.btnMusteriAra.TabIndex = 23;
            this.btnMusteriAra.Text = "Müşteri Ara";
            this.btnMusteriAra.UseVisualStyleBackColor = true;
            this.btnMusteriAra.Click += new System.EventHandler(this.btnMusteriAra_Click);
            // 
            // txtMusteriTelefonArama
            // 
            this.txtMusteriTelefonArama.Location = new System.Drawing.Point(151, 20);
            this.txtMusteriTelefonArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriTelefonArama.Mask = "(999) 000-0000";
            this.txtMusteriTelefonArama.Name = "txtMusteriTelefonArama";
            this.txtMusteriTelefonArama.Size = new System.Drawing.Size(101, 22);
            this.txtMusteriTelefonArama.TabIndex = 22;
            // 
            // lblMusteriArama
            // 
            this.lblMusteriArama.AutoSize = true;
            this.lblMusteriArama.Location = new System.Drawing.Point(23, 23);
            this.lblMusteriArama.Name = "lblMusteriArama";
            this.lblMusteriArama.Size = new System.Drawing.Size(99, 16);
            this.lblMusteriArama.TabIndex = 21;
            this.lblMusteriArama.Text = "Müşteri Arama :";
            // 
            // musteriEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 605);
            this.Controls.Add(this.btnMusteriAra);
            this.Controls.Add(this.txtMusteriTelefonArama);
            this.Controls.Add(this.lblMusteriArama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKayitSil);
            this.Controls.Add(this.btnMusteriGuncelle);
            this.Controls.Add(this.btnMusteriKayit);
            this.Controls.Add(this.mtbTelefon);
            this.Controls.Add(this.rtbAdresTarif);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMusteriListele);
            this.Name = "musteriEkran";
            this.Text = "musteriEkran";
            this.Load += new System.EventHandler(this.musteriEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriListele;
        private System.Windows.Forms.Button btnMusteriKayit;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
        private System.Windows.Forms.RichTextBox rtbAdresTarif;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMusteriAra;
        private System.Windows.Forms.MaskedTextBox txtMusteriTelefonArama;
        private System.Windows.Forms.Label lblMusteriArama;
    }
}