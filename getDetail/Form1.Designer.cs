
namespace getDetail
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnAraclar = new DevExpress.XtraEditors.SimpleButton();
            this.btnYakit = new DevExpress.XtraEditors.SimpleButton();
            this.btnQR = new DevExpress.XtraEditors.SimpleButton();
            this.btnSS = new DevExpress.XtraEditors.SimpleButton();
            this.btnExcel = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAralik = new DevExpress.XtraEditors.SimpleButton();
            this.btnKasim = new DevExpress.XtraEditors.SimpleButton();
            this.btnEkim = new DevExpress.XtraEditors.SimpleButton();
            this.btnEylul = new DevExpress.XtraEditors.SimpleButton();
            this.btnMart = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgustos = new DevExpress.XtraEditors.SimpleButton();
            this.btnNisan = new DevExpress.XtraEditors.SimpleButton();
            this.btnMayis = new DevExpress.XtraEditors.SimpleButton();
            this.btnHaziran = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemmuz = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubat = new DevExpress.XtraEditors.SimpleButton();
            this.btnOcak = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Plasiyer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CariKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CariAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StokAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Birim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NetTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnBarkodIslem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBarkodIslem);
            this.panelControl1.Controls.Add(this.btnAraclar);
            this.panelControl1.Controls.Add(this.btnYakit);
            this.panelControl1.Controls.Add(this.btnQR);
            this.panelControl1.Controls.Add(this.btnSS);
            this.panelControl1.Controls.Add(this.btnExcel);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1490, 50);
            this.panelControl1.TabIndex = 0;
            // 
            // btnAraclar
            // 
            this.btnAraclar.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAraclar.Appearance.Options.UseFont = true;
            this.btnAraclar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAraclar.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAraclar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAraclar.ImageOptions.SvgImage")));
            this.btnAraclar.Location = new System.Drawing.Point(922, 2);
            this.btnAraclar.Name = "btnAraclar";
            this.btnAraclar.Size = new System.Drawing.Size(230, 46);
            this.btnAraclar.TabIndex = 4;
            this.btnAraclar.Text = "Araç Girişi";
            this.btnAraclar.Click += new System.EventHandler(this.btnAraclar_Click);
            // 
            // btnYakit
            // 
            this.btnYakit.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYakit.Appearance.Options.UseFont = true;
            this.btnYakit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYakit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnYakit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnYakit.ImageOptions.SvgImage")));
            this.btnYakit.Location = new System.Drawing.Point(692, 2);
            this.btnYakit.Name = "btnYakit";
            this.btnYakit.Size = new System.Drawing.Size(230, 46);
            this.btnYakit.TabIndex = 3;
            this.btnYakit.Text = "Yakıt Girişi";
            this.btnYakit.Click += new System.EventHandler(this.btnYakit_Click);
            // 
            // btnQR
            // 
            this.btnQR.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQR.Appearance.Options.UseFont = true;
            this.btnQR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQR.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnQR.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnQR.ImageOptions.SvgImage")));
            this.btnQR.Location = new System.Drawing.Point(462, 2);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(230, 46);
            this.btnQR.TabIndex = 2;
            this.btnQR.Text = "Envanter Listesi";
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnSS
            // 
            this.btnSS.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSS.Appearance.Options.UseFont = true;
            this.btnSS.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSS.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSS.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSS.ImageOptions.SvgImage")));
            this.btnSS.Location = new System.Drawing.Point(232, 2);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(230, 46);
            this.btnSS.TabIndex = 1;
            this.btnSS.Text = "Ekran Görüntüsü Al";
            this.btnSS.Click += new System.EventHandler(this.btnSS_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcel.Appearance.Options.UseFont = true;
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExcel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExcel.ImageOptions.SvgImage")));
            this.btnExcel.Location = new System.Drawing.Point(2, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(230, 46);
            this.btnExcel.TabIndex = 0;
            this.btnExcel.Text = "Excel\'e Aktar";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.btnAralik);
            this.panelControl2.Controls.Add(this.btnKasim);
            this.panelControl2.Controls.Add(this.btnEkim);
            this.panelControl2.Controls.Add(this.btnEylul);
            this.panelControl2.Controls.Add(this.btnMart);
            this.panelControl2.Controls.Add(this.btnAgustos);
            this.panelControl2.Controls.Add(this.btnNisan);
            this.panelControl2.Controls.Add(this.btnMayis);
            this.panelControl2.Controls.Add(this.btnHaziran);
            this.panelControl2.Controls.Add(this.btnTemmuz);
            this.panelControl2.Controls.Add(this.btnSubat);
            this.panelControl2.Controls.Add(this.btnOcak);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 50);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(47, 516);
            this.panelControl2.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 25);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "AYLAR";
            // 
            // btnAralik
            // 
            this.btnAralik.Location = new System.Drawing.Point(5, 478);
            this.btnAralik.Name = "btnAralik";
            this.btnAralik.Size = new System.Drawing.Size(36, 34);
            this.btnAralik.TabIndex = 13;
            this.btnAralik.Text = "12";
            this.btnAralik.Click += new System.EventHandler(this.btnAralik_Click);
            // 
            // btnKasim
            // 
            this.btnKasim.Location = new System.Drawing.Point(6, 438);
            this.btnKasim.Name = "btnKasim";
            this.btnKasim.Size = new System.Drawing.Size(36, 34);
            this.btnKasim.TabIndex = 12;
            this.btnKasim.Text = "11";
            this.btnKasim.Click += new System.EventHandler(this.btnKasim_Click);
            // 
            // btnEkim
            // 
            this.btnEkim.Location = new System.Drawing.Point(5, 398);
            this.btnEkim.Name = "btnEkim";
            this.btnEkim.Size = new System.Drawing.Size(36, 34);
            this.btnEkim.TabIndex = 11;
            this.btnEkim.Text = "10";
            this.btnEkim.Click += new System.EventHandler(this.btnEkim_Click);
            // 
            // btnEylul
            // 
            this.btnEylul.Location = new System.Drawing.Point(5, 358);
            this.btnEylul.Name = "btnEylul";
            this.btnEylul.Size = new System.Drawing.Size(36, 34);
            this.btnEylul.TabIndex = 10;
            this.btnEylul.Text = "9";
            this.btnEylul.Click += new System.EventHandler(this.btnEylul_Click);
            // 
            // btnMart
            // 
            this.btnMart.Location = new System.Drawing.Point(6, 118);
            this.btnMart.Name = "btnMart";
            this.btnMart.Size = new System.Drawing.Size(36, 34);
            this.btnMart.TabIndex = 9;
            this.btnMart.Text = "3";
            this.btnMart.Click += new System.EventHandler(this.btnMart_Click);
            // 
            // btnAgustos
            // 
            this.btnAgustos.Location = new System.Drawing.Point(6, 318);
            this.btnAgustos.Name = "btnAgustos";
            this.btnAgustos.Size = new System.Drawing.Size(36, 34);
            this.btnAgustos.TabIndex = 8;
            this.btnAgustos.Text = "8";
            this.btnAgustos.Click += new System.EventHandler(this.btnAgustos_Click);
            // 
            // btnNisan
            // 
            this.btnNisan.Location = new System.Drawing.Point(6, 158);
            this.btnNisan.Name = "btnNisan";
            this.btnNisan.Size = new System.Drawing.Size(36, 34);
            this.btnNisan.TabIndex = 7;
            this.btnNisan.Text = "4";
            this.btnNisan.Click += new System.EventHandler(this.btnNisan_Click);
            // 
            // btnMayis
            // 
            this.btnMayis.Location = new System.Drawing.Point(5, 198);
            this.btnMayis.Name = "btnMayis";
            this.btnMayis.Size = new System.Drawing.Size(36, 34);
            this.btnMayis.TabIndex = 6;
            this.btnMayis.Text = "5";
            this.btnMayis.Click += new System.EventHandler(this.btnMayis_Click);
            // 
            // btnHaziran
            // 
            this.btnHaziran.Location = new System.Drawing.Point(6, 238);
            this.btnHaziran.Name = "btnHaziran";
            this.btnHaziran.Size = new System.Drawing.Size(36, 34);
            this.btnHaziran.TabIndex = 5;
            this.btnHaziran.Text = "6";
            this.btnHaziran.Click += new System.EventHandler(this.btnHaziran_Click);
            // 
            // btnTemmuz
            // 
            this.btnTemmuz.Location = new System.Drawing.Point(6, 278);
            this.btnTemmuz.Name = "btnTemmuz";
            this.btnTemmuz.Size = new System.Drawing.Size(36, 34);
            this.btnTemmuz.TabIndex = 4;
            this.btnTemmuz.Text = "7";
            this.btnTemmuz.Click += new System.EventHandler(this.btnTemmuz_Click);
            // 
            // btnSubat
            // 
            this.btnSubat.Location = new System.Drawing.Point(5, 78);
            this.btnSubat.Name = "btnSubat";
            this.btnSubat.Size = new System.Drawing.Size(36, 34);
            this.btnSubat.TabIndex = 3;
            this.btnSubat.Text = "2";
            this.btnSubat.Click += new System.EventHandler(this.btnSubat_Click);
            // 
            // btnOcak
            // 
            this.btnOcak.Location = new System.Drawing.Point(6, 38);
            this.btnOcak.Name = "btnOcak";
            this.btnOcak.Size = new System.Drawing.Size(36, 34);
            this.btnOcak.TabIndex = 2;
            this.btnOcak.Text = "1";
            this.btnOcak.Click += new System.EventHandler(this.btnOcak_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(47, 50);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1443, 516);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tarih,
            this.Plasiyer,
            this.CariKod,
            this.CariAdı,
            this.StokKod,
            this.StokAdı,
            this.Birim,
            this.Miktar,
            this.NetTutar,
            this.Aciklama});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // Tarih
            // 
            this.Tarih.Caption = "Tarih";
            this.Tarih.FieldName = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 0;
            this.Tarih.Width = 119;
            // 
            // Plasiyer
            // 
            this.Plasiyer.Caption = "Plasiyer";
            this.Plasiyer.FieldName = "SatisElemani";
            this.Plasiyer.Name = "Plasiyer";
            this.Plasiyer.Visible = true;
            this.Plasiyer.VisibleIndex = 1;
            this.Plasiyer.Width = 119;
            // 
            // CariKod
            // 
            this.CariKod.Caption = "CariKod";
            this.CariKod.FieldName = "CariKodu";
            this.CariKod.Name = "CariKod";
            this.CariKod.Visible = true;
            this.CariKod.VisibleIndex = 2;
            this.CariKod.Width = 93;
            // 
            // CariAdı
            // 
            this.CariAdı.Caption = "CariAdı";
            this.CariAdı.FieldName = "CariAdi";
            this.CariAdı.Name = "CariAdı";
            this.CariAdı.Visible = true;
            this.CariAdı.VisibleIndex = 3;
            this.CariAdı.Width = 123;
            // 
            // StokKod
            // 
            this.StokKod.Caption = "StokKod";
            this.StokKod.FieldName = "MalHizmetKodu";
            this.StokKod.Name = "StokKod";
            this.StokKod.Visible = true;
            this.StokKod.VisibleIndex = 4;
            this.StokKod.Width = 123;
            // 
            // StokAdı
            // 
            this.StokAdı.Caption = "StokAdı";
            this.StokAdı.FieldName = "MalHizmetAdi";
            this.StokAdı.Name = "StokAdı";
            this.StokAdı.Visible = true;
            this.StokAdı.VisibleIndex = 5;
            this.StokAdı.Width = 123;
            // 
            // Birim
            // 
            this.Birim.Caption = "Birim";
            this.Birim.FieldName = "Birim";
            this.Birim.Name = "Birim";
            this.Birim.Visible = true;
            this.Birim.VisibleIndex = 6;
            this.Birim.Width = 211;
            // 
            // Miktar
            // 
            this.Miktar.Caption = "Miktar";
            this.Miktar.FieldName = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.Visible = true;
            this.Miktar.VisibleIndex = 7;
            this.Miktar.Width = 87;
            // 
            // NetTutar
            // 
            this.NetTutar.Caption = "NetTutar";
            this.NetTutar.DisplayFormat.FormatString = "c";
            this.NetTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NetTutar.FieldName = "NetTutar";
            this.NetTutar.GroupFormat.FormatString = "c";
            this.NetTutar.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NetTutar.Name = "NetTutar";
            this.NetTutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetTutar", "Toplam ={0:c}")});
            this.NetTutar.Visible = true;
            this.NetTutar.VisibleIndex = 8;
            this.NetTutar.Width = 79;
            // 
            // Aciklama
            // 
            this.Aciklama.Caption = "Aciklama";
            this.Aciklama.FieldName = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Visible = true;
            this.Aciklama.VisibleIndex = 9;
            // 
            // btnBarkodIslem
            // 
            this.btnBarkodIslem.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBarkodIslem.Appearance.Options.UseFont = true;
            this.btnBarkodIslem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBarkodIslem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnBarkodIslem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btnBarkodIslem.Location = new System.Drawing.Point(1152, 2);
            this.btnBarkodIslem.Name = "btnBarkodIslem";
            this.btnBarkodIslem.Size = new System.Drawing.Size(230, 46);
            this.btnBarkodIslem.TabIndex = 5;
            this.btnBarkodIslem.Text = "Barkod İşlemleri";
            this.btnBarkodIslem.Click += new System.EventHandler(this.btnBarkodIslem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 566);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Şekeroğlu Pazarlama Rapor Detayları";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSS;
        private DevExpress.XtraEditors.SimpleButton btnExcel;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAralik;
        private DevExpress.XtraEditors.SimpleButton btnKasim;
        private DevExpress.XtraEditors.SimpleButton btnEkim;
        private DevExpress.XtraEditors.SimpleButton btnEylul;
        private DevExpress.XtraEditors.SimpleButton btnMart;
        private DevExpress.XtraEditors.SimpleButton btnAgustos;
        private DevExpress.XtraEditors.SimpleButton btnNisan;
        private DevExpress.XtraEditors.SimpleButton btnMayis;
        private DevExpress.XtraEditors.SimpleButton btnHaziran;
        private DevExpress.XtraEditors.SimpleButton btnTemmuz;
        private DevExpress.XtraEditors.SimpleButton btnSubat;
        private DevExpress.XtraEditors.SimpleButton btnOcak;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn Plasiyer;
        private DevExpress.XtraGrid.Columns.GridColumn CariKod;
        private DevExpress.XtraGrid.Columns.GridColumn CariAdı;
        private DevExpress.XtraGrid.Columns.GridColumn StokKod;
        private DevExpress.XtraGrid.Columns.GridColumn StokAdı;
        private DevExpress.XtraGrid.Columns.GridColumn Birim;
        private DevExpress.XtraGrid.Columns.GridColumn Miktar;
        private DevExpress.XtraGrid.Columns.GridColumn NetTutar;
        private DevExpress.XtraGrid.Columns.GridColumn Aciklama;
        private DevExpress.XtraEditors.SimpleButton btnQR;
        private DevExpress.XtraEditors.SimpleButton btnYakit;
        private DevExpress.XtraEditors.SimpleButton btnAraclar;
        private DevExpress.XtraEditors.SimpleButton btnBarkodIslem;
    }
}

