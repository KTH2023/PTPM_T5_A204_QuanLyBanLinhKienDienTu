using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DoAn.FRM
{
    public partial class FrmSystem : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmSystem()
        {
            InitializeComponent();
            lbStatus.Caption = "";
        }
        void openForm(Type typeForm)
        {
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm, this);
            f.MdiParent = this;
            f.Show();
        }
        public void setStatus(string status, Color cl)
        {
            lbStatus.Caption = status;
            lbStatus.ItemAppearance.Normal.ForeColor = cl;
        }
        private void btnConnect_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FrmConnect));
        }
        private void btnLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FrmLogin));
        }
        private void frmSystem_Load(object sender, EventArgs e)
        {
            openForm(typeof(FrmLogin));
        }
        public void _show()
        {
            this.Show();
            foreach (Form frm in MdiChildren)
            {
                if (frm.GetType() == typeof(FrmLogin))
                {
                    frm.Close();
                    return;
                }
            }
        }
    }
}