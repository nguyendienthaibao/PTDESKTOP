using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm3
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public double HeSoLuong { get; set; }
        public double HeSoPhuCap { get; set; }

        //Method
        public NhanVien(string maNV, string hoTen, string ngaySinh, double heSoLuong, double heSoPhuCap)
        {
            MaNV = maNV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            HeSoPhuCap = heSoPhuCap;
        }

        public double TinhTongLuong()
        {
            double tongLuong = (HeSoLuong + HeSoPhuCap) * 1150000;
            return tongLuong;
        }
    }
}
