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
using BUS;
using DoAn.FRM;
using GUI.Report;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;
namespace DoAn.UC
{
    public partial class Uc_inventory : DevExpress.XtraEditors.XtraUserControl
    {
        readonly FrmMain frm;
        public Uc_inventory(FrmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
            gvInventory.IndicatorWidth = 50;
            dateFrom.DateTime = DateTime.Now;
            dateTo.DateTime = DateTime.Now;
        }

        private void BtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm.CLOSE();
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            if(DateTime.Parse(dateFrom.DateTime.ToShortDateString()).CompareTo(DateTime.Parse(dateTo.DateTime.ToShortDateString())) >0)
            {
                XtraMessageBox.Show("Ngày tìm không hợp lệ.", "Thông báo");
                return;
            }
            var luongNhapVao = InventoryBUS.Instances.LuongNhapVao(dateFrom.DateTime, dateTo.DateTime);
            var luongBanRa = InventoryBUS.Instances.LuongBanRa(dateFrom.DateTime, dateTo.DateTime);
            txtLuongNhap.Text = Support.ConvertVND(luongNhapVao.ToString());
            txtLuongBan.Text = Support.ConvertVND(luongBanRa.ToString());
            gcInventory.DataSource = InventoryBUS.Instances.LoadDetailInventory( dateFrom.DateTime, dateTo.DateTime);

        }

        private void BtnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable tb = InventoryBUS.Instances.LoadDetailInventory(dateFrom.DateTime, dateTo.DateTime);
            if (tb == null || tb.Rows.Count == 0)
                return;
            var rp = new rpInventory
            {
                DataSource = tb
            };
            rp.lbNguoiLap.Value = frm.nv.TENNV;
            rp.ShowPreviewDialog();
        }

        private void GvInventory_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0)
                return;
            e.Info.DisplayText = (e.RowHandle + 1) + "";
        }
    }
}
