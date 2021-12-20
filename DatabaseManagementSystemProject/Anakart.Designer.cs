
namespace DatabaseManagementSystemProject
{
    partial class Anakart
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.anakartekle = new System.Windows.Forms.Button();
            this.anakartsil = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            this.anakartid = new System.Windows.Forms.TextBox();
            this.ramslot = new System.Windows.Forms.TextBox();
            this.ramcap = new System.Windows.Forms.TextBox();
            this.tur = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.depola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(775, 682);
            this.dataGridView1.TabIndex = 3;
            // 
            // anakartekle
            // 
            this.anakartekle.Location = new System.Drawing.Point(822, 524);
            this.anakartekle.Name = "anakartekle";
            this.anakartekle.Size = new System.Drawing.Size(200, 50);
            this.anakartekle.TabIndex = 4;
            this.anakartekle.Text = "Ekle";
            this.anakartekle.UseVisualStyleBackColor = true;
            this.anakartekle.Click += new System.EventHandler(this.anakartekle_Click);
            // 
            // anakartsil
            // 
            this.anakartsil.Location = new System.Drawing.Point(1022, 524);
            this.anakartsil.Name = "anakartsil";
            this.anakartsil.Size = new System.Drawing.Size(200, 50);
            this.anakartsil.TabIndex = 5;
            this.anakartsil.Text = "Sil";
            this.anakartsil.UseVisualStyleBackColor = true;
            this.anakartsil.Click += new System.EventHandler(this.anakartsil_Click);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(822, 455);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(400, 50);
            this.listele.TabIndex = 6;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // anakartid
            // 
            this.anakartid.Location = new System.Drawing.Point(822, 75);
            this.anakartid.Multiline = true;
            this.anakartid.Name = "anakartid";
            this.anakartid.Size = new System.Drawing.Size(180, 27);
            this.anakartid.TabIndex = 9;
            this.anakartid.TextChanged += new System.EventHandler(this.anakartid_TextChanged);
            // 
            // ramslot
            // 
            this.ramslot.Location = new System.Drawing.Point(1022, 75);
            this.ramslot.Multiline = true;
            this.ramslot.Name = "ramslot";
            this.ramslot.Size = new System.Drawing.Size(180, 27);
            this.ramslot.TabIndex = 10;
            this.ramslot.TextChanged += new System.EventHandler(this.ramslot_TextChanged);
            // 
            // ramcap
            // 
            this.ramcap.Location = new System.Drawing.Point(822, 175);
            this.ramcap.Multiline = true;
            this.ramcap.Name = "ramcap";
            this.ramcap.Size = new System.Drawing.Size(180, 27);
            this.ramcap.TabIndex = 11;
            this.ramcap.TextChanged += new System.EventHandler(this.ramcap_TextChanged);
            // 
            // tur
            // 
            this.tur.Location = new System.Drawing.Point(822, 275);
            this.tur.Multiline = true;
            this.tur.Name = "tur";
            this.tur.Size = new System.Drawing.Size(180, 27);
            this.tur.TabIndex = 12;
            this.tur.TextChanged += new System.EventHandler(this.tur_TextChanged);
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(1022, 275);
            this.marka.Multiline = true;
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(180, 27);
            this.marka.TabIndex = 13;
            this.marka.TextChanged += new System.EventHandler(this.marka_TextChanged);
            // 
            // depola
            // 
            this.depola.Location = new System.Drawing.Point(1022, 175);
            this.depola.Multiline = true;
            this.depola.Name = "depola";
            this.depola.Size = new System.Drawing.Size(180, 27);
            this.depola.TabIndex = 14;
            this.depola.TextChanged += new System.EventHandler(this.depola_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ürün Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1019, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ram Slot Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(819, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ram Kapasitesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1019, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Depolama Alanı Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(819, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tür";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1019, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Marka";
            // 
            // Anakart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1251, 706);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depola);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.tur);
            this.Controls.Add(this.ramcap);
            this.Controls.Add(this.ramslot);
            this.Controls.Add(this.anakartid);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.anakartsil);
            this.Controls.Add(this.anakartekle);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anakart";
            this.Text = "Anakart";
            this.Load += new System.EventHandler(this.Anakart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button anakartekle;
        private System.Windows.Forms.Button anakartsil;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.TextBox anakartid;
        private System.Windows.Forms.TextBox ramslot;
        private System.Windows.Forms.TextBox ramcap;
        private System.Windows.Forms.TextBox tur;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox depola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}