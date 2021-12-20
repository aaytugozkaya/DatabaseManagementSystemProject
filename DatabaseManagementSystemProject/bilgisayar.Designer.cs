
namespace DatabaseManagementSystemProject
{
    partial class bilgisayar
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
            this.ekle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listele = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelId = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.labelislemci = new System.Windows.Forms.Label();
            this.labelssd = new System.Windows.Forms.Label();
            this.labelram1 = new System.Windows.Forms.Label();
            this.islemci = new System.Windows.Forms.TextBox();
            this.ram1 = new System.Windows.Forms.TextBox();
            this.ssd = new System.Windows.Forms.TextBox();
            this.hdd = new System.Windows.Forms.TextBox();
            this.ram2 = new System.Windows.Forms.TextBox();
            this.ekrankarti = new System.Windows.Forms.TextBox();
            this.labelram2 = new System.Windows.Forms.Label();
            this.anakart = new System.Windows.Forms.TextBox();
            this.labelhdd = new System.Windows.Forms.Label();
            this.labelekrankarti = new System.Windows.Forms.Label();
            this.labelanakart = new System.Windows.Forms.Label();
            this.klavye = new System.Windows.Forms.TextBox();
            this.labelklavye = new System.Windows.Forms.Label();
            this.monitor = new System.Windows.Forms.TextBox();
            this.labelmonitor = new System.Windows.Forms.Label();
            this.ara = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(231, 8);
            this.ekle.Margin = new System.Windows.Forms.Padding(5);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(215, 50);
            this.ekle.TabIndex = 0;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listele);
            this.panel1.Controls.Add(this.guncelle);
            this.panel1.Controls.Add(this.sil);
            this.panel1.Controls.Add(this.ekle);
            this.panel1.Location = new System.Drawing.Point(793, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 124);
            this.panel1.TabIndex = 1;
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(228, 68);
            this.listele.Margin = new System.Windows.Forms.Padding(5);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(215, 50);
            this.listele.TabIndex = 3;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.listele_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(9, 68);
            this.guncelle.Margin = new System.Windows.Forms.Padding(5);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(215, 50);
            this.guncelle.TabIndex = 2;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(7, 8);
            this.sil.Margin = new System.Windows.Forms.Padding(5);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(215, 50);
            this.sil.TabIndex = 1;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
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
            this.dataGridView1.TabIndex = 2;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(797, 55);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(21, 17);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(800, 75);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(180, 27);
            this.id.TabIndex = 8;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // labelislemci
            // 
            this.labelislemci.AutoSize = true;
            this.labelislemci.Location = new System.Drawing.Point(797, 131);
            this.labelislemci.Name = "labelislemci";
            this.labelislemci.Size = new System.Drawing.Size(71, 17);
            this.labelislemci.TabIndex = 10;
            this.labelislemci.Text = "İşlemci(G)";
            // 
            // labelssd
            // 
            this.labelssd.AutoSize = true;
            this.labelssd.Location = new System.Drawing.Point(797, 280);
            this.labelssd.Name = "labelssd";
            this.labelssd.Size = new System.Drawing.Size(36, 17);
            this.labelssd.TabIndex = 11;
            this.labelssd.Text = "SSD";
            // 
            // labelram1
            // 
            this.labelram1.AutoSize = true;
            this.labelram1.Location = new System.Drawing.Point(797, 205);
            this.labelram1.Name = "labelram1";
            this.labelram1.Size = new System.Drawing.Size(71, 17);
            this.labelram1.TabIndex = 12;
            this.labelram1.Text = "Ram-1(G)";
            // 
            // islemci
            // 
            this.islemci.Location = new System.Drawing.Point(800, 150);
            this.islemci.Multiline = true;
            this.islemci.Name = "islemci";
            this.islemci.Size = new System.Drawing.Size(180, 27);
            this.islemci.TabIndex = 14;
            this.islemci.TextChanged += new System.EventHandler(this.islemci_TextChanged);
            // 
            // ram1
            // 
            this.ram1.Location = new System.Drawing.Point(800, 225);
            this.ram1.Multiline = true;
            this.ram1.Name = "ram1";
            this.ram1.Size = new System.Drawing.Size(180, 27);
            this.ram1.TabIndex = 15;
            this.ram1.TextChanged += new System.EventHandler(this.ram1_TextChanged);
            // 
            // ssd
            // 
            this.ssd.Location = new System.Drawing.Point(800, 300);
            this.ssd.Multiline = true;
            this.ssd.Name = "ssd";
            this.ssd.Size = new System.Drawing.Size(180, 27);
            this.ssd.TabIndex = 16;
            // 
            // hdd
            // 
            this.hdd.Location = new System.Drawing.Point(1056, 300);
            this.hdd.Multiline = true;
            this.hdd.Name = "hdd";
            this.hdd.Size = new System.Drawing.Size(180, 27);
            this.hdd.TabIndex = 24;
            this.hdd.TextChanged += new System.EventHandler(this.hdd_TextChanged);
            // 
            // ram2
            // 
            this.ram2.Location = new System.Drawing.Point(1056, 225);
            this.ram2.Multiline = true;
            this.ram2.Name = "ram2";
            this.ram2.Size = new System.Drawing.Size(180, 27);
            this.ram2.TabIndex = 23;
            // 
            // ekrankarti
            // 
            this.ekrankarti.Location = new System.Drawing.Point(1056, 150);
            this.ekrankarti.Multiline = true;
            this.ekrankarti.Name = "ekrankarti";
            this.ekrankarti.Size = new System.Drawing.Size(180, 27);
            this.ekrankarti.TabIndex = 22;
            this.ekrankarti.TextChanged += new System.EventHandler(this.ekrankarti_TextChanged);
            // 
            // labelram2
            // 
            this.labelram2.AutoSize = true;
            this.labelram2.Location = new System.Drawing.Point(1053, 205);
            this.labelram2.Name = "labelram2";
            this.labelram2.Size = new System.Drawing.Size(50, 17);
            this.labelram2.TabIndex = 21;
            this.labelram2.Text = "Ram-2";
            // 
            // anakart
            // 
            this.anakart.Location = new System.Drawing.Point(1056, 75);
            this.anakart.Multiline = true;
            this.anakart.Name = "anakart";
            this.anakart.Size = new System.Drawing.Size(180, 27);
            this.anakart.TabIndex = 18;
            this.anakart.TextChanged += new System.EventHandler(this.anakart_TextChanged);
            // 
            // labelhdd
            // 
            this.labelhdd.AutoSize = true;
            this.labelhdd.Location = new System.Drawing.Point(1053, 280);
            this.labelhdd.Name = "labelhdd";
            this.labelhdd.Size = new System.Drawing.Size(38, 17);
            this.labelhdd.TabIndex = 20;
            this.labelhdd.Text = "HDD";
            // 
            // labelekrankarti
            // 
            this.labelekrankarti.AutoSize = true;
            this.labelekrankarti.Location = new System.Drawing.Point(1053, 131);
            this.labelekrankarti.Name = "labelekrankarti";
            this.labelekrankarti.Size = new System.Drawing.Size(99, 17);
            this.labelekrankarti.TabIndex = 19;
            this.labelekrankarti.Text = "Ekran Kartı(G)";
            // 
            // labelanakart
            // 
            this.labelanakart.AutoSize = true;
            this.labelanakart.Location = new System.Drawing.Point(1053, 55);
            this.labelanakart.Name = "labelanakart";
            this.labelanakart.Size = new System.Drawing.Size(78, 17);
            this.labelanakart.TabIndex = 17;
            this.labelanakart.Text = "Anakart(G)";
            // 
            // klavye
            // 
            this.klavye.Location = new System.Drawing.Point(1056, 375);
            this.klavye.Multiline = true;
            this.klavye.Name = "klavye";
            this.klavye.Size = new System.Drawing.Size(180, 27);
            this.klavye.TabIndex = 28;
            this.klavye.TextChanged += new System.EventHandler(this.klavye_TextChanged);
            // 
            // labelklavye
            // 
            this.labelklavye.AutoSize = true;
            this.labelklavye.Location = new System.Drawing.Point(1053, 355);
            this.labelklavye.Name = "labelklavye";
            this.labelklavye.Size = new System.Drawing.Size(50, 17);
            this.labelklavye.TabIndex = 27;
            this.labelklavye.Text = "Klavye";
            // 
            // monitor
            // 
            this.monitor.Location = new System.Drawing.Point(800, 375);
            this.monitor.Multiline = true;
            this.monitor.Name = "monitor";
            this.monitor.Size = new System.Drawing.Size(180, 27);
            this.monitor.TabIndex = 26;
            this.monitor.TextChanged += new System.EventHandler(this.monitor_TextChanged);
            // 
            // labelmonitor
            // 
            this.labelmonitor.AutoSize = true;
            this.labelmonitor.Location = new System.Drawing.Point(797, 355);
            this.labelmonitor.Name = "labelmonitor";
            this.labelmonitor.Size = new System.Drawing.Size(55, 17);
            this.labelmonitor.TabIndex = 25;
            this.labelmonitor.Text = "Monitör";
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(968, 450);
            this.ara.Multiline = true;
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(268, 37);
            this.ara.TabIndex = 5;
            this.ara.TextChanged += new System.EventHandler(this.ara_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Anakart",
            "İşlemci",
            "Ekran Kartı",
            "Ram",
            "SSD",
            "HDD",
            "Monitör",
            "Klavye"});
            this.comboBox1.Location = new System.Drawing.Point(800, 450);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 24);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(800, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Arama";
            // 
            // bilgisayar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1251, 706);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.klavye);
            this.Controls.Add(this.labelklavye);
            this.Controls.Add(this.monitor);
            this.Controls.Add(this.labelmonitor);
            this.Controls.Add(this.hdd);
            this.Controls.Add(this.ram2);
            this.Controls.Add(this.ekrankarti);
            this.Controls.Add(this.labelram2);
            this.Controls.Add(this.anakart);
            this.Controls.Add(this.labelhdd);
            this.Controls.Add(this.labelekrankarti);
            this.Controls.Add(this.labelanakart);
            this.Controls.Add(this.ssd);
            this.Controls.Add(this.ram1);
            this.Controls.Add(this.islemci);
            this.Controls.Add(this.labelram1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.labelssd);
            this.Controls.Add(this.labelislemci);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bilgisayar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "bilgisayar";
            this.Load += new System.EventHandler(this.bilgisayar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label labelislemci;
        private System.Windows.Forms.Label labelssd;
        private System.Windows.Forms.Label labelram1;
        private System.Windows.Forms.TextBox islemci;
        private System.Windows.Forms.TextBox ram1;
        private System.Windows.Forms.TextBox ssd;
        private System.Windows.Forms.TextBox hdd;
        private System.Windows.Forms.TextBox ram2;
        private System.Windows.Forms.TextBox ekrankarti;
        private System.Windows.Forms.Label labelram2;
        private System.Windows.Forms.TextBox anakart;
        private System.Windows.Forms.Label labelhdd;
        private System.Windows.Forms.Label labelekrankarti;
        private System.Windows.Forms.Label labelanakart;
        private System.Windows.Forms.TextBox klavye;
        private System.Windows.Forms.Label labelklavye;
        private System.Windows.Forms.TextBox monitor;
        private System.Windows.Forms.Label labelmonitor;
        private System.Windows.Forms.TextBox ara;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}