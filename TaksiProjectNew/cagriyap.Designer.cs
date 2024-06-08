namespace TaksiProjectNew
{
    partial class cagriyap
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
            this.btnTaksiCagir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbTarih = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbNot = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.txtAracId = new System.Windows.Forms.TextBox();
            this.txtSoforId = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaksiCagir
            // 
            this.btnTaksiCagir.Location = new System.Drawing.Point(123, 371);
            this.btnTaksiCagir.Name = "btnTaksiCagir";
            this.btnTaksiCagir.Size = new System.Drawing.Size(125, 43);
            this.btnTaksiCagir.TabIndex = 0;
            this.btnTaksiCagir.Text = "TAKSİ ÇAĞRISI YAP";
            this.btnTaksiCagir.UseVisualStyleBackColor = true;
            this.btnTaksiCagir.Click += new System.EventHandler(this.btnTaksiCagir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "TARİH:";
            // 
            // mtbTarih
            // 
            this.mtbTarih.Location = new System.Drawing.Point(138, 57);
            this.mtbTarih.Mask = "00/00/0000 90:00";
            this.mtbTarih.Name = "mtbTarih";
            this.mtbTarih.Size = new System.Drawing.Size(100, 22);
            this.mtbTarih.TabIndex = 2;
            this.mtbTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOT GÖNDER:";
            // 
            // rtbNot
            // 
            this.rtbNot.Location = new System.Drawing.Point(123, 245);
            this.rtbNot.Name = "rtbNot";
            this.rtbNot.Size = new System.Drawing.Size(125, 120);
            this.rtbNot.TabIndex = 4;
            this.rtbNot.Text = "";
            this.rtbNot.TextChanged += new System.EventHandler(this.rtbNot_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "MUSTERIID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ARACID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "SOFORID";
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Location = new System.Drawing.Point(138, 99);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(100, 22);
            this.txtMusteriId.TabIndex = 9;
            this.txtMusteriId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAracId
            // 
            this.txtAracId.Location = new System.Drawing.Point(138, 143);
            this.txtAracId.Name = "txtAracId";
            this.txtAracId.Size = new System.Drawing.Size(100, 22);
            this.txtAracId.TabIndex = 10;
            // 
            // txtSoforId
            // 
            this.txtSoforId.Location = new System.Drawing.Point(138, 177);
            this.txtSoforId.Name = "txtSoforId";
            this.txtSoforId.Size = new System.Drawing.Size(100, 22);
            this.txtSoforId.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(681, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(268, 83);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(681, 171);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(268, 83);
            this.dataGridView2.TabIndex = 13;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(681, 303);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(268, 83);
            this.dataGridView3.TabIndex = 14;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(761, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "MÜŞTERİ BİLGİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(775, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "ARAC BİLGİ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(775, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "SOFOR BİLGİ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "ÇAĞRILARI GÖRÜNTÜLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(308, 83);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(320, 303);
            this.dataGridView4.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(394, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Aktif Araçlar ve Şoförler";
            // 
            // cagriyap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 572);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSoforId);
            this.Controls.Add(this.txtAracId);
            this.Controls.Add(this.txtMusteriId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtbTarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaksiCagir);
            this.Name = "cagriyap";
            this.Text = "cagriyap";
            this.Load += new System.EventHandler(this.cagriyap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaksiCagir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbNot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.TextBox txtAracId;
        private System.Windows.Forms.TextBox txtSoforId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label9;
    }
}