using DevExpress.XtraEditors;
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
    public partial class AracSec : XtraForm
    {
        public AracSec()
        {
            InitializeComponent();
        }
        eckaDBDataContext con = new eckaDBDataContext();

        private void AracSec_Load(object sender, EventArgs e)
        {
            try
            {
                con = new eckaDBDataContext();
                var aq = con.PazAraclars.ToList();
                gridControl1.DataSource = aq;
                gridView1.OptionsView.BestFitMaxRowCount = -1;
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            string id = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "aracID").ToString();
            string plaka = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "aracPlaka").ToString();
            string aciklama = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "aracAciklama").ToString();

            if(id !="" && plaka !="" && aciklama !="")
            {
                aracContainer.aracID = int.Parse(id);
                aracContainer.aracPlaka = plaka;
                aracContainer.aracAciklama = aciklama;
                Close();
            }
        }
    }
}
