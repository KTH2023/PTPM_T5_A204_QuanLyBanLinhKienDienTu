using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DoAn.UC;
using System;
using System.Windows.Forms;

namespace DoAn.FRM
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        UserControl uc;
        public dynamic nv;
        FrmSystem frm;
        bool checkClose;
        public FrmMain(FrmSystem frm, dynamic nv)
        {
            InitializeComponent();
            this.nv = nv;
            this.frm = frm;
            LbAccount.Caption = "Nhân viên: " + nv.TENNV;
            OpenUC(typeof(Uc_home));
            checkClose = true;
            if (!nv.QUYEN.tenquyen.ToLower().Equals("admin"))
                BtnManagerment.Visible = BtnStatistical.Visible = BtnRestore.Enabled = BtnBackup.Enabled = false;
            else
                BtnCustomerOfStaff.Visible = false;
        }
        public void _close()
        {
            fluentDesignFormContainer1.Controls.Remove(uc);
            fluentDesignFormContainer1.BringToFront();
        }

        private void OpenUC(Type typeUC)
        {
            splashScreenManager1.ShowWaitForm();
            bool check = false;
            foreach (UserControl _uc in fluentDesignFormContainer1.Controls)
            {

                if (_uc.GetType() == typeUC)
                {
                    _uc.BringToFront();
                    LbTieuDe.Caption = _uc.Tag.ToString();
                    check = true;
                    continue;
                }
                fluentDesignFormContainer1.Controls.Remove(_uc);

            }
            if (!check)
            {
                uc = (UserControl)Activator.CreateInstance(typeUC, this);
                uc.Dock = DockStyle.Fill;
                fluentDesignFormContainer1.Controls.Add(uc);
                uc.BringToFront();
                LbTieuDe.Caption = uc.Tag.ToString();
            }
            splashScreenManager1.CloseWaitForm();
        }
        private void BtnChangePass_ItemClick(object sender, ItemClickEventArgs e)
        {
            new FrmChangePass(this, nv).ShowDialog();
        }

        private void BtnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "SQL Backup (*.bak)|*.bak";
            sf.Title = "Backup database";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                new FrmBKRS(sf.FileName, 0).ShowDialog();
            }
        }

        private void BtnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "SQL Backup (*.bak)|*.bak";
            op.Title = "Restore database";
            if (op.ShowDialog() == DialogResult.OK)
            {
                new FrmBKRS(op.FileName, 1).ShowDialog();
            }
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
        private void BtnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            Logout();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkClose)
                e.Cancel = true;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_home));
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_product));
        }

        private void BtnNhanVien_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_staff));
        }

        private void BtnKhachHang_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_customer));
        }

        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_import));
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_order));
        }

        private void BtnBanHang_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_order_employee));
        }

        private void BtnNhapHang_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_import_employee));
        }

        private void BtnCustomerOfStaff_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_customer));
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_inventory));
        }

        private void BtnTurnover_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_statistical));
        }

        private void BtnTopStaffCustomer_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_statistic_staff_customer));
        }

        private void BtnPredictNextDay_Click(object sender, EventArgs e)
        {
            OpenUC(typeof(Uc_predict));
        }
    }
}
