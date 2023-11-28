using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChartTopCustomerStaffDAO
    {
        readonly QL_LinhKienDBDataContext db = new QL_LinhKienDBDataContext();
        private static ChartTopCustomerStaffDAO instances;
        public static ChartTopCustomerStaffDAO Instances
        {
            get
            {
                if (instances == null)
                    instances = new ChartTopCustomerStaffDAO();
                return instances;
            }

            set
            {
                instances = value;
            }
        }

        public DataTable LoadTopCustomerBuy(bool checkType, DateTime date)
        {
            return Support.ToDataTable(db.topCustomerBuy(checkType, date).ToList());
        }
        public DataTable LoadTopStaffSell(bool checkType, DateTime date)
        {
            return Support.ToDataTable(db.topStaffSell(checkType, date).ToList());
        }
    }
}
