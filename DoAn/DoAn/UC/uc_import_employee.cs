using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DoAn.FRM;

namespace DoAn.UC
{
    public partial class Uc_import_employee : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMain frm;
        public Uc_import_employee(FrmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
    }
}
