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
    public partial class Masalar : Form
    {
       
        public Masalar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Bahir\source\repos\KafeKontrolProgramı\KafeKontrolProgramı\Database1.mdf;Integrated Security=True");
       
        private void MasalarAnasayfaButonu_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Anasayfa sistema = new Anasayfa();
            //sistema.ShowDialog();
            this.Close();
        }
        public void teslim()
        {
                       
            if (MasalardataGridView1.Rows.Count > 0)
            {
                con.Open();
                int secili = Convert.ToInt32(MasalardataGridView1.CurrentRow.Cells[0].Value);
                SqlCommand güncelle = new SqlCommand("update " + MasalarcomboBox.Text + " set teslim = '1' where urun_id='" + secili + "'", con);
                güncelle.ExecuteNonQuery();
                con.Close();
            }
            else MessageBox.Show("Lütfen Bir Ürün Seçiniz!");


            
        }

        public void cmbox_veri()
        {
            string masalar = "select masa_adi from Masalar";
            SqlDataAdapter da = new SqlDataAdapter(masalar, con);
            con.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Masalar");
            MasalarcomboBox.DisplayMember = "masa_adi";
            MasalarcomboBox.DataSource = ds.Tables["Masalar"];
            con.Close();
        }
        public void verigöster(string s)
        {
            
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MasalardataGridView1.DataSource = ds.Tables[0];
            
        }
        
        private void MasalarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            verigöster("Select * from " + MasalarcomboBox.Text);
        }

        private void MasalarTahminiHesapButonu_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 0; i < MasalardataGridView1.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(MasalardataGridView1.Rows[i].Cells[2].Value);
            }
            MessageBox.Show("Tahmini Hesap "+Convert.ToString( toplam)+"₺");
            
        }

        private void MasalarTeslimButonu_Click(object sender, EventArgs e)
        {
            teslim();
            verigöster("Select * from " + MasalarcomboBox.Text);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbox_veri();
        }
    }
}
