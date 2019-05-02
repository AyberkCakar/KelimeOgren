﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOgren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEVLA_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 0;
        }

        private void btnKelimeOgren_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 1;
        }

        private void btnOgrenmismiyim_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 2;
        }

        private void btnOgrendiklerim_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 3;
        }

        private void btnBilgi_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPageIndex = 4;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sayac = 0;

        Kelime kelime = new Kelime();
        private void btnOgrenBack_Click(object sender, EventArgs e)
        {
            sayac--;
            kelime.UyeKelimeOgren(sayac);
            foreach (Kelime sec in kelime.SeciliKelime )
            {
                lblTur.Text = sec.Turu;
                lblKelime.Text = sec.Turkce;
                lblIng.Text = sec.Ingilizce;
                lblOrn.Text = sec.OrnCumle;
                lblOrnTurk.Text = sec.TurkceCumle;
                pictureBox1.ImageLocation = sec.Resim;
            }
            kelime.SeciliKelime.Clear();


        }

        private void btnOgrenNext_Click(object sender, EventArgs e)
        {
            kelime.UyeKelimeOgren(sayac);
            foreach (Kelime sec in kelime.SeciliKelime)
            {
                lblTur.Text = sec.Turu;
                lblKelime.Text = sec.Turkce;
                lblIng.Text = sec.Ingilizce;
                lblOrn.Text = sec.OrnCumle;
                lblOrnTurk.Text = sec.TurkceCumle;
                pictureBox1.ImageLocation = sec.Resim;
                
            }
            sayac++;
            kelime.SeciliKelime.Clear();
        }
    }
}
