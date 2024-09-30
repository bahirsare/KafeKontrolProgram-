
namespace KafeKontrolProgramı
{
    partial class YoneticiPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiPaneli));
            this.YoneticiPaneliUrunDuzenleButonu = new System.Windows.Forms.Button();
            this.YoneticiPaneliRaporGörüntülemeListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.YoneticiPaneliAnasayfaButonu = new System.Windows.Forms.Button();
            this.YoneticiPaneliMasaDuzenleButonu = new System.Windows.Forms.Button();
            this.YoneticiPaneliRaporButonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.YöneticiPaneliHesapToplamıLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YoneticiPaneliUrunDuzenleButonu
            // 
            this.YoneticiPaneliUrunDuzenleButonu.BackColor = System.Drawing.Color.OldLace;
            this.YoneticiPaneliUrunDuzenleButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YoneticiPaneliUrunDuzenleButonu.Location = new System.Drawing.Point(200, 210);
            this.YoneticiPaneliUrunDuzenleButonu.Name = "YoneticiPaneliUrunDuzenleButonu";
            this.YoneticiPaneliUrunDuzenleButonu.Size = new System.Drawing.Size(162, 36);
            this.YoneticiPaneliUrunDuzenleButonu.TabIndex = 0;
            this.YoneticiPaneliUrunDuzenleButonu.Text = "Ürün Düzenle";
            this.YoneticiPaneliUrunDuzenleButonu.UseVisualStyleBackColor = false;
            this.YoneticiPaneliUrunDuzenleButonu.Click += new System.EventHandler(this.YoneticiPaneliUrunDuzenleButonu_Click);
            // 
            // YoneticiPaneliRaporGörüntülemeListview
            // 
            this.YoneticiPaneliRaporGörüntülemeListview.BackColor = System.Drawing.Color.OldLace;
            this.YoneticiPaneliRaporGörüntülemeListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.YoneticiPaneliRaporGörüntülemeListview.HideSelection = false;
            this.YoneticiPaneliRaporGörüntülemeListview.Location = new System.Drawing.Point(254, 12);
            this.YoneticiPaneliRaporGörüntülemeListview.Name = "YoneticiPaneliRaporGörüntülemeListview";
            this.YoneticiPaneliRaporGörüntülemeListview.Size = new System.Drawing.Size(289, 150);
            this.YoneticiPaneliRaporGörüntülemeListview.TabIndex = 2;
            this.YoneticiPaneliRaporGörüntülemeListview.UseCompatibleStateImageBehavior = false;
            this.YoneticiPaneliRaporGörüntülemeListview.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            this.columnHeader3.Width = 85;
            // 
            // YoneticiPaneliAnasayfaButonu
            // 
            this.YoneticiPaneliAnasayfaButonu.BackColor = System.Drawing.Color.OldLace;
            this.YoneticiPaneliAnasayfaButonu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YoneticiPaneliAnasayfaButonu.BackgroundImage")));
            this.YoneticiPaneliAnasayfaButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YoneticiPaneliAnasayfaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YoneticiPaneliAnasayfaButonu.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YoneticiPaneliAnasayfaButonu.Location = new System.Drawing.Point(38, 256);
            this.YoneticiPaneliAnasayfaButonu.Name = "YoneticiPaneliAnasayfaButonu";
            this.YoneticiPaneliAnasayfaButonu.Size = new System.Drawing.Size(49, 46);
            this.YoneticiPaneliAnasayfaButonu.TabIndex = 26;
            this.YoneticiPaneliAnasayfaButonu.UseVisualStyleBackColor = false;
            this.YoneticiPaneliAnasayfaButonu.Click += new System.EventHandler(this.YoneticiPaneliAnasayfaButonu_Click);
            // 
            // YoneticiPaneliMasaDuzenleButonu
            // 
            this.YoneticiPaneliMasaDuzenleButonu.BackColor = System.Drawing.Color.OldLace;
            this.YoneticiPaneliMasaDuzenleButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YoneticiPaneliMasaDuzenleButonu.Location = new System.Drawing.Point(368, 210);
            this.YoneticiPaneliMasaDuzenleButonu.Name = "YoneticiPaneliMasaDuzenleButonu";
            this.YoneticiPaneliMasaDuzenleButonu.Size = new System.Drawing.Size(162, 36);
            this.YoneticiPaneliMasaDuzenleButonu.TabIndex = 27;
            this.YoneticiPaneliMasaDuzenleButonu.Text = "Masa Düzenle";
            this.YoneticiPaneliMasaDuzenleButonu.UseVisualStyleBackColor = false;
            this.YoneticiPaneliMasaDuzenleButonu.Click += new System.EventHandler(this.YoneticiPaneliMasaDuzenleButonu_Click);
            // 
            // YoneticiPaneliRaporButonu
            // 
            this.YoneticiPaneliRaporButonu.BackColor = System.Drawing.Color.OldLace;
            this.YoneticiPaneliRaporButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YoneticiPaneliRaporButonu.Location = new System.Drawing.Point(38, 72);
            this.YoneticiPaneliRaporButonu.Name = "YoneticiPaneliRaporButonu";
            this.YoneticiPaneliRaporButonu.Size = new System.Drawing.Size(162, 41);
            this.YoneticiPaneliRaporButonu.TabIndex = 28;
            this.YoneticiPaneliRaporButonu.Text = "Rapor";
            this.YoneticiPaneliRaporButonu.UseVisualStyleBackColor = false;
            this.YoneticiPaneliRaporButonu.Click += new System.EventHandler(this.YoneticiPaneliRaporButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Toplam Satış";
            // 
            // YöneticiPaneliHesapToplamıLabel
            // 
            this.YöneticiPaneliHesapToplamıLabel.AutoSize = true;
            this.YöneticiPaneliHesapToplamıLabel.Location = new System.Drawing.Point(417, 169);
            this.YöneticiPaneliHesapToplamıLabel.Name = "YöneticiPaneliHesapToplamıLabel";
            this.YöneticiPaneliHesapToplamıLabel.Size = new System.Drawing.Size(10, 15);
            this.YöneticiPaneliHesapToplamıLabel.TabIndex = 30;
            this.YöneticiPaneliHesapToplamıLabel.Text = " ";
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(578, 322);
            this.Controls.Add(this.YöneticiPaneliHesapToplamıLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YoneticiPaneliRaporButonu);
            this.Controls.Add(this.YoneticiPaneliMasaDuzenleButonu);
            this.Controls.Add(this.YoneticiPaneliAnasayfaButonu);
            this.Controls.Add(this.YoneticiPaneliRaporGörüntülemeListview);
            this.Controls.Add(this.YoneticiPaneliUrunDuzenleButonu);
            this.Name = "YoneticiPaneli";
            this.Text = "Yönetici Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button YoneticiPaneliUrunDuzenleButonu;
        private System.Windows.Forms.ListView YoneticiPaneliRaporGörüntülemeListview;
        private System.Windows.Forms.Button YoneticiPaneliAnasayfaButonu;
        private System.Windows.Forms.Button YoneticiPaneliMasaDuzenleButonu;
        private System.Windows.Forms.Button YoneticiPaneliRaporButonu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label YöneticiPaneliHesapToplamıLabel;
    }
}