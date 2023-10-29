using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DoAn.UC;
using System;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace DoAn.FRM
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private UserControl uc;
        public dynamic nv;
        FrmSystem frm;
        private bool checkClose;
        public FrmMain( FrmSystem frm, dynamic nv)
        {
            InitializeComponent();
            this.nv = nv;
            this.frm = frm;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbAccount.Caption = "Nhân viên: " + nv.TENNV;
            openUC(typeof(Uc_home));
            checkClose = true;
            if (!nv.QUYEN.tenquyen.ToLower().Equals("admin"))
                btnManagerment.Visible = btnStatistical.Visible = btnRestore.Enabled = btnBackup.Enabled = false;
            else
                btnCustomerOfStaff.Visible = false;
        }
        public void _close()
        {
            mainContainer.Controls.Remove(uc);
            mainContainer.BringToFront();
        }
        private void openUC(Type typeUC)
        {
            splashScreenManager1.ShowWaitForm();
            bool check = false;
            foreach (UserControl _uc in mainContainer.Controls)
            {
                if (_uc.GetType() == typeUC)
                {
                    _uc.BringToFront();
                    lbTieuDe.Caption = _uc.Tag.ToString();
                    check = true;
                    continue;
                }
                mainContainer.Controls.Remove(_uc);
            }
            if (!check)
            {
                uc = (UserControl)Activator.CreateInstance(typeUC, this);
                uc.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(uc);
                uc.BringToFront();
                lbTieuDe.Caption = uc.Tag.ToString();
            }
            splashScreenManager1.CloseWaitForm();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_home));
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_product));
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_staff));
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_customer));
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_import));
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_order));
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_order_employee));
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_import_employee));
        }

        private void btnCustomerOfStaff_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_customer));
        }

        private void btnTurnover_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_statistical));
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_inventory));
        }

        private void btnTopStaffCustomer_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_statistic_staff_customer));
        }

        private void btnPredictNextDay_Click(object sender, EventArgs e)
        {
            openUC(typeof(Uc_predict));
        }
        public void Logout(int check = 0)
        {
            checkClose = false;
            if (check == 0)
            {
                if (XtraMessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Close();
                    frm._show();
                }
            }
            else
            {
                Close();
                frm._show();
            }
            checkClose = true;
        }
        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmChangePass(this, nv).ShowDialog();
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "SQL Backup (*.bak)|*.bak";
            sf.Title = "Backup database";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                new FrmBKRS(sf.FileName, 0).ShowDialog();
            }
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "SQL Backup (*.bak)|*.bak";
            op.Title = "Restore database";
            if (op.ShowDialog() == DialogResult.OK)
            {
                new FrmBKRS(op.FileName, 1).ShowDialog();
            }
        }
        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            Logout();
        }
    }
}
