namespace TaksiProjectNew
{
    partial class surucuEkran
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
            this.dgvSurucuListele = new System.Windows.Forms.DataGridView();
            this.btnSoforKaydet = new System.Windows.Forms.Button();
            this.mtbSoforTel = new System.Windows.Forms.MaskedTextBox();
            this.txtSoforAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSurucuGuncelle = new System.Windows.Forms.Button();
            this.btnSurucuSil = new System.Windows.Forms.Button();
            this.cbSil = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbMusait = new System.Windows.Forms.RadioButton();
            this.rbMesgul = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurucuListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSurucuListele
            // 
            this.dgvSurucuListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSurucuListele.Location = new System.Drawing.Point(15, 21);
            this.dgvSurucuListele.Name = "dgvSurucuListele";
            this.dgvSurucuListele.RowHeadersWidth = 51;
            this.dgvSurucuListele.RowTemplate.Height = 24;
            this.dgvSurucuListele.Size = new System.Drawing.Size(608, 254);
            this.dgvSurucuListele.TabIndex = 0;
            this.dgvSurucuListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvSurucuListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSurucuListele_CellDoubleClick);
            // 
            // btnSoforKaydet
            // 
            this.btnSoforKaydet.Location = new System.Drawing.Point(660, 103);
            this.btnSoforKaydet.Name = "btnSoforKaydet";
            this.btnSoforKaydet.Size = new System.Drawing.Size(192, 36);
            this.btnSoforKaydet.TabIndex = 9;
            this.btnSoforKaydet.Text = "KAYDET\r\n";
            this.btnSoforKaydet.UseVisualStyleBackColor = true;
            this.btnSoforKaydet.Click += new System.EventHandler(this.btnSoforKaydet_Click);
            // 
            // mtbSoforTel
            // 
            this.mtbSoforTel.Location = new System.Drawing.Point(745, 49);
            this.mtbSoforTel.Mask = "(999) 000-0000";
            this.mtbSoforTel.Name = "mtbSoforTel";
            this.mtbSoforTel.Size = new System.Drawing.Size(100, 22);
            this.mtbSoforTel.TabIndex = 8;
            // 
            // txtSoforAdSoyad
            // 
            this.txtSoforAdSoyad.Location = new System.Drawing.Point(745, 21);
            this.txtSoforAdSoyad.Name = "txtSoforAdSoyad";
            this.txtSoforAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoforAdSoyad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "TELEFONU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADI SOYADI";
            // 
            // btnSurucuGuncelle
            // 
            this.btnSurucuGuncelle.Location = new System.Drawing.Point(660, 145);
            this.btnSurucuGuncelle.Name = "btnSurucuGuncelle";
            this.btnSurucuGuncelle.Size = new System.Drawing.Size(192, 37);
            this.btnSurucuGuncelle.TabIndex = 19;
            this.btnSurucuGuncelle.Text = "Güncelle";
            this.btnSurucuGuncelle.UseVisualStyleBackColor = true;
            this.btnSurucuGuncelle.Click += new System.EventHandler(this.btnSurucuGuncelle_Click);
            // 
            // btnSurucuSil
            // 
            this.btnSurucuSil.Location = new System.Drawing.Point(660, 188);
            this.btnSurucuSil.Name = "btnSurucuSil";
            this.btnSurucuSil.Size = new System.Drawing.Size(192, 37);
            this.btnSurucuSil.TabIndex = 20;
            this.btnSurucuSil.Text = "SİL";
            this.btnSurucuSil.UseVisualStyleBackColor = true;
            this.btnSurucuSil.Click += new System.EventHandler(this.btnSurucuSil_Click);
            // 
            // cbSil
            // 
            this.cbSil.AutoSize = true;
            this.cbSil.Location = new System.Drawing.Point(658, 228);
            this.cbSil.Name = "cbSil";
            this.cbSil.Size = new System.Drawing.Size(18, 17);
            this.cbSil.TabIndex = 21;
            this.cbSil.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "*Silme işlemini onaylıyorum";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Sürücü Çalışma Durumu:";
            // 
            // rbMusait
            // 
            this.rbMusait.AutoSize = true;
            this.rbMusait.Location = new System.Drawing.Point(477, 276);
            this.rbMusait.Name = "rbMusait";
            this.rbMusait.Size = new System.Drawing.Size(67, 20);
            this.rbMusait.TabIndex = 24;
            this.rbMusait.TabStop = true;
            this.rbMusait.Text = "Müsait";
            this.rbMusait.UseVisualStyleBackColor = true;
            this.rbMusait.CheckedChanged += new System.EventHandler(this.rbMusait_CheckedChanged);
            // 
            // rbMesgul
            // 
            this.rbMesgul.AutoSize = true;
            this.rbMesgul.Location = new System.Drawing.Point(550, 276);
            this.rbMesgul.Name = "rbMesgul";
            this.rbMesgul.Size = new System.Drawing.Size(72, 20);
            this.rbMesgul.TabIndex = 25;
            this.rbMesgul.TabStop = true;
            this.rbMesgul.Text = "Meşgul";
            this.rbMesgul.UseVisualStyleBackColor = true;
            // 
            // surucuEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 442);
            this.Controls.Add(this.rbMesgul);
            this.Controls.Add(this.rbMusait);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSil);
            this.Controls.Add(this.btnSurucuSil);
            this.Controls.Add(this.btnSurucuGuncelle);
            this.Controls.Add(this.btnSoforKaydet);
            this.Controls.Add(this.mtbSoforTel);
            this.Controls.Add(this.txtSoforAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSurucuListele);
            this.Name = "surucuEkran";
            this.Text = "surucuEkran";
            this.Load += new System.EventHandler(this.surucuEkran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurucuListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSurucuListele;
        private System.Windows.Forms.Button btnSoforKaydet;
        private System.Windows.Forms.MaskedTextBox mtbSoforTel;
        private System.Windows.Forms.TextBox txtSoforAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSurucuGuncelle;
        private System.Windows.Forms.Button btnSurucuSil;
        private System.Windows.Forms.CheckBox cbSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbMusait;
        private System.Windows.Forms.RadioButton rbMesgul;
    }
}