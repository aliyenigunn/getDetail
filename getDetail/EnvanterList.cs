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
    public partial class EnvanterList : XtraForm
    {
        public EnvanterList()
        {
            InitializeComponent();
        }
        DataClasses1DataContext con = new DataClasses1DataContext();
        bool isEdit;
        private void EnvanterList_Load(object sender, EventArgs e)
        {
            grpDegerler.Visible = false;
            grpQR.Visible = false;
            lblPic.Visible = false;
            pictureBox1.Visible = false;
            getData();
        }
        public void getData()
        {
            con = new DataClasses1DataContext();
            var aq = con.PAZ_ENVANTERLİSTEs.ToList();
            gridControl1.DataSource = aq;
            gridView1.OptionsView.BestFitMaxRowCount = -1;
            gridView1.BestFitColumns();
        }
        public void allClear()
        {
            txtUrunAdi.Text = "";
            txtAnaGrubu.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            txtSeriNo.Text = "";
            txtMiktar.Text = "";
            cbBulunduguYer.Text = "";
            txtSorumlu.Text = "";
            cbDurum.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtUrunAdi.Text != "" && txtAnaGrubu.Text != "" && txtMarka.Text != "" && txtModel.Text != "" && txtSeriNo.Text != "" && txtMiktar.Text != "" && cbBulunduguYer.Text != "" && txtSorumlu.Text != "")
                {
                    if (!isEdit)
                    {
                        PAZ_ENVANTERLİSTE add = new PAZ_ENVANTERLİSTE()
                        {
                            envAdi = txtUrunAdi.Text.ToString(),
                            envAnaGrup = txtAnaGrubu.Text.ToString(),
                            envMarka = txtMarka.Text.ToString(),
                            envModel = txtModel.Text.ToString(),
                            envSeriNo = txtSeriNo.Text.ToString(),
                            envMiktar = Convert.ToInt32(txtMiktar.Text),
                            envKonum = cbBulunduguYer.Text.ToString(),
                            envSorumlu = txtSorumlu.Text.ToString(),
                            envDurum = cbDurum.Text.ToString()
                        };
                        con.PAZ_ENVANTERLİSTEs.InsertOnSubmit(add);
                    }
                    else
                    {
                        string id = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "envID").ToString();
                        
                        PAZ_ENVANTERLİSTE edit = con.PAZ_ENVANTERLİSTEs.First(x => x.envID.ToString() == id);
                        edit.envAdi = txtUrunAdi.Text.ToString();
                        edit.envAnaGrup = txtAnaGrubu.Text.ToString();
                        edit.envMarka = txtMarka.Text.ToString();
                        edit.envModel = txtModel.Text.ToString();
                        edit.envSeriNo = txtSeriNo.Text.ToString();
                        edit.envMiktar = Convert.ToInt32(txtMiktar.Text);
                        edit.envKonum = cbBulunduguYer.Text.ToString();
                        edit.envSorumlu = txtSorumlu.Text.ToString();
                        edit.envDurum = cbDurum.Text.ToString();
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
            grpDegerler.Visible = true;
            try
            {
                string id = gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "envID").ToString();
                if (id != "" )
                {
                    PAZ_ENVANTERLİSTE edit = con.PAZ_ENVANTERLİSTEs.FirstOrDefault(x => x.envID.ToString() == id);
                    txtUrunAdi.Text = edit.envAdi;
                    txtAnaGrubu.Text = edit.envAnaGrup;
                    txtMarka.Text = edit.envMarka;
                    txtModel.Text = edit.envModel;
                    txtSeriNo.Text = edit.envSeriNo;
                    txtMiktar.Text = edit.envMiktar.ToString();
                    cbBulunduguYer.Text = edit.envKonum;
                    txtSorumlu.Text = edit.envSorumlu;
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
                    if (gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "envID").ToString() != "")
                    {
                        var z = con.PAZ_ENVANTERLİSTEs.Where(x => x.envID.ToString() == gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "envID").ToString());
                        if (z.Any())
                        {
                            PAZ_ENVANTERLİSTE t = con.PAZ_ENVANTERLİSTEs.FirstOrDefault(x => x.envID.ToString() == gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "envID").ToString());
                            con.PAZ_ENVANTERLİSTEs.DeleteOnSubmit(t);
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
            grpDegerler.Visible = true;
            isEdit = false;
        }
        
        private void btnGroupClose_Click(object sender, EventArgs e)
        {
            grpDegerler.Visible = false;
            allClear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            grpQR.Visible = true;
            
        }

        private void btnQrSave_Click(object sender, EventArgs e)
        {
            try
            {
                XtraMessageBox.Show("Çok yakında", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //lblPic.Visible = true;
                //pictureBox1.Visible = true;

                //if(cbMekan.Text !="")
                //{
                //    var q = con.PAZ_ENVANTERLİSTEs.Where(x => x.envKonum == cbMekan.Text).ToList();
                //    gridControl1.DataSource = q;
                //}
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnQrClose_Click(object sender, EventArgs e)
        {
            grpQR.Visible =false;
            getData();
        }

        
    }
}
