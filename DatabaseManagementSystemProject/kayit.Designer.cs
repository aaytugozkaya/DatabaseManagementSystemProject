﻿
namespace DatabaseManagementSystemProject
{
    partial class kayit
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
            this.sifre = new System.Windows.Forms.TextBox();
            this.sifreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kadi = new System.Windows.Forms.TextBox();
            this.kayitol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(46, 191);
            this.sifre.Multiline = true;
            this.sifre.Name = "sifre";
            this.sifre.PasswordChar = '*';
            this.sifre.Size = new System.Drawing.Size(340, 32);
            this.sifre.TabIndex = 14;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // sifreLabel
            // 
            this.sifreLabel.Location = new System.Drawing.Point(43, 166);
            this.sifreLabel.Name = "sifreLabel";
            this.sifreLabel.Size = new System.Drawing.Size(100, 22);
            this.sifreLabel.TabIndex = 13;
            this.sifreLabel.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // kadi
            // 
            this.kadi.Location = new System.Drawing.Point(46, 120);
            this.kadi.Multiline = true;
            this.kadi.Name = "kadi";
            this.kadi.Size = new System.Drawing.Size(340, 32);
            this.kadi.TabIndex = 11;
            this.kadi.TextChanged += new System.EventHandler(this.kadi_TextChanged);
            // 
            // kayitol
            // 
            this.kayitol.BackColor = System.Drawing.Color.Transparent;
            this.kayitol.Location = new System.Drawing.Point(135, 248);
            this.kayitol.Name = "kayitol";
            this.kayitol.Size = new System.Drawing.Size(138, 48);
            this.kayitol.TabIndex = 15;
            this.kayitol.Text = "Kayıt Ol";
            this.kayitol.UseVisualStyleBackColor = false;
            this.kayitol.Click += new System.EventHandler(this.kayitol_Click);
            // 
            // kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.kayitol);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.sifreLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.Label sifreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kadi;
        private System.Windows.Forms.Button kayitol;
    }
}