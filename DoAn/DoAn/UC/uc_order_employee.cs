using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.Controls;
using System.Globalization;
using DoAn.FRM;
using BUS;

namespace DoAn.UC
{
    public partial class Uc_order_employee : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMain frm;
        public Uc_order_employee(FrmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
       
    }
}
