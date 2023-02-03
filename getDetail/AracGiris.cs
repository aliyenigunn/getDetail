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
    public partial class AracGiris : XtraForm
    {
        public AracGiris()
        {
            InitializeComponent();
        }
        eckaDBDataContext con = new eckaDBDataContext();
        bool isEdit;

        private void AracGiris_Load(object sender, EventArgs e)
        {
            grpArac.Visible = false;
            getData();
        }
        public void getData()
        {
            con = new eckaDBDataContext();
            var aq = con.PazAraclars.ToList();
            gridControl1.DataSource = aq;
            gridView1.OptionsView.BestFitMaxRowCount = -1;
            gridView1.BestFitColumns();
        }
        public void allClear()
        {
            txtPlaka.Text = "";
            txtAciklama.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPlaka.Text != "" && txtAciklama.Text != "" )
                {
                    if (!isEdit)
                    {
                        PazAraclar add = new PazAraclar()
                        {
                            aracPlaka = txtPlaka.Text,
                            aracAciklama = txtAciklama.Text
                        };
                        con.PazAraclars.InsertOnSubmit(add);
                    }
                    else
                    {
                        string id = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "aracID").ToString();

                        PazAraclar edit = con.PazAraclars.First(x => x.aracID.ToString() == id);
                        edit.aracPlaka = txtPlaka.Text;
                        edit.aracAciklama = txtAciklama.Text;
                        isEdit = false;


                    }
                    con.SubmitChanges();
                    getData();
                    allClear();
                    XtraMessageBox.Show("Kayıt işlemi tamamlandı", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    XtraMessageBox.Show("Lütfen boşlukları doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            grpArac.Visible = true;
            try
            {
                string id = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "aracID").ToString();
                if (id != "")
                {
                    PazAraclar edit = con.PazAraclars.FirstOrDefault(x => x.aracID.ToString() == id);
                    txtPlaka.Text = edit.aracPlaka;
                    txtAciklama.Text = edit.aracAciklama;
                    isEdit = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dia = new DialogResult();
                dia = XtraMessageBox.Show("Seçili satır kalıcı olarak siliencektir! Bu işlemin geri dönüşü yoktur. Onaylıyor musunuz?", "Silme uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    if (gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "aracID").ToString() != "")
                    {
                        var z = con.PazAraclars.Where(x => x.aracID.ToString() == gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "aracID").ToString());
                        if (z.Any())
                        {
                            PazAraclar t = con.PazAraclars.FirstOrDefault(x => x.aracID.ToString() == gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "aracID").ToString());
                            con.PazAraclars.DeleteOnSubmit(t);
                            con.SubmitChanges();
                            XtraMessageBox.Show("Satır silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    else XtraMessageBox.Show("Satır seçmediniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                getData();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grpArac.Visible = true;
            isEdit = false;
        }

        private void btnGrpClose_Click(object sender, EventArgs e)
        {
            grpArac.Visible = false;
            allClear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
