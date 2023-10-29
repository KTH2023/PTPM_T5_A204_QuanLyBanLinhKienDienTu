using DevExpress.XtraCharts;
using System;
using System.Data;
using BUS;

namespace DoAn.UC
{
    public partial class Uc_home : DevExpress.XtraEditors.XtraUserControl
    {
        public Uc_home()
        {
            InitializeComponent();
        }

        private void uc_home_Load(object sender, EventArgs e)
        {
            //load biểu đồ doanh thu năm hiện tại
            loadStatisticalYear();
            //load biểu đồ lượng nhập vào bán ra tháng hiện tại
            loadQuantityImportAndOrder();
            //load biểu đồ top sản phẩm bán chạy (số lượng bán >=30)
            loadTopProductSelling();
            //load biểu đồ các sản phẩm hết hàng
            loadProductsNotStock();
        }

        private void loadProductsNotStock()
        {
            Series _seri = new Series("Linh kiện", ViewType.Area);
            ChartTitle title = new ChartTitle();
            title.Text = "Các sản phẩm sắp hoặc đã hết hàng";
            chartNotStock.Titles.Add(title);
            chartNotStock.Series.Add(_seri);
            foreach (DataRow dr in ChartBUS.Instances.loadProductNotStock().Rows)
                _seri.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString()));
        }

        private void loadTopProductSelling()
        {
            Series _seri = new Series("Linh kiện", ViewType.Bar);
            ChartTitle title = new ChartTitle();
            title.Text = "Top sản phẩm bán chạy tháng " + DateTime.Now.Month + "/" + DateTime.Now.Year;
            _seri.ShowInLegend = true;
            chartTopSelling.Titles.Add(title);
            chartTopSelling.Series.Add(_seri);
            foreach (DataRow dr in ChartBUS.Instances.loadTopSelling().Rows)
                _seri.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString()));
        }

        private void loadQuantityImportAndOrder()
        {
            Series _seri = new Series("Đơn hàng, phiếu nhập", ViewType.Doughnut);
            ChartTitle title = new ChartTitle();
            title.Text = "Đơn hàng, phiếu nhập tháng " + DateTime.Now.Month + "/" + DateTime.Now.Year;
            chartQuantityImportOrder.Titles.Add(title);
            chartQuantityImportOrder.Series.Add(_seri);
            foreach (DataRow dr in ChartBUS.Instances.loadOrderAndImportInMonthNow().Rows)
            {
                _seri.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString().Equals("") ? "0" : dr[1].ToString()));
            }
            _seri.Label.TextPattern = "{A}: {V}";
        }

        private void loadStatisticalYear()
        {
            Series _seri = new Series("Doanh thu", ViewType.Pie);
            ChartTitle title = new ChartTitle();
            title.Text = "Doanh thu năm " + DateTime.Now.Year;
            chartStatistical.Titles.Add(title);
            foreach (DataRow dr in ChartBUS.Instances.loadStatisticalYear().Rows)
                _seri.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString().Equals("") ? "0" : dr[1].ToString()));
            _seri.ShowInLegend = true;
            _seri.Label.TextPattern = "{A}: {V: N0}";
            chartStatistical.Series.Add(_seri);
        }
    }
}
