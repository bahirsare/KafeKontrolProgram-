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
    public partial class MasaDuzenle : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bahir\source\repos\KafeKontrolProgramı\KafeKontrolProgramı\Database1.mdf;Integrated Security=True");
        public MasaDuzenle()
        {
            InitializeComponent();
        }
        public void verigöster(string s)
        {

            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MasaDuzenleMasaListesiDataGridView.DataSource = ds.Tables[0];
            string s1 = "Masa" + MasaDuzenleMasaListesiDataGridView.Rows.Count;
            MasaDuzenleMasaNumarasıTextbox.Text = s1;
            MasaDuzenleMasaNumarasıTextbox.Enabled = false;

        }
       
        public void masa_ekle()
        {
            
            con.Open();
            SqlCommand masa_ekle = new SqlCommand("insert into Masalar (masa_id, masa_adi) values (@masa_id,@masa_adi)", con);
            string s = "Masa" + MasaDuzenleMasaListesiDataGridView.Rows.Count;
            masa_ekle.Parameters.AddWithValue("masa_id", MasaDuzenleMasaListesiDataGridView.Rows.Count   );
            masa_ekle.Parameters.AddWithValue("masa_adi", s );
            masa_ekle.ExecuteNonQuery();
            SqlCommand tbl_ekle = new SqlCommand("CREATE TABLE [dbo].[" +s + "](urun_id int, urun char(50),fiyat float,teslim bit);", con);
            tbl_ekle.ExecuteNonQuery();
            con.Close();

        }
        public void masa_sil()
        {
            con.Open();
            SqlCommand masa_sil = new SqlCommand("delete from Masalar where masa_id= @masa_id",con);
            masa_sil.Parameters.AddWithValue("@masa_id", MasaDuzenleMasaListesiDataGridView.Rows.Count-1 );
            masa_sil.ExecuteNonQuery();
            string s = "Masa" + (MasaDuzenleMasaListesiDataGridView.Rows.Count-1).ToString();
            SqlCommand tbl_sil = new SqlCommand("DROP TABLE [dbo].["+s+ "]", con);
            tbl_sil.ExecuteNonQuery();
            con.Close();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            verigöster("Select * from Masalar");
           
        }

        private void MasaDuzenleMasaEkleButonu_Click(object sender, EventArgs e)
        {
            masa_ekle();
            verigöster("Select * from Masalar");
        }

        private void MasaDuzenleMasaSilButonu_Click(object sender, EventArgs e)
        {
            masa_sil();
            verigöster("Select * from Masalar");
        }

        private void MasaDuzenleGeridonusButonu_Click(object sender, EventArgs e)
        {
                this.Hide();
                YoneticiPaneli sistema = new YoneticiPaneli();
                sistema.ShowDialog();
                this.Close();
        }
    }
}
