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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("server=localHost;port=5432;Database=Proje;user ID=postgres;password=143646");

      
        private void giris_Click(object sender, EventArgs e)
        {
            bool blnfound = false;
           
            baglan.Open();
            NpgsqlCommand command = new NpgsqlCommand("Select * from public.giris where kullaniciadi= '" + kadi.Text + "' and sifre = '" + sifre.Text + "'", baglan);
            NpgsqlDataReader dataread = command.ExecuteReader();
            
            if (dataread.Read())
            {
                blnfound = true;
                giris girisyap = new giris();
                
                MessageBox.Show("Giriş Sağlandı");
                this.Hide();
                girisyap.Show();
            }
            if(blnfound == false)
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
            baglan.Close();
            dataread.Close();
         
            }

        private void kayitol_Click(object sender, EventArgs e)
        {
            kayit kaydol = new kayit();
            kaydol.Show();
        }

      
    }
}
