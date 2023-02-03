
namespace getDetail
{
    partial class StokBarkod
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
            DevExpress.XtraPrinting.BarCode.EAN13Generator eaN13Generator1 = new DevExpress.XtraPrinting.BarCode.EAN13Generator();
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.SuspendLayout();
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.AutoModule = true;
            this.barCodeControl1.Location = new System.Drawing.Point(219, 147);
            this.barCodeControl1.Module = 8695890002214D;
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(301, 127);
            this.barCodeControl1.Symbology = eaN13Generator1;
            this.barCodeControl1.TabIndex = 0;
            // 
            // StokBarkod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.barCodeControl1);
            this.Name = "StokBarkod";
            this.Text = "StokBarkod";
            this.Load += new System.EventHandler(this.StokBarkod_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
    }
}