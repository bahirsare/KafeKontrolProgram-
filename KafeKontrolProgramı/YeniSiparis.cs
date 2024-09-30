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
    public partial class YeniSiparis : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bahir\source\repos\KafeKontrolProgramı\KafeKontrolProgramı\Database1.mdf;Integrated Security=True");
        
            
            int siparis_id=0;
        public YeniSiparis()
        {
            InitializeComponent();
        }

        public void cmbox_veri()
        {
            string masalar = "select masa_adi from Masalar";
            SqlDataAdapter da = new SqlDataAdapter(masalar, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Masalar");
            YeniSiparisMasalarCombobox.DisplayMember = "masa_adi";
            YeniSiparisMasalarCombobox.DataSource = ds.Tables["Masalar"];
            con.Close();
        }
        private void YeniSiparisOnaylaButonu_Click(object sender, EventArgs e)
        {
            if (YeniSiparisSiparisListview.Items.Count == 0 )
            {
                MessageBox.Show("Lütfen siparişi giriniz.");
            }
            else if (YeniSiparisMasalarCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen masa seçiniz.");
            }
            else
            {
               
                con.Open();
                SqlCommand siparis = new SqlCommand("insert into [" + YeniSiparisMasalarCombobox.Text + "](urun_id,urun,fiyat,teslim) values (@urun_id,@urun,@fiyat,@teslim)", con);
                siparis.Parameters.Add("@teslim", SqlDbType.Bit);
                
                siparis.Parameters.Add("@urun_id", SqlDbType.Int);
                siparis.Parameters.Add("@urun", SqlDbType.NVarChar);
                siparis.Parameters.Add("@fiyat", SqlDbType.Int);

                for (int i = 0; i < YeniSiparisSiparisListview.Items.Count; i++)
                {
                   
                    siparis.Parameters["@urun_id"].Value = YeniSiparisSiparisListview.Items[i].SubItems[0].Text;
                    siparis.Parameters["@urun"].Value = YeniSiparisSiparisListview.Items[i].SubItems[1].Text;
                    siparis.Parameters["@fiyat"].Value = YeniSiparisSiparisListview.Items[i].SubItems[2].Text;
                    siparis.Parameters["@teslim"].Value = false;
                    siparis.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Siparis alindi.");
                this.Hide();
                Anasayfa sistema = new Anasayfa();
                sistema.ShowDialog();
                this.Close();
            }
        }
        
        

        
        private void Form2_Load(object sender, EventArgs e)
        {
            cmbox_veri();

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from icecek", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                YeniSiparisIceceklerListview.Items.Add(reader["Id"].ToString());
                YeniSiparisIceceklerListview.Items[YeniSiparisIceceklerListview.Items.Count - 1].SubItems.Add(reader["Urun"].ToString());
                YeniSiparisIceceklerListview.Items[YeniSiparisIceceklerListview.Items.Count - 1].SubItems.Add(reader["Fiyat"].ToString());
            }
            reader.Close();
            con.Close();

            con.Open();

            SqlCommand cmd2 = new SqlCommand("select * from tatli", con);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                YeniSiparisTatlilarListview.Items.Add(reader2["Id"].ToString());
                YeniSiparisTatlilarListview.Items[YeniSiparisTatlilarListview.Items.Count - 1].SubItems.Add(reader2["Urun"].ToString());
                YeniSiparisTatlilarListview.Items[YeniSiparisTatlilarListview.Items.Count - 1].SubItems.Add(reader2["Fiyat"].ToString());
            }

            reader2.Close();
            con.Close();
            con.Open();


            SqlCommand cmd3 = new SqlCommand("select * from yiyecek", con);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                YeniSiparisYiyeceklerListview.Items.Add(reader3["Id"].ToString());
                YeniSiparisYiyeceklerListview.Items[YeniSiparisYiyeceklerListview.Items.Count - 1].SubItems.Add(reader3["Urun"].ToString());
                YeniSiparisYiyeceklerListview.Items[YeniSiparisYiyeceklerListview.Items.Count - 1].SubItems.Add(reader3["Fiyat"].ToString());
            }


            reader3.Close();
            con.Close();

        }
        private void YeniSiparisIptalButonu_Click(object sender, EventArgs e)
        {
           
            //this.Hide();
            //Anasayfa sistema = new Anasayfa();
            //sistema.ShowDialog();
            this.Close();

        }

        private void YeniSiparisIceceklerListview_SelectedIndexChanged(object sender, EventArgs e)
        {
               
            if (YeniSiparisIceceklerListview.SelectedItems.Count > 0)
              YeniSiparisSiparisListview.Items.Add((ListViewItem)YeniSiparisIceceklerListview.SelectedItems[0].Clone());
            YeniSiparisSiparisListview.Items[YeniSiparisSiparisListview.Items.Count-1].SubItems.Add(siparis_id.ToString());
        }
        private void YeniSiparisTatlilarListview_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (YeniSiparisTatlilarListview.SelectedItems.Count > 0)

                YeniSiparisSiparisListview.Items.Add((ListViewItem)YeniSiparisTatlilarListview.SelectedItems[0].Clone());
            YeniSiparisSiparisListview.Items[YeniSiparisSiparisListview.Items.Count - 1].SubItems.Add(siparis_id.ToString());
        }
        private void YeniSiparisYiyeceklerListview_SelectedIndexChanged(object sender, EventArgs e)
        {            
            
            if (YeniSiparisYiyeceklerListview.SelectedItems.Count > 0)
                YeniSiparisSiparisListview.Items.Add((ListViewItem)YeniSiparisYiyeceklerListview.SelectedItems[0].Clone());
            YeniSiparisSiparisListview.Items[YeniSiparisSiparisListview.Items.Count - 1].SubItems.Add(siparis_id.ToString());

        }        
        private void YeniSiparisSiparisListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if (YeniSiparisSiparisListview.SelectedItems.Count > 0)
                YeniSiparisSiparisListview.Items.Remove((ListViewItem)YeniSiparisSiparisListview.SelectedItems[0]);
            
        }

       
    }
}
