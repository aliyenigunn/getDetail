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
    public partial class YakitGiris : XtraForm
    {
        public YakitGiris()
        {
            InitializeComponent();
        }
        eckaDBDataContext con = new eckaDBDataContext();
        bool isEdit;

        private void YakitGiris_Load(object sender, EventArgs e)
        {
            grpYakit.Visible = false;
            getData();
        }
        public void getData()
        {
            try
            {
                var q = con.VW_ARACYAKITDETAYs.ToList();
                gridControl1.DataSource = q;
                gridView1.OptionsView.BestFitMaxRowCount = -1;
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void allClear()
        {
            btnAracSec.Text = "";
            txtAciklama.Text = "";
            txtLitre.Text = "";
            txtTutar.Text = "";
            cbAy.Text = "";
            cbPeriod.Text = "";
        }

        private void btnAracSec_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            AracSec arac = new AracSec(); arac.ShowDialog();
            btnAracSec.Text = aracContainer.aracPlaka;
            txtAciklama.Text = aracContainer.aracAciklama;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAracSec.Text != "" && txtAciklama.Text != "" && txtLitre.Text != "" && txtTutar.Text != "" && cbAy.Text != "" && cbPeriod.Text != "" )
                {
                    if (!isEdit)
                    {
                        PazYakitlar add = new PazYakitlar()
                        {
                            aracID = aracContainer.aracID,
                            litre=Convert.ToDecimal(txtLitre.Text),
                            tutar = Convert.ToDecimal(txtTutar.Text),
                            ay = Convert.ToInt32(cbAy.Text),
                            periyod = Convert.ToInt32(cbPeriod.Text),
                            tarih =DateTime.Now.ToString()
                        };
                        con.PazYakitlars.InsertOnSubmit(add);
                    }
                    else
                    {
                        string id = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "yakitID").ToString();

                        PazYakitlar edit = con.PazYakitlars.First(x => x.yakitID.ToString() == id);
                        edit.aracID = aracContainer.aracID;
                        edit.litre = Convert.ToDecimal(txtLitre.Text);
                        edit.tutar = Convert.ToDecimal(txtTutar.Text);
                        edit.ay = Convert.ToInt32(cbAy.Text);
                        edit.periyod = Convert.ToInt32(cbPeriod.Text);
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
            //grpYakit.Visible = true;
            //try
            //{
            //    string id = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "yakitID").ToString();
            //    if (id != "")
            //    {
            //        PazYakitlar edit = con.PazYakitlars.FirstOrDefault(x => x.yakitID.ToString() == id);
            //        txt.Text = edit.envAdi;
            //        txtAnaGrubu.Text = edit.envAnaGrup;
            //        txtMarka.Text = edit.envMarka;
            //        txtModel.Text = edit.envModel;
            //        txtSeriNo.Text = edit.envSeriNo;
            //        txtMiktar.Text = edit.envMiktar.ToString();
            //        cbBulunduguYer.Text = edit.envKonum;
            //        txtSorumlu.Text = edit.envSorumlu;
            //        isEdit = true;
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dia = new DialogResult();
                dia = XtraMessageBox.Show("Seçili satır kalıcı olarak siliencektir! Bu işlemin geri dönüşü yoktur. Onaylıyor musunuz?", "Silme uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    if (gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "yakitID").ToString() != "")
                    {
                        var z = con.PazYakitlars.Where(x => x.yakitID.ToString() == gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "yakitID").ToString());
                        if (z.Any())
                        {
                            PazYakitlar t = con.PazYakitlars.FirstOrDefault(x => x.yakitID.ToString() == gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "yakitID").ToString());
                            con.PazYakitlars.DeleteOnSubmit(t);
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
            grpYakit.Visible = true;
            isEdit = false;
        }

        private void btnGrpClose_Click(object sender, EventArgs e)
        {
            grpYakit.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
