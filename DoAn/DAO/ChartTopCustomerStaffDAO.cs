using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChartTopCustomerStaffDAO
    {
        QL_LinhKienDBDataContext db = new QL_LinhKienDBDataContext();
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

        public dynamic loadTopCustomerBuy(bool checkType, DateTime date)
        {
            return db.topCustomerBuy(checkType, date).ToList();
        }
        public dynamic loadTopStaffSell(bool checkType, DateTime date)
        {
            return db.topStaffSell(checkType, date).ToList();
        }
    }
}
