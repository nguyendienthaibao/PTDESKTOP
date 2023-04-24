using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BaiTapWindowsForm4
{
    internal class SanPham
    {
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string loaiSP { get; set; }
        public string ngaySX { get; set; }

        public SanPham()
        {

        }

        public int NamHetHan()
        {
            string ngaySX = this.ngaySX.Trim();
            int firstIndex = ngaySX.LastIndexOf('/') + 1;
            string namSX = ngaySX.Substring(firstIndex, ngaySX.Length - firstIndex);
            //
            int namHetHan;
            namHetHan = int.Parse(namSX) + 3;
            return namHetHan;
        }
    }
}
