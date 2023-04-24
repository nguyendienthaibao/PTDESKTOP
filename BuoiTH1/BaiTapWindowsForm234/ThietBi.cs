using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm2
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public float DonGia { get; set; }
        public int SoLuong { get; set; }

        //Method
        public ThietBi(string maThietBi,string tenThietBi,string nuocSanXuat,float donGia,int soLuong)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;
            NuocSanXuat = nuocSanXuat;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public string ThanhTien()
        {
            float thanhTien = SoLuong * DonGia;
            return thanhTien.ToString() + " đồng";
        }
    }
}
