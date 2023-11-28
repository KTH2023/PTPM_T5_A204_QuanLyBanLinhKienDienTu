using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class ChartTopCustomerStaffBUS
    {
        private static ChartTopCustomerStaffBUS instances;
        public static ChartTopCustomerStaffBUS Instances
        {
            get
            {
                if (instances == null)
                    instances = new ChartTopCustomerStaffBUS();
                return instances;
            }

            set
            {
                instances = value;
            }
        }
        
        public DataTable LoadTopCustomerBuy(bool checkType,DateTime date)
        {
            return ChartTopCustomerStaffDAO.Instances.LoadTopCustomerBuy(checkType,date);
        }
        public DataTable LoadTopStaffSell(bool checkType,DateTime date)
        {
            return ChartTopCustomerStaffDAO.Instances.LoadTopStaffSell(checkType, date);
        }
    }
}
