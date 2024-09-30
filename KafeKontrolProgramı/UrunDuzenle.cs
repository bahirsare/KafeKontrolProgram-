using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KafeKontrolProgramı
{
    public partial class UrunDuzenle : Form
    {
        public UrunDuzenle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bahir\source\repos\KafeKontrolProgramı\KafeKontrolProgramı\Database1.mdf;Integrated Security=True");
        private void UrunDuzenleAnasayfaButonu_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Anasayfa sistema = new Anasayfa();
            //sistema.ShowDialog();
            this.Close();
        }

        public void verigöster(string s)
        {
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            UrunDuzenleListeDataGridView.DataSource = ds.Tables[0];
        }
        public void kaydet()
        {
            con.Open();
            SqlCommand kaydet = new SqlCommand("insert into " + UrunDuzenleTurCombobox.Text + "(Id,urun,fiyat) values (@Id,@urun,@fiyat)", con);
            if (UrunDuzenleTurCombobox.Text == "Icecek")
               kaydet.Parameters.AddWithValue("@Id", UrunDuzenleListeDataGridView.Rows.Count + 101);
            else if (UrunDuzenleTurCombobox.Text == "Tatli")
                kaydet.Parameters.AddWithValue("@Id", UrunDuzenleListeDataGridView.Rows.Count + 201);
            else if (UrunDuzenleTurCombobox.Text == "Yiyecek")
                kaydet.Parameters.AddWithValue("@Id", UrunDuzenleListeDataGridView.Rows.Count + 301);

            kaydet.Parameters.AddWithValue("@urun", UrunDuzenleUrunAdıTextbox.Text);
            kaydet.Parameters.AddWithValue("@fiyat", UrunDuzenleFiyatTextbox.Text);
            kaydet.ExecuteNonQuery();
            verigöster("select *from " + UrunDuzenleTurCombobox.Text);
            con.Close();
        }
        public void sil()
        {
            con.Open();
            SqlCommand sil = new SqlCommand("delete from " + UrunDuzenleTurCombobox.Text + " where id=@id ", con);
            sil.Parameters.AddWithValue("@id", UrunDuzenleIdTextbox.Text);
            sil.ExecuteNonQuery();
            verigöster("select *from " + UrunDuzenleTurCombobox.Text);
            con.Close();
            
        }
        public void guncelle()
        {
            con.Open();
            SqlCommand güncelle = new SqlCommand("update " +UrunDuzenleTurCombobox.Text+ " set urun='"+UrunDuzenleUrunAdıTextbox.Text+ "', fiyat= '"+UrunDuzenleFiyatTextbox.Text+ "'  where id= '"+UrunDuzenleIdTextbox.Text+ "'", con);
            güncelle.ExecuteNonQuery();
            verigöster("select *from " + UrunDuzenleTurCombobox.Text);
            con.Close();
        }
        public void ara()
        {
            
            con.Open();
            SqlCommand ara = new SqlCommand("Select * from " + UrunDuzenleTurCombobox.Text +" where urun like '%"+UrunDuzenleUrunAdıTextbox.Text+ "%'", con);
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataSet ds = new DataSet();
            da.Fill(ds);
            UrunDuzenleListeDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        private void UrunDuzenleEkleButonu_Click(object sender, EventArgs e)
        {
            if ((UrunDuzenleTurCombobox.SelectedIndex>=0)&&(UrunDuzenleUrunAdıTextbox.Text != "") && (UrunDuzenleFiyatTextbox.Text != ""))
            {

                kaydet();
                UrunDuzenleUrunAdıTextbox.Clear();
                UrunDuzenleFiyatTextbox.Clear();
                UrunDuzenleIdTextbox.Clear();

                MessageBox.Show("Ürün veri tabanına eklendi");
            }
            else
                MessageBox.Show("Lütfen eksiksiz doldurunuz");
        }

      
        private void UrunDuzenleSilButonu_Click(object sender, EventArgs e)
        {
            if (UrunDuzenleIdTextbox.Text != "")
            {

                sil();
                UrunDuzenleUrunAdıTextbox.Clear();
                UrunDuzenleFiyatTextbox.Clear();
                UrunDuzenleIdTextbox.Clear();

                MessageBox.Show("Ürün silindi");
            }
            else
                MessageBox.Show("Lütfen ID giriniz"); 
        }
       

        private void UrunDuzenleTurCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            verigöster("select *from " +UrunDuzenleTurCombobox.Text );
        }

        private void UrunDuzenleGüncelleButonu_Click(object sender, EventArgs e)
        {
            guncelle();
            UrunDuzenleUrunAdıTextbox.Clear();
            UrunDuzenleFiyatTextbox.Clear();
            UrunDuzenleIdTextbox.Clear();
        }

        private void UrunDuzenleAraButonu_Click(object sender, EventArgs e)
        {
            
            if (UrunDuzenleTurCombobox.SelectedIndex >= 0)
            {
                if ((UrunDuzenleIdTextbox.Text != "") || (UrunDuzenleUrunAdıTextbox.Text != "") || (UrunDuzenleFiyatTextbox.Text != ""))
                {
                    ara();
                    UrunDuzenleUrunAdıTextbox.Clear();
                    UrunDuzenleFiyatTextbox.Clear();
                    UrunDuzenleIdTextbox.Clear();
                }
                else
                    MessageBox.Show("Lütfen bir değer giriniz!");
            }
            else
                MessageBox.Show("Lütfen bir tür seçiniz!");
        }

        private void UrunDuzenleListeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = UrunDuzenleListeDataGridView.SelectedCells[0].RowIndex;
            UrunDuzenleIdTextbox.Text = UrunDuzenleListeDataGridView.Rows[secili].Cells[0].Value.ToString();
            UrunDuzenleUrunAdıTextbox.Text = UrunDuzenleListeDataGridView.Rows[secili].Cells[1].Value.ToString();
            UrunDuzenleFiyatTextbox.Text = UrunDuzenleListeDataGridView.Rows[secili].Cells[2].Value.ToString();
        }

        private void UrunDuzenleGeridonusButonu_Click(object sender, EventArgs e)
        {
            this.Hide();
            YoneticiPaneli sistema = new YoneticiPaneli();
            sistema.ShowDialog();
            this.Close();
            
        }

       
    }
    
}
