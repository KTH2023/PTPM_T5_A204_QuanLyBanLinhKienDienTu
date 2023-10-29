using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChartBUS
    {
        private static ChartBUS instances;
        public static ChartBUS Instances
        {
            get
            {
                if (instances == null)
                    instances = new ChartBUS();
                return instances;
            }
            set { instances = value; }
        }
        //đơn hàng phiếu nhập trong tháng hiện tại
        public dynamic loadOrderAndImportInMonthNow()
        {
            return ChartDAO.Instances.loadOrderAndImportInMonthNow();
        }
        //top sản phẩm bán chạy nhất
        public dynamic loadTopSelling()
        {
            return ChartDAO.Instances.loadTopSelling();
        }
        //load doanh thu năm hiện tại
        public dynamic loadStatisticalYear()
        {
            return ChartDAO.Instances.loadStatisticalYear();
        }
        //sản phẩm sắp hết hàng <=5
        public dynamic loadProductNotStock()
        {
            return ChartDAO.Instances.loadProductNotStock();
        }
    }
}
