﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseManagementSystemProject
{
    public partial class Monitor : Form
    {
        public Monitor()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=Proje;user ID=postgres;password=143646");
        private void listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from public.monitor ";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand varMi = new NpgsqlCommand("Select COUNT(monitorurunkodu) from public.monitor WHERE monitorurunkodu='" + monitorid.Text + "'", baglan);
            int sonuc = Convert.ToInt32(varMi.ExecuteScalar());
            if (sonuc != 1)
            {
                NpgsqlCommand ekleme = new NpgsqlCommand("insert into public.monitor (monitorurunkodu,panelboyutu,panelturu,uretici) values (@p1,@p2,@p3,@p4) ", baglan);
                ekleme.Parameters.AddWithValue("@p1", monitorid.Text);
                ekleme.Parameters.AddWithValue("@p2", int.Parse(boyut.Text));
                ekleme.Parameters.AddWithValue("@p3", paneltur.Text);
                ekleme.Parameters.AddWithValue("@p4", uretici.Text);



                ekleme.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Eklendi.");
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                monitorid.Text = "";

            }
            else
            {
                MessageBox.Show("Bu Monitör Ürün Kodu zaten var");
            }
            baglan.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from public.monitor where monitorurunkodu=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", monitorid.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            monitorid.Text = "";
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            ekle.Enabled = false;
            sil.Enabled = false;
        }

        private void hddid_TextChanged(object sender, EventArgs e)
        {
            if (monitorid.Text != "" && boyut.Text != "" && paneltur.Text != "" && uretici.Text != "")
            {
                ekle.Enabled = true;
            }
            if (monitorid.Text != "")
            {
                sil.Enabled = true;
            }
        }

        private void paneltur_TextChanged(object sender, EventArgs e)
        {
            if (monitorid.Text != "" && boyut.Text != "" && paneltur.Text != "" && uretici.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void boyut_TextChanged(object sender, EventArgs e)
        {
            if (monitorid.Text != "" && boyut.Text != "" && paneltur.Text != "" && uretici.Text != "")
            {
                ekle.Enabled = true;
            }
        }

        private void uretici_TextChanged(object sender, EventArgs e)
        {
            if (monitorid.Text != "" && boyut.Text != "" && paneltur.Text != "" && uretici.Text != "")
            {
                ekle.Enabled = true;
            }
        }
    }
}
