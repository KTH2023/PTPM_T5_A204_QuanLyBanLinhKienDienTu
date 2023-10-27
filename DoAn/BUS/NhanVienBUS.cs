using DAO;

namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instances;
        public static NhanVienBUS Instances
        {
            get
            {
                if (instances == null)
                    instances = new NhanVienBUS();
                return instances;
            }
            set { instances = value; }
        }
        public dynamic getNVs()
        {
            return NhanVienDAO.Instances.getNVs();
        }
        public dynamic login(string userName, string passWord, ref int errorCode)
        {
            return NhanVienDAO.Instances.login(userName, passWord, ref errorCode);
        }
    }
}
