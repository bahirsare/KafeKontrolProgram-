
namespace KafeKontrolProgramı
{
    partial class UrunDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunDuzenle));
            this.UrunDuzenleUrunAdıTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UrunDuzenleFiyatTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UrunDuzenleEkleButonu = new System.Windows.Forms.Button();
            this.UrunDuzenleSilButonu = new System.Windows.Forms.Button();
            this.UrunDuzenleTurCombobox = new System.Windows.Forms.ComboBox();
            this.UrunDuzenleListeDataGridView = new System.Windows.Forms.DataGridView();
            this.UrunDuzenleGüncelleButonu = new System.Windows.Forms.Button();
            this.UrunDuzenleIdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UrunDuzenleAraButonu = new System.Windows.Forms.Button();
            this.UrunDuzenleAnasayfaButonu = new System.Windows.Forms.Button();
            this.UrunDuzenleGeridonusButonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UrunDuzenleListeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UrunDuzenleUrunAdıTextbox
            // 
            this.UrunDuzenleUrunAdıTextbox.BackColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleUrunAdıTextbox.Location = new System.Drawing.Point(66, 114);
            this.UrunDuzenleUrunAdıTextbox.Name = "UrunDuzenleUrunAdıTextbox";
            this.UrunDuzenleUrunAdıTextbox.Size = new System.Drawing.Size(100, 23);
            this.UrunDuzenleUrunAdıTextbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı";
            // 
            // UrunDuzenleFiyatTextbox
            // 
            this.UrunDuzenleFiyatTextbox.BackColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleFiyatTextbox.Location = new System.Drawing.Point(66, 143);
            this.UrunDuzenleFiyatTextbox.Name = "UrunDuzenleFiyatTextbox";
            this.UrunDuzenleFiyatTextbox.Size = new System.Drawing.Size(100, 23);
            this.UrunDuzenleFiyatTextbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fiyat";
            // 
            // UrunDuzenleEkleButonu
            // 
            this.UrunDuzenleEkleButonu.BackColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleEkleButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UrunDuzenleEkleButonu.Location = new System.Drawing.Point(12, 302);
            this.UrunDuzenleEkleButonu.Name = "UrunDuzenleEkleButonu";
            this.UrunDuzenleEkleButonu.Size = new System.Drawing.Size(154, 23);
            this.UrunDuzenleEkleButonu.TabIndex = 12;
            this.UrunDuzenleEkleButonu.Text = "Ekle";
            this.UrunDuzenleEkleButonu.UseVisualStyleBackColor = false;
            this.UrunDuzenleEkleButonu.Click += new System.EventHandler(this.UrunDuzenleEkleButonu_Click);
            // 
            // UrunDuzenleSilButonu
            // 
            this.UrunDuzenleSilButonu.BackColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleSilButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UrunDuzenleSilButonu.Location = new System.Drawing.Point(238, 302);
            this.UrunDuzenleSilButonu.Name = "UrunDuzenleSilButonu";
            this.UrunDuzenleSilButonu.Size = new System.Drawing.Size(210, 23);
            this.UrunDuzenleSilButonu.TabIndex = 13;
            this.UrunDuzenleSilButonu.Text = "Sil";
            this.UrunDuzenleSilButonu.UseVisualStyleBackColor = false;
            this.UrunDuzenleSilButonu.Click += new System.EventHandler(this.UrunDuzenleSilButonu_Click);
            // 
            // UrunDuzenleTurCombobox
            // 
            this.UrunDuzenleTurCombobox.BackColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleTurCombobox.FormattingEnabled = true;
            this.UrunDuzenleTurCombobox.Items.AddRange(new object[] {
            "Icecek",
            "Tatli",
            "Yiyecek"});
            this.UrunDuzenleTurCombobox.Location = new System.Drawing.Point(12, 34);
            this.UrunDuzenleTurCombobox.Name = "UrunDuzenleTurCombobox";
            this.UrunDuzenleTurCombobox.Size = new System.Drawing.Size(121, 23);
            this.UrunDuzenleTurCombobox.TabIndex = 16;
            this.UrunDuzenleTurCombobox.Text = "Tür seçiniz";
            this.UrunDuzenleTurCombobox.SelectedIndexChanged += new System.EventHandler(this.UrunDuzenleTurCombobox_SelectedIndexChanged);
            // 
            // UrunDuzenleListeDataGridView
            // 
            this.UrunDuzenleListeDataGridView.AllowUserToAddRows = false;
            this.UrunDuzenleListeDataGridView.AllowUserToDeleteRows = false;
            this.UrunDuzenleListeDataGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleListeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UrunDuzenleListeDataGridView.GridColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleListeDataGridView.Location = new System.Drawing.Point(204, 34);
            this.UrunDuzenleListeDataGridView.Name = "UrunDuzenleListeDataGridView";
            this.UrunDuzenleListeDataGridView.ReadOnly = true;
            this.UrunDuzenleListeDataGridView.RowTemplate.Height = 25;
            this.UrunDuzenleListeDataGridView.Size = new System.Drawing.Size(544, 183);
            this.UrunDuzenleListeDataGridView.TabIndex = 19;
            this.UrunDuzenleListeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UrunDuzenleListeDataGridView_CellClick);
            // 
            // UrunDuzenleGüncelleButonu
            // 
            this.UrunDuzenleGüncelleButonu.BackColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleGüncelleButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UrunDuzenleGüncelleButonu.Location = new System.Drawing.Point(238, 343);
            this.UrunDuzenleGüncelleButonu.Name = "UrunDuzenleGüncelleButonu";
            this.UrunDuzenleGüncelleButonu.Size = new System.Drawing.Size(210, 23);
            this.UrunDuzenleGüncelleButonu.TabIndex = 20;
            this.UrunDuzenleGüncelleButonu.Text = "Güncelle";
            this.UrunDuzenleGüncelleButonu.UseVisualStyleBackColor = false;
            this.UrunDuzenleGüncelleButonu.Click += new System.EventHandler(this.UrunDuzenleGüncelleButonu_Click);
            // 
            // UrunDuzenleIdTextbox
            // 
            this.UrunDuzenleIdTextbox.BackColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleIdTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UrunDuzenleIdTextbox.Location = new System.Drawing.Point(66, 82);
            this.UrunDuzenleIdTextbox.Name = "UrunDuzenleIdTextbox";
            this.UrunDuzenleIdTextbox.PlaceholderText = "silmek için ID giriniz";
            this.UrunDuzenleIdTextbox.Size = new System.Drawing.Size(100, 23);
            this.UrunDuzenleIdTextbox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(6, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // UrunDuzenleAraButonu
            // 
            this.UrunDuzenleAraButonu.BackColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleAraButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UrunDuzenleAraButonu.Location = new System.Drawing.Point(483, 302);
            this.UrunDuzenleAraButonu.Name = "UrunDuzenleAraButonu";
            this.UrunDuzenleAraButonu.Size = new System.Drawing.Size(210, 23);
            this.UrunDuzenleAraButonu.TabIndex = 23;
            this.UrunDuzenleAraButonu.Text = "Ara";
            this.UrunDuzenleAraButonu.UseVisualStyleBackColor = false;
            this.UrunDuzenleAraButonu.Click += new System.EventHandler(this.UrunDuzenleAraButonu_Click);
            // 
            // UrunDuzenleAnasayfaButonu
            // 
            this.UrunDuzenleAnasayfaButonu.BackColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleAnasayfaButonu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UrunDuzenleAnasayfaButonu.BackgroundImage")));
            this.UrunDuzenleAnasayfaButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UrunDuzenleAnasayfaButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UrunDuzenleAnasayfaButonu.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UrunDuzenleAnasayfaButonu.Location = new System.Drawing.Point(67, 343);
            this.UrunDuzenleAnasayfaButonu.Name = "UrunDuzenleAnasayfaButonu";
            this.UrunDuzenleAnasayfaButonu.Size = new System.Drawing.Size(49, 46);
            this.UrunDuzenleAnasayfaButonu.TabIndex = 27;
            this.UrunDuzenleAnasayfaButonu.UseVisualStyleBackColor = false;
            this.UrunDuzenleAnasayfaButonu.Click += new System.EventHandler(this.UrunDuzenleAnasayfaButonu_Click);
            // 
            // UrunDuzenleGeridonusButonu
            // 
            this.UrunDuzenleGeridonusButonu.BackColor = System.Drawing.Color.OldLace;
            this.UrunDuzenleGeridonusButonu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UrunDuzenleGeridonusButonu.BackgroundImage")));
            this.UrunDuzenleGeridonusButonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UrunDuzenleGeridonusButonu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UrunDuzenleGeridonusButonu.Font = new System.Drawing.Font("Ink Free", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UrunDuzenleGeridonusButonu.Location = new System.Drawing.Point(12, 343);
            this.UrunDuzenleGeridonusButonu.Name = "UrunDuzenleGeridonusButonu";
            this.UrunDuzenleGeridonusButonu.Size = new System.Drawing.Size(49, 46);
            this.UrunDuzenleGeridonusButonu.TabIndex = 29;
            this.UrunDuzenleGeridonusButonu.UseVisualStyleBackColor = false;
            this.UrunDuzenleGeridonusButonu.Click += new System.EventHandler(this.UrunDuzenleGeridonusButonu_Click);
            // 
            // UrunDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 425);
            this.Controls.Add(this.UrunDuzenleGeridonusButonu);
            this.Controls.Add(this.UrunDuzenleAnasayfaButonu);
            this.Controls.Add(this.UrunDuzenleAraButonu);
            this.Controls.Add(this.UrunDuzenleIdTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrunDuzenleGüncelleButonu);
            this.Controls.Add(this.UrunDuzenleListeDataGridView);
            this.Controls.Add(this.UrunDuzenleTurCombobox);
            this.Controls.Add(this.UrunDuzenleSilButonu);
            this.Controls.Add(this.UrunDuzenleEkleButonu);
            this.Controls.Add(this.UrunDuzenleFiyatTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UrunDuzenleUrunAdıTextbox);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Name = "UrunDuzenle";
            this.Text = "Ürün Düzenle";
            ((System.ComponentModel.ISupportInitialize)(this.UrunDuzenleListeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UrunDuzenleUrunAdıTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UrunDuzenleFiyatTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UrunDuzenleEkleButonu;
        private System.Windows.Forms.Button UrunDuzenleSilButonu;
        private System.Windows.Forms.ComboBox UrunDuzenleTurCombobox;
        private System.Windows.Forms.DataGridView UrunDuzenleListeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button UrunDuzenleGüncelleButonu;
        private System.Windows.Forms.TextBox UrunDuzenleIdTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UrunDuzenleAraButonu;
        private System.Windows.Forms.Button UrunDuzenleAnasayfaButonu;
        private System.Windows.Forms.Button UrunDuzenleGeridonusButonu;
    }
}