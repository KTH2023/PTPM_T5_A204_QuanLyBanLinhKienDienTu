using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAn.FRM
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private readonly UserControl uc;
        public dynamic nv;
        frmSystem frm;
        private bool checkClose;
        public FrmMain( frmSystem frm, dynamic nv)
        {
            InitializeComponent();
            this.nv = nv;
            this.frm = frm;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbAccount.Caption = "Nhân viên: " + nv.TENNV;
            //openUC(typeof(uc_home));
            checkClose = true;
            //if (!nv.QUYEN.tenquyen.ToLower().Equals("admin"))
            //    btnManagerment.Visible = btnStatistical.Visible = btnRestore.Enabled = btnBackup.Enabled = false;
            //else
            //    btnCustomerOfStaff.Visible = false;
        }
    }
}
