﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DoAn.FRM;
using DevExpress.XtraCharts;
using BUS;

namespace DoAn.UC
{
    public partial class Uc_home : DevExpress.XtraEditors.XtraUserControl
    {
        FrmMain frm;
        public Uc_home(FrmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void Uc_home_Load(object sender, EventArgs e)
        {
            //load biểu đồ doanh thu năm hiện tại
            LoadStatisticalYear();
            //load biểu đồ lượng nhập vào bán ra tháng hiện tại
            LoadQuantityImportAndOrder();
            //load biểu đồ top sản phẩm bán chạy (số lượng bán >=30)
            LoadTopProductSelling();
            //load biểu đồ các sản phẩm hết hàng
            LoadProductsNotStock();
        }

        private void LoadProductsNotStock()
        {
            Series _seri = new Series("Linh kiện", ViewType.Area);
            ChartTitle title = new ChartTitle();
            title.Text = "Các sản phẩm sắp hoặc đã hết hàng";
            chartNotStock.Titles.Add(title);
            chartNotStock.Series.Add(_seri);
            foreach (DataRow dr in ChartBUS.Instances.loadProductNotStock().Rows)
                _seri.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString()));
        }

        private void LoadTopProductSelling()
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

        private void LoadQuantityImportAndOrder()
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

        private void LoadStatisticalYear()
        {
            Series _seri = new Series("Doanh thu", ViewType.Pie);
            ChartTitle title = new ChartTitle();
            title.Text = "Doanh thu năm " + DateTime.Now.Year;
            chartStatistical.Titles.Add(title);
            foreach (DataRow dr in ChartBUS.Instances.loadStatisticalYear().Rows)
            _seri.Points.Add(new SeriesPoint(dr[0].ToString(), dr[1].ToString().Equals("")?"0": dr[1].ToString()));
            _seri.ShowInLegend = true;
            _seri.Label.TextPattern = "{A}: {V: N0}";
            chartStatistical.Series.Add(_seri);
        }
    }
}
