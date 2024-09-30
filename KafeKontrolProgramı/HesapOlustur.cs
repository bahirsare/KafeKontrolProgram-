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

    public partial class HesapOlustur : Form
    {
        int kontrol = 0; //
        public HesapOlustur()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bahir\source\repos\KafeKontrolProgramı\KafeKontrolProgramı\Database1.mdf;Integrated Security=True");
        private void HesapOlusturAnasayfaButonu_Click(object sender, EventArgs e)
           
        {
            this.Hide();
            //Anasayfa sistema = new Anasayfa();
            //sistema.ShowDialog();
            this.Close();
        }


        
        private void HesapOlusturHesapOlusturButonu_Click(object sender, EventArgs e)
        {
            if (kontrol == 0)
            {
                if (HesapOIusturBekleyenSiparislerListView.Items.Count > 0)
                {
                    DialogResult dialog1 = new DialogResult();
                    dialog1 = MessageBox.Show("Teslim Edilmemiş Siparişler Var. Hesap Oluşturulsun mu?", "Uyarı", MessageBoxButtons.YesNo);
                    if (dialog1 == DialogResult.Yes)
                        hesap();
                }
                else
                    hesap();
                        
            }
            else
                MessageBox.Show("Hesap zaten oluşturuldu!");
        }
        public void hesap()
        {
            if (HesapOlusturHesapListview.Items.Count > 0)
            {
                double hesap = 0;
                double[] topla = new double[HesapOlusturHesapListview.Items.Count];
                for (int i = 0; i < HesapOlusturHesapListview.Items.Count; i++)
                {
                    topla[i] = Convert.ToDouble(HesapOlusturHesapListview.Items[i].SubItems[1].Text.ToString());
                    hesap = hesap + topla[i];
                }

                string[] hesaplama = { "Toplam Tutar", hesap.ToString() };
                var hsp = new ListViewItem(hesaplama);
                HesapOlusturHesapListview.Items.Add(hsp);
                kontrol = 1;

            }
            else
            {
                MessageBox.Show("Teslim Edilen Sipariş Yok");
            }
        }

        private void HesapOlusturMasalarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            HesapOlusturHesapListview.Items.Clear();
            HesapOIusturBekleyenSiparislerListView.Items.Clear();

            verigoster("select urun, fiyat from " + HesapOlusturMasalarComboBox.Text + " Where teslim=1 ");
            BekleyenSiparis("select urun, fiyat from " + HesapOlusturMasalarComboBox.Text + " Where teslim=0 ");

        }
        public void BekleyenSiparis(string s)
        {
            ListViewItem urun = new ListViewItem();
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand hesap = new SqlCommand(s, con);
            SqlDataReader reader = hesap.ExecuteReader();
            while (reader.Read())
            {
                urun = HesapOIusturBekleyenSiparislerListView.Items.Add(reader.GetString(0));
                urun.SubItems.Add(reader.GetDouble(1).ToString());
            }
            reader.Close();
            con.Close();
        }
        public void verigoster(string s)
        {
            ListViewItem urun = new ListViewItem();
            if (con.State != ConnectionState.Open)
                con.Open();
            SqlCommand hesap = new SqlCommand(s, con);
            SqlDataReader reader = hesap.ExecuteReader();
            while (reader.Read())
            {
                urun = HesapOlusturHesapListview.Items.Add(reader.GetString(0));
                urun.SubItems.Add(reader.GetDouble(1).ToString());
            }
            reader.Close();
            con.Close();
        }
        public void rapor()
        {
            con.Open();
            SqlCommand rapor = new SqlCommand("insert into Rapor values (@urun,@fiyat) ", con);
            
            
            rapor.Parameters.Add("@urun", SqlDbType.NVarChar);
            rapor.Parameters.Add("@fiyat", SqlDbType.Int);

            for (int i = 0; i < HesapOlusturHesapListview.Items.Count-1; i++)
            {
                rapor.Parameters["@urun"].Value = HesapOlusturHesapListview.Items[i].SubItems[0].Text;
                rapor.Parameters["@fiyat"].Value = HesapOlusturHesapListview.Items[i].SubItems[1].Text;
                rapor.ExecuteNonQuery();
            }
            con.Close();
        }
        public void OdemeOnayı()
        {
            rapor();
            con.Open();
            SqlCommand odeme = new SqlCommand("DELETE FROM " + HesapOlusturMasalarComboBox.Text + " where teslim=1  ", con);
            odeme.ExecuteNonQuery();
            con.Close();
            HesapOlusturHesapListview.Items.Clear();
            verigoster("select urun, fiyat from " + HesapOlusturMasalarComboBox.Text + " where teslim=1  ");
            kontrol = 0;
        }
        private void HesapOlusturOdemeOnayıButonu_Click(object sender, EventArgs e)
        {
            if (kontrol == 1)
            {
                if (HesapOIusturBekleyenSiparislerListView.Items.Count > 0)
                {
                    DialogResult dialog1 = new DialogResult();
                    dialog1 = MessageBox.Show("Teslim Edilmemiş Siparişler Silinsin Mi?", "Uyarı", MessageBoxButtons.YesNo);
                    if (dialog1 == DialogResult.Yes)
                    {
                        OdemeOnayı();
                        HesapOIusturBekleyenSiparislerListView.Items.Clear();
                    }
                    else
                    {
                        OdemeOnayı();
                    }
                } else
                {
                    OdemeOnayı();
                }
            }
            else
                MessageBox.Show("Lütfen Hesap Oluşturunuz");
        }

        public void cmbox_veri()
        {
            con.Open();
            string masalar = "select masa_adi from Masalar";
            SqlDataAdapter da = new SqlDataAdapter(masalar, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Masalar");
            HesapOlusturMasalarComboBox.DisplayMember = "masa_adi";
            HesapOlusturMasalarComboBox.DataSource = ds.Tables["Masalar"];
            con.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            cmbox_veri();
           
        }

        
    }
}

