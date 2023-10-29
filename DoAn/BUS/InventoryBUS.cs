using DAO;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class InventoryBUS
    {
        private static InventoryBUS instances;
        public static InventoryBUS Instances
        {
            get
            {
                if (instances == null)
                    instances = new InventoryBUS();
                return instances;
            }

            set
            {
                instances = value;
            }
        }
        public int LuongNhapVao(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            return InventoryDAO.Instances.LuongNhapVao(dateTimeFrom, dateTimeTo);
        }

        public int LuongBanRa(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            return InventoryDAO.Instances.LuongBanRa(dateTimeFrom, dateTimeTo);
        }
        public dynamic LoadDetailInventory(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            return InventoryDAO.Instances.LoadDetailInventory(dateTimeFrom, dateTimeTo);
        }

        //private void LoadTotalImportAndOrder(List<ItemInventory> lstItemInventory, List<NHAPKHO> lstImportTemp, List<HOADON> lstOrderTemp)
        //{
        //    return InventoryDAO.Instances.LuongBanRa(dateTimeFrom, dateTimeTo);
        //}

        //private void LoadProductOfDay(List<ItemInventory> lstItemInventory, DateTime date, List<NHAPKHO> lstImportTemp, List<HOADON> lstOrderTemp)
        //{
        //    return InventoryDAO.Instances.LuongBanRa(dateTimeFrom, dateTimeTo);
        //}
    }
}
