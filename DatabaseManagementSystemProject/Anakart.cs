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
    public partial class Anakart : Form
    {
        public Anakart()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=Proje;user ID=postgres;password=143646");
        private void anakartekle_Click(object sender, EventArgs e)
        {
          
            baglan.Open();
            NpgsqlCommand varMi = new NpgsqlCommand("Select COUNT(anakarturunkodu) from public.anakart WHERE anakarturunkodu='" + anakartid.Text + "'", baglan);
            int sonuc = Convert.ToInt32(varMi.ExecuteScalar());
            if (sonuc != 1)
            {
                NpgsqlCommand ekleme = new NpgsqlCommand("insert into public.anakart (anakarturunkodu,marka,ramslotsayisi,maxramkapasitesi,boyutturu,depolamabirimisayisi) values (@p1,@p2,@p3,@p4,@p5,@p6) ", baglan);
                ekleme.Parameters.AddWithValue("@p1", anakartid.Text);
                ekleme.Parameters.AddWithValue("@p2", marka.Text);
                ekleme.Parameters.AddWithValue("@p3", ramslot.Text);
                ekleme.Parameters.AddWithValue("@p4", ramcap.Text);
                ekleme.Parameters.AddWithValue("@p5", tur.Text);
                ekleme.Parameters.AddWithValue("@p6", depola.Text);

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

            }
            else
            {
                MessageBox.Show("Bu Anakart Ürün Kodu zaten var");
            }
            baglan.Close();



        }

        private void listele_Click(object sender, EventArgs e)
        {
            
            string sorgu = "select * from public.anakart ";
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void anakartid_TextChanged(object sender, EventArgs e)
        {
            if (anakartid.Text != "" && marka.Text != "" && ramslot.Text != "" && ramcap.Text != "" && tur.Text != "" && depola.Text != "")
            {
                anakartekle.Enabled = true;
            }
            if(anakartid.Text != "")
            {
                anakartsil.Enabled = true;
            }
           
        }

        private void ramslot_TextChanged(object sender, EventArgs e)
        {
            if (anakartid.Text != "" && marka.Text != "" && ramslot.Text != "" && ramcap.Text != "" && tur.Text != "" && depola.Text != "")
            {
                anakartekle.Enabled = true;
            }
          
        }

        private void ramcap_TextChanged(object sender, EventArgs e)
        {
            if (anakartid.Text != "" && marka.Text != "" && ramslot.Text != "" && ramcap.Text != "" && tur.Text != "" && depola.Text != "")
            {
                anakartekle.Enabled = true;
            }
           
        }

        private void depola_TextChanged(object sender, EventArgs e)
        {
            if (anakartid.Text != "" && marka.Text != "" && ramslot.Text != "" && ramcap.Text != "" && tur.Text != "" && depola.Text != "")
            {
                anakartekle.Enabled = true;
            }
           
        }

        private void tur_TextChanged(object sender, EventArgs e)
        {
            if (anakartid.Text != "" && marka.Text != "" && ramslot.Text != "" && ramcap.Text != "" && tur.Text != "" && depola.Text != "")
            {
                anakartekle.Enabled = true;
            }
           
        }

        private void marka_TextChanged(object sender, EventArgs e)
        {
            if (anakartid.Text != "" && marka.Text != "" && ramslot.Text != "" && ramcap.Text != "" && tur.Text != "" && depola.Text != "")
            {
                anakartekle.Enabled = true;
            }
           
        }

        private void Anakart_Load(object sender, EventArgs e)
        {
            if(anakartid.Text == "" && marka.Text == "" && ramslot.Text == "" && ramcap.Text == "" && tur.Text == "" && depola.Text == "")
            {
                anakartekle.Enabled = false;
            }
            if (anakartid.Text == "")
            {
                anakartsil.Enabled = false;
            }
        }

        private void anakartsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand sil = new NpgsqlCommand("delete from public.anakart where anakarturunkodu=@p1", baglan);
            sil.Parameters.AddWithValue("@p1", anakartid.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            anakartid.Text = "";
        }
    }
}
