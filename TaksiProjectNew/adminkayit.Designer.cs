namespace TaksiProjectNew
{
    partial class adminkayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminKayitEposta = new System.Windows.Forms.TextBox();
            this.txtAdminKayitSifre = new System.Windows.Forms.TextBox();
            this.btnAdminKayit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbKvkkOnay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-posta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txtAdminKayitEposta
            // 
            this.txtAdminKayitEposta.Location = new System.Drawing.Point(151, 28);
            this.txtAdminKayitEposta.Name = "txtAdminKayitEposta";
            this.txtAdminKayitEposta.Size = new System.Drawing.Size(100, 22);
            this.txtAdminKayitEposta.TabIndex = 2;
            // 
            // txtAdminKayitSifre
            // 
            this.txtAdminKayitSifre.Location = new System.Drawing.Point(151, 98);
            this.txtAdminKayitSifre.Name = "txtAdminKayitSifre";
            this.txtAdminKayitSifre.Size = new System.Drawing.Size(100, 22);
            this.txtAdminKayitSifre.TabIndex = 3;
            // 
            // btnAdminKayit
            // 
            this.btnAdminKayit.Location = new System.Drawing.Point(69, 144);
            this.btnAdminKayit.Name = "btnAdminKayit";
            this.btnAdminKayit.Size = new System.Drawing.Size(197, 23);
            this.btnAdminKayit.TabIndex = 4;
            this.btnAdminKayit.Text = "KAYIT";
            this.btnAdminKayit.UseVisualStyleBackColor = true;
            this.btnAdminKayit.Click += new System.EventHandler(this.btnAdminKayit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(86, 182);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(180, 16);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "KVKK metnini kabul ediyorum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cbKvkkOnay
            // 
            this.cbKvkkOnay.AutoSize = true;
            this.cbKvkkOnay.Location = new System.Drawing.Point(62, 181);
            this.cbKvkkOnay.Name = "cbKvkkOnay";
            this.cbKvkkOnay.Size = new System.Drawing.Size(18, 17);
            this.cbKvkkOnay.TabIndex = 6;
            this.cbKvkkOnay.UseVisualStyleBackColor = true;
            // 
            // adminkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 290);
            this.Controls.Add(this.cbKvkkOnay);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAdminKayit);
            this.Controls.Add(this.txtAdminKayitSifre);
            this.Controls.Add(this.txtAdminKayitEposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminkayit";
            this.Text = "adminkayit";
            this.Load += new System.EventHandler(this.adminkayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminKayitEposta;
        private System.Windows.Forms.TextBox txtAdminKayitSifre;
        private System.Windows.Forms.Button btnAdminKayit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox cbKvkkOnay;
    }
}