using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKontrolProgramı
{
    public partial class Anasayfa : Form
    {

        public Anasayfa()
        {
            
            InitializeComponent();
        }

        private void AnasayfaYeniSiparisButonu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            YeniSiparis sistema = new YeniSiparis();
            sistema.ShowDialog();
            //this.Close();

        }
        

        private void AnasayfaMasalarButonu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Masalar sistema = new Masalar();
            sistema.ShowDialog();
            //this.Close();
        }

        private void AnasayfaHesapOlusturButonu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            HesapOlustur sistema = new HesapOlustur();
            sistema.ShowDialog();
            //this.Close();
        }

        private void AnasayfaYoneticiPaneliButonu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            YoneticiPaneli sistema = new YoneticiPaneli();
            sistema.ShowDialog();
            //this.Close();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
