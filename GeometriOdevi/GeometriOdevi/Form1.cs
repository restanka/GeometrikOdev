using GeometriOdevi.Classes;
using GeometriOdevi.Classes.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometriOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bDikUcgen_Click(object sender, EventArgs e)
        {
            if (tbDikUcgenTaban.Text == "" || tbDikucgenYukseklik.Text == "")
            {
                MessageBox.Show("Lütfen Değer Giriniz!!!", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                
                bKare.Enabled = false;
                bUckenar.Enabled = false;
                bDaire.Enabled = false;
                bDikdortgen.Enabled = false;

                DikUcgen dikucgen = new DikUcgen();
                dikucgen.Taban = Convert.ToDouble(tbDikUcgenTaban.Text);
                dikucgen.Yukseklik = Convert.ToDouble(tbDikucgenYukseklik.Text);
                tbAlanSonuc.Text = dikucgen.AlanHesapla().ToString();
                tbCevreSonuc.Text = dikucgen.CevreHesapla().ToString();
            }

            
        }

        private void bKare_Click(object sender, EventArgs e)
        {
            if (tbKareTaban.Text == "" || tbKareYukseklik.Text == "")
                MessageBox.Show("Lütfen Değer Giriniz!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                
                bDikUcgen.Enabled = false;
                bUckenar.Enabled = false;
                bDaire.Enabled = false;
                bDikdortgen.Enabled = false;

                Dikdortgen kare = new Dikdortgen();
                kare.Taban = Convert.ToDouble(tbKareTaban.Text);
                kare.Yukseklik = Convert.ToDouble(tbKareYukseklik.Text);
                tbAlanSonuc.Text = kare.AlanHesapla().ToString();
                tbCevreSonuc.Text = kare.CevreHesapla().ToString(); 
            }
        }

        private void bDikdortgen_Click(object sender, EventArgs e)
        {
            if (tbDikdortgenTaban.Text == "" || tbDikdortgenYuksekil.Text == "")
            {
                MessageBox.Show("Lütfen Değer Giriniz!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                bKare.Enabled = false;
                bUckenar.Enabled = false;
                bDaire.Enabled = false;
                bDikUcgen.Enabled = false;

                Dikdortgen dikdortgen = new Dikdortgen();
                dikdortgen.Taban = Convert.ToDouble(tbKareTaban.Text);
                dikdortgen.Yukseklik = Convert.ToDouble(tbKareYukseklik.Text);
                tbAlanSonuc.Text = dikdortgen.AlanHesapla().ToString();
                tbCevreSonuc.Text = dikdortgen.CevreHesapla().ToString(); 
            }
        }

        private void bUckenar_Click(object sender, EventArgs e)
        {
            if (tbDikUcgenTaban.Text == "" || tbDikucgenYukseklik.Text == "")
            {
                MessageBox.Show("Lütfen Değer Giriniz!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                bKare.Enabled = false;
                bDikUcgen.Enabled = false;
                bDaire.Enabled = false;
                bDikdortgen.Enabled = false;

                EskenarUcgen eskenar = new EskenarUcgen();
                eskenar.Taban = Convert.ToDouble(tbKareTaban.Text);
                eskenar.Yukseklik = Convert.ToDouble(tbKareYukseklik.Text);
                tbAlanSonuc.Text = eskenar.AlanHesapla().ToString();
                tbCevreSonuc.Text = eskenar.CevreHesapla().ToString(); 
            }
        }

        private void bDaire_Click(object sender, EventArgs e)
        {
            if (tbDaireYaricap.Text == "")
            {
                MessageBox.Show("Lütfen Değer Giriniz!!!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                bKare.Enabled = false;
                bUckenar.Enabled = false;
                bDikUcgen.Enabled = false;
                bDikdortgen.Enabled = false;

                Daire daire = new Daire();

                daire.YariCap = Convert.ToDouble(tbDaireYaricap.Text);

                tbAlanSonuc.Text = daire.AlanHesapla().ToString();
                tbCevreSonuc.Text = daire.CevreHesapla().ToString();
            }
            


        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            bKare.Enabled = true;
            bDikUcgen.Enabled = true;
            bDikdortgen.Enabled = true;
            bDaire.Enabled = true;
            bUckenar.Enabled = true;
            tbKareTaban.Text = "";
            tbKareYukseklik.Text = "";
            tbDikucgenYukseklik.Text = "";
            tbDikUcgenTaban.Text = "";
            tbDaireYaricap.Text = "";
            tbEskenarUcgenTaban.Text = "";
            tbEskenarUcgenYukseklik.Text = "";
            tbDikdortgenTaban.Text = "";
            tbDikdortgenYuksekil.Text = "";
            tbAlanSonuc.Text = "";
            tbCevreSonuc.Text = "";
        }
    }
}
