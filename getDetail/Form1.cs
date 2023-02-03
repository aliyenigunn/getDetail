using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getDetail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext con = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            con = new DataClasses1DataContext();
            var q = con.CTN_SATICIBAZLIMALIYETKARZARARs.Where(x =>x.FaturaTuru =="Alınan Hizmet Faturası").ToList();
            gridControl1.DataSource = q;
            //gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.BestFitMaxRowCount = -1;
            gridView1.BestFitColumns();
        }
        public void getDataMonth(int ay)
        {
            con = new DataClasses1DataContext();
            var q = con.CTN_SATICIBAZLIMALIYETKARZARARs.Where(x => x.FaturaTuru == "Alınan Hizmet Faturası" && x.Ay ==ay).ToList();
            gridControl1.DataSource = q;
            //gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.OptionsView.BestFitMaxRowCount = -1;
            gridView1.BestFitColumns();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            cd(".xlsx");
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            using (var bmp = new Bitmap(gridControl1.Width,gridControl1.Height))
            {
                try
                {
                    gridControl1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    string newPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Resimler\\";
                    if (!System.IO.Directory.Exists(newPath))
                    {
                        System.IO.Directory.CreateDirectory(newPath);
                    }
                    string adi = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "MalHizmetAdi").ToString();
                    bmp.Save(newPath + adi + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Resim kaydedildi");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
       
        void cd(string format)
        {
            try
            {
                string  cr;
                string adi = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "MalHizmetAdi").ToString();
                cr = "";
                string newPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Raporlar\\" ;
                if (!System.IO.Directory.Exists(newPath))
                {
                    System.IO.Directory.CreateDirectory(newPath);
                }

                if (format == ".xlsx")
                {
                    cr = newPath+ adi.Trim().Replace(" ", string.Empty) + ".xlsx";
                    gridControl1.ExportToXlsx(cr);
                }

                if (cr != "")
                {
                    DialogResult dia = MessageBox.Show("Rapor " + adi + "  olarak kaydedildi. \nRaporunuzu şimdi görüntülemek ister misiniz?", "Ecka Reporter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dia == DialogResult.Yes)
                    {

                        System.Diagnostics.Process.Start("EXCEL.exe", cr);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnOcak_Click(object sender, EventArgs e)
        {
            getDataMonth(1);
        }

        private void btnSubat_Click(object sender, EventArgs e)
        {
            getDataMonth(2);
        }

        private void btnMart_Click(object sender, EventArgs e)
        {
            getDataMonth(3);
        }

        private void btnNisan_Click(object sender, EventArgs e)
        {
            getDataMonth(4);
        }

        private void btnMayis_Click(object sender, EventArgs e)
        {
            getDataMonth(5);
        }

        private void btnHaziran_Click(object sender, EventArgs e)
        {
            getDataMonth(6);
        }

        private void btnTemmuz_Click(object sender, EventArgs e)
        {
            getDataMonth(7);
        }

        private void btnAgustos_Click(object sender, EventArgs e)
        {
            getDataMonth(8);
        }

        private void btnEylul_Click(object sender, EventArgs e)
        {
            getDataMonth(9);
        }

        private void btnEkim_Click(object sender, EventArgs e)
        {
            getDataMonth(10);
        }

        private void btnKasim_Click(object sender, EventArgs e)
        {
            getDataMonth(11);
        }

        private void btnAralik_Click(object sender, EventArgs e)
        {
            getDataMonth(12);
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            EnvanterList qr = new EnvanterList(); qr.ShowDialog();
        }

        private void btnYakit_Click(object sender, EventArgs e)
        {
            YakitGiris yg = new YakitGiris(); yg.ShowDialog();
        }

        private void btnAraclar_Click(object sender, EventArgs e)
        {
            AracGiris ag = new AracGiris(); ag.ShowDialog();
        }

        private void btnBarkodIslem_Click(object sender, EventArgs e)
        {
            StokBarkod sb = new StokBarkod(); sb.ShowDialog();
        }
    }
}
