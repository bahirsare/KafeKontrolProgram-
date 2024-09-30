
namespace KafeKontrolProgramı
{
    partial class HesapOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesapOlustur));
            this.HesapOlusturAnasayfaButonu = new System.Windows.Forms.Button();
            this.HesapOlusturHesapOlusturButonu = new System.Windows.Forms.Button();
            this.HesapOlusturHesapListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.HesapOlusturOdemeOnayıButonu = new System.Windows.Forms.Button();
            this.HesapOlusturMasalarComboBox = new System.Windows.Forms.ComboBox();
            this.HesapOIusturBekleyenSiparislerListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HesapOlusturAnasayfaButonu
            // 
            this.HesapOlusturAnasayfaButonu.BackColor = System.Drawing.Color.OldLace;
            this.HesapOlusturAnasayfaButonu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HesapOlusturAnasayfaButonu.BackgroundImage")));
            this.HesapOlusturAnasayfaButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HesapOlusturAnasayfaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HesapOlusturAnasayfaButonu.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HesapOlusturAnasayfaButonu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HesapOlusturAnasayfaButonu.Location = new System.Drawing.Point(38, 301);
            this.HesapOlusturAnasayfaButonu.Name = "HesapOlusturAnasayfaButonu";
            this.HesapOlusturAnasayfaButonu.Size = new System.Drawing.Size(49, 46);
            this.HesapOlusturAnasayfaButonu.TabIndex = 25;
            this.HesapOlusturAnasayfaButonu.UseVisualStyleBackColor = false;
            this.HesapOlusturAnasayfaButonu.Click += new System.EventHandler(this.HesapOlusturAnasayfaButonu_Click);
            // 
            // HesapOlusturHesapOlusturButonu
            // 
            this.HesapOlusturHesapOlusturButonu.BackColor = System.Drawing.Color.OldLace;
            this.HesapOlusturHesapOlusturButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HesapOlusturHesapOlusturButonu.Location = new System.Drawing.Point(263, 52);
            this.HesapOlusturHesapOlusturButonu.Name = "HesapOlusturHesapOlusturButonu";
            this.HesapOlusturHesapOlusturButonu.Size = new System.Drawing.Size(121, 46);
            this.HesapOlusturHesapOlusturButonu.TabIndex = 26;
            this.HesapOlusturHesapOlusturButonu.Text = "Hesap Oluştur";
            this.HesapOlusturHesapOlusturButonu.UseVisualStyleBackColor = false;
            this.HesapOlusturHesapOlusturButonu.Click += new System.EventHandler(this.HesapOlusturHesapOlusturButonu_Click);
            // 
            // HesapOlusturHesapListview
            // 
            this.HesapOlusturHesapListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.HesapOlusturHesapListview.GridLines = true;
            this.HesapOlusturHesapListview.HideSelection = false;
            this.HesapOlusturHesapListview.Location = new System.Drawing.Point(38, 13);
            this.HesapOlusturHesapListview.Name = "HesapOlusturHesapListview";
            this.HesapOlusturHesapListview.Size = new System.Drawing.Size(189, 283);
            this.HesapOlusturHesapListview.TabIndex = 28;
            this.HesapOlusturHesapListview.UseCompatibleStateImageBehavior = false;
            this.HesapOlusturHesapListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            this.columnHeader2.Width = 70;
            // 
            // HesapOlusturOdemeOnayıButonu
            // 
            this.HesapOlusturOdemeOnayıButonu.BackColor = System.Drawing.Color.OldLace;
            this.HesapOlusturOdemeOnayıButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HesapOlusturOdemeOnayıButonu.Location = new System.Drawing.Point(263, 104);
            this.HesapOlusturOdemeOnayıButonu.Name = "HesapOlusturOdemeOnayıButonu";
            this.HesapOlusturOdemeOnayıButonu.Size = new System.Drawing.Size(121, 46);
            this.HesapOlusturOdemeOnayıButonu.TabIndex = 29;
            this.HesapOlusturOdemeOnayıButonu.Text = "Ödeme Onayı";
            this.HesapOlusturOdemeOnayıButonu.UseVisualStyleBackColor = false;
            this.HesapOlusturOdemeOnayıButonu.Click += new System.EventHandler(this.HesapOlusturOdemeOnayıButonu_Click);
            // 
            // HesapOlusturMasalarComboBox
            // 
            this.HesapOlusturMasalarComboBox.FormattingEnabled = true;
            this.HesapOlusturMasalarComboBox.Location = new System.Drawing.Point(263, 12);
            this.HesapOlusturMasalarComboBox.Name = "HesapOlusturMasalarComboBox";
            this.HesapOlusturMasalarComboBox.Size = new System.Drawing.Size(121, 23);
            this.HesapOlusturMasalarComboBox.TabIndex = 30;
            this.HesapOlusturMasalarComboBox.SelectedIndexChanged += new System.EventHandler(this.HesapOlusturMasalarComboBox_SelectedIndexChanged);
            // 
            // HesapOIusturBekleyenSiparislerListView
            // 
            this.HesapOIusturBekleyenSiparislerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.HesapOIusturBekleyenSiparislerListView.GridLines = true;
            this.HesapOIusturBekleyenSiparislerListView.HideSelection = false;
            this.HesapOIusturBekleyenSiparislerListView.Location = new System.Drawing.Point(233, 186);
            this.HesapOIusturBekleyenSiparislerListView.Name = "HesapOIusturBekleyenSiparislerListView";
            this.HesapOIusturBekleyenSiparislerListView.Size = new System.Drawing.Size(151, 109);
            this.HesapOIusturBekleyenSiparislerListView.TabIndex = 31;
            this.HesapOIusturBekleyenSiparislerListView.UseCompatibleStateImageBehavior = false;
            this.HesapOIusturBekleyenSiparislerListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bekleyen Siparişler";
            // 
            // HesapOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 353);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HesapOIusturBekleyenSiparislerListView);
            this.Controls.Add(this.HesapOlusturMasalarComboBox);
            this.Controls.Add(this.HesapOlusturOdemeOnayıButonu);
            this.Controls.Add(this.HesapOlusturHesapListview);
            this.Controls.Add(this.HesapOlusturHesapOlusturButonu);
            this.Controls.Add(this.HesapOlusturAnasayfaButonu);
            this.Name = "HesapOlustur";
            this.Text = "Hesap Oluştur";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button HesapOlusturAnasayfaButonu;
        private System.Windows.Forms.Button HesapOlusturHesapOlusturButonu;
        private System.Windows.Forms.ListView HesapOlusturHesapListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button HesapOlusturOdemeOnayıButonu;
        private System.Windows.Forms.ComboBox HesapOlusturMasalarComboBox;
        private System.Windows.Forms.ListView HesapOIusturBekleyenSiparislerListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
    }
}