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
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
using DoAn.FRM;
using GUI.Report;
using BUS;

namespace DoAn.UC
{
    public partial class Uc_inventory : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMain frm;
        public Uc_inventory(FrmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
            gvInventory.IndicatorWidth = 50;
            dateFrom.DateTime = DateTime.Now;
            dateTo.DateTime = DateTime.Now;
        }

        
    }
}
