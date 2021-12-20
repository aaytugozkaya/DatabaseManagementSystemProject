
namespace DatabaseManagementSystemProject
{
    partial class AnaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.giris = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.kayitol = new System.Windows.Forms.Button();
            this.sifre = new System.Windows.Forms.TextBox();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kadi = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(-8, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 668);
            this.panel1.TabIndex = 2;
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(171, 453);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(138, 48);
            this.giris.TabIndex = 0;
            this.giris.Text = "Giriş Yap";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.kayitol);
            this.panel2.Controls.Add(this.sifre);
            this.panel2.Controls.Add(this.sifreLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.kadi);
            this.panel2.Controls.Add(this.giris);
            this.panel2.Location = new System.Drawing.Point(169, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 668);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(168, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hesabınız yok mu?";
            // 
            // kayitol
            // 
            this.kayitol.Location = new System.Drawing.Point(171, 577);
            this.kayitol.Name = "kayitol";
            this.kayitol.Size = new System.Drawing.Size(138, 48);
            this.kayitol.TabIndex = 11;
            this.kayitol.Text = "Kayıt Ol";
            this.kayitol.UseVisualStyleBackColor = true;
            this.kayitol.Click += new System.EventHandler(this.kayitol_Click);
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(171, 400);
            this.sifre.Multiline = true;
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(340, 32);
            this.sifre.TabIndex = 10;
            // 
            // sifreLabel
            // 
            this.sifreLabel.Location = new System.Drawing.Point(168, 375);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(100, 22);
            this.sifreLabel.TabIndex = 9;
            this.sifreLabel.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(168, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(119, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 278);
            this.label1.TabIndex = 7;
            this.label1.Text = "BİLGİSAYAR FABRİKASI YÖNETİM SİSTEMİ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kadi
            // 
            this.kadi.Location = new System.Drawing.Point(171, 329);
            this.kadi.Multiline = true;
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(340, 32);
            this.kadi.TabIndex = 6;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox kadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kayitol;
        private System.Windows.Forms.Label label3;
    }
}

