namespace TaksiProjectNew
{
    partial class admingiris
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
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.txtAdminGirisSifre = new System.Windows.Forms.TextBox();
            this.txtAdminGirisEposta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.Location = new System.Drawing.Point(12, 148);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(197, 23);
            this.btnAdminGiris.TabIndex = 9;
            this.btnAdminGiris.Text = "GİRİŞ";
            this.btnAdminGiris.UseVisualStyleBackColor = true;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // txtAdminGirisSifre
            // 
            this.txtAdminGirisSifre.Location = new System.Drawing.Point(109, 94);
            this.txtAdminGirisSifre.Name = "txtAdminGirisSifre";
            this.txtAdminGirisSifre.Size = new System.Drawing.Size(100, 22);
            this.txtAdminGirisSifre.TabIndex = 8;
            // 
            // txtAdminGirisEposta
            // 
            this.txtAdminGirisEposta.Location = new System.Drawing.Point(109, 24);
            this.txtAdminGirisEposta.Name = "txtAdminGirisEposta";
            this.txtAdminGirisEposta.Size = new System.Drawing.Size(100, 22);
            this.txtAdminGirisEposta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-posta";
            // 
            // admingiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 186);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.txtAdminGirisSifre);
            this.Controls.Add(this.txtAdminGirisEposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "admingiris";
            this.Text = "admingiris";
            this.Load += new System.EventHandler(this.admingiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.TextBox txtAdminGirisSifre;
        private System.Windows.Forms.TextBox txtAdminGirisEposta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}