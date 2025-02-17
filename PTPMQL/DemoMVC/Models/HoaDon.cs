namespace DemoMVC.Models
{
    public class HoaDon
    {        public int SoLuong { get; set; }
             public double DonGia { get; set; }
             public double TongTien => SoLuong * DonGia;
    }
}