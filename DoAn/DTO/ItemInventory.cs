namespace DTO
{
    public class ItemInventory
    {
        private string _Date;
        private int _Malk, _SoLuongNhap, _SoLuongBan;
        public string Date { get => _Date; set => _Date = value; }
        public int Malk { get => _Malk; set => _Malk = value; }
        public int SoLuongNhap { get => _SoLuongNhap; set => _SoLuongNhap = value; }
        public int SoLuongBan { get => _SoLuongBan; set => _SoLuongBan = value; }
    }
}
