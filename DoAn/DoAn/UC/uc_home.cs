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
using System.Data;
using System.Globalization;

namespace GUI.UC
{
    public partial class uc_home : DevExpress.XtraEditors.XtraUserControl
    {
        public uc_home()
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
            
        }

        private void loadTopProductSelling()
        {
            
        }

        private void loadQuantityImportAndOrder()
        {
            
        }

        private void loadStatisticalYear()
        {
            
        }
    }
}
