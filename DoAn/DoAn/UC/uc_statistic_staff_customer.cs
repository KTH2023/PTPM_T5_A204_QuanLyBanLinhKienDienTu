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
using DevExpress.XtraCharts;
using DoAn.FRM;
using BUS;

namespace DoAn.UC
{
    public partial class Uc_statistic_staff_customer : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMain frm;
        //bool checkTypeStatistic;
        public Uc_statistic_staff_customer(FrmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
            dateStatistic.DateTime = DateTime.Now;
        }

        
    }
}
