using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KafeKontrolProgramı
{
    public partial class YoneticiPaneli : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bahir\source\repos\KafeKontrolProgramı\KafeKontrolProgramı\Database1.mdf;Integrated Security=True");
        public YoneticiPaneli()
        {
            InitializeComponent();
        }

        private void YoneticiPaneliUrunDuzenleButonu_Click(object sender, EventArgs e)
        {
            this.Hide();
            UrunDuzenle sistema = new UrunDuzenle();
            sistema.ShowDialog();
            this.Close();
        }

        private void YoneticiPaneliAnasayfaButonu_Click(object sender, EventArgs e)
        {
            this.Hide();
           // Anasayfa sistema = new Anasayfa();
           // sistema.ShowDialog();
            this.Close();
        }

        

        private void YoneticiPaneliMasaDuzenleButonu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasaDuzenle sistema = new MasaDuzenle();
            sistema.ShowDialog();
            this.Close();

        }
        int kontrol = 0; //
        public void rapor()
        {
           
                if (YoneticiPaneliRaporGörüntülemeListview.Items.Count > 0)
                {
                    double hesap = 0;
                    double[] topla = new double[YoneticiPaneliRaporGörüntülemeListview.Items.Count];
                    for (int i = 0; i < YoneticiPaneliRaporGörüntülemeListview.Items.Count; i++)
                    {
                        topla[i] = Convert.ToDouble(YoneticiPaneliRaporGörüntülemeListview.Items[i].SubItems[2].Text.ToString());
                        hesap += topla[i];
                    }

                    YöneticiPaneliHesapToplamıLabel.Text = (hesap.ToString()+"₺");
                   
                }
                else
                {
                    MessageBox.Show("Henüz Satış Yok!");
                }
           
        }
        private void YoneticiPaneliRaporButonu_Click(object sender, EventArgs e)
        {
             if (kontrol == 0)
            {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Rapor", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                YoneticiPaneliRaporGörüntülemeListview.Items.Add(reader["id"].ToString());
                YoneticiPaneliRaporGörüntülemeListview.Items[YoneticiPaneliRaporGörüntülemeListview.Items.Count - 1].SubItems.Add(reader["urun"].ToString());
                YoneticiPaneliRaporGörüntülemeListview.Items[YoneticiPaneliRaporGörüntülemeListview.Items.Count - 1].SubItems.Add(reader["fiyat"].ToString());
            }
            reader.Close();
            con.Close();
                rapor();
                kontrol = 1;
            }
            else
                MessageBox.Show("Rapor zaten hesaplandı!");
        }


        
    }
}
