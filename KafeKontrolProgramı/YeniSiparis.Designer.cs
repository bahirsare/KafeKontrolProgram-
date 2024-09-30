
namespace KafeKontrolProgramı
{
    partial class YeniSiparis
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
            this.YeniSiparisOnaylaButonu = new System.Windows.Forms.Button();
            this.YeniSiparisMasalarCombobox = new System.Windows.Forms.ComboBox();
            this.YeniSiparisIptalButonu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YeniSiparisIceceklerListview = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Ürün = new System.Windows.Forms.ColumnHeader();
            this.Fiyat = new System.Windows.Forms.ColumnHeader();
            this.YeniSiparisTatlilarListview = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.YeniSiparisYiyeceklerListview = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.YeniSiparisSiparisListview = new System.Windows.Forms.ListView();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // YeniSiparisOnaylaButonu
            // 
            this.YeniSiparisOnaylaButonu.BackColor = System.Drawing.Color.White;
            this.YeniSiparisOnaylaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YeniSiparisOnaylaButonu.Location = new System.Drawing.Point(408, 332);
            this.YeniSiparisOnaylaButonu.Name = "YeniSiparisOnaylaButonu";
            this.YeniSiparisOnaylaButonu.Size = new System.Drawing.Size(75, 23);
            this.YeniSiparisOnaylaButonu.TabIndex = 3;
            this.YeniSiparisOnaylaButonu.Text = "Onayla";
            this.YeniSiparisOnaylaButonu.UseVisualStyleBackColor = false;
            this.YeniSiparisOnaylaButonu.Click += new System.EventHandler(this.YeniSiparisOnaylaButonu_Click);
            // 
            // YeniSiparisMasalarCombobox
            // 
            this.YeniSiparisMasalarCombobox.BackColor = System.Drawing.Color.White;
            this.YeniSiparisMasalarCombobox.FormattingEnabled = true;
            this.YeniSiparisMasalarCombobox.Location = new System.Drawing.Point(352, 241);
            this.YeniSiparisMasalarCombobox.Name = "YeniSiparisMasalarCombobox";
            this.YeniSiparisMasalarCombobox.Size = new System.Drawing.Size(121, 23);
            this.YeniSiparisMasalarCombobox.TabIndex = 4;
            // 
            // YeniSiparisIptalButonu
            // 
            this.YeniSiparisIptalButonu.BackColor = System.Drawing.Color.White;
            this.YeniSiparisIptalButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YeniSiparisIptalButonu.Location = new System.Drawing.Point(408, 364);
            this.YeniSiparisIptalButonu.Name = "YeniSiparisIptalButonu";
            this.YeniSiparisIptalButonu.Size = new System.Drawing.Size(75, 23);
            this.YeniSiparisIptalButonu.TabIndex = 8;
            this.YeniSiparisIptalButonu.Text = "İptal";
            this.YeniSiparisIptalButonu.UseVisualStyleBackColor = false;
            this.YeniSiparisIptalButonu.Click += new System.EventHandler(this.YeniSiparisIptalButonu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "İçecekler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tatlılar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yiyecekler";
            // 
            // YeniSiparisIceceklerListview
            // 
            this.YeniSiparisIceceklerListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Ürün,
            this.Fiyat});
            this.YeniSiparisIceceklerListview.FullRowSelect = true;
            this.YeniSiparisIceceklerListview.GridLines = true;
            this.YeniSiparisIceceklerListview.HideSelection = false;
            this.YeniSiparisIceceklerListview.Location = new System.Drawing.Point(22, 27);
            this.YeniSiparisIceceklerListview.Name = "YeniSiparisIceceklerListview";
            this.YeniSiparisIceceklerListview.Size = new System.Drawing.Size(130, 164);
            this.YeniSiparisIceceklerListview.TabIndex = 13;
            this.YeniSiparisIceceklerListview.UseCompatibleStateImageBehavior = false;
            this.YeniSiparisIceceklerListview.View = System.Windows.Forms.View.Details;
            this.YeniSiparisIceceklerListview.SelectedIndexChanged += new System.EventHandler(this.YeniSiparisIceceklerListview_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 35;
            // 
            // Ürün
            // 
            this.Ürün.Text = "Ürün";
            this.Ürün.Width = 50;
            // 
            // Fiyat
            // 
            this.Fiyat.Text = "Fiyat";
            this.Fiyat.Width = 40;
            // 
            // YeniSiparisTatlilarListview
            // 
            this.YeniSiparisTatlilarListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.YeniSiparisTatlilarListview.FullRowSelect = true;
            this.YeniSiparisTatlilarListview.GridLines = true;
            this.YeniSiparisTatlilarListview.HideSelection = false;
            this.YeniSiparisTatlilarListview.Location = new System.Drawing.Point(191, 27);
            this.YeniSiparisTatlilarListview.Name = "YeniSiparisTatlilarListview";
            this.YeniSiparisTatlilarListview.Size = new System.Drawing.Size(130, 164);
            this.YeniSiparisTatlilarListview.TabIndex = 14;
            this.YeniSiparisTatlilarListview.UseCompatibleStateImageBehavior = false;
            this.YeniSiparisTatlilarListview.View = System.Windows.Forms.View.Details;
            this.YeniSiparisTatlilarListview.SelectedIndexChanged += new System.EventHandler(this.YeniSiparisTatlilarListview_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 35;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fiyat";
            this.columnHeader3.Width = 40;
            // 
            // YeniSiparisYiyeceklerListview
            // 
            this.YeniSiparisYiyeceklerListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.YeniSiparisYiyeceklerListview.FullRowSelect = true;
            this.YeniSiparisYiyeceklerListview.GridLines = true;
            this.YeniSiparisYiyeceklerListview.HideSelection = false;
            this.YeniSiparisYiyeceklerListview.Location = new System.Drawing.Point(352, 27);
            this.YeniSiparisYiyeceklerListview.Name = "YeniSiparisYiyeceklerListview";
            this.YeniSiparisYiyeceklerListview.Size = new System.Drawing.Size(131, 164);
            this.YeniSiparisYiyeceklerListview.TabIndex = 15;
            this.YeniSiparisYiyeceklerListview.UseCompatibleStateImageBehavior = false;
            this.YeniSiparisYiyeceklerListview.View = System.Windows.Forms.View.Details;
            this.YeniSiparisYiyeceklerListview.SelectedIndexChanged += new System.EventHandler(this.YeniSiparisYiyeceklerListview_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 35;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ürün";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fiyat";
            this.columnHeader6.Width = 40;
            // 
            // YeniSiparisSiparisListview
            // 
            this.YeniSiparisSiparisListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.YeniSiparisSiparisListview.HideSelection = false;
            this.YeniSiparisSiparisListview.Location = new System.Drawing.Point(22, 241);
            this.YeniSiparisSiparisListview.Name = "YeniSiparisSiparisListview";
            this.YeniSiparisSiparisListview.Size = new System.Drawing.Size(289, 126);
            this.YeniSiparisSiparisListview.TabIndex = 16;
            this.YeniSiparisSiparisListview.UseCompatibleStateImageBehavior = false;
            this.YeniSiparisSiparisListview.View = System.Windows.Forms.View.Details;
            this.YeniSiparisSiparisListview.SelectedIndexChanged += new System.EventHandler(this.YeniSiparisSiparisListview_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Id";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ürün";
            this.columnHeader8.Width = 170;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Fiyat";
            // 
            // YeniSiparis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 413);
            this.Controls.Add(this.YeniSiparisSiparisListview);
            this.Controls.Add(this.YeniSiparisYiyeceklerListview);
            this.Controls.Add(this.YeniSiparisTatlilarListview);
            this.Controls.Add(this.YeniSiparisIceceklerListview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YeniSiparisIptalButonu);
            this.Controls.Add(this.YeniSiparisMasalarCombobox);
            this.Controls.Add(this.YeniSiparisOnaylaButonu);
            this.Name = "YeniSiparis";
            this.Text = "Yeni Sipariş";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button YeniSiparisOnaylaButonu;
        private System.Windows.Forms.ComboBox YeniSiparisMasalarCombobox;
        private System.Windows.Forms.Button YeniSiparisIptalButonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView YeniSiparisIceceklerListview;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Ürün;
        private System.Windows.Forms.ColumnHeader Fiyat;
        private System.Windows.Forms.ListView YeniSiparisTatlilarListview;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView YeniSiparisYiyeceklerListview;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView YeniSiparisSiparisListview;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}